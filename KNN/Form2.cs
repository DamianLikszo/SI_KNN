using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KNN
{
    public partial class Form2 : Form
    {
        private Form1 oMain;

        public Form2(Form1 Main, string sMacierz, string sLog)
        {
            this.oMain = Main;

            InitializeComponent();

            txtbLogi.Text = sLog;

            this.txtbMacierz.Text = sMacierz;

        }

        protected override void OnClosed(EventArgs e)
        {
            base.OnClosed(e);
            Application.Exit();
        }

        private void btnPowrot_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.oMain.Show();
        }

        private void btnWyjscie_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
