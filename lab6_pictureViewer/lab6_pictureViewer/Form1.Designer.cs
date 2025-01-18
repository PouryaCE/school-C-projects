namespace lab6_pictureViewer
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
            this.btnPrev = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnZoomIN = new System.Windows.Forms.Button();
            this.btnZoomOut = new System.Windows.Forms.Button();
            this.picSample = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrev
            // 
            this.btnPrev.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(56, 55);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(151, 80);
            this.btnPrev.TabIndex = 0;
            this.btnPrev.Text = "< ==";
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNext.Location = new System.Drawing.Point(688, 55);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(151, 80);
            this.btnNext.TabIndex = 1;
            this.btnNext.Text = "== >";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnZoomIN
            // 
            this.btnZoomIN.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomIN.Location = new System.Drawing.Point(280, 55);
            this.btnZoomIN.Name = "btnZoomIN";
            this.btnZoomIN.Size = new System.Drawing.Size(151, 80);
            this.btnZoomIN.TabIndex = 2;
            this.btnZoomIN.Text = "+";
            this.btnZoomIN.UseVisualStyleBackColor = true;
            this.btnZoomIN.Click += new System.EventHandler(this.btnZoomIN_Click);
            // 
            // btnZoomOut
            // 
            this.btnZoomOut.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnZoomOut.Location = new System.Drawing.Point(466, 55);
            this.btnZoomOut.Name = "btnZoomOut";
            this.btnZoomOut.Size = new System.Drawing.Size(151, 80);
            this.btnZoomOut.TabIndex = 3;
            this.btnZoomOut.Text = "-";
            this.btnZoomOut.UseVisualStyleBackColor = true;
            this.btnZoomOut.Click += new System.EventHandler(this.btnZoomOut_Click);
            // 
            // picSample
            // 
            this.picSample.Location = new System.Drawing.Point(128, 179);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(639, 364);
            this.picSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSample.TabIndex = 4;
            this.picSample.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 648);
            this.Controls.Add(this.picSample);
            this.Controls.Add(this.btnZoomOut);
            this.Controls.Add(this.btnZoomIN);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrev);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnZoomIN;
        private System.Windows.Forms.Button btnZoomOut;
        private System.Windows.Forms.PictureBox picSample;
    }
}

