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
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, btn_Quit.Width, btn_Quit.Height);
            btn_Quit.Region = new Region(gp);
            gp.AddEllipse(0, 0, btn_RSA.Width, btn_RSA.Height);
            btn_RSA.Region = new Region(gp);
            gp.AddEllipse(0, 0, btn_PlayFair.Width, btn_PlayFair.Height);
            btn_PlayFair.Region = new Region(gp);
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
