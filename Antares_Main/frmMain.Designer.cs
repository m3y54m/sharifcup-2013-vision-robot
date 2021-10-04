namespace Antares_Main
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ibCam = new Emgu.CV.UI.ImageBox();
            this.ibResult = new Emgu.CV.UI.ImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.txtFieldRealSize = new System.Windows.Forms.TextBox();
            this.btnStream = new System.Windows.Forms.Button();
            this.btnFreeze = new System.Windows.Forms.Button();
            this.btnGetColors = new System.Windows.Forms.Button();
            this.gbGetColors = new System.Windows.Forms.GroupBox();
            this.lblCyan = new System.Windows.Forms.Label();
            this.lblPurple = new System.Windows.Forms.Label();
            this.lblYellow = new System.Windows.Forms.Label();
            this.lblGreen = new System.Windows.Forms.Label();
            this.lblBlue = new System.Windows.Forms.Label();
            this.lblRed = new System.Windows.Forms.Label();
            this.rbCyan = new System.Windows.Forms.RadioButton();
            this.rbPurple = new System.Windows.Forms.RadioButton();
            this.rbYellow = new System.Windows.Forms.RadioButton();
            this.rbGreen = new System.Windows.Forms.RadioButton();
            this.rbBlue = new System.Windows.Forms.RadioButton();
            this.rbRed = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbNegative = new System.Windows.Forms.GroupBox();
            this.cbNCyan = new System.Windows.Forms.CheckBox();
            this.cbNPurple = new System.Windows.Forms.CheckBox();
            this.cbNYellow = new System.Windows.Forms.CheckBox();
            this.cbNGreen = new System.Windows.Forms.CheckBox();
            this.cbNBlue = new System.Windows.Forms.CheckBox();
            this.cbNRed = new System.Windows.Forms.CheckBox();
            this.gbPositive = new System.Windows.Forms.GroupBox();
            this.cbPCyan = new System.Windows.Forms.CheckBox();
            this.cbPPurple = new System.Windows.Forms.CheckBox();
            this.cbPYellow = new System.Windows.Forms.CheckBox();
            this.cbPGreen = new System.Windows.Forms.CheckBox();
            this.cbPBlue = new System.Windows.Forms.CheckBox();
            this.cbPRed = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ibCam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibResult)).BeginInit();
            this.gbGetColors.SuspendLayout();
            this.gbNegative.SuspendLayout();
            this.gbPositive.SuspendLayout();
            this.SuspendLayout();
            // 
            // ibCam
            // 
            this.ibCam.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ibCam.Location = new System.Drawing.Point(12, 12);
            this.ibCam.Name = "ibCam";
            this.ibCam.Size = new System.Drawing.Size(480, 360);
            this.ibCam.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibCam.TabIndex = 2;
            this.ibCam.TabStop = false;
            this.ibCam.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ibCam_MouseDoubleClick);
            // 
            // ibResult
            // 
            this.ibResult.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ibResult.Location = new System.Drawing.Point(500, 12);
            this.ibResult.Name = "ibResult";
            this.ibResult.Size = new System.Drawing.Size(480, 360);
            this.ibResult.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ibResult.TabIndex = 3;
            this.ibResult.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 385);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Field Real Size (cm):";
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            // 
            // txtFieldRealSize
            // 
            this.txtFieldRealSize.Location = new System.Drawing.Point(442, 382);
            this.txtFieldRealSize.Name = "txtFieldRealSize";
            this.txtFieldRealSize.Size = new System.Drawing.Size(57, 21);
            this.txtFieldRealSize.TabIndex = 6;
            this.txtFieldRealSize.Text = "350";
            // 
            // btnStream
            // 
            this.btnStream.Location = new System.Drawing.Point(12, 380);
            this.btnStream.Name = "btnStream";
            this.btnStream.Size = new System.Drawing.Size(111, 23);
            this.btnStream.TabIndex = 7;
            this.btnStream.Text = "Start Streaming";
            this.btnStream.UseVisualStyleBackColor = true;
            this.btnStream.Click += new System.EventHandler(this.btnStream_Click);
            // 
            // btnFreeze
            // 
            this.btnFreeze.Enabled = false;
            this.btnFreeze.Location = new System.Drawing.Point(12, 409);
            this.btnFreeze.Name = "btnFreeze";
            this.btnFreeze.Size = new System.Drawing.Size(111, 23);
            this.btnFreeze.TabIndex = 8;
            this.btnFreeze.Text = "Freeze";
            this.btnFreeze.UseVisualStyleBackColor = true;
            this.btnFreeze.Click += new System.EventHandler(this.btnFreeze_Click);
            // 
            // btnGetColors
            // 
            this.btnGetColors.Location = new System.Drawing.Point(131, 380);
            this.btnGetColors.Name = "btnGetColors";
            this.btnGetColors.Size = new System.Drawing.Size(201, 23);
            this.btnGetColors.TabIndex = 9;
            this.btnGetColors.Text = "Disable Getting Colors";
            this.btnGetColors.UseVisualStyleBackColor = true;
            this.btnGetColors.Click += new System.EventHandler(this.btnGetColors_Click);
            // 
            // gbGetColors
            // 
            this.gbGetColors.Controls.Add(this.lblCyan);
            this.gbGetColors.Controls.Add(this.lblPurple);
            this.gbGetColors.Controls.Add(this.lblYellow);
            this.gbGetColors.Controls.Add(this.lblGreen);
            this.gbGetColors.Controls.Add(this.lblBlue);
            this.gbGetColors.Controls.Add(this.lblRed);
            this.gbGetColors.Controls.Add(this.rbCyan);
            this.gbGetColors.Controls.Add(this.rbPurple);
            this.gbGetColors.Controls.Add(this.rbYellow);
            this.gbGetColors.Controls.Add(this.rbGreen);
            this.gbGetColors.Controls.Add(this.rbBlue);
            this.gbGetColors.Controls.Add(this.rbRed);
            this.gbGetColors.Location = new System.Drawing.Point(132, 409);
            this.gbGetColors.Name = "gbGetColors";
            this.gbGetColors.Size = new System.Drawing.Size(200, 163);
            this.gbGetColors.TabIndex = 10;
            this.gbGetColors.TabStop = false;
            this.gbGetColors.Text = "Colors";
            // 
            // lblCyan
            // 
            this.lblCyan.BackColor = System.Drawing.Color.White;
            this.lblCyan.Location = new System.Drawing.Point(72, 135);
            this.lblCyan.Name = "lblCyan";
            this.lblCyan.Size = new System.Drawing.Size(116, 17);
            this.lblCyan.TabIndex = 12;
            // 
            // lblPurple
            // 
            this.lblPurple.BackColor = System.Drawing.Color.White;
            this.lblPurple.Location = new System.Drawing.Point(72, 112);
            this.lblPurple.Name = "lblPurple";
            this.lblPurple.Size = new System.Drawing.Size(116, 17);
            this.lblPurple.TabIndex = 11;
            // 
            // lblYellow
            // 
            this.lblYellow.BackColor = System.Drawing.Color.White;
            this.lblYellow.Location = new System.Drawing.Point(72, 89);
            this.lblYellow.Name = "lblYellow";
            this.lblYellow.Size = new System.Drawing.Size(116, 17);
            this.lblYellow.TabIndex = 10;
            // 
            // lblGreen
            // 
            this.lblGreen.BackColor = System.Drawing.Color.White;
            this.lblGreen.Location = new System.Drawing.Point(72, 66);
            this.lblGreen.Name = "lblGreen";
            this.lblGreen.Size = new System.Drawing.Size(116, 17);
            this.lblGreen.TabIndex = 9;
            // 
            // lblBlue
            // 
            this.lblBlue.BackColor = System.Drawing.Color.White;
            this.lblBlue.Location = new System.Drawing.Point(72, 43);
            this.lblBlue.Name = "lblBlue";
            this.lblBlue.Size = new System.Drawing.Size(116, 17);
            this.lblBlue.TabIndex = 8;
            // 
            // lblRed
            // 
            this.lblRed.BackColor = System.Drawing.Color.White;
            this.lblRed.Location = new System.Drawing.Point(72, 20);
            this.lblRed.Name = "lblRed";
            this.lblRed.Size = new System.Drawing.Size(116, 17);
            this.lblRed.TabIndex = 7;
            // 
            // rbCyan
            // 
            this.rbCyan.AutoSize = true;
            this.rbCyan.Location = new System.Drawing.Point(9, 135);
            this.rbCyan.Name = "rbCyan";
            this.rbCyan.Size = new System.Drawing.Size(50, 17);
            this.rbCyan.TabIndex = 5;
            this.rbCyan.TabStop = true;
            this.rbCyan.Text = "Cyan";
            this.rbCyan.UseVisualStyleBackColor = true;
            // 
            // rbPurple
            // 
            this.rbPurple.AutoSize = true;
            this.rbPurple.Location = new System.Drawing.Point(9, 112);
            this.rbPurple.Name = "rbPurple";
            this.rbPurple.Size = new System.Drawing.Size(55, 17);
            this.rbPurple.TabIndex = 4;
            this.rbPurple.TabStop = true;
            this.rbPurple.Text = "Purple";
            this.rbPurple.UseVisualStyleBackColor = true;
            // 
            // rbYellow
            // 
            this.rbYellow.AutoSize = true;
            this.rbYellow.Location = new System.Drawing.Point(9, 89);
            this.rbYellow.Name = "rbYellow";
            this.rbYellow.Size = new System.Drawing.Size(55, 17);
            this.rbYellow.TabIndex = 3;
            this.rbYellow.TabStop = true;
            this.rbYellow.Text = "Yellow";
            this.rbYellow.UseVisualStyleBackColor = true;
            // 
            // rbGreen
            // 
            this.rbGreen.AutoSize = true;
            this.rbGreen.Location = new System.Drawing.Point(8, 66);
            this.rbGreen.Name = "rbGreen";
            this.rbGreen.Size = new System.Drawing.Size(54, 17);
            this.rbGreen.TabIndex = 2;
            this.rbGreen.TabStop = true;
            this.rbGreen.Text = "Green";
            this.rbGreen.UseVisualStyleBackColor = true;
            // 
            // rbBlue
            // 
            this.rbBlue.AutoSize = true;
            this.rbBlue.Location = new System.Drawing.Point(8, 43);
            this.rbBlue.Name = "rbBlue";
            this.rbBlue.Size = new System.Drawing.Size(45, 17);
            this.rbBlue.TabIndex = 1;
            this.rbBlue.TabStop = true;
            this.rbBlue.Text = "Blue";
            this.rbBlue.UseVisualStyleBackColor = true;
            // 
            // rbRed
            // 
            this.rbRed.AutoSize = true;
            this.rbRed.Location = new System.Drawing.Point(8, 20);
            this.rbRed.Name = "rbRed";
            this.rbRed.Size = new System.Drawing.Size(44, 17);
            this.rbRed.TabIndex = 0;
            this.rbRed.TabStop = true;
            this.rbRed.Text = "Red";
            this.rbRed.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 438);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(111, 21);
            this.button2.TabIndex = 11;
            this.button2.Text = "Process";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(607, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(51, 21);
            this.textBox1.TabIndex = 13;
            this.textBox1.Text = "COM3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(511, 385);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Serial Port Name:";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gbNegative
            // 
            this.gbNegative.Controls.Add(this.cbNCyan);
            this.gbNegative.Controls.Add(this.cbNPurple);
            this.gbNegative.Controls.Add(this.cbNYellow);
            this.gbNegative.Controls.Add(this.cbNGreen);
            this.gbNegative.Controls.Add(this.cbNBlue);
            this.gbNegative.Controls.Add(this.cbNRed);
            this.gbNegative.Location = new System.Drawing.Point(338, 409);
            this.gbNegative.Name = "gbNegative";
            this.gbNegative.Size = new System.Drawing.Size(78, 163);
            this.gbNegative.TabIndex = 14;
            this.gbNegative.TabStop = false;
            this.gbNegative.Text = "Negative";
            // 
            // cbNCyan
            // 
            this.cbNCyan.AutoSize = true;
            this.cbNCyan.Location = new System.Drawing.Point(10, 136);
            this.cbNCyan.Name = "cbNCyan";
            this.cbNCyan.Size = new System.Drawing.Size(51, 17);
            this.cbNCyan.TabIndex = 11;
            this.cbNCyan.Text = "Cyan";
            this.cbNCyan.UseVisualStyleBackColor = true;
            // 
            // cbNPurple
            // 
            this.cbNPurple.AutoSize = true;
            this.cbNPurple.Location = new System.Drawing.Point(10, 113);
            this.cbNPurple.Name = "cbNPurple";
            this.cbNPurple.Size = new System.Drawing.Size(56, 17);
            this.cbNPurple.TabIndex = 10;
            this.cbNPurple.Text = "Purple";
            this.cbNPurple.UseVisualStyleBackColor = true;
            // 
            // cbNYellow
            // 
            this.cbNYellow.AutoSize = true;
            this.cbNYellow.Location = new System.Drawing.Point(10, 90);
            this.cbNYellow.Name = "cbNYellow";
            this.cbNYellow.Size = new System.Drawing.Size(56, 17);
            this.cbNYellow.TabIndex = 9;
            this.cbNYellow.Text = "Yellow";
            this.cbNYellow.UseVisualStyleBackColor = true;
            // 
            // cbNGreen
            // 
            this.cbNGreen.AutoSize = true;
            this.cbNGreen.Location = new System.Drawing.Point(10, 67);
            this.cbNGreen.Name = "cbNGreen";
            this.cbNGreen.Size = new System.Drawing.Size(55, 17);
            this.cbNGreen.TabIndex = 8;
            this.cbNGreen.Text = "Green";
            this.cbNGreen.UseVisualStyleBackColor = true;
            // 
            // cbNBlue
            // 
            this.cbNBlue.AutoSize = true;
            this.cbNBlue.Location = new System.Drawing.Point(10, 44);
            this.cbNBlue.Name = "cbNBlue";
            this.cbNBlue.Size = new System.Drawing.Size(46, 17);
            this.cbNBlue.TabIndex = 7;
            this.cbNBlue.Text = "Blue";
            this.cbNBlue.UseVisualStyleBackColor = true;
            // 
            // cbNRed
            // 
            this.cbNRed.AutoSize = true;
            this.cbNRed.Location = new System.Drawing.Point(10, 21);
            this.cbNRed.Name = "cbNRed";
            this.cbNRed.Size = new System.Drawing.Size(45, 17);
            this.cbNRed.TabIndex = 6;
            this.cbNRed.Text = "Red";
            this.cbNRed.UseVisualStyleBackColor = true;
            // 
            // gbPositive
            // 
            this.gbPositive.Controls.Add(this.cbPCyan);
            this.gbPositive.Controls.Add(this.cbPPurple);
            this.gbPositive.Controls.Add(this.cbPYellow);
            this.gbPositive.Controls.Add(this.cbPGreen);
            this.gbPositive.Controls.Add(this.cbPBlue);
            this.gbPositive.Controls.Add(this.cbPRed);
            this.gbPositive.Location = new System.Drawing.Point(422, 409);
            this.gbPositive.Name = "gbPositive";
            this.gbPositive.Size = new System.Drawing.Size(78, 163);
            this.gbPositive.TabIndex = 15;
            this.gbPositive.TabStop = false;
            this.gbPositive.Text = "Positive";
            // 
            // cbPCyan
            // 
            this.cbPCyan.AutoSize = true;
            this.cbPCyan.Location = new System.Drawing.Point(10, 136);
            this.cbPCyan.Name = "cbPCyan";
            this.cbPCyan.Size = new System.Drawing.Size(51, 17);
            this.cbPCyan.TabIndex = 11;
            this.cbPCyan.Text = "Cyan";
            this.cbPCyan.UseVisualStyleBackColor = true;
            // 
            // cbPPurple
            // 
            this.cbPPurple.AutoSize = true;
            this.cbPPurple.Location = new System.Drawing.Point(10, 113);
            this.cbPPurple.Name = "cbPPurple";
            this.cbPPurple.Size = new System.Drawing.Size(56, 17);
            this.cbPPurple.TabIndex = 10;
            this.cbPPurple.Text = "Purple";
            this.cbPPurple.UseVisualStyleBackColor = true;
            // 
            // cbPYellow
            // 
            this.cbPYellow.AutoSize = true;
            this.cbPYellow.Location = new System.Drawing.Point(10, 90);
            this.cbPYellow.Name = "cbPYellow";
            this.cbPYellow.Size = new System.Drawing.Size(56, 17);
            this.cbPYellow.TabIndex = 9;
            this.cbPYellow.Text = "Yellow";
            this.cbPYellow.UseVisualStyleBackColor = true;
            // 
            // cbPGreen
            // 
            this.cbPGreen.AutoSize = true;
            this.cbPGreen.Location = new System.Drawing.Point(10, 67);
            this.cbPGreen.Name = "cbPGreen";
            this.cbPGreen.Size = new System.Drawing.Size(55, 17);
            this.cbPGreen.TabIndex = 8;
            this.cbPGreen.Text = "Green";
            this.cbPGreen.UseVisualStyleBackColor = true;
            // 
            // cbPBlue
            // 
            this.cbPBlue.AutoSize = true;
            this.cbPBlue.Location = new System.Drawing.Point(10, 44);
            this.cbPBlue.Name = "cbPBlue";
            this.cbPBlue.Size = new System.Drawing.Size(46, 17);
            this.cbPBlue.TabIndex = 7;
            this.cbPBlue.Text = "Blue";
            this.cbPBlue.UseVisualStyleBackColor = true;
            // 
            // cbPRed
            // 
            this.cbPRed.AutoSize = true;
            this.cbPRed.Location = new System.Drawing.Point(10, 21);
            this.cbPRed.Name = "cbPRed";
            this.cbPRed.Size = new System.Drawing.Size(45, 17);
            this.cbPRed.TabIndex = 6;
            this.cbPRed.Text = "Red";
            this.cbPRed.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(514, 418);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "label3";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 580);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gbPositive);
            this.Controls.Add(this.gbNegative);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.gbGetColors);
            this.Controls.Add(this.btnGetColors);
            this.Controls.Add(this.btnFreeze);
            this.Controls.Add(this.btnStream);
            this.Controls.Add(this.txtFieldRealSize);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ibResult);
            this.Controls.Add(this.ibCam);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Antares Main Processing Unit";
            ((System.ComponentModel.ISupportInitialize)(this.ibCam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ibResult)).EndInit();
            this.gbGetColors.ResumeLayout(false);
            this.gbGetColors.PerformLayout();
            this.gbNegative.ResumeLayout(false);
            this.gbNegative.PerformLayout();
            this.gbPositive.ResumeLayout(false);
            this.gbPositive.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox ibCam;
        private Emgu.CV.UI.ImageBox ibResult;
        private System.Windows.Forms.Label label1;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox txtFieldRealSize;
        private System.Windows.Forms.Button btnStream;
        private System.Windows.Forms.Button btnFreeze;
        private System.Windows.Forms.Button btnGetColors;
        private System.Windows.Forms.GroupBox gbGetColors;
        private System.Windows.Forms.Label lblCyan;
        private System.Windows.Forms.Label lblPurple;
        private System.Windows.Forms.Label lblYellow;
        private System.Windows.Forms.Label lblGreen;
        private System.Windows.Forms.Label lblBlue;
        private System.Windows.Forms.Label lblRed;
        private System.Windows.Forms.RadioButton rbCyan;
        private System.Windows.Forms.RadioButton rbPurple;
        private System.Windows.Forms.RadioButton rbYellow;
        private System.Windows.Forms.RadioButton rbGreen;
        private System.Windows.Forms.RadioButton rbBlue;
        private System.Windows.Forms.RadioButton rbRed;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox gbNegative;
        private System.Windows.Forms.CheckBox cbNCyan;
        private System.Windows.Forms.CheckBox cbNPurple;
        private System.Windows.Forms.CheckBox cbNYellow;
        private System.Windows.Forms.CheckBox cbNGreen;
        private System.Windows.Forms.CheckBox cbNBlue;
        private System.Windows.Forms.CheckBox cbNRed;
        private System.Windows.Forms.GroupBox gbPositive;
        private System.Windows.Forms.CheckBox cbPCyan;
        private System.Windows.Forms.CheckBox cbPPurple;
        private System.Windows.Forms.CheckBox cbPYellow;
        private System.Windows.Forms.CheckBox cbPGreen;
        private System.Windows.Forms.CheckBox cbPBlue;
        private System.Windows.Forms.CheckBox cbPRed;
        private System.Windows.Forms.Label label3;
    }
}

