namespace BouncingBall
{
    partial class BouncingBallForm
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
            this.components = new System.ComponentModel.Container();
            this.buttonStop = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.groupBoxDrawObjects = new System.Windows.Forms.GroupBox();
            this.numericUpDownSlowdown = new System.Windows.Forms.NumericUpDown();
            this.labelSlowdown = new System.Windows.Forms.Label();
            this.numericUpDownSpeed = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownAngle = new System.Windows.Forms.NumericUpDown();
            this.labelSpeed = new System.Windows.Forms.Label();
            this.labelAngle = new System.Windows.Forms.Label();
            this.groupBoxCanvas = new System.Windows.Forms.GroupBox();
            this.panelPictureBox = new System.Windows.Forms.Panel();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.groupBoxOperations = new System.Windows.Forms.GroupBox();
            this.timerMoveBall = new System.Windows.Forms.Timer(this.components);
            this.groupBoxDrawObjects.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlowdown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).BeginInit();
            this.groupBoxCanvas.SuspendLayout();
            this.panelPictureBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.groupBoxOperations.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(139, 27);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(112, 23);
            this.buttonStop.TabIndex = 53;
            this.buttonStop.Text = "Stop";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // buttonStart
            // 
            this.buttonStart.Location = new System.Drawing.Point(13, 27);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(112, 23);
            this.buttonStart.TabIndex = 55;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // groupBoxDrawObjects
            // 
            this.groupBoxDrawObjects.Controls.Add(this.numericUpDownSlowdown);
            this.groupBoxDrawObjects.Controls.Add(this.labelSlowdown);
            this.groupBoxDrawObjects.Controls.Add(this.numericUpDownSpeed);
            this.groupBoxDrawObjects.Controls.Add(this.numericUpDownAngle);
            this.groupBoxDrawObjects.Controls.Add(this.labelSpeed);
            this.groupBoxDrawObjects.Controls.Add(this.labelAngle);
            this.groupBoxDrawObjects.Location = new System.Drawing.Point(10, 9);
            this.groupBoxDrawObjects.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDrawObjects.Name = "groupBoxDrawObjects";
            this.groupBoxDrawObjects.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxDrawObjects.Size = new System.Drawing.Size(269, 125);
            this.groupBoxDrawObjects.TabIndex = 56;
            this.groupBoxDrawObjects.TabStop = false;
            this.groupBoxDrawObjects.Text = "Settings:";
            // 
            // numericUpDownSlowdown
            // 
            this.numericUpDownSlowdown.DecimalPlaces = 2;
            this.numericUpDownSlowdown.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.numericUpDownSlowdown.Location = new System.Drawing.Point(8, 91);
            this.numericUpDownSlowdown.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSlowdown.Name = "numericUpDownSlowdown";
            this.numericUpDownSlowdown.Size = new System.Drawing.Size(112, 23);
            this.numericUpDownSlowdown.TabIndex = 66;
            this.numericUpDownSlowdown.Value = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            // 
            // labelSlowdown
            // 
            this.labelSlowdown.AutoSize = true;
            this.labelSlowdown.Location = new System.Drawing.Point(8, 73);
            this.labelSlowdown.Name = "labelSlowdown";
            this.labelSlowdown.Size = new System.Drawing.Size(109, 15);
            this.labelSlowdown.TabIndex = 65;
            this.labelSlowdown.Text = "Slowdown Per Tick:";
            // 
            // numericUpDownSpeed
            // 
            this.numericUpDownSpeed.Location = new System.Drawing.Point(8, 42);
            this.numericUpDownSpeed.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownSpeed.Name = "numericUpDownSpeed";
            this.numericUpDownSpeed.Size = new System.Drawing.Size(112, 23);
            this.numericUpDownSpeed.TabIndex = 63;
            this.numericUpDownSpeed.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownSpeed.ValueChanged += new System.EventHandler(this.NumericUpDownSpeed_ValueChanged);
            // 
            // numericUpDownAngle
            // 
            this.numericUpDownAngle.Location = new System.Drawing.Point(139, 42);
            this.numericUpDownAngle.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.numericUpDownAngle.Name = "numericUpDownAngle";
            this.numericUpDownAngle.Size = new System.Drawing.Size(112, 23);
            this.numericUpDownAngle.TabIndex = 62;
            this.numericUpDownAngle.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            this.numericUpDownAngle.ValueChanged += new System.EventHandler(this.NumericUpDownAngle_ValueChanged);
            // 
            // labelSpeed
            // 
            this.labelSpeed.AutoSize = true;
            this.labelSpeed.Location = new System.Drawing.Point(8, 22);
            this.labelSpeed.Name = "labelSpeed";
            this.labelSpeed.Size = new System.Drawing.Size(42, 15);
            this.labelSpeed.TabIndex = 59;
            this.labelSpeed.Text = "Speed:";
            // 
            // labelAngle
            // 
            this.labelAngle.AutoSize = true;
            this.labelAngle.Location = new System.Drawing.Point(139, 23);
            this.labelAngle.Name = "labelAngle";
            this.labelAngle.Size = new System.Drawing.Size(41, 15);
            this.labelAngle.TabIndex = 58;
            this.labelAngle.Text = "Angle:";
            // 
            // groupBoxCanvas
            // 
            this.groupBoxCanvas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCanvas.Controls.Add(this.panelPictureBox);
            this.groupBoxCanvas.Location = new System.Drawing.Point(295, 9);
            this.groupBoxCanvas.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCanvas.Name = "groupBoxCanvas";
            this.groupBoxCanvas.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxCanvas.Size = new System.Drawing.Size(505, 351);
            this.groupBoxCanvas.TabIndex = 57;
            this.groupBoxCanvas.TabStop = false;
            this.groupBoxCanvas.Text = "Bouncing Ball";
            // 
            // panelPictureBox
            // 
            this.panelPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelPictureBox.Controls.Add(this.pictureBox);
            this.panelPictureBox.Location = new System.Drawing.Point(8, 24);
            this.panelPictureBox.Name = "panelPictureBox";
            this.panelPictureBox.Size = new System.Drawing.Size(490, 319);
            this.panelPictureBox.TabIndex = 66;
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(6, 4);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(480, 312);
            this.pictureBox.TabIndex = 48;
            this.pictureBox.TabStop = false;
            this.pictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.PictureBox_Paint);
            // 
            // groupBoxOperations
            // 
            this.groupBoxOperations.Controls.Add(this.buttonStart);
            this.groupBoxOperations.Controls.Add(this.buttonStop);
            this.groupBoxOperations.Location = new System.Drawing.Point(10, 138);
            this.groupBoxOperations.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOperations.Name = "groupBoxOperations";
            this.groupBoxOperations.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBoxOperations.Size = new System.Drawing.Size(269, 61);
            this.groupBoxOperations.TabIndex = 58;
            this.groupBoxOperations.TabStop = false;
            this.groupBoxOperations.Text = "Operations";
            // 
            // timerMoveBall
            // 
            this.timerMoveBall.Tick += new System.EventHandler(this.TimerMoveBall_Tick);
            // 
            // BouncingBallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 373);
            this.Controls.Add(this.groupBoxOperations);
            this.Controls.Add(this.groupBoxCanvas);
            this.Controls.Add(this.groupBoxDrawObjects);
            this.Name = "BouncingBallForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bouncing Ball";
            this.groupBoxDrawObjects.ResumeLayout(false);
            this.groupBoxDrawObjects.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSlowdown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownSpeed)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownAngle)).EndInit();
            this.groupBoxCanvas.ResumeLayout(false);
            this.panelPictureBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.groupBoxOperations.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Button buttonStop;
        private Button buttonStart;
        private GroupBox groupBoxDrawObjects;
        private NumericUpDown numericUpDownSpeed;
        private NumericUpDown numericUpDownAngle;
        private Label labelSpeed;
        private Label labelAngle;
        private GroupBox groupBoxCanvas;
        private PictureBox pictureBox;
        private GroupBox groupBoxOperations;
        private Panel panelPictureBox;
        private System.Windows.Forms.Timer timerMoveBall;
        private NumericUpDown numericUpDownSlowdown;
        private Label labelSlowdown;
    }
}
