using System.ComponentModel;

namespace LoginForm
{
    partial class login_form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login_form));
            this.btLogin = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btHide = new System.Windows.Forms.Button();
            this.btView = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btLogin
            // 
            this.btLogin.BackColor = System.Drawing.Color.Lime;
            this.btLogin.Location = new System.Drawing.Point(292, 239);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(180, 43);
            this.btLogin.TabIndex = 0;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.btLogin_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "EmailId";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmail.Location = new System.Drawing.Point(371, 92);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(222, 26);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbUserName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(371, 153);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(222, 26);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // btRegister
            // 
            this.btRegister.AutoSize = true;
            this.btRegister.BackColor = System.Drawing.Color.RoyalBlue;
            this.btRegister.Location = new System.Drawing.Point(244, 312);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(277, 48);
            this.btRegister.TabIndex = 5;
            this.btRegister.Text = "Click To Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // btHide
            // 
            this.btHide.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.Image = ((System.Drawing.Image)(resources.GetObject("btHide.Image")));
            this.btHide.Location = new System.Drawing.Point(572, 155);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(21, 25);
            this.btHide.TabIndex = 6;
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // btView
            // 
            this.btView.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btView.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btView.Image = ((System.Drawing.Image)(resources.GetObject("btView.Image")));
            this.btView.Location = new System.Drawing.Point(572, 155);
            this.btView.Name = "btView";
            this.btView.Size = new System.Drawing.Size(22, 26);
            this.btView.TabIndex = 7;
            this.btView.UseVisualStyleBackColor = false;
            this.btView.Click += new System.EventHandler(this.btView_Click);
            // 
            // login_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OldLace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btView);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btLogin);
            this.Name = "login_form";
            this.Text = "Search_form";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btHide;
        private System.Windows.Forms.Button btView;

        private System.Windows.Forms.Button btRegister;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;

        private System.Windows.Forms.Button btLogin;

        #endregion
    }
}