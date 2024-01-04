namespace BTL
{
    partial class frmPass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTk = new System.Windows.Forms.TextBox();
            this.txtmkc = new System.Windows.Forms.TextBox();
            this.txtmkm = new System.Windows.Forms.TextBox();
            this.txtmkmm = new System.Windows.Forms.TextBox();
            this.btnXacNhan = new System.Windows.Forms.Button();
            this.btnHuy3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(138, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Đổi Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tài Khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mật Khẩu Cũ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mật Khẩu Mới:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nhập Lại Mật Khẩu Mới:";
            // 
            // txtTk
            // 
            this.txtTk.Enabled = false;
            this.txtTk.Location = new System.Drawing.Point(170, 85);
            this.txtTk.Name = "txtTk";
            this.txtTk.Size = new System.Drawing.Size(159, 20);
            this.txtTk.TabIndex = 5;
            // 
            // txtmkc
            // 
            this.txtmkc.Location = new System.Drawing.Point(170, 115);
            this.txtmkc.Name = "txtmkc";
            this.txtmkc.PasswordChar = '*';
            this.txtmkc.Size = new System.Drawing.Size(159, 20);
            this.txtmkc.TabIndex = 6;
            // 
            // txtmkm
            // 
            this.txtmkm.Location = new System.Drawing.Point(170, 145);
            this.txtmkm.Name = "txtmkm";
            this.txtmkm.PasswordChar = '*';
            this.txtmkm.Size = new System.Drawing.Size(159, 20);
            this.txtmkm.TabIndex = 7;
            // 
            // txtmkmm
            // 
            this.txtmkmm.Location = new System.Drawing.Point(170, 175);
            this.txtmkmm.Name = "txtmkmm";
            this.txtmkmm.PasswordChar = '*';
            this.txtmkmm.Size = new System.Drawing.Size(159, 20);
            this.txtmkmm.TabIndex = 8;
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.Location = new System.Drawing.Point(77, 244);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.TabIndex = 9;
            this.btnXacNhan.Text = "Xác Nhận";
            this.btnXacNhan.UseVisualStyleBackColor = true;
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy3
            // 
            this.btnHuy3.Location = new System.Drawing.Point(217, 244);
            this.btnHuy3.Name = "btnHuy3";
            this.btnHuy3.Size = new System.Drawing.Size(75, 23);
            this.btnHuy3.TabIndex = 10;
            this.btnHuy3.Text = "Huỷ";
            this.btnHuy3.UseVisualStyleBackColor = true;
            this.btnHuy3.Click += new System.EventHandler(this.btnHuy3_Click);
            // 
            // frmPass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 326);
            this.Controls.Add(this.btnHuy3);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.txtmkmm);
            this.Controls.Add(this.txtmkm);
            this.Controls.Add(this.txtmkc);
            this.Controls.Add(this.txtTk);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Đổi Mật Khẩu";
            this.Load += new System.EventHandler(this.frmPass_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTk;
        private System.Windows.Forms.TextBox txtmkc;
        private System.Windows.Forms.TextBox txtmkm;
        private System.Windows.Forms.TextBox txtmkmm;
        private System.Windows.Forms.Button btnXacNhan;
        private System.Windows.Forms.Button btnHuy3;
    }
}