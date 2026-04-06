using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;

namespace CryptoAppForNS_PHK
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
            this.btn_BackMain.Click += new System.EventHandler(this.btn_BackMain_Click);
            this.btnAutoKey.Click += new System.EventHandler(this.btnAutoKey_Click);
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
        }
        private void btn_BackMain_Click(object sender, EventArgs e)
        {
            MAIN mainForm = (MAIN)Application.OpenForms["MAIN"];
            mainForm.Show();
            this.Close();
        }
        private BigInteger ExtendedEuclidean(BigInteger e, BigInteger phi)
        {
            BigInteger m0 = phi, t, q;
            BigInteger x0 = 0, x1 = 1;

            if (phi == 1) return 0;

            while (e > 1)
            {
                q = e / phi;
                t = phi;
                phi = e % phi; e = t;
                t = x0;
                x0 = x1 - q * x0;
                x1 = t;
            }

            if (x1 < 0) x1 += m0;
            return x1;
        }
        
        private void TinhToanKhoa()
        {
            try
            {
                BigInteger p = BigInteger.Parse(txt_p.Text);
                BigInteger q = BigInteger.Parse(txt_q.Text);
                BigInteger eVal = BigInteger.Parse(txt_e.Text);
                BigInteger n = p * q;
                BigInteger phi = (p - 1) * (q - 1);
                BigInteger d = ExtendedEuclidean(eVal, phi);

                txt_n.Text = n.ToString();
                txt_d.Text = d.ToString();
            }
            catch { 
                MessageBox.Show("Vui lòng nhập số hợp lệ!"); 
            }
        }
        private void btnAutoKey_Click(object sender, EventArgs e)
        {
            txt_p.Text = "61";
            txt_q.Text = "53";
            txt_e.Text = "17";
            TinhToanKhoa();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            TinhToanKhoa();
            try
            {
                BigInteger n = BigInteger.Parse(txt_n.Text);
                BigInteger ev = BigInteger.Parse(txt_e.Text);
                string plaintext = txtInputText.Text;
                List<string> cipherList = new List<string>();

                foreach (char c in plaintext)
                {
                    BigInteger m = (BigInteger)c;
                    BigInteger encryptedChar = BigInteger.ModPow(m, ev, n);
                    cipherList.Add(encryptedChar.ToString());
                }
                txtOutputText.Text = string.Join(" ", cipherList);
            }
            catch {
                MessageBox.Show("Lỗi mã hóa! Hãy đảm bảo đã tạo khóa."); 
            }
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            TinhToanKhoa();
            try
            {
                BigInteger n = BigInteger.Parse(txt_n.Text);
                BigInteger dv = BigInteger.Parse(txt_d.Text);
                string[] cipherArray = txtInputText.Text.Split(' ');
                string decryptedText = "";

                foreach (string s in cipherArray)
                {
                    if (string.IsNullOrWhiteSpace(s)) continue;
                    BigInteger c = BigInteger.Parse(s);
                    BigInteger decryptedChar = BigInteger.ModPow(c, dv, n);
                    decryptedText += (char)((int)decryptedChar);
                }
                txtOutputText.Text = decryptedText;
            }
            catch { MessageBox.Show("Lỗi giải mã! Kiểm tra lại bản mã đầu vào."); }
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            txtInputText.Text = string.Empty;
            txtOutputText.Text = string.Empty;
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            txt_p.Text = string.Empty;
            txt_q.Text = string.Empty;
            txt_e.Text = string.Empty;
            txt_n.Text = string.Empty;
            txt_d.Text = string.Empty;

        }
    }
}
