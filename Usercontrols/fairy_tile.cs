using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFBattleSimulator.Usercontrols
{
    public partial class fairy_tile : UserControl
    {
        [Category("UserProperty"), Description("Level")]
        public string fairy_lv
        {
            get
            {
                return this.flv.Text;
            }
            set
            {
                this.flv.Text = value;
            }
        }

        public fairy_tile()
        {
            InitializeComponent();
        }
    }
}
