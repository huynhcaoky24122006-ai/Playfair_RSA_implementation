using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CryptoAppForNS_PHK
{
    public partial class MAIN : Form
    {
        public MAIN()
        {
            InitializeComponent();
        }
        
        private void MAIN_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_PlayFair_Click(object sender, EventArgs e)
        {
            PlayFair pf = new PlayFair();
            pf.Show();
        }

        private void btn_RSA_Click(object sender, EventArgs e)
        {
            RSA rsa = new RSA();
            rsa.Show();
        }

        private void btn_Quit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
