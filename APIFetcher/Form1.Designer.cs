namespace APIFetcher
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
            this.btn_fetch = new System.Windows.Forms.Button();
            this.txt_connection = new System.Windows.Forms.TextBox();
            this.lbl_connection = new System.Windows.Forms.Label();
            this.txt_response = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_fetch
            // 
            this.btn_fetch.Location = new System.Drawing.Point(318, 230);
            this.btn_fetch.Name = "btn_fetch";
            this.btn_fetch.Size = new System.Drawing.Size(142, 46);
            this.btn_fetch.TabIndex = 0;
            this.btn_fetch.Text = "FetchAPI";
            this.btn_fetch.UseVisualStyleBackColor = true;
            this.btn_fetch.Click += new System.EventHandler(this.btn_fetch_Click);
            // 
            // txt_connection
            // 
            this.txt_connection.Location = new System.Drawing.Point(272, 113);
            this.txt_connection.Name = "txt_connection";
            this.txt_connection.Size = new System.Drawing.Size(357, 20);
            this.txt_connection.TabIndex = 1;
            // 
            // lbl_connection
            // 
            this.lbl_connection.AutoSize = true;
            this.lbl_connection.Location = new System.Drawing.Point(115, 120);
            this.lbl_connection.Name = "lbl_connection";
            this.lbl_connection.Size = new System.Drawing.Size(91, 13);
            this.lbl_connection.TabIndex = 2;
            this.lbl_connection.Text = "Connection String";
            // 
            // txt_response
            // 
            this.txt_response.Location = new System.Drawing.Point(272, 323);
            this.txt_response.Multiline = true;
            this.txt_response.Name = "txt_response";
            this.txt_response.Size = new System.Drawing.Size(254, 98);
            this.txt_response.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_response);
            this.Controls.Add(this.lbl_connection);
            this.Controls.Add(this.txt_connection);
            this.Controls.Add(this.btn_fetch);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_fetch;
        private System.Windows.Forms.TextBox txt_connection;
        private System.Windows.Forms.Label lbl_connection;
        private System.Windows.Forms.TextBox txt_response;
    }
}

