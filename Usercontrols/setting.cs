using System;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.IO;
using GFBattleSimulator.Util;
using System.Windows.Documents;

namespace GFBattleSimulator.Usercontrols
{
    public partial class setting : UserControl
    {
        public static UserControl uc;

        private bool proxyEdit = false;
        private bool enemyEdit = false;
        private JObject data;

        public setting()
        {
            InitializeComponent();
            uc = this;

            proxyIp.Text = Ip.GetLocalIP();
        }

        private void setting_SizeChanged(object sender, EventArgs e)
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

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://gf.hometehomete.com/ko/");
        }

        private void proxy_Click(object sender, EventArgs e)
        {
            if (proxyEdit)
            {
                try
                {
                    data["port"] = int.Parse(port.Text);
                }
                catch {
                    MessageBox.Show("잘못된 값을 입력하였습니다 숫자로만 입력해주세요.");
                }
                proxy.Text = "편집";
                port.Enabled = false;
                proxyEdit = false;
                File.WriteAllText("./GFBattleSimulator.json", data.ToString());
            }
            else {
                proxy.Text = "저장";
                port.Enabled = true;
                proxyEdit = true;
            }
        }

        private void enemy_Click(object sender, EventArgs e)
        {
            if (enemyEdit)
            {
                bool error = false;

                try
                {
                    data["battle"]["enemy_team_id"] = int.Parse(enemyId.Text);
                    data["battle"]["boss_hp"] = int.Parse(bossHp.Text);
                    error = false;
                }
                catch
                {
                    MessageBox.Show("잘못된 값을 입력하였습니다 숫자로만 입력해주세요.","GFBattleSimulator Alert");
                    error = true;
                }

                if (!error) {
                    File.WriteAllText("./GFBattleSimulator.json", data.ToString());
                    enemy.Text = "편집";
                    enemyId.Enabled = false;
                    bossHp.Enabled = false;
                    enemyEdit = false;
                }
            }
            else {
                enemy.Text = "저장";
                enemyId.Enabled = true;
                bossHp.Enabled = true;
                enemyEdit = true;
            }
        }

        private void setting_Load(object sender, EventArgs e)
        {
            data = JsonParse.JObjectRead("./GFBattleSimulator.Json");

            if (data != null)
            {
                port.Text = data["port"].ToString();
                enemyId.Text = data["battle"]["enemy_team_id"].ToString();
                bossHp.Text = data["battle"]["boss_hp"].ToString();

                if (data["battle"]["type"].Equals("Day"))
                {
                    radioButton1.Checked = true;
                    radioButton2.Checked = false;
                }
                else if (data["battle"]["type"].ToString().Equals("Night"))
                {
                    radioButton1.Checked = false;
                    radioButton2.Checked = true;
                }
                else
                {
                    radioButton2.Checked = true;
                    radioButton1.Checked = true;
                }
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) {
                data["battle"]["type"] = "Day";
                File.WriteAllText("./GFBattleSimulator.json", data.ToString());
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                data["battle"]["type"] = "Night";
                File.WriteAllText("./GFBattleSimulator.json", data.ToString());
            }
        }
    }

    /*public class JsonParse {
        private static JObject obj;
        public static JObject read(String dir) {
            try
            {
                obj = JObject.Parse(System.IO.File.ReadAllText(dir));
            }
            catch {
                MessageBox.Show("파일을 불러올 수 없습니다.","GFBattleSimulator Alert");
                obj = null;
            }

            return obj;
        }
    }*/

    public class Ip {
        public static string GetLocalIP()
        {
            string localIP = "Not available, please check your network seetings!";
            IPHostEntry host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    localIP = ip.ToString();
                    break;
                }
            }
            return localIP;
        }
    }
}
