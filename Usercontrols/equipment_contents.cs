using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFBattleSimulator
{
    public partial class equipContents : UserControl
    {
        public static UserControl uc;
        public equipContents()
        {
            InitializeComponent();
            uc = this;

            loadbtn.Text = "\ue8e5";
            filterbtn.Text = "\ue71c";
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void equipContents_SizeChanged(object sender, EventArgs e)
        {
            if (this.Size.Width <= 996)
            {
                sidepanel.Hide();
            }
            else if (this.Size.Width > 996 && this.Size.Width <= 1096)
            {
                sidepanel.Width = 200;
                sidepanel.Show();
            }
            else
            {
                sidepanel.Width = 300;
                sidepanel.Show();
            }
        }
    }
}
