namespace VirtualMarketApplication
{
    partial class FormAdminEntry
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
            this.btnAdminLogin = new System.Windows.Forms.Button();
            this.txtAdminPass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdminLogin
            // 
            this.btnAdminLogin.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnAdminLogin.Location = new System.Drawing.Point(131, 107);
            this.btnAdminLogin.Name = "btnAdminLogin";
            this.btnAdminLogin.Size = new System.Drawing.Size(141, 23);
            this.btnAdminLogin.TabIndex = 5;
            this.btnAdminLogin.Text = "OK";
            this.btnAdminLogin.UseVisualStyleBackColor = true;
            this.btnAdminLogin.Click += new System.EventHandler(this.btnAdminLogin_Click);
            // 
            // txtAdminPass
            // 
            this.txtAdminPass.Location = new System.Drawing.Point(131, 68);
            this.txtAdminPass.Name = "txtAdminPass";
            this.txtAdminPass.PasswordChar = '•';
            this.txtAdminPass.Size = new System.Drawing.Size(141, 20);
            this.txtAdminPass.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Print", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 63);
            this.label1.TabIndex = 3;
            this.label1.Text = "Please enter your admin ; \r\n\r\n   password :";
            // 
            // FormAdminEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.btnAdminLogin);
            this.Controls.Add(this.txtAdminPass);
            this.Controls.Add(this.label1);
            this.Name = "FormAdminEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdminEntry";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAdminLogin;
        private System.Windows.Forms.TextBox txtAdminPass;
        private System.Windows.Forms.Label label1;
    }
}