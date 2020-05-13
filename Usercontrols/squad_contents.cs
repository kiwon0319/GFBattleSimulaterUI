using GFBattleSimulator.Util;
using Newtonsoft.Json.Linq;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using GFBattleSimulator.Util;
using GFBattleSimulator.Calc;
using System.Diagnostics;

namespace GFBattleSimulator
{
    public partial class squadContents : UserControl
    {
        private JArray data;
        private JObject dollData;
        public static UserControl uc;
        private bool editmode = false;
        private string[] skillLv = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" };
        private string[] poslist = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };
        private string[] modlist = { "0", "1", "2", "3" };
        public squadContents()
        {
            InitializeComponent();
            uc = this;

            savebtn.Text = "\ue70f";
            openbtn.Text = "\ue8e5";
            refreshbtn.Text = "\ue72c";

            //콤보박스 초기화
            doll0_skill1.Items.AddRange(skillLv);
            doll0_skill2.Items.AddRange(skillLv);
            doll0_mod.Items.AddRange(modlist);
            doll0_pos.Items.AddRange(poslist);
            doll1_skill1.Items.AddRange(skillLv);
            doll1_skill2.Items.AddRange(skillLv);
            doll1_mod.Items.AddRange(modlist);
            doll1_pos.Items.AddRange(poslist);
            doll2_skill1.Items.AddRange(skillLv);
            doll2_skill2.Items.AddRange(skillLv);
            doll2_mod.Items.AddRange(modlist);
            doll2_pos.Items.AddRange(poslist);
            doll3_skill1.Items.AddRange(skillLv);
            doll3_skill2.Items.AddRange(skillLv);
            doll3_mod.Items.AddRange(modlist);
            doll3_pos.Items.AddRange(poslist);
            doll4_skill1.Items.AddRange(skillLv);
            doll4_skill2.Items.AddRange(skillLv);
            doll4_mod.Items.AddRange(modlist);
            doll4_pos.Items.AddRange(poslist);

        }
        private void refresh()
        {
            data = JsonParse.JArrayRead("./Preset/gun_with_user_info.json");
            dollData = JsonUtil.get("doll");
            int len = data.Count;

            QuickSortUtil.sort(data, 0, data.Count - 1);

            for (int i = 0; i < data.Count; i++) {
                data[i]["location"] = (i+1).ToString();
                data[i]["id"] = (11 + i).ToString();
            }

            System.IO.File.WriteAllText("./Preset/gun_with_user_info.json", data.ToString());

            if (len == 5)
            {
                doll1_name.Show();
                doll1_stat.Show();
                doll2_name.Show();
                doll2_stat.Show();
                doll3_name.Show();
                doll3_stat.Show();
                doll4_name.Show();
                doll4_stat.Show();
            }
            else if (len == 4)
            {
                doll1_name.Show();
                doll1_stat.Show();
                doll2_name.Show();
                doll2_stat.Show();
                doll3_name.Show();
                doll3_stat.Show();
            }
            else if (len == 3)
            {
                doll1_name.Show();
                doll1_stat.Show();
                doll2_name.Show();
                doll2_stat.Show();
            }
            else if (len == 2)
            {
                doll1_name.Show();
                doll1_stat.Show();
            }

            if (data != null)
            {

                string name = "./Resource/doll_card/null.png";
                Image tmp = Image.FromFile(name);
                doll_0.BackgroundImage = tmp;
                doll_1.BackgroundImage = tmp;
                doll_2.BackgroundImage = tmp;
                doll_3.BackgroundImage = tmp;
                doll_4.BackgroundImage = tmp;

                try
                {
                    name = "./Resource/doll_card/" + data[0]["gun_id"].ToString() + ".png";
                    tmp = Image.FromFile(name);
                    doll_0.BackgroundImage = tmp;

                    name = "./Resource/doll_card/" + data[1]["gun_id"].ToString() + ".png";
                    tmp = Image.FromFile(name);
                    doll_1.BackgroundImage = tmp;

                    name = "./Resource/doll_card/" + data[2]["gun_id"].ToString() + ".png";
                    tmp = Image.FromFile(name);
                    doll_2.BackgroundImage = tmp;

                    name = "./Resource/doll_card/" + data[3]["gun_id"].ToString() + ".png";
                    tmp = Image.FromFile(name);
                    doll_3.BackgroundImage = tmp;


                    name = "./Resource/doll_card/" + data[4]["gun_id"].ToString() + ".png";
                    tmp = Image.FromFile(name);
                    doll_4.BackgroundImage = tmp;
                }
                catch 
                { 
                }

            }
            else
            {
                MessageBox.Show("파일이 없습니다.", "GFBattleSimulator Alert");
            }

            if (data != null || dollData != null)
            {
                try
                {
                    doll0_name.Text = dollData[data[0]["gun_id"].ToString()]["name"].ToString();
                    doll1_name.Text = dollData[data[1]["gun_id"].ToString()]["name"].ToString();
                    doll2_name.Text = dollData[data[2]["gun_id"].ToString()]["name"].ToString();
                    doll3_name.Text = dollData[data[3]["gun_id"].ToString()]["name"].ToString();
                    doll4_name.Text = dollData[data[4]["gun_id"].ToString()]["name"].ToString();
                }
                catch
                {

                }
            }

            try
            {
                //0번 인형
                doll0_level.Text = data[0]["gun_level"].ToString();
                doll0_life.Text = data[0]["life"].ToString();
                doll0_pow.Text = data[0]["pow"].ToString();
                doll0_hit.Text = data[0]["hit"].ToString();
                doll0_dodge.Text = data[0]["dodge"].ToString();
                doll0_rate.Text = data[0]["rate"].ToString();
                doll0_number.Text = data[0]["number"].ToString();
                refreshSkill(doll0_skill1, data[0]["skill1"].ToString());
                refreshSkill(doll0_skill2, data[0]["skill2"].ToString());
                doll0_mod.SelectedIndex = int.Parse(data[0]["if_modification"].ToString());
                doll0_favor.Text = (int.Parse(data[0]["favor"].ToString()) / 10000).ToString();
                doll0_pos.SelectedIndex = int.Parse(Data.readPos(data[0]["position"].ToString()));

                //1번 인형
                doll1_level.Text = data[1]["gun_level"].ToString();
                doll1_life.Text = data[1]["life"].ToString();
                doll1_pow.Text = data[1]["pow"].ToString();
                doll1_hit.Text = data[1]["hit"].ToString();
                doll1_dodge.Text = data[1]["dodge"].ToString();
                doll1_rate.Text = data[1]["rate"].ToString();
                doll1_number.Text = data[1]["number"].ToString();
                refreshSkill(doll1_skill1, data[1]["skill1"].ToString());
                refreshSkill(doll1_skill2, data[1]["skill2"].ToString());
                doll1_mod.SelectedIndex = int.Parse(data[1]["if_modification"].ToString());
                doll1_favor.Text = (int.Parse(data[1]["favor"].ToString()) / 10000).ToString();
                doll1_pos.SelectedIndex = int.Parse(Data.readPos(data[1]["position"].ToString()));

                //2번 인형
                doll2_level.Text = data[2]["gun_level"].ToString();
                doll2_life.Text = data[2]["life"].ToString();
                doll2_pow.Text = data[2]["pow"].ToString();
                doll2_hit.Text = data[2]["hit"].ToString();
                doll2_dodge.Text = data[2]["dodge"].ToString();
                doll2_rate.Text = data[2]["rate"].ToString();
                doll2_number.Text = data[2]["number"].ToString();
                refreshSkill(doll2_skill1, data[2]["skill1"].ToString());
                refreshSkill(doll2_skill2, data[2]["skill2"].ToString());
                doll2_mod.SelectedIndex = int.Parse(data[2]["if_modification"].ToString());
                doll2_favor.Text = (int.Parse(data[2]["favor"].ToString()) / 10000).ToString();
                doll2_pos.SelectedIndex = int.Parse(Data.readPos(data[2]["position"].ToString()));


                //3번 인형
                doll3_level.Text = data[3]["gun_level"].ToString();
                doll3_life.Text = data[3]["life"].ToString();
                doll3_pow.Text = data[3]["pow"].ToString();
                doll3_hit.Text = data[3]["hit"].ToString();
                doll3_dodge.Text = data[3]["dodge"].ToString();
                doll3_rate.Text = data[3]["rate"].ToString();
                doll3_number.Text = data[1]["number"].ToString();
                refreshSkill(doll3_skill1, data[3]["skill1"].ToString());
                refreshSkill(doll3_skill2, data[3]["skill2"].ToString());
                doll3_mod.SelectedIndex = int.Parse(data[3]["if_modification"].ToString());
                doll3_favor.Text = (int.Parse(data[3]["favor"].ToString()) / 10000).ToString();
                doll3_pos.SelectedIndex = int.Parse(Data.readPos(data[3]["position"].ToString()));

                //4번인형
                doll4_level.Text = data[4]["gun_level"].ToString();
                doll4_life.Text = data[4]["life"].ToString();
                doll4_pow.Text = data[4]["pow"].ToString();
                doll4_hit.Text = data[4]["hit"].ToString();
                doll4_dodge.Text = data[4]["dodge"].ToString();
                doll4_rate.Text = data[4]["rate"].ToString();
                doll4_number.Text = data[4]["number"].ToString();
                refreshSkill(doll4_skill1, data[4]["skill1"].ToString());
                refreshSkill(doll4_skill2, data[4]["skill2"].ToString());
                doll4_mod.SelectedIndex = int.Parse(data[4]["if_modification"].ToString());
                doll4_favor.Text = (int.Parse(data[4]["favor"].ToString()) / 10000).ToString();
                doll4_pos.SelectedIndex = int.Parse(Data.readPos(data[4]["position"].ToString()));
            }
            catch { }

        }

        private void refreshSkill(ComboBox c, string str)
        {
            switch (str)
            {
                case "0":
                    c.SelectedIndex = 0;
                    break;
                case "1":
                    c.SelectedIndex = 1;
                    break;
                case "2":
                    c.SelectedIndex = 2;
                    break;
                case "3":
                    c.SelectedIndex = 3;
                    break;
                case "4":
                    c.SelectedIndex = 4;
                    break;
                case "5":
                    c.SelectedIndex = 5;
                    break;
                case "6":
                    c.SelectedIndex = 6;
                    break;
                case "7":
                    c.SelectedIndex = 7;
                    break;
                case "8":
                    c.SelectedIndex = 8;
                    break;
                case "9":
                    c.SelectedIndex = 9;
                    break;
                case "10":
                    c.SelectedIndex = 10;
                    break;
            }
        }

        private void save()
        {
            int len = data.Count;

            try
            {
                //리더
                data[0]["gun_level"] = doll0_level.Text;
                data[0]["life"] = doll0_life.Text;
                data[0]["pow"] = doll0_pow.Text;
                data[0]["hit"] = doll0_hit.Text;
                data[0]["dodge"] = doll0_dodge.Text;
                data[0]["rate"] = doll0_rate.Text;
                data[0]["number"] = doll0_number.Text;
                data[0]["skill1"] = doll0_skill1.SelectedItem.ToString();
                data[0]["skill2"] = doll0_skill2.SelectedItem.ToString();
                data[0]["if_modification"] = doll0_mod.SelectedItem.ToString();
                data[0]["favor"] = (int.Parse(doll0_favor.Text) * 10000).ToString();
                data[0]["position"] = Data.writePos(doll0_pos.SelectedItem.ToString());

                data[1]["gun_level"] = doll1_level.Text;
                data[1]["life"] = doll1_life.Text;
                data[1]["pow"] = doll1_pow.Text;
                data[1]["hit"] = doll1_hit.Text;
                data[1]["dodge"] = doll1_dodge.Text;
                data[1]["rate"] = doll1_rate.Text;
                data[1]["number"] = doll1_number.Text;
                data[1]["skill1"] = doll1_skill1.SelectedItem.ToString();
                data[1]["skill2"] = doll1_skill2.SelectedItem.ToString();
                data[1]["if_modification"] = doll1_mod.SelectedItem.ToString();
                data[1]["favor"] = (int.Parse(doll1_favor.Text) * 10000).ToString();
                data[1]["position"] = Data.writePos(doll1_pos.SelectedItem.ToString());

                data[2]["gun_level"] = doll2_level.Text;
                data[2]["life"] = doll2_life.Text;
                data[2]["pow"] = doll2_pow.Text;
                data[2]["hit"] = doll2_hit.Text;
                data[2]["dodge"] = doll2_dodge.Text;
                data[2]["rate"] = doll2_rate.Text;
                data[2]["number"] = doll2_number.Text;
                data[2]["skill1"] = doll2_skill1.SelectedItem.ToString();
                data[2]["skill2"] = doll2_skill2.SelectedItem.ToString();
                data[2]["if_modification"] = doll2_mod.SelectedItem.ToString();
                data[2]["favor"] = (int.Parse(doll2_favor.Text) * 10000).ToString();
                data[2]["position"] = Data.writePos(doll2_pos.SelectedItem.ToString());

                data[3]["gun_level"] = doll3_level.Text;
                data[3]["life"] = doll3_life.Text;
                data[3]["pow"] = doll3_pow.Text;
                data[3]["hit"] = doll3_hit.Text;
                data[3]["dodge"] = doll3_dodge.Text;
                data[3]["rate"] = doll3_rate.Text;
                data[3]["number"] = doll3_number.Text;
                data[3]["skill1"] = doll3_skill1.SelectedItem.ToString();
                data[3]["skill2"] = doll3_skill2.SelectedItem.ToString();
                data[3]["if_modification"] = doll3_mod.SelectedItem.ToString();
                data[3]["favor"] = (int.Parse(doll3_favor.Text) * 10000).ToString();
                data[3]["position"] = Data.writePos(doll3_pos.SelectedItem.ToString());

                data[4]["gun_level"] = doll4_level.Text;
                data[4]["life"] = doll4_life.Text;
                data[4]["pow"] = doll4_pow.Text;
                data[4]["hit"] = doll4_hit.Text;
                data[4]["dodge"] = doll4_dodge.Text;
                data[4]["rate"] = doll4_rate.Text;
                data[4]["number"] = doll4_number.Text;
                data[4]["skill1"] = doll4_skill1.SelectedItem.ToString();
                data[4]["skill2"] = doll4_skill2.SelectedItem.ToString();
                data[4]["if_modification"] = doll4_mod.SelectedItem.ToString();
                data[4]["favor"] = (int.Parse(doll4_favor.Text) * 10000).ToString();
                data[4]["position"] = Data.writePos(doll4_pos.SelectedItem.ToString());
            } catch { }

            System.IO.File.WriteAllText("./Preset/gun_with_user_info.json", data.ToString());

            MessageBox.Show("저장되었습니다.", "저장완료!");
        }

        private void Enable(bool b)
        {
            doll0_mod.Enabled = b;
            doll1_mod.Enabled = b;
            doll2_mod.Enabled = b;
            doll3_mod.Enabled = b;
            doll4_mod.Enabled = b;

            doll0_level.Enabled = b;
            doll1_level.Enabled = b;
            doll2_level.Enabled = b;
            doll3_level.Enabled = b;
            doll4_level.Enabled = b;

            doll0_life.Enabled = b;
            doll1_life.Enabled = b;
            doll2_life.Enabled = b;
            doll3_life.Enabled = b;
            doll4_life.Enabled = b;

            doll0_pow.Enabled = b;
            doll1_pow.Enabled = b;
            doll2_pow.Enabled = b;
            doll3_pow.Enabled = b;
            doll4_pow.Enabled = b;

            doll0_hit.Enabled = b;
            doll1_hit.Enabled = b;
            doll2_hit.Enabled = b;
            doll3_hit.Enabled = b;
            doll4_hit.Enabled = b;

            doll0_dodge.Enabled = b;
            doll1_dodge.Enabled = b;
            doll2_dodge.Enabled = b;
            doll3_dodge.Enabled = b;
            doll4_dodge.Enabled = b;

            doll0_rate.Enabled = b;
            doll1_rate.Enabled = b;
            doll2_rate.Enabled = b;
            doll3_rate.Enabled = b;
            doll4_rate.Enabled = b;

            doll0_skill1.Enabled = b;
            doll1_skill1.Enabled = b;
            doll2_skill1.Enabled = b;
            doll3_skill1.Enabled = b;
            doll4_skill1.Enabled = b;

            doll0_skill2.Enabled = b;
            doll1_skill2.Enabled = b;
            doll2_skill2.Enabled = b;
            doll3_skill2.Enabled = b;
            doll4_skill2.Enabled = b;

            doll0_number.Enabled = b;
            doll1_number.Enabled = b;
            doll2_number.Enabled = b;
            doll3_number.Enabled = b;
            doll4_number.Enabled = b;

            doll0_favor.Enabled = b;
            doll1_favor.Enabled = b;
            doll2_favor.Enabled = b;
            doll3_favor.Enabled = b;
            doll4_favor.Enabled = b;

            doll0_pos.Enabled = b;
            doll1_pos.Enabled = b;
            doll2_pos.Enabled = b;
            doll3_pos.Enabled = b;
            doll4_pos.Enabled = b;
        }

        private void squadContents_SizeChanged(object sender, EventArgs e)
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

        private void squadContents_Load(object sender, EventArgs e)
        {
            refresh();
        }

        private void savebtn_MouseHover(object sender, EventArgs e)
        {
            if (editmode)
                tooltip.Show("저장", savebtn);
            else
                tooltip.Show("편집", savebtn);
        }

        private void savebtn_Click(object sender, EventArgs e)
        {
            if (editmode)
            {
                //편집모드 종료
                editmode = false;
                savebtn.Text = "\ue70f";
                Enable(false);
                save();
            }
            else
            {
                //편집모드 실행
                editmode = true;
                savebtn.Text = "\ue74e";
                Enable(true);
            }
        }

        private void refreshbtn_MouseHover(object sender, EventArgs e)
        {
            tooltip.Show("새로고침", refreshbtn);
            refresh();
        }

        private void doll_leader_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = data[0]["gun_id"].ToString();
            }
            catch {
                str = "-1";
            }

            SelectDoll select = new SelectDoll(str, 0);
            select.ShowDialog();
            refresh();

        }

        private void doll_1_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = data[1]["gun_id"].ToString();
            }
            catch
            {
                str = "-1";
            }

            SelectDoll select = new SelectDoll(str, 1);
            select.ShowDialog();
            refresh();
        }

        private void doll_2_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = data[2]["gun_id"].ToString();
            }
            catch
            {
                str = "-1";
            }

            SelectDoll select = new SelectDoll(str, 2);
            select.ShowDialog();
            refresh();
        }

        private void doll_3_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = data[3]["gun_id"].ToString();
            }
            catch
            {
                str = "-1";
            }

            SelectDoll select = new SelectDoll(str, 3);
            select.ShowDialog();
            refresh();
        }

        private void doll_4_Click(object sender, EventArgs e)
        {
            string str;
            try
            {
                str = data[4]["gun_id"].ToString();
            }
            catch
            {
                str = "-1";
            }

            SelectDoll select = new SelectDoll(str, 4);
            select.ShowDialog();
            refresh();
        }
    }
}
