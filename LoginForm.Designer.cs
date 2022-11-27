
namespace ITLabs_client
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
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_register = new System.Windows.Forms.Button();
            this.input_login = new System.Windows.Forms.TextBox();
            this.login_error_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(316, 178);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(144, 30);
            this.btn_login.TabIndex = 0;
            this.btn_login.Text = "Увійти";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_register
            // 
            this.btn_register.Location = new System.Drawing.Point(316, 214);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(144, 30);
            this.btn_register.TabIndex = 1;
            this.btn_register.Text = "Зареєструватися";
            this.btn_register.UseVisualStyleBackColor = true;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // input_login
            // 
            this.input_login.Location = new System.Drawing.Point(316, 117);
            this.input_login.Name = "input_login";
            this.input_login.Size = new System.Drawing.Size(144, 23);
            this.input_login.TabIndex = 2;
            // 
            // login_error_label
            // 
            this.login_error_label.AutoSize = true;
            this.login_error_label.Location = new System.Drawing.Point(319, 150);
            this.login_error_label.Name = "login_error_label";
            this.login_error_label.Size = new System.Drawing.Size(0, 15);
            this.login_error_label.TabIndex = 3;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.login_error_label);
            this.Controls.Add(this.input_login);
            this.Controls.Add(this.btn_register);
            this.Controls.Add(this.btn_login);
            this.Name = "LoginForm";
            this.Text = "LoginForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.TextBox input_login;
        private System.Windows.Forms.Label login_error_label;
    }
}