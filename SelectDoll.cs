using GFBattleSimulator.Calc;
using GFBattleSimulator.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;

namespace GFBattleSimulator
{
    public partial class SelectDoll : Form
    {
        private JObject dolldata = JsonUtil.get("doll");
        private int order;
        private JArray data;

        public SelectDoll(string gun_id, int _order)
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;
            order = _order;
            data = JsonParse.JArrayRead("./Preset/gun_with_user_info.json");

            if (dolldata == null)
            {
                DialogResult result = MessageBox.Show("doll.json이 없습니다.", "GFBattleSimulator Alert", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

            try
            {
                curruntdoll.BackgroundImage = Image.FromFile("./Resource/doll_card/" + gun_id + ".png");
            }
            catch
            {
                
                curruntdoll.Hide();
            }
            
            foreach (var data in dolldata)
            {
                //Debug.WriteLine("--------------------");
                //Debug.WriteLine(data.Value["id"]);

                if (data.Value["id"].ToString() == gun_id)
                    continue;

                string name = string.Format("./Resource/doll_card/{0}.png", data.Value["id"].ToString());
                PictureBox picture = new PictureBox();
                try
                {
                    picture.BackgroundImage = Image.FromFile(name);
                }
                catch
                {
                    continue;
                }
                picture.BackgroundImageLayout = ImageLayout.Zoom;

                picture.MaximumSize = new Size(128, 206);
                picture.MinimumSize = new Size(128, 206);

                picture.Name = data.Value["id"].ToString();
                flowLayoutPanel1.Controls.Add(picture);

                picture.Click += imageclick;
            }
        }

        private void imageclick(object sender, EventArgs e)
        {
            PictureBox p = (PictureBox)sender;
            Debug.WriteLine(p.Name);
            JObject obj = new JObject();
            try
            {
                data[order] = GunObject.get(order, int.Parse(p.Name),100);
            }
            catch
            {
                data.Add(GunObject.get(order, int.Parse(p.Name), 100));
            }

            System.IO.File.WriteAllText("./Preset/gun_with_user_info.json", data.ToString());
            this.Close();
        }

        private void curruntdoll_Click(object sender, EventArgs e)
        {
            if (data[order]["location"].ToString() == "1")
            {
                MessageBox.Show("리더인형은 제외할 수 없습니다.", "GFBattlesimulator Alert");
            }
            else
            {
                data[order].Remove();
                System.IO.File.WriteAllText("./Preset/gun_with_user_info.json", data.ToString());
                this.Close();
            }
        }

        private void SelectDoll_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }

        private void SelectDoll_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
