using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using GFBattleSimulator.Util;
using System.Diagnostics;
using System.Drawing.Text;
using System.IO;

namespace GFBattleSimulator
{
    public partial class fairyContents : UserControl
    {
        private JObject data;
        private JObject setting;
        private JObject fairyData;

        private String[] fairySkill = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private string[] fairyTrait = 
            { 
            "살상계 I", 
            "살상계 II", 
            "정밀계 I", 
            "정밀계 II", 
            "회피계 I",
            "회피계 II",
            "장갑계 I",
            "장갑계 II",
            "필살계 I",
            "필살계 II",
            "선봉계",
            "돌격계",
            "조준계",
            "완강계",
            "진압계",
            "예민계",
            "격양계",
            "황금계",
            "급양계",
            "현란계",
            "연하계",
            "청량계",
            "길운계"
        };
        public static UserControl uc;
        public fairyContents()
        {
            InitializeComponent();
            uc = this;

            loadbtn.Text = "\ue8e5";
            filterbtn.Text = "\ue71c";

            skillLv.Items.AddRange(fairySkill);
            skillLv.SelectedIndex = 0;

            trait.Items.AddRange(fairyTrait);
            trait.SelectedIndex = 0;
        }

        private void UserControl4_SizeChanged(object sender, EventArgs e)
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

        private void fairyContents_Load(object sender, EventArgs e)
        {
            string id;
            string src;
            int skin;
            
            setting = JsonParse.JObjectRead("./GFBattleSimulator.json");
            data = JsonParse.JObjectRead("./Preset/fairy_with_user_info.json");
            fairyData = JsonUtil.get("fairy");

            toggle1.toggleState = bool.Parse(setting["battle"]["fairy_skill"].ToString());

            id = data["1"]["fairy_id"].ToString();

            switch (data["1"]["quality_lv"].ToString()) {
                case "1":
                case "2":
                    skin = 1;
                    break;
                case "3":
                case "4":
                    skin = 2;
                    break;
                case "5":
                    skin = 3;
                    break;
                default:
                    skin = 1;
                    break;
            }

            src = string.Format("./Resource/fairy_card/{0}_{1}.png", fairyData[id]["code"],data["1"]["quality_lv"]);
            Debug.WriteLine(src);

            fairy_tile.BackgroundImage = Image.FromFile(src);
            skillLv.SelectedItem = data["1"]["skill_lv"].ToString();
        }
    }
}
