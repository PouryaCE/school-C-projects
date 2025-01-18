namespace lab8
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtFamily = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.txtPass = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.picSample = new System.Windows.Forms.PictureBox();
            this.btnAvatar = new System.Windows.Forms.Button();
            this.OpenFileDialogAvatar = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام کاربر:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(151, 64);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(285, 40);
            this.txtName.TabIndex = 1;
            // 
            // txtFamily
            // 
            this.txtFamily.Location = new System.Drawing.Point(151, 132);
            this.txtFamily.Name = "txtFamily";
            this.txtFamily.Size = new System.Drawing.Size(285, 40);
            this.txtFamily.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 35);
            this.label2.TabIndex = 2;
            this.label2.Text = "نام خانوادگی:";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(151, 202);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(285, 40);
            this.txtUserName.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 35);
            this.label3.TabIndex = 4;
            this.label3.Text = "نام کاربری:";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(151, 286);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(285, 40);
            this.textBox4.TabIndex = 7;
            // 
            // txtPass
            // 
            this.txtPass.AutoSize = true;
            this.txtPass.Location = new System.Drawing.Point(47, 291);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(98, 35);
            this.txtPass.TabIndex = 6;
            this.txtPass.Text = "گذرواژه:";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(151, 373);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(285, 40);
            this.textBox5.TabIndex = 9;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.AutoSize = true;
            this.txtConfirmPass.Location = new System.Drawing.Point(2, 378);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(145, 35);
            this.txtConfirmPass.TabIndex = 8;
            this.txtConfirmPass.Text = "تکرار گذرواژه:";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(151, 462);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(285, 153);
            this.textBox6.TabIndex = 11;
            // 
            // txtAddress
            // 
            this.txtAddress.AutoSize = true;
            this.txtAddress.Location = new System.Drawing.Point(70, 465);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(75, 35);
            this.txtAddress.TabIndex = 10;
            this.txtAddress.Text = "نشانی:";
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(559, 458);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(222, 46);
            this.btnSubmit.TabIndex = 12;
            this.btnSubmit.Text = "ثبت";
            this.btnSubmit.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.CadetBlue;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Location = new System.Drawing.Point(559, 517);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(222, 46);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.CadetBlue;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(559, 569);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(222, 46);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // picSample
            // 
            this.picSample.Image = global::lab8.Properties.Resources.user_avatar_male_5;
            this.picSample.Location = new System.Drawing.Point(524, 64);
            this.picSample.Name = "picSample";
            this.picSample.Size = new System.Drawing.Size(271, 262);
            this.picSample.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picSample.TabIndex = 15;
            this.picSample.TabStop = false;
            this.picSample.Click += new System.EventHandler(this.picSample_Click);
            // 
            // btnAvatar
            // 
            this.btnAvatar.Location = new System.Drawing.Point(524, 325);
            this.btnAvatar.Name = "btnAvatar";
            this.btnAvatar.Size = new System.Drawing.Size(271, 46);
            this.btnAvatar.TabIndex = 16;
            this.btnAvatar.Text = "بارگذاری تصویر";
            this.btnAvatar.UseVisualStyleBackColor = true;
            this.btnAvatar.Click += new System.EventHandler(this.btnAvatar_Click);
            // 
            // OpenFileDialogAvatar
            // 
            this.OpenFileDialogAvatar.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(807, 627);
            this.Controls.Add(this.btnAvatar);
            this.Controls.Add(this.picSample);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtConfirmPass);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.txtPass);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFamily);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RightToLeftLayout = true;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picSample)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtFamily;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label txtPass;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label txtConfirmPass;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label txtAddress;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PictureBox picSample;
        private System.Windows.Forms.Button btnAvatar;
        private System.Windows.Forms.OpenFileDialog OpenFileDialogAvatar;
    }
}

