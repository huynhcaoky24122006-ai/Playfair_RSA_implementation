namespace CryptoAppForNS_PHK
{
    partial class RSA
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.btn_BackMain = new System.Windows.Forms.Button();
            this.grpKeyGen = new System.Windows.Forms.GroupBox();
            this.btnAutoKey = new System.Windows.Forms.Button();
            this.txt_e = new System.Windows.Forms.TextBox();
            this.txt_q = new System.Windows.Forms.TextBox();
            this.txt_p = new System.Windows.Forms.TextBox();
            this.lbl_e = new System.Windows.Forms.Label();
            this.lbl_q = new System.Windows.Forms.Label();
            this.lbl_p = new System.Windows.Forms.Label();
            this.grpDisplayKey = new System.Windows.Forms.GroupBox();
            this.txt_d = new System.Windows.Forms.TextBox();
            this.txt_n = new System.Windows.Forms.TextBox();
            this.lbl_d = new System.Windows.Forms.Label();
            this.lbl_n = new System.Windows.Forms.Label();
            this.txtInputText = new System.Windows.Forms.TextBox();
            this.txtOutputText = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.lblInputText = new System.Windows.Forms.Label();
            this.lblOutputText = new System.Windows.Forms.Label();
            this.btn_Delete = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.grpKeyGen.SuspendLayout();
            this.grpDisplayKey.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(328, 9);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(76, 37);
            this.labelTitle.TabIndex = 1;
            this.labelTitle.Text = "RSA ";
            // 
            // btn_BackMain
            // 
            this.btn_BackMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackMain.Location = new System.Drawing.Point(25, 391);
            this.btn_BackMain.Name = "btn_BackMain";
            this.btn_BackMain.Size = new System.Drawing.Size(126, 46);
            this.btn_BackMain.TabIndex = 13;
            this.btn_BackMain.Text = " Quay lại";
            this.btn_BackMain.UseVisualStyleBackColor = true;
            this.btn_BackMain.Click += new System.EventHandler(this.btn_BackMain_Click);
            // 
            // grpKeyGen
            // 
            this.grpKeyGen.Controls.Add(this.btnAutoKey);
            this.grpKeyGen.Controls.Add(this.txt_e);
            this.grpKeyGen.Controls.Add(this.txt_q);
            this.grpKeyGen.Controls.Add(this.txt_p);
            this.grpKeyGen.Controls.Add(this.lbl_e);
            this.grpKeyGen.Controls.Add(this.lbl_q);
            this.grpKeyGen.Controls.Add(this.lbl_p);
            this.grpKeyGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpKeyGen.Location = new System.Drawing.Point(25, 67);
            this.grpKeyGen.Name = "grpKeyGen";
            this.grpKeyGen.Size = new System.Drawing.Size(320, 180);
            this.grpKeyGen.TabIndex = 14;
            this.grpKeyGen.TabStop = false;
            this.grpKeyGen.Text = "Quản lý khóa";
            // 
            // btnAutoKey
            // 
            this.btnAutoKey.Location = new System.Drawing.Point(87, 128);
            this.btnAutoKey.Name = "btnAutoKey";
            this.btnAutoKey.Size = new System.Drawing.Size(202, 32);
            this.btnAutoKey.TabIndex = 6;
            this.btnAutoKey.Text = "Tạo khóa tự động";
            this.btnAutoKey.UseVisualStyleBackColor = true;
            this.btnAutoKey.Click += new System.EventHandler(this.btnAutoKey_Click);
            // 
            // txt_e
            // 
            this.txt_e.Location = new System.Drawing.Point(100, 95);
            this.txt_e.Name = "txt_e";
            this.txt_e.Size = new System.Drawing.Size(180, 27);
            this.txt_e.TabIndex = 5;
            // 
            // txt_q
            // 
            this.txt_q.Location = new System.Drawing.Point(100, 65);
            this.txt_q.Name = "txt_q";
            this.txt_q.Size = new System.Drawing.Size(180, 27);
            this.txt_q.TabIndex = 4;
            // 
            // txt_p
            // 
            this.txt_p.Location = new System.Drawing.Point(100, 35);
            this.txt_p.Name = "txt_p";
            this.txt_p.Size = new System.Drawing.Size(180, 27);
            this.txt_p.TabIndex = 3;
            // 
            // lbl_e
            // 
            this.lbl_e.AutoSize = true;
            this.lbl_e.Location = new System.Drawing.Point(15, 98);
            this.lbl_e.Name = "lbl_e";
            this.lbl_e.Size = new System.Drawing.Size(76, 20);
            this.lbl_e.TabIndex = 2;
            this.lbl_e.Text = "Chỉ số e:";
            // 
            // lbl_q
            // 
            this.lbl_q.AutoSize = true;
            this.lbl_q.Location = new System.Drawing.Point(15, 68);
            this.lbl_q.Name = "lbl_q";
            this.lbl_q.Size = new System.Drawing.Size(67, 20);
            this.lbl_q.TabIndex = 1;
            this.lbl_q.Text = "Nhập q:";
            // 
            // lbl_p
            // 
            this.lbl_p.AutoSize = true;
            this.lbl_p.Location = new System.Drawing.Point(15, 38);
            this.lbl_p.Name = "lbl_p";
            this.lbl_p.Size = new System.Drawing.Size(67, 20);
            this.lbl_p.TabIndex = 0;
            this.lbl_p.Text = "Nhập p:";
            // 
            // grpDisplayKey
            // 
            this.grpDisplayKey.Controls.Add(this.txt_d);
            this.grpDisplayKey.Controls.Add(this.txt_n);
            this.grpDisplayKey.Controls.Add(this.lbl_d);
            this.grpDisplayKey.Controls.Add(this.lbl_n);
            this.grpDisplayKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpDisplayKey.Location = new System.Drawing.Point(25, 264);
            this.grpDisplayKey.Name = "grpDisplayKey";
            this.grpDisplayKey.Size = new System.Drawing.Size(320, 110);
            this.grpDisplayKey.TabIndex = 15;
            this.grpDisplayKey.TabStop = false;
            this.grpDisplayKey.Text = "Hiển thị khóa (n, d)";
            // 
            // txt_d
            // 
            this.txt_d.BackColor = System.Drawing.SystemColors.Window;
            this.txt_d.Location = new System.Drawing.Point(100, 65);
            this.txt_d.Name = "txt_d";
            this.txt_d.ReadOnly = true;
            this.txt_d.Size = new System.Drawing.Size(180, 27);
            this.txt_d.TabIndex = 5;
            // 
            // txt_n
            // 
            this.txt_n.BackColor = System.Drawing.SystemColors.Window;
            this.txt_n.Location = new System.Drawing.Point(100, 35);
            this.txt_n.Name = "txt_n";
            this.txt_n.ReadOnly = true;
            this.txt_n.Size = new System.Drawing.Size(180, 27);
            this.txt_n.TabIndex = 4;
            // 
            // lbl_d
            // 
            this.lbl_d.AutoSize = true;
            this.lbl_d.Location = new System.Drawing.Point(15, 68);
            this.lbl_d.Name = "lbl_d";
            this.lbl_d.Size = new System.Drawing.Size(66, 20);
            this.lbl_d.TabIndex = 2;
            this.lbl_d.Text = "Khóa d:";
            // 
            // lbl_n
            // 
            this.lbl_n.AutoSize = true;
            this.lbl_n.Location = new System.Drawing.Point(15, 38);
            this.lbl_n.Name = "lbl_n";
            this.lbl_n.Size = new System.Drawing.Size(66, 20);
            this.lbl_n.TabIndex = 0;
            this.lbl_n.Text = "Khóa n:";
            // 
            // txtInputText
            // 
            this.txtInputText.Location = new System.Drawing.Point(370, 90);
            this.txtInputText.Multiline = true;
            this.txtInputText.Name = "txtInputText";
            this.txtInputText.Size = new System.Drawing.Size(380, 120);
            this.txtInputText.TabIndex = 16;
            // 
            // txtOutputText
            // 
            this.txtOutputText.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutputText.Location = new System.Drawing.Point(370, 250);
            this.txtOutputText.Multiline = true;
            this.txtOutputText.Name = "txtOutputText";
            this.txtOutputText.ReadOnly = true;
            this.txtOutputText.Size = new System.Drawing.Size(380, 120);
            this.txtOutputText.TabIndex = 17;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(374, 384);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(169, 63);
            this.btnEncrypt.TabIndex = 18;
            this.btnEncrypt.Text = "Mã hóa (M^e mod n)";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(581, 384);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(169, 63);
            this.btnDecrypt.TabIndex = 19;
            this.btnDecrypt.Text = "Giải mã (C^d mod n)";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            // 
            // lblInputText
            // 
            this.lblInputText.AutoSize = true;
            this.lblInputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInputText.Location = new System.Drawing.Point(370, 67);
            this.lblInputText.Name = "lblInputText";
            this.lblInputText.Size = new System.Drawing.Size(171, 20);
            this.lblInputText.TabIndex = 20;
            this.lblInputText.Text = "Văn bản gốc | mã hóa";
            // 
            // lblOutputText
            // 
            this.lblOutputText.AutoSize = true;
            this.lblOutputText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutputText.Location = new System.Drawing.Point(370, 227);
            this.lblOutputText.Name = "lblOutputText";
            this.lblOutputText.Size = new System.Drawing.Size(171, 20);
            this.lblOutputText.TabIndex = 21;
            this.lblOutputText.Text = "Văn bản mã hóa | gốc";
            // 
            // btn_Delete
            // 
            this.btn_Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Delete.Location = new System.Drawing.Point(567, 23);
            this.btn_Delete.Name = "btn_Delete";
            this.btn_Delete.Size = new System.Drawing.Size(183, 46);
            this.btn_Delete.TabIndex = 22;
            this.btn_Delete.Text = "Xóa văn bản";
            this.btn_Delete.UseVisualStyleBackColor = true;
            this.btn_Delete.Click += new System.EventHandler(this.btn_Delete_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Refresh.Location = new System.Drawing.Point(176, 387);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(138, 50);
            this.btn_Refresh.TabIndex = 23;
            this.btn_Refresh.Text = "Làm mới khóa";
            this.btn_Refresh.UseVisualStyleBackColor = true;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 460);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Delete);
            this.Controls.Add(this.lblOutputText);
            this.Controls.Add(this.lblInputText);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtOutputText);
            this.Controls.Add(this.txtInputText);
            this.Controls.Add(this.grpDisplayKey);
            this.Controls.Add(this.grpKeyGen);
            this.Controls.Add(this.btn_BackMain);
            this.Controls.Add(this.labelTitle);
            this.Name = "RSA";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RSA Algorithm";
            this.grpKeyGen.ResumeLayout(false);
            this.grpKeyGen.PerformLayout();
            this.grpDisplayKey.ResumeLayout(false);
            this.grpDisplayKey.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button btn_BackMain;
        private System.Windows.Forms.GroupBox grpKeyGen;
        private System.Windows.Forms.Button btnAutoKey;
        private System.Windows.Forms.TextBox txt_e;
        private System.Windows.Forms.TextBox txt_q;
        private System.Windows.Forms.TextBox txt_p;
        private System.Windows.Forms.Label lbl_e;
        private System.Windows.Forms.Label lbl_q;
        private System.Windows.Forms.Label lbl_p;
        private System.Windows.Forms.GroupBox grpDisplayKey;
        private System.Windows.Forms.TextBox txt_d;
        private System.Windows.Forms.TextBox txt_n;
        private System.Windows.Forms.Label lbl_d;
        private System.Windows.Forms.Label lbl_n;
        private System.Windows.Forms.TextBox txtInputText;
        private System.Windows.Forms.TextBox txtOutputText;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Label lblInputText;
        private System.Windows.Forms.Label lblOutputText;
        private System.Windows.Forms.Button btn_Delete;
        private System.Windows.Forms.Button btn_Refresh;
    }
}