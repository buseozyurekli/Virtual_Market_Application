namespace VirtualMarketApplication
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnSign = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.txtPass = new System.Windows.Forms.TextBox();
			this.txtUserName = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.txtPassPer = new System.Windows.Forms.TextBox();
			this.btnAddPer = new System.Windows.Forms.Button();
			this.btnLoginPer = new System.Windows.Forms.Button();
			this.label5 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.Thistle;
			this.groupBox1.Controls.Add(this.btnSign);
			this.groupBox1.Controls.Add(this.btnLogin);
			this.groupBox1.Controls.Add(this.txtPass);
			this.groupBox1.Controls.Add(this.txtUserName);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(12, 50);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(360, 146);
			this.groupBox1.TabIndex = 0;
			this.groupBox1.TabStop = false;
			// 
			// btnSign
			// 
			this.btnSign.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnSign.Location = new System.Drawing.Point(208, 112);
			this.btnSign.Name = "btnSign";
			this.btnSign.Size = new System.Drawing.Size(98, 23);
			this.btnSign.TabIndex = 6;
			this.btnSign.Text = "SIGN UP";
			this.btnSign.UseVisualStyleBackColor = true;
			this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLogin.Location = new System.Drawing.Point(101, 112);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(98, 23);
			this.btnLogin.TabIndex = 5;
			this.btnLogin.Text = "LOGIN";
			this.btnLogin.UseVisualStyleBackColor = true;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// txtPass
			// 
			this.txtPass.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPass.Location = new System.Drawing.Point(101, 86);
			this.txtPass.MaxLength = 8;
			this.txtPass.Name = "txtPass";
			this.txtPass.PasswordChar = '•';
			this.txtPass.Size = new System.Drawing.Size(205, 26);
			this.txtPass.TabIndex = 4;
			// 
			// txtUserName
			// 
			this.txtUserName.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtUserName.Location = new System.Drawing.Point(101, 52);
			this.txtUserName.Name = "txtUserName";
			this.txtUserName.Size = new System.Drawing.Size(205, 26);
			this.txtUserName.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(5, 82);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(127, 31);
			this.label4.TabIndex = 2;
			this.label4.Text = "Password  : ";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 48);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(124, 31);
			this.label3.TabIndex = 1;
			this.label3.Text = "Username : ";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(94, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(224, 43);
			this.label1.TabIndex = 0;
			this.label1.Text = "Customer Entry";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.Thistle;
			this.groupBox2.Controls.Add(this.txtPassPer);
			this.groupBox2.Controls.Add(this.btnAddPer);
			this.groupBox2.Controls.Add(this.btnLoginPer);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label2);
			this.groupBox2.Location = new System.Drawing.Point(12, 217);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(360, 132);
			this.groupBox2.TabIndex = 1;
			this.groupBox2.TabStop = false;
			// 
			// txtPassPer
			// 
			this.txtPassPer.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.txtPassPer.Location = new System.Drawing.Point(101, 67);
			this.txtPassPer.MaxLength = 11;
			this.txtPassPer.Name = "txtPassPer";
			this.txtPassPer.PasswordChar = '•';
			this.txtPassPer.Size = new System.Drawing.Size(205, 26);
			this.txtPassPer.TabIndex = 10;
			// 
			// btnAddPer
			// 
			this.btnAddPer.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnAddPer.Location = new System.Drawing.Point(198, 93);
			this.btnAddPer.Name = "btnAddPer";
			this.btnAddPer.Size = new System.Drawing.Size(108, 23);
			this.btnAddPer.TabIndex = 9;
			this.btnAddPer.Text = "ADD PERSONNEL";
			this.btnAddPer.UseVisualStyleBackColor = true;
			this.btnAddPer.Click += new System.EventHandler(this.btnAddPer_Click);
			// 
			// btnLoginPer
			// 
			this.btnLoginPer.Font = new System.Drawing.Font("Segoe Print", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.btnLoginPer.Location = new System.Drawing.Point(101, 93);
			this.btnLoginPer.Name = "btnLoginPer";
			this.btnLoginPer.Size = new System.Drawing.Size(87, 23);
			this.btnLoginPer.TabIndex = 7;
			this.btnLoginPer.Text = "LOGIN";
			this.btnLoginPer.UseVisualStyleBackColor = true;
			this.btnLoginPer.Click += new System.EventHandler(this.btnLoginPer_Click);
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe Print", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(5, 63);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(127, 31);
			this.label5.TabIndex = 3;
			this.label5.Text = "Password  : ";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(95, 16);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(226, 43);
			this.label2.TabIndex = 1;
			this.label2.Text = "Personnel Entry";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe Print", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label6.Location = new System.Drawing.Point(12, 10);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(259, 44);
			this.label6.TabIndex = 2;
			this.label6.Text = "VIRTUAL MARKET";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(384, 361);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Name = "Form1";
			this.Text = "Virtual Market";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Button btnLoginPer;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAddPer;
        private System.Windows.Forms.TextBox txtPassPer;
    }
}

