namespace QuanLyKhachSan
{
    partial class FormDoiMK
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
            this.components = new System.ComponentModel.Container();
            this.txtMkm2 = new System.Windows.Forms.TextBox();
            this.txtMkm = new System.Windows.Forms.TextBox();
            this.txtMkc = new System.Windows.Forms.TextBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnHuy = new System.Windows.Forms.Button();
            this.btnXacnhan = new System.Windows.Forms.Button();
            this.batloi = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.batloi)).BeginInit();
            this.SuspendLayout();
            // 
            // txtMkm2
            // 
            this.txtMkm2.Location = new System.Drawing.Point(208, 198);
            this.txtMkm2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMkm2.Name = "txtMkm2";
            this.txtMkm2.Size = new System.Drawing.Size(180, 20);
            this.txtMkm2.TabIndex = 21;
            this.txtMkm2.UseSystemPasswordChar = true;
            // 
            // txtMkm
            // 
            this.txtMkm.Location = new System.Drawing.Point(208, 159);
            this.txtMkm.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMkm.Name = "txtMkm";
            this.txtMkm.Size = new System.Drawing.Size(180, 20);
            this.txtMkm.TabIndex = 20;
            this.txtMkm.UseSystemPasswordChar = true;
            // 
            // txtMkc
            // 
            this.txtMkc.Location = new System.Drawing.Point(208, 119);
            this.txtMkc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtMkc.Name = "txtMkc";
            this.txtMkc.Size = new System.Drawing.Size(180, 20);
            this.txtMkc.TabIndex = 19;
            this.txtMkc.UseSystemPasswordChar = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(204, 86);
            this.lblUser.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(35, 13);
            this.lblUser.TabIndex = 18;
            this.lblUser.Text = "label6";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nhập lại mật khẩu mới";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 163);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Mật khẩu mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Mật khẩu cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 86);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Tên đăng nhập";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(122, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 31);
            this.label1.TabIndex = 13;
            this.label1.Text = "Đổi mật khẩu";
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(69, 248);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(100, 35);
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnXacnhan
            // 
            this.btnXacnhan.Location = new System.Drawing.Point(260, 248);
            this.btnXacnhan.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnXacnhan.Name = "btnXacnhan";
            this.btnXacnhan.Size = new System.Drawing.Size(100, 35);
            this.btnXacnhan.TabIndex = 11;
            this.btnXacnhan.Text = "Xác nhận";
            this.btnXacnhan.UseVisualStyleBackColor = true;
            this.btnXacnhan.Click += new System.EventHandler(this.btnXacnhan_Click);
            // 
            // batloi
            // 
            this.batloi.ContainerControl = this;
            // 
            // FormDoiMK
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 324);
            this.Controls.Add(this.txtMkm2);
            this.Controls.Add(this.txtMkm);
            this.Controls.Add(this.txtMkc);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacnhan);
            this.Name = "FormDoiMK";
            this.Text = "FormDoiMK";
            this.Load += new System.EventHandler(this.FormDoiMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.batloi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMkm2;
        private System.Windows.Forms.TextBox txtMkm;
        private System.Windows.Forms.TextBox txtMkc;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.Button btnXacnhan;
        private System.Windows.Forms.ErrorProvider batloi;
    }
}