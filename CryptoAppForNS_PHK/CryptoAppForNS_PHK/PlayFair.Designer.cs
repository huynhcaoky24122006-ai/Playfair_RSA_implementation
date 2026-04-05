namespace CryptoAppForNS_PHK
{
    partial class PlayFair
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
            this.txtInput = new System.Windows.Forms.TextBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.btnEncrypt = new System.Windows.Forms.Button();
            this.btnDecrypt = new System.Windows.Forms.Button();
            this.btnGenerateMatrix = new System.Windows.Forms.Button();
            this.lblInput = new System.Windows.Forms.Label();
            this.lblKey = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.lblMatrix = new System.Windows.Forms.Label();
            this.panelMatrix = new System.Windows.Forms.Panel();
            this.btn_BackMain = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitle.Location = new System.Drawing.Point(308, 21);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(141, 37);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "PLAYFAIR";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(30, 100);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(350, 100);
            this.txtInput.TabIndex = 1;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(35, 237);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(255, 30);
            this.txtKey.TabIndex = 2;
            // 
            // txtOutput
            // 
            this.txtOutput.BackColor = System.Drawing.SystemColors.Info;
            this.txtOutput.Location = new System.Drawing.Point(400, 100);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ReadOnly = true;
            this.txtOutput.Size = new System.Drawing.Size(357, 100);
            this.txtOutput.TabIndex = 3;
            // 
            // btnEncrypt
            // 
            this.btnEncrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEncrypt.Location = new System.Drawing.Point(412, 347);
            this.btnEncrypt.Name = "btnEncrypt";
            this.btnEncrypt.Size = new System.Drawing.Size(163, 52);
            this.btnEncrypt.TabIndex = 4;
            this.btnEncrypt.Text = "Mã hóa";
            this.btnEncrypt.UseVisualStyleBackColor = true;
            // 
            // btnDecrypt
            // 
            this.btnDecrypt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDecrypt.Location = new System.Drawing.Point(587, 347);
            this.btnDecrypt.Name = "btnDecrypt";
            this.btnDecrypt.Size = new System.Drawing.Size(163, 52);
            this.btnDecrypt.TabIndex = 5;
            this.btnDecrypt.Text = "Giải mã";
            this.btnDecrypt.UseVisualStyleBackColor = true;
            // 
            // btnGenerateMatrix
            // 
            this.btnGenerateMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateMatrix.Location = new System.Drawing.Point(296, 230);
            this.btnGenerateMatrix.Name = "btnGenerateMatrix";
            this.btnGenerateMatrix.Size = new System.Drawing.Size(141, 47);
            this.btnGenerateMatrix.TabIndex = 6;
            this.btnGenerateMatrix.Text = "Tạo ma trận";
            this.btnGenerateMatrix.UseVisualStyleBackColor = true;
            // 
            // lblInput
            // 
            this.lblInput.AutoSize = true;
            this.lblInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInput.Location = new System.Drawing.Point(31, 77);
            this.lblInput.Name = "lblInput";
            this.lblInput.Size = new System.Drawing.Size(102, 20);
            this.lblInput.TabIndex = 7;
            this.lblInput.Text = "Văn bản gốc";
            // 
            // lblKey
            // 
            this.lblKey.AutoSize = true;
            this.lblKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKey.Location = new System.Drawing.Point(31, 214);
            this.lblKey.Name = "lblKey";
            this.lblKey.Size = new System.Drawing.Size(113, 20);
            this.lblKey.TabIndex = 8;
            this.lblKey.Text = "Từ khóa (Key)";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOutput.Location = new System.Drawing.Point(396, 77);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(130, 20);
            this.lblOutput.TabIndex = 9;
            this.lblOutput.Text = "Văn bản mã hóa";
            // 
            // lblMatrix
            // 
            this.lblMatrix.AutoSize = true;
            this.lblMatrix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMatrix.Location = new System.Drawing.Point(25, 279);
            this.lblMatrix.Name = "lblMatrix";
            this.lblMatrix.Size = new System.Drawing.Size(163, 25);
            this.lblMatrix.TabIndex = 10;
            this.lblMatrix.Text = "Ma trận khóa 5x5";
            // 
            // panelMatrix
            // 
            this.panelMatrix.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMatrix.Location = new System.Drawing.Point(30, 307);
            this.panelMatrix.Name = "panelMatrix";
            this.panelMatrix.Size = new System.Drawing.Size(350, 200);
            this.panelMatrix.TabIndex = 11;
            // 
            // btn_BackMain
            // 
            this.btn_BackMain.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_BackMain.Location = new System.Drawing.Point(495, 435);
            this.btn_BackMain.Name = "btn_BackMain";
            this.btn_BackMain.Size = new System.Drawing.Size(174, 43);
            this.btn_BackMain.TabIndex = 12;
            this.btn_BackMain.Text = "Quay lại";
            this.btn_BackMain.UseVisualStyleBackColor = true;
            // 
            // PlayFair
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 530);
            this.Controls.Add(this.btn_BackMain);
            this.Controls.Add(this.panelMatrix);
            this.Controls.Add(this.lblMatrix);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblKey);
            this.Controls.Add(this.lblInput);
            this.Controls.Add(this.btnGenerateMatrix);
            this.Controls.Add(this.btnDecrypt);
            this.Controls.Add(this.btnEncrypt);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.labelTitle);
            this.Name = "PlayFair";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PlayFair Algorithm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Button btnEncrypt;
        private System.Windows.Forms.Button btnDecrypt;
        private System.Windows.Forms.Button btnGenerateMatrix;
        private System.Windows.Forms.Label lblInput;
        private System.Windows.Forms.Label lblKey;
        private System.Windows.Forms.Label lblOutput;
        private System.Windows.Forms.Label lblMatrix;
        private System.Windows.Forms.Panel panelMatrix;
        private System.Windows.Forms.Button btn_BackMain;
    }
}