namespace lab4
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
            this.lblcalc = new System.Windows.Forms.Label();
            this.txtnum1 = new System.Windows.Forms.TextBox();
            this.txtnum2 = new System.Windows.Forms.TextBox();
            this.txtnum3 = new System.Windows.Forms.TextBox();
            this.btnmultiple = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btndiv = new System.Windows.Forms.Button();
            this.btnsum = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnclear = new System.Windows.Forms.Button();
            this.btnexit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblcalc
            // 
            this.lblcalc.BackColor = System.Drawing.Color.Black;
            this.lblcalc.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblcalc.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcalc.ForeColor = System.Drawing.Color.White;
            this.lblcalc.Location = new System.Drawing.Point(0, 0);
            this.lblcalc.Name = "lblcalc";
            this.lblcalc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblcalc.Size = new System.Drawing.Size(981, 58);
            this.lblcalc.TabIndex = 0;
            this.lblcalc.Text = "ماشین حساب";
            this.lblcalc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtnum1
            // 
            this.txtnum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum1.Location = new System.Drawing.Point(37, 109);
            this.txtnum1.Name = "txtnum1";
            this.txtnum1.Size = new System.Drawing.Size(153, 38);
            this.txtnum1.TabIndex = 1;
            // 
            // txtnum2
            // 
            this.txtnum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum2.Location = new System.Drawing.Point(486, 113);
            this.txtnum2.Name = "txtnum2";
            this.txtnum2.Size = new System.Drawing.Size(153, 38);
            this.txtnum2.TabIndex = 2;
            // 
            // txtnum3
            // 
            this.txtnum3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnum3.Location = new System.Drawing.Point(771, 113);
            this.txtnum3.Name = "txtnum3";
            this.txtnum3.ReadOnly = true;
            this.txtnum3.Size = new System.Drawing.Size(153, 38);
            this.txtnum3.TabIndex = 3;
            // 
            // btnmultiple
            // 
            this.btnmultiple.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnmultiple.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmultiple.Location = new System.Drawing.Point(217, 101);
            this.btnmultiple.Name = "btnmultiple";
            this.btnmultiple.Size = new System.Drawing.Size(47, 56);
            this.btnmultiple.TabIndex = 4;
            this.btnmultiple.Text = "*";
            this.btnmultiple.UseVisualStyleBackColor = true;
            this.btnmultiple.Click += new System.EventHandler(this.btnmultiple_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(671, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 69);
            this.label1.TabIndex = 5;
            this.label1.Text = "=";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btndiv
            // 
            this.btndiv.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndiv.Location = new System.Drawing.Point(283, 101);
            this.btndiv.Name = "btndiv";
            this.btndiv.Size = new System.Drawing.Size(47, 56);
            this.btndiv.TabIndex = 6;
            this.btndiv.Text = "/";
            this.btndiv.UseVisualStyleBackColor = true;
            this.btndiv.Click += new System.EventHandler(this.btndiv_Click);
            // 
            // btnsum
            // 
            this.btnsum.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsum.Location = new System.Drawing.Point(350, 101);
            this.btnsum.Name = "btnsum";
            this.btnsum.Size = new System.Drawing.Size(51, 56);
            this.btnsum.TabIndex = 7;
            this.btnsum.Text = "+";
            this.btnsum.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnsum.UseVisualStyleBackColor = true;
            this.btnsum.Click += new System.EventHandler(this.btnsum_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(422, 102);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(47, 56);
            this.button1.TabIndex = 8;
            this.button1.Text = "-";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnclear
            // 
            this.btnclear.Location = new System.Drawing.Point(600, 198);
            this.btnclear.Name = "btnclear";
            this.btnclear.Size = new System.Drawing.Size(159, 49);
            this.btnclear.TabIndex = 9;
            this.btnclear.Text = "پاک کردن";
            this.btnclear.UseVisualStyleBackColor = true;
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnexit
            // 
            this.btnexit.Location = new System.Drawing.Point(217, 198);
            this.btnexit.Name = "btnexit";
            this.btnexit.Size = new System.Drawing.Size(159, 49);
            this.btnexit.TabIndex = 10;
            this.btnexit.Text = "خروج";
            this.btnexit.UseVisualStyleBackColor = true;
            this.btnexit.Click += new System.EventHandler(this.btnexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 287);
            this.ControlBox = false;
            this.Controls.Add(this.btnexit);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnsum);
            this.Controls.Add(this.btndiv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnmultiple);
            this.Controls.Add(this.txtnum3);
            this.Controls.Add(this.txtnum2);
            this.Controls.Add(this.txtnum1);
            this.Controls.Add(this.lblcalc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblcalc;
        private System.Windows.Forms.TextBox txtnum1;
        private System.Windows.Forms.TextBox txtnum2;
        private System.Windows.Forms.TextBox txtnum3;
        private System.Windows.Forms.Button btnmultiple;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btndiv;
        private System.Windows.Forms.Button btnsum;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnclear;
        private System.Windows.Forms.Button btnexit;
    }
}

