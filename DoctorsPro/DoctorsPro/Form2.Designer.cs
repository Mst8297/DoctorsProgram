namespace DoctorsPro
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1_newUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.newUser_tb = new System.Windows.Forms.TextBox();
            this.newPass_tb = new System.Windows.Forms.TextBox();
            this.confirmPass_tb = new System.Windows.Forms.TextBox();
            this.back_bt = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.signIn_bt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1_newUser
            // 
            this.label1_newUser.AutoSize = true;
            this.label1_newUser.BackColor = System.Drawing.Color.Transparent;
            this.label1_newUser.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.label1_newUser.Location = new System.Drawing.Point(592, 136);
            this.label1_newUser.Name = "label1_newUser";
            this.label1_newUser.Size = new System.Drawing.Size(123, 28);
            this.label1_newUser.TabIndex = 1;
            this.label1_newUser.Text = ":שם משתמש";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(635, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 28);
            this.label2.TabIndex = 2;
            this.label2.Text = ":סיסמא";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Text", 11F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(577, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 28);
            this.label3.TabIndex = 3;
            this.label3.Text = ":אימות סיסמא";
            // 
            // newUser_tb
            // 
            this.newUser_tb.Location = new System.Drawing.Point(457, 136);
            this.newUser_tb.Name = "newUser_tb";
            this.newUser_tb.Size = new System.Drawing.Size(114, 22);
            this.newUser_tb.TabIndex = 4;
            // 
            // newPass_tb
            // 
            this.newPass_tb.Location = new System.Drawing.Point(457, 177);
            this.newPass_tb.Name = "newPass_tb";
            this.newPass_tb.Size = new System.Drawing.Size(114, 22);
            this.newPass_tb.TabIndex = 5;
            // 
            // confirmPass_tb
            // 
            this.confirmPass_tb.Location = new System.Drawing.Point(457, 222);
            this.confirmPass_tb.Name = "confirmPass_tb";
            this.confirmPass_tb.Size = new System.Drawing.Size(114, 22);
            this.confirmPass_tb.TabIndex = 6;
            // 
            // back_bt
            // 
            this.back_bt.BackColor = System.Drawing.Color.Transparent;
            this.back_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back_bt.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.back_bt.Location = new System.Drawing.Point(630, 378);
            this.back_bt.Name = "back_bt";
            this.back_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.back_bt.Size = new System.Drawing.Size(136, 48);
            this.back_bt.TabIndex = 7;
            this.back_bt.Text = "אחורה";
            this.back_bt.UseVisualStyleBackColor = false;
            this.back_bt.Click += new System.EventHandler(this.back_bt_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::DoctorsPro.Properties.Resources.doctors_user;
            this.pictureBox1.Location = new System.Drawing.Point(85, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(285, 325);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(504, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 87);
            this.label1.TabIndex = 9;
            this.label1.Text = "הרשמה";
            // 
            // signIn_bt
            // 
            this.signIn_bt.BackColor = System.Drawing.Color.Transparent;
            this.signIn_bt.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn_bt.Font = new System.Drawing.Font("Sitka Text", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn_bt.Location = new System.Drawing.Point(457, 267);
            this.signIn_bt.Name = "signIn_bt";
            this.signIn_bt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.signIn_bt.Size = new System.Drawing.Size(175, 61);
            this.signIn_bt.TabIndex = 10;
            this.signIn_bt.Text = "הירשם/מי:";
            this.signIn_bt.UseVisualStyleBackColor = false;
            this.signIn_bt.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::DoctorsPro.Properties.Resources.background_pic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.signIn_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.back_bt);
            this.Controls.Add(this.confirmPass_tb);
            this.Controls.Add(this.newPass_tb);
            this.Controls.Add(this.newUser_tb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1_newUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Doctors Program";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1_newUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox newUser_tb;
        private System.Windows.Forms.TextBox newPass_tb;
        private System.Windows.Forms.TextBox confirmPass_tb;
        private System.Windows.Forms.Button back_bt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signIn_bt;
    }
}