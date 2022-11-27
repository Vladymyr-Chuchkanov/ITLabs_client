
namespace ITLabs_client
{
    partial class DatabaseForm
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
            this.login_label = new System.Windows.Forms.Label();
            this.dbname_label = new System.Windows.Forms.Label();
            this.login_label2 = new System.Windows.Forms.Label();
            this.tbls_list_left = new System.Windows.Forms.ComboBox();
            this.tbls_list_right = new System.Windows.Forms.ComboBox();
            this.table_mult_btn = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.table_mult_result = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Location = new System.Drawing.Point(-598, -87);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(0, 15);
            this.login_label.TabIndex = 0;
            // 
            // dbname_label
            // 
            this.dbname_label.AutoSize = true;
            this.dbname_label.Location = new System.Drawing.Point(12, 33);
            this.dbname_label.Name = "dbname_label";
            this.dbname_label.Size = new System.Drawing.Size(25, 15);
            this.dbname_label.TabIndex = 1;
            this.dbname_label.Text = "123";
            // 
            // login_label2
            // 
            this.login_label2.AutoSize = true;
            this.login_label2.Location = new System.Drawing.Point(12, 9);
            this.login_label2.Name = "login_label2";
            this.login_label2.Size = new System.Drawing.Size(38, 15);
            this.login_label2.TabIndex = 2;
            this.login_label2.Text = "label1";
            // 
            // tbls_list_left
            // 
            this.tbls_list_left.FormattingEnabled = true;
            this.tbls_list_left.Location = new System.Drawing.Point(12, 61);
            this.tbls_list_left.Name = "tbls_list_left";
            this.tbls_list_left.Size = new System.Drawing.Size(111, 23);
            this.tbls_list_left.TabIndex = 3;
            // 
            // tbls_list_right
            // 
            this.tbls_list_right.FormattingEnabled = true;
            this.tbls_list_right.Location = new System.Drawing.Point(154, 61);
            this.tbls_list_right.Name = "tbls_list_right";
            this.tbls_list_right.Size = new System.Drawing.Size(121, 23);
            this.tbls_list_right.TabIndex = 4;
            // 
            // table_mult_btn
            // 
            this.table_mult_btn.Location = new System.Drawing.Point(105, 96);
            this.table_mult_btn.Name = "table_mult_btn";
            this.table_mult_btn.Size = new System.Drawing.Size(68, 28);
            this.table_mult_btn.TabIndex = 5;
            this.table_mult_btn.Text = "Добуток";
            this.table_mult_btn.UseVisualStyleBackColor = true;
            this.table_mult_btn.Click += new System.EventHandler(this.table_mult_btn_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(208, 96);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(32, 15);
            this.error_label.TabIndex = 7;
            this.error_label.Text = "error";
            // 
            // table_mult_result
            // 
            this.table_mult_result.FormattingEnabled = true;
            this.table_mult_result.ItemHeight = 15;
            this.table_mult_result.Location = new System.Drawing.Point(21, 170);
            this.table_mult_result.Name = "table_mult_result";
            this.table_mult_result.Size = new System.Drawing.Size(268, 214);
            this.table_mult_result.TabIndex = 9;
            // 
            // DatabaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.table_mult_result);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.table_mult_btn);
            this.Controls.Add(this.tbls_list_right);
            this.Controls.Add(this.tbls_list_left);
            this.Controls.Add(this.login_label2);
            this.Controls.Add(this.dbname_label);
            this.Controls.Add(this.login_label);
            this.Name = "DatabaseForm";
            this.Text = "DatabaseForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DatabaseForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label dbname_label;
        private System.Windows.Forms.Label login_label2;
        private System.Windows.Forms.ComboBox tbls_list_left;
        private System.Windows.Forms.ComboBox tbls_list_right;
        private System.Windows.Forms.Button table_mult_btn;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.ListBox table_mult_result;
    }
}