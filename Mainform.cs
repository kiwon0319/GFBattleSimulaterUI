using GFBattleSimulator.Properties;
using GFBattleSimulator.Usercontrols;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFBattleSimulator
{
    public partial class Main : Form
    {
        private int isMaximized = 0;
        private Size lastsize;
        private Point lastlocation;
        private Point last = new Point(0, 0);
        private Point mousePoint;
        private bool hidden = false;
        private bool resizing = false;

        private UserControl squadcontrol = new squadContents();
        private UserControl equipcontrol = new equipContents();
        private UserControl fiarycontrol = new fairyContents();
        private UserControl firesupportcontrol = new firesupportContents();
        private UserControl chipcontrol = new chipContents();
        private UserControl settingcontrol = new setting();

        public static Main mainForm;

        public Main()
        {
            InitializeComponent();
            mainForm = this;
            this.Size = new Size(980, 600);
            this.MinimumSize = new System.Drawing.Size(980, 600);
            this.ControlBox = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            lastlocation = this.Location;
            lastsize = this.Size;
            indicator.Location = squad_info.Location;

            closebtn.Text = "\ue8bb";
            normalbtn.Text = "\ue922";
            minimizebtn.Text = "\ue921";
            run.Text = "\ue768";

            UserControlShow(squadcontrol);

            this.SetStyle(ControlStyles.ResizeRedraw, true);

            settingIndicator.Hide();

            this.AutoScaleMode = AutoScaleMode.Dpi;

        }

        private void UserControlShow(UserControl _user) {
            contentPanel.Controls.Add(_user);
        }

        private void hideBtnText() {
            squad_info.Text = "";
            equip_info.Text = "";
            fairy_info.Text = "";
            firesupport_info.Text = "";
            chip_info.Text = "";
            Title.Text = "";
        }

        private void showBtnText()
        {
            squad_info.Text = "    제대 정보";
            equip_info.Text = "    장비 정보";
            fairy_info.Text = "    요정 정보";
            firesupport_info.Text = "    화력지원 소대 정보";
            chip_info.Text = "    칩 정보";
            Title.Text = "       GF Battle Simulator";
        }

        private void MaximizeWindow()
        {
            this.SuspendLayout();
            var rectangle = Screen.FromControl(this).Bounds;
            this.FormBorderStyle = FormBorderStyle.None;
            Size = new Size(rectangle.Width, rectangle.Height);
            Location = new Point(0, 0);
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            this.Size = new Size(workingRectangle.Width, workingRectangle.Height);
            this.ResumeLayout();
        }

        private void closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void minimizebtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void normalbtn_Click(object sender, EventArgs e)
        {
            if (isMaximized == 1)
            {
                isMaximized = 0;
                Location = lastlocation;
                this.Size = lastsize;
                normalbtn.Text = "\ue922";
            }
            else {
                isMaximized = 1;
                lastsize = new Size(this.Size.Width, this.Size.Height);
                lastlocation = this.Location;
                MaximizeWindow();
                normalbtn.Text = "\ue923";
            }
        }

        private void Main_SizeChanged(object sender, EventArgs e)
        {
            Rectangle workingRectangle = Screen.PrimaryScreen.WorkingArea;
            if (this.Size == new Size(workingRectangle.Width, workingRectangle.Height))
            {
                isMaximized = 1;
                normalbtn.Text = "\ue923";
            }
            else {
                isMaximized = 0;
                normalbtn.Text = "\ue922";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (hidden)
            {
                panelMenu.Width = 200;
                showBtnText();
                hidden = false;
            }
            else {
                panelMenu.Width = 65;
                hideBtnText();
                hidden = true;
            }
        }

        private void squad_info_Click(object sender, EventArgs e)
        {
            indicator.Show();
            settingIndicator.Hide();
            contentPanel.Controls.Clear();
            UserControlShow(squadcontrol);
            indicator.Location = squad_info.Location;
        }

        private void equip_info_Click(object sender, EventArgs e)
        {
            indicator.Show();
            settingIndicator.Hide();
            contentPanel.Controls.Clear();
            UserControlShow(equipcontrol);
            indicator.Location = equip_info.Location;
        }

        private void fairy_info_Click(object sender, EventArgs e)
        {
            indicator.Show();
            settingIndicator.Hide();
            contentPanel.Controls.Clear();
            UserControlShow(fiarycontrol);
            indicator.Location = fairy_info.Location;
        }

        private void firesupport_info_Click(object sender, EventArgs e)
        {
            indicator.Show();
            settingIndicator.Hide();
            contentPanel.Controls.Clear();
            contentPanel.Controls.Add(firesupportcontrol);
            indicator.Location = firesupport_info.Location;
        }

        private void chip_info_Click(object sender, EventArgs e)
        {
            indicator.Show();
            settingIndicator.Hide();
            contentPanel.Controls.Clear();
            UserControlShow(chipcontrol);
            indicator.Location = chip_info.Location;
        }

        private void settingbtn_click(object sender, EventArgs e) {
            contentPanel.Controls.Clear();
            UserControlShow(settingcontrol);
            indicator.Hide();
            settingIndicator.Show();
        }

        private void contentPanel_SizeChanged(object sender, EventArgs e)
        {
            this.SuspendLayout();
            squadContents.uc.Size = contentPanel.Size;
            equipContents.uc.Size = contentPanel.Size;
            fairyContents.uc.Size = contentPanel.Size;
            firesupportContents.uc.Size = contentPanel.Size;
            chipContents.uc.Size = contentPanel.Size;
            setting.uc.Size = contentPanel.Size;
            this.ResumeLayout();
        }

        private void header_DoubleClick(object sender, EventArgs e)
        {
            if (isMaximized == 1)
            {
                isMaximized = 0;
                Location = lastlocation;
                this.Size = lastsize;
                normalbtn.Text = "\ue922";
            }
            else
            {
                isMaximized = 1;
                lastsize = new Size(this.Size.Width, this.Size.Height);
                lastlocation = this.Location;
                MaximizeWindow();
                normalbtn.Text = "\ue923";
            }
        }

        private void header_MouseMove(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                Location = new Point(this.Left - (mousePoint.X - e.X),
                    this.Top - (mousePoint.Y - e.Y));

                if (isMaximized == 1) {
                    isMaximized = 0;
                    this.Size = lastsize;
                    normalbtn.Text = "\ue922";

                    Location = new Point( e.X, this.Top);
                    Debug.WriteLine(Location.ToString());
                }
            }
        }

        private void header_MouseDown(object sender, MouseEventArgs e)
        {
            mousePoint = new Point(e.X, e.Y);
        }

        private void Main_MouseDown(object sender, MouseEventArgs e)
        {
            this.resizing = true;
            this.last = e.Location;
        }

        private void Main_MouseUp(object sender, MouseEventArgs e)
        {
            this.resizing = false;
        }

        private void Main_MouseMove(object sender, MouseEventArgs e)
        {
            if (!resizing) // handle cursor type
            {
                bool resize_x = e.X > (this.Width - 8);
                bool resize_y = e.Y > (this.Height - 8);

                if (resize_x && resize_y)
                    this.Cursor = Cursors.SizeNWSE;
                else if (resize_x)
                    this.Cursor = Cursors.SizeWE;
                else if (resize_y)
                    this.Cursor = Cursors.SizeNS;
                else this.Cursor = Cursors.Default;
            }
            else // handle resize
            {
                int w = this.Size.Width;
                int h = this.Size.Height;

                if (this.Cursor.Equals(Cursors.SizeNWSE))
                    this.Size = new Size(w + (e.Location.X - this.last.X), h + (e.Location.Y - this.last.Y));
                else if (this.Cursor.Equals(Cursors.SizeWE))
                    this.Size = new Size(w + (e.Location.X - this.last.X), h);
                else if (this.Cursor.Equals(Cursors.SizeNS))
                    this.Size = new Size(w, h + (e.Location.Y - this.last.Y));

                this.last = e.Location;
            }
        }

        private void run_Click(object sender, EventArgs e)
        {
            try
            {
                string runfile = Application.StartupPath + "\\GFBattleSimulator.exe";
                Process.Start(runfile);
            }
            catch {
                MessageBox.Show("실행파일이 없습니다. 해당프로그램은 UI만 제공합니다.\n전투시뮬레이터 프로그램 디렉토리에 넣어주세요", "GFBattleSimulator Alert");
            }
            
        }
    }
}
