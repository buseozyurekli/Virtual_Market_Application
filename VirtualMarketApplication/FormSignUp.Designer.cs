namespace VirtualMarketApplication
{
    partial class FormSignUp
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
            this.btnSignUp = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtAgainPass = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnSignUp
            // 
            this.btnSignUp.Font = new System.Drawing.Font("Segoe Print", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSignUp.Location = new System.Drawing.Point(155, 209);
            this.btnSignUp.Name = "btnSignUp";
            this.btnSignUp.Size = new System.Drawing.Size(117, 26);
            this.btnSignUp.TabIndex = 0;
            this.btnSignUp.Text = "SIGN UP";
            this.btnSignUp.UseVisualStyleBackColor = true;
            this.btnSignUp.Click += new System.EventHandler(this.btnSignUp_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-mail            :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Username        : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(12, 128);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Password         :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(12, 164);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(143, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Password Again :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(13, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 28);
            this.label5.TabIndex = 5;
            this.label5.Text = "WELCOME : SIGN UP";
            // 
            // txtMail
            // 
            this.txtMail.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtMail.Location = new System.Drawing.Point(155, 59);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(117, 23);
            this.txtMail.TabIndex = 6;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtUser.Location = new System.Drawing.Point(155, 95);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(117, 23);
            this.txtUser.TabIndex = 7;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtPassword.Location = new System.Drawing.Point(155, 132);
            this.txtPassword.MaxLength = 8;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '•';
            this.txtPassword.Size = new System.Drawing.Size(117, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // txtAgainPass
            // 
            this.txtAgainPass.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtAgainPass.Location = new System.Drawing.Point(155, 168);
            this.txtAgainPass.MaxLength = 8;
            this.txtAgainPass.Name = "txtAgainPass";
            this.txtAgainPass.PasswordChar = '•';
            this.txtAgainPass.Size = new System.Drawing.Size(117, 23);
            this.txtAgainPass.TabIndex = 9;
            // 
            // FormSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.txtAgainPass);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSignUp);
            this.Name = "FormSignUp";
            this.Text = "FormSignUp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSignUp;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtAgainPass;
    }
}