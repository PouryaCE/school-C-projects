namespace Lab1_MoveCar
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
            this.components = new System.ComponentModel.Container();
            this.picboxCar = new System.Windows.Forms.PictureBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.timerCar = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picboxCar)).BeginInit();
            this.SuspendLayout();
            // 
            // picboxCar
            // 
            this.picboxCar.Image = global::Lab1_MoveCar.Properties.Resources.sports_car_icon_isolated_on_white_background_free_vector;
            this.picboxCar.Location = new System.Drawing.Point(37, 304);
            this.picboxCar.Name = "picboxCar";
            this.picboxCar.Size = new System.Drawing.Size(306, 208);
            this.picboxCar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picboxCar.TabIndex = 0;
            this.picboxCar.TabStop = false;
            this.picboxCar.Click += new System.EventHandler(this.picboxCar_Click);
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(918, 86);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(187, 87);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "شروع";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Tahoma", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(27, 86);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(187, 87);
            this.btnStop.TabIndex = 2;
            this.btnStop.Text = "توقف";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // timerCar
            // 
            this.timerCar.Interval = 20;
            this.timerCar.Tick += new System.EventHandler(this.timerCar_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1150, 608);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.picboxCar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picboxCar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picboxCar;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Timer timerCar;



    }
}

