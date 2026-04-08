using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CryptoAppForNS_PHK
{
    public partial class PlayFair : Form
    {
        private char[,] matrix = new char[5, 5];
        public PlayFair()
        {
            InitializeComponent();
            this.btnEncrypt.Click += new System.EventHandler(this.btnEncrypt_Click);
            this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
            this.btn_BackMain.Click += new System.EventHandler(this.btn_BackMain_Click);
            this.btnGenerateMatrix.Click += new System.EventHandler(this.btnGenerateMatrix_Click);

        }

        private void GenerateMatrix(string key)
        {
            string alphabet = "ABCDEFGHIKLMNOPQRSTUVWXYZ"; 
            key = key.ToUpper().Replace("J", "I");
            string combined = key + alphabet;

       
            string finalKey = "";
            foreach (char c in combined)
            {
                if (char.IsLetter(c) && !finalKey.Contains(c))
                    finalKey += c;
            }


            int k = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = finalKey[k++];
                }
            }
        }
        private void FindPosition(char c, ref int row, ref int col)
        {
            if (c == 'J') c = 'I';
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (matrix[i, j] == c)
                    {
                        row = i; col = j;
                        return;
                    }
                }
            }
        }
        private string PrepareText(string text, bool isDecrypt)
        {
            text = new string(text.ToUpper().Replace("J", "I").Where(char.IsLetter).ToArray());
            if (isDecrypt) return text;
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < text.Length; i++)
            {
                sb.Append(text[i]);
                if (i == text.Length - 1) break;
                if (text[i] == text[i + 1])
                {
                    sb.Append('X'); 
                }
                else
                {
                    sb.Append(text[i + 1]); 
                    i++; 
                }
            }
            if (sb.Length % 2 != 0) sb.Append('X');

            return sb.ToString();
        }
        private string Process(string text, int mode) 
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < text.Length; i += 2)
            {
                int r1 = 0, c1 = 0, r2 = 0, c2 = 0;
                FindPosition(text[i], ref r1, ref c1);
                FindPosition(text[i + 1], ref r2, ref c2);

                if (r1 == r2) 
                {
                    result.Append(matrix[r1, (c1 + mode + 5) % 5]);
                    result.Append(matrix[r2, (c2 + mode + 5) % 5]);
                }
                else if (c1 == c2) 
                {
                    result.Append(matrix[(r1 + mode + 5) % 5, c1]);
                    result.Append(matrix[(r2 + mode + 5) % 5, c2]);
                }
                else
                {
                    result.Append(matrix[r1, c2]);
                    result.Append(matrix[r2, c1]);
                }
            }
            return result.ToString();
        }
        private void btnEncrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text)) { MessageBox.Show("Nhập Key!"); return; }
            GenerateMatrix(txtKey.Text);
            string prepared = PrepareText(txtInput.Text, false);
            txtOutput.Text = Process(prepared, 1);
        }

        private void btnDecrypt_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text)) { MessageBox.Show("Nhập Key!"); return; }
            GenerateMatrix(txtKey.Text);
            string prepared = PrepareText(txtInput.Text, true);
            txtOutput.Text = Process(prepared, -1);
        }

        private void btn_BackMain_Click(object sender, EventArgs e)
        {
            MAIN mainForm = (MAIN)Application.OpenForms["MAIN"];
            mainForm.Show();
            this.Close();
        }

        private void btnGenerateMatrix_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtKey.Text))
            {
                MessageBox.Show("Vui lòng nhập Key!");
                return;
            }
            GenerateMatrix(txtKey.Text);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    sb.Append(matrix[i, j] + "\t");
                }
                sb.Append(Environment.NewLine); 
            }
            txtMatrixDisplay.Text = sb.ToString();
        }

        private void btn_DeleteMatrix_Click(object sender, EventArgs e)
        {
            txtKey.Text = String.Empty;
            txtMatrixDisplay.Text = String.Empty;
        }

        private void btn_DeleteText_Click(object sender, EventArgs e)
        {
            txtInput.Text = String.Empty;
            txtOutput.Text = String.Empty;
        }
    }
}
