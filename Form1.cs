using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Topic_9___Assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGood_Click(object sender, EventArgs e)
        {
            this.Text = "Happy!";
            this.BackgroundImage = Properties.Resources.whimsy;
            lblGood.Visible = true;
            lblBad.Visible = false;
        }

        private void btnBad_Click(object sender, EventArgs e)
        {
            this.Text = "MAD!";
            this.BackgroundImage = Properties.Resources.hell;
            lblBad.Visible = true;
            lblGood.Visible = false;
        }
    }
}
