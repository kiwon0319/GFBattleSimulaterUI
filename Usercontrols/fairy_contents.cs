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
        private JObject fairy_trait;

        private string[] fairyQuality = {"1","2","3","4","5"};
        private String[] fairySkill = { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private string[] fairyTrait = 
            { 
            "살상계I", 
            "살상계II", 
            "정밀계I", 
            "정밀계II", 
            "회피계I",
            "회피계II",
            "장갑계I",
            "장갑계II",
            "필살계I",
            "필살계II",
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
            quality.Items.AddRange(fairyQuality);
            trait.Items.AddRange(fairyTrait);
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
            refresh();
        }

        public void refresh() {
            string id;
            string src;

            setting = JsonParse.JObjectRead("./GFBattleSimulator.json");
            data = JsonParse.JObjectRead("./Preset/fairy_with_user_info.json");
            fairyData = JsonUtil.get("fairy");
            fairy_trait = JsonUtil.get("fairy_trait");

            toggle1.toggleState = bool.Parse(setting["battle"]["fairy_skill"].ToString());

            id = data["1"]["fairy_id"].ToString();

            if (int.Parse(fairy_trait[data["1"]["passive_skill"].ToString()]["is_rare"].ToString()) == 1)
            {
                src = string.Format("./Resource/fairy_card/{0}_{1}_ext.png", fairyData[id]["code"], data["1"]["quality_lv"]);
            }
            else {
                src = string.Format("./Resource/fairy_card/{0}_{1}.png", fairyData[id]["code"], data["1"]["quality_lv"]);
            }

            fairy_tile.BackgroundImage = Image.FromFile(src);

            skillLv.SelectedItem = data["1"]["skill_lv"].ToString();
            trait.SelectedItem = fairy_trait[data["1"]["passive_skill"].ToString()]["name"].ToString();
            quality.SelectedItem = data["1"]["quality_lv"].ToString();
        }

        private void skillLv_SelectedIndexChanged(object sender, EventArgs e)
        {
            data["1"]["skill_lv"] = skillLv.SelectedItem.ToString();
            System.IO.File.WriteAllText("./Preset/fairy_with_user_info.json", data.ToString());
            refresh();
        }

        private void toggle1_ToggleChanged(object sender, EventArgs e)
        {
            setting["battle"]["fairy_skill"] = toggle1.toggleState;
            System.IO.File.WriteAllText("./GFBattleSimulator.json",setting.ToString());
        }
        
        private string trait2Id(string name) {
            string result = "error";

            foreach (var d in fairy_trait) {
                if (d.Value["name"].ToString() == name)
                    return d.Value["id"].ToString();
            }

            return result;
        }

        private void trait_SelectedIndexChanged(object sender, EventArgs e)
        {
            data["1"]["passive_skill"] = trait2Id(trait.SelectedItem.ToString());
            System.IO.File.WriteAllText("./Preset/fairy_with_user_info.json", data.ToString());
            refresh();
        }

        private void fairy_tile_Click(object sender, EventArgs e)
        {
            SelectFairy select = new SelectFairy(fairyData[data["1"]["fairy_id"].ToString()]["code"].ToString());
            select.ShowDialog();
            refresh();
        }
    }
}
