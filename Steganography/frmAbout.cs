using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;

namespace Steganography
{
    public partial class frmAbout : Form
    {
        public frmAbout()
        {
            InitializeComponent();
        }

        PrivateFontCollection pfc = new PrivateFontCollection();
        FontFamily[] fontFamilies;

        private void frmAbout_Load(object sender, EventArgs e)
        {
            this.Icon = Steganography.Properties.Resources.icon;

            pfc.AddFontFile(AppDomain.CurrentDomain.BaseDirectory + "IRANSans.ttf");
            fontFamilies = pfc.Families;
            foreach (Control c in this.Controls)
            {
                c.Font = new Font(fontFamilies[0], c.Font.Size, FontStyle.Regular);
            }

        }
    }
}
