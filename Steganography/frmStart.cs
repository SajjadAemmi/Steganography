using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Steganography
{
    public partial class frmStart : Form
    {
        public frmStart()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form = new frmMain();
            form.Closed += (s, args) => this.Close();
            form.Show();
        }

        private void frmStart_Load(object sender, EventArgs e)
        {
            this.Icon = Steganography.Properties.Resources.icon;
        }
    }
}