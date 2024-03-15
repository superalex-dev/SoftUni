using System.Drawing.Drawing2D;
using System.Numerics;
using System.Text;

namespace ImageTransformations
{
    public partial class ImageTransformationForm : Form
    {
        public ImageTransformationForm()
        {
            this.InitializeComponent();
        }

        private void UpdateState()
        {
            // Allocate image for persistence
            Image image = new Bitmap(400, 400);

            // Assign to picture box
            this.pictureBoxCoordinateSystem.Image = image;
            Graphics graphics = Graphics.FromImage(this.pictureBoxCoordinateSystem.Image);

            // Draw the axes
            this.DrawAxes(graphics);

            Matrix matrix = new Matrix();

            // Bring center to 200, 200
            matrix.Translate(200, 200, MatrixOrder.Append);

            // Apply world transformation
            graphics.Transform = matrix;

            // Create a new matrix for custom transformations
            Matrix customMatrix = new Matrix();

            // Append the transformation as ordered by the listbox
            foreach (object item in this.listBox.Items)
            {
                MatrixOperations ops = new MatrixOperations();
                if (item.ToString() == "Rotate")
                {
                    ops.Rotate(
                        customMatrix,
                        int.Parse(this.labelBarRotateDegrees.Text) * Math.PI / 180,
                        int.Parse(this.labelBarRotateX.Text),
                        int.Parse(this.labelBarRotateY.Text));

                    this.DisplayTransformMatrix(customMatrix);
                }

                if (item.ToString() == "Translation")
                {
                    ops.Transform(
                        customMatrix,
                        int.Parse(this.labelBarTranslateX.Text),
                        int.Parse(this.labelBarTranslateY.Text));

                    this.DisplayTransformMatrix(customMatrix);
                }

                if (item.ToString() == "Stretch")
                {
                    ops.Stretch(
                        customMatrix,
                        customMatrix.MatrixElements.M11 * float.Parse(this.labelBarStretchX.Text),
                        customMatrix.MatrixElements.M12 * float.Parse(this.labelBarStretchX.Text),
                        customMatrix.MatrixElements.M21 * float.Parse(this.labelBarStretchY.Text),
                        customMatrix.MatrixElements.M22 * float.Parse(this.labelBarStretchY.Text)
                        );

                    this.DisplayTransformMatrix(customMatrix);
                }
            }

            GraphicsPath path = new GraphicsPath();

            Image imageClone = (Image)this.pictureBoxBase.Image.Clone();

            Graphics.FromImage(imageClone).DrawRectangle(
                new Pen(Color.Red, 3),
                0, 0,
                imageClone.Width - 1,
                imageClone.Height - 1);

            PointF[] psrc = new PointF[]
            {
                new Point(0, 0),
                new Point(imageClone.Width, 0),
                new Point(0, imageClone.Height)
            };

            path.AddPolygon(psrc);
            path.Transform(customMatrix);

            PointF[] points = path.PathPoints;
            graphics.DrawImage(imageClone, points);

            this.pictureBoxCoordinateSystem.Refresh();

            customMatrix.Multiply(matrix, MatrixOrder.Append);
        }

        private void DisplayTransformMatrix(Matrix matrix)
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("Transform Matrix:");
            sb.AppendLine($"{this.NormalizeElement(matrix.MatrixElements.M11):f2} {this.NormalizeElement(matrix.MatrixElements.M12):f2}");
            sb.AppendLine($"{this.NormalizeElement(matrix.MatrixElements.M21):f2} {this.NormalizeElement(matrix.MatrixElements.M22):f2}");
            sb.AppendLine($"{this.NormalizeElement(matrix.MatrixElements.M31):f2} {this.NormalizeElement(matrix.MatrixElements.M32):f2}");

            this.textBoxTransformMatrix.Text = sb.ToString();
        }

        private float NormalizeElement(float num)
        {
            return num == 0 ? Math.Abs(num) : num;
        }

        private void DrawAxes(Graphics graphics)
        {
            // Save the old transform of the graphics
            Matrix oldMatrix = graphics.Transform;

            // Clear the transform
            graphics.Transform = new Matrix();

            Pen pen = new Pen(Brushes.Black, 1);
            Matrix matrix = new Matrix();

            // Move the origin to 200,200
            matrix.Translate(200, 200);

            // Apply the transformation
            graphics.Transform = matrix;

            // Draw the axes
            graphics.DrawLine(pen, -200, 0, 200, 0); // horizontal
            graphics.DrawLine(pen, 0, -200, 0, 200); // vertical	

            for (int i = -150; i <= 150; i += 50)
            {
                // Add text to vertical axis
                graphics.DrawString(i.ToString(), this.Font, Brushes.Black, 5, -i);

                // Tick the vertical axis with horizontal ticks
                graphics.DrawLine(pen, -5, i, 5, i);

                // Tick the horizontal axis with vertical ticks
                graphics.DrawLine(pen, i, -5, i, 5);
            }

            // Prepend the 90 deg clockwise rotation
            // so now the matrix would be a matrix for a 90 deg clockwise rotation 
            // followed by translation by 200, 200
            matrix.Rotate(90, MatrixOrder.Prepend);

            // Override with the new transformation
            graphics.Transform = matrix;

            for (int i = -150; i <= 150; i += 50)
            {
                // Add text to horizontal axis
                graphics.DrawString(i.ToString(), this.Font, Brushes.Black, 5, -i);
            }

            graphics.Transform = oldMatrix;
        }

        private void ImageTransformationForm_Load(object sender, EventArgs e)
        {
            this.trackBarRotateDegrees.Value = 0;
            this.trackBarRotateX.Value = 0;
            this.trackBarRotateX.Value = 0;

            this.labelBarRotateDegrees.Text = this.trackBarRotateDegrees.Value.ToString();
            this.labelBarRotateX.Text = this.trackBarRotateX.Value.ToString();
            this.labelBarRotateY.Text = this.trackBarRotateY.Value.ToString();

            this.trackBarTranslateX.Value = 0;
            this.trackBarTranslateY.Value = 0;

            this.labelBarTranslateX.Text = this.trackBarTranslateX.Value.ToString();
            this.labelBarTranslateY.Text = this.trackBarTranslateY.Value.ToString();

            this.trackBarStretchX.Value = 10;
            this.trackBarStretchY.Value = 10;

            this.labelBarStretchX.Text = $"{this.trackBarStretchX.Value / 10.0:0.0}";
            this.labelBarStretchY.Text = $"{this.trackBarStretchY.Value / 10.0:0.0}";

            this.checkBoxRotate.CheckState = CheckState.Unchecked;
            this.checkBoxTranslation.CheckState = CheckState.Unchecked;
            this.checkBoxStretch.CheckState = CheckState.Unchecked;

            this.UpdateState();

            this.DisplayTransformMatrix(new Matrix(1, 0, 0, 1, 0, 0));
        }

        private void CheckBoxRotate_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateListBox((CheckBox)sender, "Rotate");
        }

        private void CheckBoxTranslation_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateListBox((CheckBox)sender, "Translation");
        }

        private void CheckBoxStretch_CheckedChanged(object sender, EventArgs e)
        {
            this.UpdateListBox((CheckBox)sender, "Stretch");
        }

        private void TrackBarRotateDegrees_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarRotateDegrees.Text = this.trackBarRotateDegrees.Value.ToString();
            this.checkBoxRotate.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void TrackBarRotateX_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarRotateX.Text = this.trackBarRotateX.Value.ToString();
            this.checkBoxRotate.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void TrackBarRotateY_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarRotateY.Text = this.trackBarRotateY.Value.ToString();
            this.checkBoxRotate.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void TrackBarTranslateX_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarTranslateX.Text = this.trackBarTranslateX.Value.ToString();
            this.checkBoxTranslation.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void TrackBarTranslateY_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarTranslateY.Text = this.trackBarTranslateY.Value.ToString();
            this.checkBoxTranslation.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void TrackBarStretchX_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarStretchX.Text = $"{this.trackBarStretchX.Value / 10.0:0.0}";
            this.checkBoxStretch.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void TrackBarStretchY_ValueChanged(object sender, EventArgs e)
        {
            this.labelBarStretchY.Text = $"{this.trackBarStretchY.Value / 10.0:0.0}";
            this.checkBoxStretch.CheckState = CheckState.Checked;
            this.UpdateState();
        }

        private void UpdateListBox(CheckBox box, string mode)
        {
            if (box.CheckState == CheckState.Checked)
            {
                this.listBox.Items.Add(mode);
                this.listBox.SelectedIndex = this.listBox.Items.Count - 1;
            }
            else
            {
                this.listBox.Items.Remove(mode);
            }
        }

        private void ButtonReset_Click(object sender, EventArgs e)
        {
            this.ImageTransformationForm_Load(sender, null);
        }
    }
}