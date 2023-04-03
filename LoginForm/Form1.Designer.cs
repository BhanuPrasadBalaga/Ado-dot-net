using System.Drawing;

namespace LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btCancel = new System.Windows.Forms.Button();
            this.btRegister = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.epName = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbConfirmPassword = new System.Windows.Forms.TextBox();
            this.btHide = new System.Windows.Forms.Button();
            this.btUnhide = new System.Windows.Forms.Button();
            this.btHidePwd = new System.Windows.Forms.Button();
            this.btViewPwd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.epName)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(255, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 0);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Name";
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(421, 106);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(192, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(421, 145);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(192, 22);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(221, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 17);
            this.label5.TabIndex = 11;
            this.label5.Text = "Password";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(121, 17);
            this.label6.TabIndex = 13;
            this.label6.Text = "Confirm Password";
            // 
            // btCancel
            // 
            this.btCancel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btCancel.Location = new System.Drawing.Point(294, 348);
            this.btCancel.Name = "btCancel";
            this.btCancel.Size = new System.Drawing.Size(106, 34);
            this.btCancel.TabIndex = 6;
            this.btCancel.Text = "CANCEL";
            this.btCancel.UseVisualStyleBackColor = false;
            this.btCancel.Click += new System.EventHandler(this.btCancel_Click);
            // 
            // btRegister
            // 
            this.btRegister.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btRegister.Location = new System.Drawing.Point(421, 348);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(100, 34);
            this.btRegister.TabIndex = 7;
            this.btRegister.Text = "REGISTER";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.btRegister_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(312, 44);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(152, 23);
            this.label7.TabIndex = 18;
            this.label7.Text = "Registration Form";
            // 
            // epName
            // 
            this.epName.ContainerControl = this;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(421, 188);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(192, 22);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.TextChanged += new System.EventHandler(this.tbEmail_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "First Name";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(421, 236);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.PasswordChar = '*';
            this.tbPassword.Size = new System.Drawing.Size(192, 22);
            this.tbPassword.TabIndex = 4;
            this.tbPassword.TextChanged += new System.EventHandler(this.tbPassword_TextChanged);
            // 
            // tbConfirmPassword
            // 
            this.tbConfirmPassword.Location = new System.Drawing.Point(421, 286);
            this.tbConfirmPassword.Name = "tbConfirmPassword";
            this.tbConfirmPassword.PasswordChar = '*';
            this.tbConfirmPassword.Size = new System.Drawing.Size(192, 22);
            this.tbConfirmPassword.TabIndex = 5;
            this.tbConfirmPassword.TextChanged += new System.EventHandler(this.tbConfirmPassword_TextChanged);
            // 
            // btHide
            // 
            this.btHide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btHide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHide.ForeColor = System.Drawing.Color.Black;
            this.btHide.Image = ((System.Drawing.Image)(resources.GetObject("btHide.Image")));
            this.btHide.Location = new System.Drawing.Point(581, 236);
            this.btHide.Name = "btHide";
            this.btHide.Size = new System.Drawing.Size(32, 23);
            this.btHide.TabIndex = 22;
            this.btHide.UseVisualStyleBackColor = false;
            this.btHide.Click += new System.EventHandler(this.btHide_Click);
            // 
            // btUnhide
            // 
            this.btUnhide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btUnhide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btUnhide.Image = ((System.Drawing.Image)(resources.GetObject("btUnhide.Image")));
            this.btUnhide.Location = new System.Drawing.Point(581, 236);
            this.btUnhide.Name = "btUnhide";
            this.btUnhide.Size = new System.Drawing.Size(33, 23);
            this.btUnhide.TabIndex = 23;
            this.btUnhide.UseVisualStyleBackColor = false;
            this.btUnhide.Click += new System.EventHandler(this.btUnhide_Click);
            // 
            // btHidePwd
            // 
            this.btHidePwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btHidePwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btHidePwd.ForeColor = System.Drawing.Color.Black;
            this.btHidePwd.Image = ((System.Drawing.Image)(resources.GetObject("btHidePwd.Image")));
            this.btHidePwd.Location = new System.Drawing.Point(581, 286);
            this.btHidePwd.Name = "btHidePwd";
            this.btHidePwd.Size = new System.Drawing.Size(33, 23);
            this.btHidePwd.TabIndex = 24;
            this.btHidePwd.UseVisualStyleBackColor = false;
            this.btHidePwd.Click += new System.EventHandler(this.btHidePwd_Click);
            // 
            // btViewPwd
            // 
            this.btViewPwd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btViewPwd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btViewPwd.Image = ((System.Drawing.Image)(resources.GetObject("btViewPwd.Image")));
            this.btViewPwd.Location = new System.Drawing.Point(581, 286);
            this.btViewPwd.Name = "btViewPwd";
            this.btViewPwd.Size = new System.Drawing.Size(33, 23);
            this.btViewPwd.TabIndex = 25;
            this.btViewPwd.UseVisualStyleBackColor = false;
            this.btViewPwd.Click += new System.EventHandler(this.btViewPwd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btViewPwd);
            this.Controls.Add(this.btHidePwd);
            this.Controls.Add(this.btUnhide);
            this.Controls.Add(this.btHide);
            this.Controls.Add(this.tbConfirmPassword);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.btCancel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(15, 15);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.epName)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btHidePwd;
        private System.Windows.Forms.Button btViewPwd;

        private System.Windows.Forms.Button btUnhide;

        private System.Windows.Forms.Button btHide;

        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbConfirmPassword;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.TextBox tbEmail;

        private System.Windows.Forms.ErrorProvider epName;

        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Label label6;
        //private System.Windows.Forms.MaskedTextBox tbConfirmPassword;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.Button btRegister;

        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}