
namespace SelettoreFile
{
    partial class Upload
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_upload = new System.Windows.Forms.Button();
            this.btn_showDialog = new System.Windows.Forms.Button();
            this.tb_user = new System.Windows.Forms.TextBox();
            this.tb_pw = new System.Windows.Forms.TextBox();
            this.tb_server = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_fileList = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cb_showpw = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_delete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_upload
            // 
            this.btn_upload.Location = new System.Drawing.Point(554, 368);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(75, 23);
            this.btn_upload.TabIndex = 0;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = true;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // btn_showDialog
            // 
            this.btn_showDialog.Location = new System.Drawing.Point(473, 368);
            this.btn_showDialog.Name = "btn_showDialog";
            this.btn_showDialog.Size = new System.Drawing.Size(75, 23);
            this.btn_showDialog.TabIndex = 1;
            this.btn_showDialog.Text = "Open";
            this.btn_showDialog.UseVisualStyleBackColor = true;
            this.btn_showDialog.Click += new System.EventHandler(this.btn_showDialog_Click);
            // 
            // tb_user
            // 
            this.tb_user.Location = new System.Drawing.Point(146, 133);
            this.tb_user.Name = "tb_user";
            this.tb_user.Size = new System.Drawing.Size(166, 20);
            this.tb_user.TabIndex = 2;
            // 
            // tb_pw
            // 
            this.tb_pw.Location = new System.Drawing.Point(146, 188);
            this.tb_pw.Name = "tb_pw";
            this.tb_pw.Size = new System.Drawing.Size(166, 20);
            this.tb_pw.TabIndex = 3;
            // 
            // tb_server
            // 
            this.tb_server.Location = new System.Drawing.Point(146, 246);
            this.tb_server.Name = "tb_server";
            this.tb_server.Size = new System.Drawing.Size(166, 20);
            this.tb_server.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 253);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Server";
            // 
            // lb_fileList
            // 
            this.lb_fileList.FormattingEnabled = true;
            this.lb_fileList.Location = new System.Drawing.Point(487, 80);
            this.lb_fileList.Name = "lb_fileList";
            this.lb_fileList.Size = new System.Drawing.Size(198, 264);
            this.lb_fileList.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(141, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(285, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "FTP Fast Uploader";
            // 
            // cb_showpw
            // 
            this.cb_showpw.AutoSize = true;
            this.cb_showpw.Location = new System.Drawing.Point(331, 190);
            this.cb_showpw.Name = "cb_showpw";
            this.cb_showpw.Size = new System.Drawing.Size(99, 17);
            this.cb_showpw.TabIndex = 10;
            this.cb_showpw.Text = "show password";
            this.cb_showpw.UseVisualStyleBackColor = true;
            this.cb_showpw.CheckedChanged += new System.EventHandler(this.cb_showpw_CheckedChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("OCR A Extended", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(189, 29);
            this.label5.TabIndex = 11;
            this.label5.Text = "Your Files:";
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(635, 368);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 12;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // Upload
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_showpw);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_fileList);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_server);
            this.Controls.Add(this.tb_pw);
            this.Controls.Add(this.tb_user);
            this.Controls.Add(this.btn_showDialog);
            this.Controls.Add(this.btn_upload);
            this.Name = "Upload";
            this.Text = "FTP Fast Uploader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_upload;
        private System.Windows.Forms.Button btn_showDialog;
        private System.Windows.Forms.TextBox tb_user;
        private System.Windows.Forms.TextBox tb_pw;
        private System.Windows.Forms.TextBox tb_server;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lb_fileList;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox cb_showpw;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_delete;
    }
}

