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
    public partial class Toggle : UserControl
    {
        //on / off 상태
        static bool toggled = false;

        [Description("Title"), Category("UserProperty")]
        public string Title {
            get {
                return this.title.Text;
            }
            set {
                this.title.Text = value;
            }
        }
        [Description("ShowTitle"), Category("UserProperty")]
        public bool ShowTitle {
            get {
                return this.title.Visible;
            }
            set {
                this.title.Visible = value;
            }
        }
        [Description("ToggleChanged"), Category("UserProperty")]
        public event EventHandler ToggleChanged;

        [Description("toggleState"), Category("UserProperty")]
        public bool toggleState {
            get {
                return toggled;
            }
            set {
                toggled = value;

                if (toggled)
                {
                    togglebtn.BackgroundImage = Properties.Resources._Elements___Toggle___On;
                    state.Text = "켜짐";
                }
                else {
                    togglebtn.BackgroundImage = Properties.Resources._Elements___Toggle___Off;
                    state.Text = "꺼짐";
                }
            }
        }

        public Toggle()
        {
            InitializeComponent();
        }

        private void clickarea_Click(object sender, EventArgs e)
        {
            if (toggled)
            {
                togglebtn.BackgroundImage = Properties.Resources._Elements___Toggle___Off;
                state.Text = "꺼짐";
                toggled = false;
            }
            else {
                togglebtn.BackgroundImage = Properties.Resources._Elements___Toggle___On;
                state.Text = "켜짐";
                toggled = true;
            }
            if(ToggleChanged != null)
                Invoke(ToggleChanged, null);
        }
    }
}
