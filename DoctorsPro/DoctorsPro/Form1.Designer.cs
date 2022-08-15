namespace DoctorsPro
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
            this.labelUname = new System.Windows.Forms.Label();
            this.label2Pass = new System.Windows.Forms.Label();
            this.userName_tb = new System.Windows.Forms.TextBox();
            this.password_tb = new System.Windows.Forms.TextBox();
            this.login_b = new System.Windows.Forms.Button();
            this.exit1_bt = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.signIn_bt = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUname
            // 
            this.labelUname.AutoSize = true;
            this.labelUname.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelUname.Location = new System.Drawing.Point(142, 28);
            this.labelUname.Name = "labelUname";
            this.labelUname.Size = new System.Drawing.Size(132, 29);
            this.labelUname.TabIndex = 0;
            this.labelUname.Text = ":שם משתמש";
            // 
            // label2Pass
            // 
            this.label2Pass.AutoSize = true;
            this.label2Pass.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold);
            this.label2Pass.Location = new System.Drawing.Point(190, 89);
            this.label2Pass.Name = "label2Pass";
            this.label2Pass.Size = new System.Drawing.Size(84, 29);
            this.label2Pass.TabIndex = 1;
            this.label2Pass.Text = ":סיסמא";
            // 
            // userName_tb
            // 
            this.userName_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.userName_tb.Location = new System.Drawing.Point(16, 35);
            this.userName_tb.Name = "userName_tb";
            this.userName_tb.Size = new System.Drawing.Size(120, 22);
            this.userName_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            this.password_tb.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.password_tb.Location = new System.Drawing.Point(16, 96);
            this.password_tb.Name = "password_tb";
            this.password_tb.Size = new System.Drawing.Size(120, 22);
            this.password_tb.TabIndex = 3;
            // 
            // login_b
            // 
            this.login_b.BackColor = System.Drawing.Color.Transparent;
            this.login_b.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.login_b.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_b.Location = new System.Drawing.Point(328, 51);
            this.login_b.Name = "login_b";
            this.login_b.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.login_b.Size = new System.Drawing.Size(124, 93);
            this.login_b.TabIndex = 4;
            this.login_b.Text = "כניסה למשתמש";
            this.login_b.UseVisualStyleBackColor = false;
            this.login_b.Click += new System.EventHandler(this.login_b_Click);
            // 
            // exit1_bt
            // 
            this.exit1_bt.BackColor = System.Drawing.Color.Transparent;
            this.exit1_bt.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.exit1_bt.Font = new System.Drawing.Font("Sitka Text", 10.2F, System.Drawing.FontStyle.Bold);
            this.exit1_bt.Location = new System.Drawing.Point(684, 324);
            this.exit1_bt.Name = "exit1_bt";
            this.exit1_bt.Size = new System.Drawing.Size(88, 50);
            this.exit1_bt.TabIndex = 6;
            this.exit1_bt.Text = "יציאה";
            this.exit1_bt.UseVisualStyleBackColor = false;
            this.exit1_bt.Click += new System.EventHandler(this.exit1_bt_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.userName_tb);
            this.panel1.Controls.Add(this.password_tb);
            this.panel1.Controls.Add(this.labelUname);
            this.panel1.Controls.Add(this.label2Pass);
            this.panel1.Location = new System.Drawing.Point(474, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 148);
            this.panel1.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(609, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "ליצירת משתמש  לחץ כאן";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // signIn_bt
            // 
            this.signIn_bt.BackgroundImage = global::DoctorsPro.Properties.Resources.signUp_pbt;
            this.signIn_bt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signIn_bt.Location = new System.Drawing.Point(527, 195);
            this.signIn_bt.Name = "signIn_bt";
            this.signIn_bt.Size = new System.Drawing.Size(76, 65);
            this.signIn_bt.TabIndex = 10;
            this.signIn_bt.UseVisualStyleBackColor = true;
            this.signIn_bt.Click += new System.EventHandler(this.signIn_bt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(818, 386);
            this.Controls.Add(this.signIn_bt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit1_bt);
            this.Controls.Add(this.login_b);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Doctors Program";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUname;
        private System.Windows.Forms.Label label2Pass;
        private System.Windows.Forms.TextBox userName_tb;
        private System.Windows.Forms.TextBox password_tb;
        private System.Windows.Forms.Button login_b;
        private System.Windows.Forms.Button exit1_bt;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button signIn_bt;
    }
}

