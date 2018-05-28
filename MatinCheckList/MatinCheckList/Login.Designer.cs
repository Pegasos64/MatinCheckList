namespace MatinCheckList
{
    partial class Login
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
            this.l_user = new System.Windows.Forms.Label();
            this.l_password = new System.Windows.Forms.Label();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.b_login = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // l_user
            // 
            this.l_user.AutoSize = true;
            this.l_user.Location = new System.Drawing.Point(26, 25);
            this.l_user.Name = "l_user";
            this.l_user.Size = new System.Drawing.Size(32, 13);
            this.l_user.TabIndex = 0;
            this.l_user.Text = "User:";
            // 
            // l_password
            // 
            this.l_password.AutoSize = true;
            this.l_password.Location = new System.Drawing.Point(29, 66);
            this.l_password.Name = "l_password";
            this.l_password.Size = new System.Drawing.Size(56, 13);
            this.l_password.TabIndex = 1;
            this.l_password.Text = "Password:";
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(108, 22);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(100, 20);
            this.tb_user.TabIndex = 2;
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(108, 63);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(100, 20);
            this.tb_password.TabIndex = 3;
            // 
            // b_login
            // 
            this.b_login.Location = new System.Drawing.Point(32, 131);
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(75, 23);
            this.b_login.TabIndex = 4;
            this.b_login.Text = "Login";
            this.b_login.UseVisualStyleBackColor = true;
            this.b_login.Click += new System.EventHandler(this.b_login_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(133, 131);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 23);
            this.b_cancel.TabIndex = 5;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(233, 169);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.l_password);
            this.Controls.Add(this.l_user);
            this.Name = "Login";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label l_user;
        private System.Windows.Forms.Label l_password;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button b_login;
        private System.Windows.Forms.Button b_cancel;
    }
}