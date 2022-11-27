
namespace ITLabs_client
{
    partial class RegisterForm
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
            this.register_btn = new System.Windows.Forms.Button();
            this.register_label_error = new System.Windows.Forms.Label();
            this.email_input = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // register_btn
            // 
            this.register_btn.Location = new System.Drawing.Point(261, 190);
            this.register_btn.Name = "register_btn";
            this.register_btn.Size = new System.Drawing.Size(242, 32);
            this.register_btn.TabIndex = 0;
            this.register_btn.Text = "Зареєструватися";
            this.register_btn.UseVisualStyleBackColor = true;
            this.register_btn.Click += new System.EventHandler(this.register_btn_Click);
            // 
            // register_label_error
            // 
            this.register_label_error.AutoSize = true;
            this.register_label_error.Location = new System.Drawing.Point(261, 162);
            this.register_label_error.Name = "register_label_error";
            this.register_label_error.Size = new System.Drawing.Size(0, 15);
            this.register_label_error.TabIndex = 1;
            this.register_label_error.Click += new System.EventHandler(this.label1_Click);
            // 
            // email_input
            // 
            this.email_input.Location = new System.Drawing.Point(261, 120);
            this.email_input.Name = "email_input";
            this.email_input.Size = new System.Drawing.Size(241, 23);
            this.email_input.TabIndex = 2;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.email_input);
            this.Controls.Add(this.register_label_error);
            this.Controls.Add(this.register_btn);
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button register_btn;
        private System.Windows.Forms.Label register_label_error;
        private System.Windows.Forms.TextBox email_input;
    }
}