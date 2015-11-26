namespace yuni_mail_viewer
{
    partial class LoginForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.mail_address_box = new System.Windows.Forms.TextBox();
            this.password_box = new System.Windows.Forms.TextBox();
            this.login_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "メールアドレス";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "パスワード";
            // 
            // mail_address_box
            // 
            this.mail_address_box.Location = new System.Drawing.Point(96, 39);
            this.mail_address_box.Name = "mail_address_box";
            this.mail_address_box.Size = new System.Drawing.Size(176, 19);
            this.mail_address_box.TabIndex = 2;
            // 
            // password_box
            // 
            this.password_box.Location = new System.Drawing.Point(96, 87);
            this.password_box.Name = "password_box";
            this.password_box.Size = new System.Drawing.Size(176, 19);
            this.password_box.TabIndex = 3;
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(105, 138);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 4;
            this.login_button.Text = "ログイン";
            this.login_button.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 192);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.password_box);
            this.Controls.Add(this.mail_address_box);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(300, 230);
            this.MinimumSize = new System.Drawing.Size(300, 230);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox mail_address_box;
        private System.Windows.Forms.TextBox password_box;
        private System.Windows.Forms.Button login_button;
    }
}