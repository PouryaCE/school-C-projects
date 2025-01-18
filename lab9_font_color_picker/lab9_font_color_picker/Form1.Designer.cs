namespace lab9_font_color_picker
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtboxSample = new System.Windows.Forms.TextBox();
            this.picboxSample = new System.Windows.Forms.PictureBox();
            this.btnColor = new System.Windows.Forms.Button();
            this.btnFont = new System.Windows.Forms.Button();
            this.btnImage = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picboxSample)).BeginInit();
            this.SuspendLayout();
            // 
            // txtboxSample
            // 
            this.txtboxSample.Location = new System.Drawing.Point(608, 25);
            this.txtboxSample.Multiline = true;
            this.txtboxSample.Name = "txtboxSample";
            this.txtboxSample.Size = new System.Drawing.Size(404, 279);
            this.txtboxSample.TabIndex = 1;
            this.txtboxSample.Text = "حفظ محیط زیست وظیفه همه ماست\r\nبا حفظ محیط زیست .....";
            // 
            // picboxSample
            // 
            this.picboxSample.Image = ((System.Drawing.Image)(resources.GetObject("picboxSample.Image")));
            this.picboxSample.Location = new System.Drawing.Point(22, 25);
            this.picboxSample.Name = "picboxSample";
            this.picboxSample.Size = new System.Drawing.Size(548, 368);
            this.picboxSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picboxSample.TabIndex = 2;
            this.picboxSample.TabStop = false;
            // 
            // btnColor
            // 
            this.btnColor.ForeColor = System.Drawing.Color.DarkRed;
            this.btnColor.Location = new System.Drawing.Point(841, 437);
            this.btnColor.Name = "btnColor";
            this.btnColor.Size = new System.Drawing.Size(171, 49);
            this.btnColor.TabIndex = 3;
            this.btnColor.Text = "انتخاب رنگ";
            this.btnColor.UseVisualStyleBackColor = true;
            this.btnColor.Click += new System.EventHandler(this.btnColor_Click);
            // 
            // btnFont
            // 
            this.btnFont.ForeColor = System.Drawing.Color.DarkRed;
            this.btnFont.Location = new System.Drawing.Point(588, 437);
            this.btnFont.Name = "btnFont";
            this.btnFont.Size = new System.Drawing.Size(171, 49);
            this.btnFont.TabIndex = 4;
            this.btnFont.Text = "انتخاب قلم";
            this.btnFont.UseVisualStyleBackColor = true;
            this.btnFont.Click += new System.EventHandler(this.btnFont_Click);
            // 
            // btnImage
            // 
            this.btnImage.ForeColor = System.Drawing.Color.DarkRed;
            this.btnImage.Location = new System.Drawing.Point(316, 437);
            this.btnImage.Name = "btnImage";
            this.btnImage.Size = new System.Drawing.Size(171, 49);
            this.btnImage.TabIndex = 5;
            this.btnImage.Text = "انتخاب عکس";
            this.btnImage.UseVisualStyleBackColor = true;
            this.btnImage.Click += new System.EventHandler(this.btnImage_Click);
            // 
            // btnExit
            // 
            this.btnExit.ForeColor = System.Drawing.Color.DarkRed;
            this.btnExit.Location = new System.Drawing.Point(49, 437);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(171, 49);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "خروج";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1056, 512);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnImage);
            this.Controls.Add(this.btnFont);
            this.Controls.Add(this.btnColor);
            this.Controls.Add(this.picboxSample);
            this.Controls.Add(this.txtboxSample);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picboxSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtboxSample;
        private System.Windows.Forms.PictureBox picboxSample;
        private System.Windows.Forms.Button btnColor;
        private System.Windows.Forms.Button btnFont;
        private System.Windows.Forms.Button btnImage;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

