namespace CryptoAppForNS_PHK
{
    partial class MAIN
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_PlayFair = new System.Windows.Forms.Button();
            this.btn_Quit = new System.Windows.Forms.Button();
            this.btn_RSA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(234, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(453, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crypto App For Network Security";
            // 
            // btn_PlayFair
            // 
            this.btn_PlayFair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_PlayFair.Location = new System.Drawing.Point(152, 184);
            this.btn_PlayFair.Name = "btn_PlayFair";
            this.btn_PlayFair.Size = new System.Drawing.Size(198, 112);
            this.btn_PlayFair.TabIndex = 1;
            this.btn_PlayFair.Text = "PlayFair";
            this.btn_PlayFair.UseVisualStyleBackColor = true;
            this.btn_PlayFair.Click += new System.EventHandler(this.btn_PlayFair_Click);
            // 
            // btn_Quit
            // 
            this.btn_Quit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Quit.Location = new System.Drawing.Point(307, 379);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(299, 49);
            this.btn_Quit.TabIndex = 3;
            this.btn_Quit.Text = "Thoát";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // btn_RSA
            // 
            this.btn_RSA.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_RSA.Location = new System.Drawing.Point(570, 184);
            this.btn_RSA.Name = "btn_RSA";
            this.btn_RSA.Size = new System.Drawing.Size(198, 112);
            this.btn_RSA.TabIndex = 2;
            this.btn_RSA.Text = "RSA";
            this.btn_RSA.UseVisualStyleBackColor = true;
            this.btn_RSA.Click += new System.EventHandler(this.btn_RSA_Click);
            // 
            // MAIN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(942, 507);
            this.Controls.Add(this.btn_Quit);
            this.Controls.Add(this.btn_RSA);
            this.Controls.Add(this.btn_PlayFair);
            this.Controls.Add(this.label1);
            this.Name = "MAIN";
            this.Text = "MAIN";
            this.Load += new System.EventHandler(this.MAIN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_PlayFair;
        private System.Windows.Forms.Button btn_RSA;
        private System.Windows.Forms.Button btn_Quit;
    }
}

