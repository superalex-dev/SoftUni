namespace ImageTransformations
{
    partial class ImageTransformationForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ImageTransformationForm));
            this.pictureBoxCoordinateSystem = new System.Windows.Forms.PictureBox();
            this.buttonReset = new System.Windows.Forms.Button();
            this.checkBoxRotate = new System.Windows.Forms.CheckBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.checkBoxTranslation = new System.Windows.Forms.CheckBox();
            this.checkBoxStretch = new System.Windows.Forms.CheckBox();
            this.labelDegree = new System.Windows.Forms.Label();
            this.labelXRotate = new System.Windows.Forms.Label();
            this.labelYRotate = new System.Windows.Forms.Label();
            this.trackBarRotateDegrees = new System.Windows.Forms.TrackBar();
            this.labelBarRotateDegrees = new System.Windows.Forms.Label();
            this.trackBarRotateX = new System.Windows.Forms.TrackBar();
            this.trackBarRotateY = new System.Windows.Forms.TrackBar();
            this.labelBarRotateX = new System.Windows.Forms.Label();
            this.labelBarRotateY = new System.Windows.Forms.Label();
            this.labelBarTranslateY = new System.Windows.Forms.Label();
            this.labelBarTranslateX = new System.Windows.Forms.Label();
            this.trackBarTranslateY = new System.Windows.Forms.TrackBar();
            this.trackBarTranslateX = new System.Windows.Forms.TrackBar();
            this.labelYTranslate = new System.Windows.Forms.Label();
            this.labelXTranslate = new System.Windows.Forms.Label();
            this.labelBarStretchY = new System.Windows.Forms.Label();
            this.labelBarStretchX = new System.Windows.Forms.Label();
            this.trackBarStretchY = new System.Windows.Forms.TrackBar();
            this.trackBarStretchX = new System.Windows.Forms.TrackBar();
            this.labelYStretch = new System.Windows.Forms.Label();
            this.labelXStretch = new System.Windows.Forms.Label();
            this.pictureBoxBase = new System.Windows.Forms.PictureBox();
            this.textBoxTransformMatrix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoordinateSystem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateDegrees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStretchY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStretchX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxCoordinateSystem
            // 
            this.pictureBoxCoordinateSystem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCoordinateSystem.Location = new System.Drawing.Point(14, 16);
            this.pictureBoxCoordinateSystem.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxCoordinateSystem.Name = "pictureBoxCoordinateSystem";
            this.pictureBoxCoordinateSystem.Size = new System.Drawing.Size(406, 395);
            this.pictureBoxCoordinateSystem.TabIndex = 0;
            this.pictureBoxCoordinateSystem.TabStop = false;
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(318, 427);
            this.buttonReset.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(73, 32);
            this.buttonReset.TabIndex = 2;
            this.buttonReset.Text = "Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ButtonReset_Click);
            // 
            // checkBoxRotate
            // 
            this.checkBoxRotate.AutoSize = true;
            this.checkBoxRotate.Location = new System.Drawing.Point(437, 16);
            this.checkBoxRotate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxRotate.Name = "checkBoxRotate";
            this.checkBoxRotate.Size = new System.Drawing.Size(88, 24);
            this.checkBoxRotate.TabIndex = 3;
            this.checkBoxRotate.Text = "Rotation";
            this.checkBoxRotate.UseVisualStyleBackColor = true;
            this.checkBoxRotate.CheckedChanged += new System.EventHandler(this.CheckBoxRotate_CheckedChanged);
            // 
            // listBox
            // 
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(191, 427);
            this.listBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(119, 64);
            this.listBox.TabIndex = 4;
            // 
            // checkBoxTranslation
            // 
            this.checkBoxTranslation.AutoSize = true;
            this.checkBoxTranslation.Location = new System.Drawing.Point(437, 249);
            this.checkBoxTranslation.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxTranslation.Name = "checkBoxTranslation";
            this.checkBoxTranslation.Size = new System.Drawing.Size(103, 24);
            this.checkBoxTranslation.TabIndex = 5;
            this.checkBoxTranslation.Text = "Translation";
            this.checkBoxTranslation.UseVisualStyleBackColor = true;
            this.checkBoxTranslation.CheckedChanged += new System.EventHandler(this.CheckBoxTranslation_CheckedChanged);
            // 
            // checkBoxStretch
            // 
            this.checkBoxStretch.AutoSize = true;
            this.checkBoxStretch.Location = new System.Drawing.Point(437, 423);
            this.checkBoxStretch.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.checkBoxStretch.Name = "checkBoxStretch";
            this.checkBoxStretch.Size = new System.Drawing.Size(77, 24);
            this.checkBoxStretch.TabIndex = 6;
            this.checkBoxStretch.Text = "Stretch";
            this.checkBoxStretch.UseVisualStyleBackColor = true;
            this.checkBoxStretch.CheckedChanged += new System.EventHandler(this.CheckBoxStretch_CheckedChanged);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Location = new System.Drawing.Point(457, 61);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(67, 20);
            this.labelDegree.TabIndex = 7;
            this.labelDegree.Text = "Degrees:";
            // 
            // labelXRotate
            // 
            this.labelXRotate.AutoSize = true;
            this.labelXRotate.Location = new System.Drawing.Point(455, 117);
            this.labelXRotate.Name = "labelXRotate";
            this.labelXRotate.Size = new System.Drawing.Size(21, 20);
            this.labelXRotate.TabIndex = 8;
            this.labelXRotate.Text = "X:";
            // 
            // labelYRotate
            // 
            this.labelYRotate.AutoSize = true;
            this.labelYRotate.Location = new System.Drawing.Point(455, 181);
            this.labelYRotate.Name = "labelYRotate";
            this.labelYRotate.Size = new System.Drawing.Size(20, 20);
            this.labelYRotate.TabIndex = 9;
            this.labelYRotate.Text = "Y:";
            // 
            // trackBarRotateDegrees
            // 
            this.trackBarRotateDegrees.LargeChange = 1;
            this.trackBarRotateDegrees.Location = new System.Drawing.Point(517, 57);
            this.trackBarRotateDegrees.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarRotateDegrees.Maximum = 180;
            this.trackBarRotateDegrees.Minimum = -180;
            this.trackBarRotateDegrees.Name = "trackBarRotateDegrees";
            this.trackBarRotateDegrees.Size = new System.Drawing.Size(119, 56);
            this.trackBarRotateDegrees.TabIndex = 2;
            this.trackBarRotateDegrees.TickFrequency = 30;
            this.trackBarRotateDegrees.ValueChanged += new System.EventHandler(this.TrackBarRotateDegrees_ValueChanged);
            // 
            // labelBarRotateDegrees
            // 
            this.labelBarRotateDegrees.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarRotateDegrees.Location = new System.Drawing.Point(643, 61);
            this.labelBarRotateDegrees.Name = "labelBarRotateDegrees";
            this.labelBarRotateDegrees.Size = new System.Drawing.Size(37, 32);
            this.labelBarRotateDegrees.TabIndex = 11;
            this.labelBarRotateDegrees.Text = "0";
            // 
            // trackBarRotateX
            // 
            this.trackBarRotateX.LargeChange = 1;
            this.trackBarRotateX.Location = new System.Drawing.Point(481, 115);
            this.trackBarRotateX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarRotateX.Maximum = 50;
            this.trackBarRotateX.Minimum = -50;
            this.trackBarRotateX.Name = "trackBarRotateX";
            this.trackBarRotateX.Size = new System.Drawing.Size(119, 56);
            this.trackBarRotateX.TabIndex = 12;
            this.trackBarRotateX.TickFrequency = 30;
            this.trackBarRotateX.ValueChanged += new System.EventHandler(this.TrackBarRotateX_ValueChanged);
            // 
            // trackBarRotateY
            // 
            this.trackBarRotateY.LargeChange = 1;
            this.trackBarRotateY.Location = new System.Drawing.Point(481, 181);
            this.trackBarRotateY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarRotateY.Maximum = 50;
            this.trackBarRotateY.Minimum = -50;
            this.trackBarRotateY.Name = "trackBarRotateY";
            this.trackBarRotateY.Size = new System.Drawing.Size(119, 56);
            this.trackBarRotateY.TabIndex = 13;
            this.trackBarRotateY.TickFrequency = 30;
            this.trackBarRotateY.ValueChanged += new System.EventHandler(this.TrackBarRotateY_ValueChanged);
            // 
            // labelBarRotateX
            // 
            this.labelBarRotateX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarRotateX.Location = new System.Drawing.Point(607, 117);
            this.labelBarRotateX.Name = "labelBarRotateX";
            this.labelBarRotateX.Size = new System.Drawing.Size(37, 32);
            this.labelBarRotateX.TabIndex = 14;
            this.labelBarRotateX.Text = "0";
            // 
            // labelBarRotateY
            // 
            this.labelBarRotateY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarRotateY.Location = new System.Drawing.Point(602, 181);
            this.labelBarRotateY.Name = "labelBarRotateY";
            this.labelBarRotateY.Size = new System.Drawing.Size(37, 32);
            this.labelBarRotateY.TabIndex = 15;
            this.labelBarRotateY.Text = "0";
            // 
            // labelBarTranslateY
            // 
            this.labelBarTranslateY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarTranslateY.Location = new System.Drawing.Point(602, 353);
            this.labelBarTranslateY.Name = "labelBarTranslateY";
            this.labelBarTranslateY.Size = new System.Drawing.Size(37, 32);
            this.labelBarTranslateY.TabIndex = 21;
            this.labelBarTranslateY.Text = "0";
            // 
            // labelBarTranslateX
            // 
            this.labelBarTranslateX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarTranslateX.Location = new System.Drawing.Point(607, 291);
            this.labelBarTranslateX.Name = "labelBarTranslateX";
            this.labelBarTranslateX.Size = new System.Drawing.Size(37, 32);
            this.labelBarTranslateX.TabIndex = 20;
            this.labelBarTranslateX.Text = "0";
            // 
            // trackBarTranslateY
            // 
            this.trackBarTranslateY.LargeChange = 1;
            this.trackBarTranslateY.Location = new System.Drawing.Point(481, 355);
            this.trackBarTranslateY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTranslateY.Maximum = 150;
            this.trackBarTranslateY.Minimum = -150;
            this.trackBarTranslateY.Name = "trackBarTranslateY";
            this.trackBarTranslateY.Size = new System.Drawing.Size(119, 56);
            this.trackBarTranslateY.TabIndex = 19;
            this.trackBarTranslateY.TickFrequency = 20;
            this.trackBarTranslateY.ValueChanged += new System.EventHandler(this.TrackBarTranslateY_ValueChanged);
            // 
            // trackBarTranslateX
            // 
            this.trackBarTranslateX.LargeChange = 1;
            this.trackBarTranslateX.Location = new System.Drawing.Point(481, 288);
            this.trackBarTranslateX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarTranslateX.Maximum = 150;
            this.trackBarTranslateX.Minimum = -150;
            this.trackBarTranslateX.Name = "trackBarTranslateX";
            this.trackBarTranslateX.Size = new System.Drawing.Size(119, 56);
            this.trackBarTranslateX.TabIndex = 18;
            this.trackBarTranslateX.TickFrequency = 20;
            this.trackBarTranslateX.ValueChanged += new System.EventHandler(this.TrackBarTranslateX_ValueChanged);
            // 
            // labelYTranslate
            // 
            this.labelYTranslate.AutoSize = true;
            this.labelYTranslate.Location = new System.Drawing.Point(455, 355);
            this.labelYTranslate.Name = "labelYTranslate";
            this.labelYTranslate.Size = new System.Drawing.Size(20, 20);
            this.labelYTranslate.TabIndex = 17;
            this.labelYTranslate.Text = "Y:";
            // 
            // labelXTranslate
            // 
            this.labelXTranslate.AutoSize = true;
            this.labelXTranslate.Location = new System.Drawing.Point(455, 291);
            this.labelXTranslate.Name = "labelXTranslate";
            this.labelXTranslate.Size = new System.Drawing.Size(21, 20);
            this.labelXTranslate.TabIndex = 16;
            this.labelXTranslate.Text = "X:";
            // 
            // labelBarStretchY
            // 
            this.labelBarStretchY.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarStretchY.Location = new System.Drawing.Point(602, 521);
            this.labelBarStretchY.Name = "labelBarStretchY";
            this.labelBarStretchY.Size = new System.Drawing.Size(37, 32);
            this.labelBarStretchY.TabIndex = 27;
            this.labelBarStretchY.Text = "0";
            // 
            // labelBarStretchX
            // 
            this.labelBarStretchX.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBarStretchX.Location = new System.Drawing.Point(607, 459);
            this.labelBarStretchX.Name = "labelBarStretchX";
            this.labelBarStretchX.Size = new System.Drawing.Size(37, 32);
            this.labelBarStretchX.TabIndex = 26;
            this.labelBarStretchX.Text = "0";
            // 
            // trackBarStretchY
            // 
            this.trackBarStretchY.LargeChange = 1;
            this.trackBarStretchY.Location = new System.Drawing.Point(481, 523);
            this.trackBarStretchY.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarStretchY.Maximum = 20;
            this.trackBarStretchY.Minimum = 1;
            this.trackBarStretchY.Name = "trackBarStretchY";
            this.trackBarStretchY.Size = new System.Drawing.Size(119, 56);
            this.trackBarStretchY.TabIndex = 25;
            this.trackBarStretchY.Value = 10;
            this.trackBarStretchY.ValueChanged += new System.EventHandler(this.TrackBarStretchY_ValueChanged);
            // 
            // trackBarStretchX
            // 
            this.trackBarStretchX.LargeChange = 1;
            this.trackBarStretchX.Location = new System.Drawing.Point(481, 456);
            this.trackBarStretchX.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.trackBarStretchX.Maximum = 20;
            this.trackBarStretchX.Minimum = 1;
            this.trackBarStretchX.Name = "trackBarStretchX";
            this.trackBarStretchX.Size = new System.Drawing.Size(119, 56);
            this.trackBarStretchX.TabIndex = 24;
            this.trackBarStretchX.Value = 10;
            this.trackBarStretchX.ValueChanged += new System.EventHandler(this.TrackBarStretchX_ValueChanged);
            // 
            // labelYStretch
            // 
            this.labelYStretch.AutoSize = true;
            this.labelYStretch.Location = new System.Drawing.Point(455, 523);
            this.labelYStretch.Name = "labelYStretch";
            this.labelYStretch.Size = new System.Drawing.Size(20, 20);
            this.labelYStretch.TabIndex = 23;
            this.labelYStretch.Text = "Y:";
            // 
            // labelXStretch
            // 
            this.labelXStretch.AutoSize = true;
            this.labelXStretch.Location = new System.Drawing.Point(455, 459);
            this.labelXStretch.Name = "labelXStretch";
            this.labelXStretch.Size = new System.Drawing.Size(21, 20);
            this.labelXStretch.TabIndex = 22;
            this.labelXStretch.Text = "X:";
            // 
            // pictureBoxBase
            // 
            this.pictureBoxBase.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxBase.Image")));
            this.pictureBoxBase.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBoxBase.InitialImage")));
            this.pictureBoxBase.Location = new System.Drawing.Point(805, 521);
            this.pictureBoxBase.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pictureBoxBase.Name = "pictureBoxBase";
            this.pictureBoxBase.Size = new System.Drawing.Size(59, 40);
            this.pictureBoxBase.TabIndex = 28;
            this.pictureBoxBase.TabStop = false;
            this.pictureBoxBase.Visible = false;
            // 
            // textBoxTransformMatrix
            // 
            this.textBoxTransformMatrix.Location = new System.Drawing.Point(14, 427);
            this.textBoxTransformMatrix.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxTransformMatrix.Multiline = true;
            this.textBoxTransformMatrix.Name = "textBoxTransformMatrix";
            this.textBoxTransformMatrix.Size = new System.Drawing.Size(170, 84);
            this.textBoxTransformMatrix.TabIndex = 29;
            // 
            // ImageTransformationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(693, 574);
            this.Controls.Add(this.textBoxTransformMatrix);
            this.Controls.Add(this.pictureBoxBase);
            this.Controls.Add(this.labelBarStretchY);
            this.Controls.Add(this.labelBarStretchX);
            this.Controls.Add(this.trackBarStretchY);
            this.Controls.Add(this.trackBarStretchX);
            this.Controls.Add(this.labelYStretch);
            this.Controls.Add(this.labelXStretch);
            this.Controls.Add(this.labelBarTranslateY);
            this.Controls.Add(this.labelBarTranslateX);
            this.Controls.Add(this.trackBarTranslateY);
            this.Controls.Add(this.trackBarTranslateX);
            this.Controls.Add(this.labelYTranslate);
            this.Controls.Add(this.labelXTranslate);
            this.Controls.Add(this.labelBarRotateY);
            this.Controls.Add(this.labelBarRotateX);
            this.Controls.Add(this.trackBarRotateY);
            this.Controls.Add(this.trackBarRotateX);
            this.Controls.Add(this.labelBarRotateDegrees);
            this.Controls.Add(this.trackBarRotateDegrees);
            this.Controls.Add(this.labelYRotate);
            this.Controls.Add(this.labelXRotate);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.checkBoxStretch);
            this.Controls.Add(this.checkBoxTranslation);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.checkBoxRotate);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.pictureBoxCoordinateSystem);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ImageTransformationForm";
            this.Text = "Image Transformations";
            this.Load += new System.EventHandler(this.ImageTransformationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCoordinateSystem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateDegrees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarRotateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarTranslateX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStretchY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarStretchX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBase)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pictureBoxCoordinateSystem;
        private Button buttonReset;
        private CheckBox checkBoxRotate;
        private ListBox listBox;
        private CheckBox checkBoxTranslation;
        private CheckBox checkBoxStretch;
        private Label labelDegree;
        private Label labelXRotate;
        private Label labelYRotate;
        private TrackBar trackBarRotateDegrees;
        private Label labelBarRotateDegrees;
        private TrackBar trackBarRotateX;
        private TrackBar trackBarRotateY;
        private Label labelBarRotateX;
        private Label labelBarRotateY;
        private Label labelBarTranslateY;
        private Label labelBarTranslateX;
        private TrackBar trackBarTranslateY;
        private TrackBar trackBarTranslateX;
        private Label labelYTranslate;
        private Label labelXTranslate;
        private Label labelBarStretchY;
        private Label labelBarStretchX;
        private TrackBar trackBarStretchY;
        private TrackBar trackBarStretchX;
        private Label labelYStretch;
        private Label labelXStretch;
        private PictureBox pictureBoxBase;
        private TextBox textBoxTransformMatrix;
    }
}