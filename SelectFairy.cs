using GFBattleSimulator.Calc;
using GFBattleSimulator.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GFBattleSimulator
{
    public partial class SelectFairy : Form
    {
        private JObject fairydata = JsonUtil.get("fairy");
        private JObject data;
        public SelectFairy(String codename)
        {
            InitializeComponent();

            data = JsonParse.JObjectRead("./Preset/fairy_with_user_info.json");

            if (fairydata == null) {
                DialogResult result = MessageBox.Show("fiary.json이 없습니다.", "GFBattleSimulator Alert", MessageBoxButtons.OK);
                if (result == DialogResult.OK)
                {
                    this.Close();
                }
            }

            try
            {
                curruntfiary.BackgroundImage = Image.FromFile("./Resource/fairy_card/" + codename + "_5_ext.png");
            }
            catch {
                curruntfiary.Hide();
            }

            foreach (var data in fairydata) {
                if (data.Value["code"].ToString() == codename)
                    continue;

                string name = string.Format("./Resource/fairy_card/{0}_5_ext.png", data.Value["code"].ToString());
                PictureBox picture = new PictureBox();

                try
                {
                    picture.BackgroundImage = Image.FromFile(name);
                }
                catch {
                    continue;
                }
                picture.BackgroundImageLayout = ImageLayout.Zoom;

                picture.MaximumSize = new Size(128, 206);
                picture.MinimumSize = new Size(128, 206);

                picture.Name = data.Value["code"].ToString();
                flowLayoutPanel1.Controls.Add(picture);

                picture.Click += imageClick;
            }
        }

        private void imageClick(object sender, EventArgs e) {
            PictureBox p = (PictureBox)sender;
            JObject obj = new JObject();

            data["1"] = FairyObject.get(p.Name);

            System.IO.File.WriteAllText("./Preset/fairy_with_user_info.json", data.ToString());
            this.Close();
        }

        private void SelectFairy_FormClosed(object sender, FormClosedEventArgs e)
        {
            GC.Collect();
        }
    }
}
