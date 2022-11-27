
namespace ITLabs_client
{
    partial class AccountForm
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
            this.acc_name = new System.Windows.Forms.Label();
            this.dbs_list = new System.Windows.Forms.ComboBox();
            this.open_btn = new System.Windows.Forms.Button();
            this.error_label = new System.Windows.Forms.Label();
            this.add_db_btn = new System.Windows.Forms.Button();
            this.new_db_input = new System.Windows.Forms.TextBox();
            this.delete_db_btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // acc_name
            // 
            this.acc_name.AutoSize = true;
            this.acc_name.Location = new System.Drawing.Point(14, 14);
            this.acc_name.Name = "acc_name";
            this.acc_name.Size = new System.Drawing.Size(0, 15);
            this.acc_name.TabIndex = 0;
            // 
            // dbs_list
            // 
            this.dbs_list.FormattingEnabled = true;
            this.dbs_list.Location = new System.Drawing.Point(14, 66);
            this.dbs_list.Name = "dbs_list";
            this.dbs_list.Size = new System.Drawing.Size(159, 23);
            this.dbs_list.TabIndex = 2;
            // 
            // open_btn
            // 
            this.open_btn.Location = new System.Drawing.Point(217, 66);
            this.open_btn.Name = "open_btn";
            this.open_btn.Size = new System.Drawing.Size(150, 23);
            this.open_btn.TabIndex = 3;
            this.open_btn.Text = "Відкрити";
            this.open_btn.UseVisualStyleBackColor = true;
            this.open_btn.Click += new System.EventHandler(this.open_btn_Click);
            // 
            // error_label
            // 
            this.error_label.AutoSize = true;
            this.error_label.Location = new System.Drawing.Point(217, 38);
            this.error_label.Name = "error_label";
            this.error_label.Size = new System.Drawing.Size(0, 15);
            this.error_label.TabIndex = 4;
            // 
            // add_db_btn
            // 
            this.add_db_btn.Location = new System.Drawing.Point(217, 94);
            this.add_db_btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.add_db_btn.Name = "add_db_btn";
            this.add_db_btn.Size = new System.Drawing.Size(150, 23);
            this.add_db_btn.TabIndex = 5;
            this.add_db_btn.Text = "Додати";
            this.add_db_btn.UseVisualStyleBackColor = true;
            this.add_db_btn.Click += new System.EventHandler(this.add_db_btn_Click);
            // 
            // new_db_input
            // 
            this.new_db_input.Location = new System.Drawing.Point(393, 94);
            this.new_db_input.Name = "new_db_input";
            this.new_db_input.Size = new System.Drawing.Size(147, 23);
            this.new_db_input.TabIndex = 6;
            // 
            // delete_db_btn
            // 
            this.delete_db_btn.Location = new System.Drawing.Point(217, 122);
            this.delete_db_btn.Name = "delete_db_btn";
            this.delete_db_btn.Size = new System.Drawing.Size(150, 23);
            this.delete_db_btn.TabIndex = 7;
            this.delete_db_btn.Text = "Видалити";
            this.delete_db_btn.UseVisualStyleBackColor = true;
            this.delete_db_btn.Click += new System.EventHandler(this.delete_db_btn_Click);
            // 
            // AccountForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.delete_db_btn);
            this.Controls.Add(this.new_db_input);
            this.Controls.Add(this.add_db_btn);
            this.Controls.Add(this.error_label);
            this.Controls.Add(this.open_btn);
            this.Controls.Add(this.dbs_list);
            this.Controls.Add(this.acc_name);
            this.Name = "AccountForm";
            this.Text = "Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label acc_name;
        private System.Windows.Forms.ComboBox dbs_list;
        private System.Windows.Forms.Button open_btn;
        private System.Windows.Forms.Label error_label;
        private System.Windows.Forms.Button add_db_btn;
        private System.Windows.Forms.TextBox new_db_input;
        private System.Windows.Forms.Button delete_db_btn;
    }
}