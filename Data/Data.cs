using GFBattleSimulator.Util;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GFBattleSimulator.Calc
{
    class Data
    {
        private static JArray data = JArray.Parse(System.IO.File.ReadAllText("./Preset/gun_with_user_info.json"));
        //진형버프 관련
        public static string readPos(string clientValue) 
        {
                switch (clientValue) {
                    case "7":
                        return "1";
                    case "8":
                        return "4";
                    case "9":
                        return "7";
                    case "12":
                        return "2";
                    case "13":
                        return "5";
                    case "14":
                        return "8";
                    case "17":
                        return "3";
                    case "18":
                        return "6";
                    case "19":
                        return "9";
                    default:
                        break;
                }
            return "0";
        }
        public static string writePos(string numpad) {
                switch (numpad)
                {
                    case "1":
                        return "7";
                    case "4":
                        return "8";
                    case "7":
                        return "9";
                    case "2":
                        return "12";
                    case "5":
                        return "13";
                    case "8":
                        return "14";
                    case "3":
                        return "17";
                    case "6":
                        return "18";
                    case "9":
                        return "19";
                    default:
                        break;
                }
            return "0";
        }
    }
    //스탯 Object 클래스
    public class GunObject {
        private static JObject gunObj = new JObject() {
            {"id", "0" },
            {"gun_id", "0"},
            {"gun_level","0"},
            {"gun_exp", "30283300"},
            {"team_id", "1"},
            {"if_modification","0"},
            {"location","0"},
            {"position","0"},
            {"life","0"},
            {"ammo","5"},
            {"mre","10"},
            {"pow","0"},
            {"hit","0"},
            {"dodge","0"},
            {"rate","0"},
            {"skill1","10"},
            {"skill2","10"},
            {"is_locked","1"},
            {"number","5"},
            {"equip1","0"},
            {"equip2","0"},
            {"equip3","0"},
            {"equip4","0"},
            {"skin","0"},
            {"favor","500000"},
            {"max_favor", "1000000"},
            {"favor_toplimit","2000000"},
            {"soul_bond","0"}
        };
        public static JObject get(int location, int num, int level, int favor = 100) {
            int[] stat = Stat.GetStat(num, level, favor);
            
            gunObj["id"] = (11 + location).ToString();
            gunObj["gun_id"] = num.ToString();
            gunObj["gun_level"] = level.ToString();
            gunObj["location"] = (location +1).ToString();
            gunObj["pow"] = stat[1].ToString();
            gunObj["hit"] = stat[2].ToString();
            gunObj["dodge"] = stat[3].ToString();
            gunObj["rate"] = stat[5].ToString();
            gunObj["favor"] = (favor * 10000).ToString();

            if (level >= 90)
            {
                gunObj["number"] = "5";
            }
            else if (level >= 70)
            {
                gunObj["number"] = "4";
            }
            else if (level >= 30)
            {
                gunObj["number"] = "3";
            }
            else if (level >= 10)
            {
                gunObj["number"] = "2";
            }
            else {
                gunObj["number"] = "1";
            }

            if(num >= 20000)
                gunObj["if_modification"] = level >= 115 ?  "3" : level >= 110 ? "2" : level >= 100 ? "1" : "0";

            gunObj["life"] = (stat[0] * int.Parse(gunObj["number"].ToString())).ToString();

            return gunObj;
        }
    }

    //인형스탯 클래스
    public class Stat {
        private static string[] attrList = new string[] { "hp", "pow", "hit", "dodge", "speed", "rate", "armor" };
        private static Dictionary<string, Dictionary<string, double>> dollAttrs = new Dictionary<string, Dictionary<string, double>>()
            {
                { "HG", new Dictionary<string, double>() {
                    { "hp", 0.6 },
                    { "pow", 0.6 },
                    { "rate", 0.8 },
                    { "speed", 1.5 },
                    { "hit", 1.2 },
                    { "dodge", 1.8 }
                } },
                { "SMG", new Dictionary<string, double>() {
                    { "hp", 1.6 },
                    { "pow", 0.6 },
                    { "rate", 1.2 },
                    { "speed", 1.2 },
                    { "hit", 0.3 },
                    { "dodge", 1.6 }
                } },
                { "RF", new Dictionary<string, double>() {
                    { "hp", 0.8 },
                    { "pow", 2.4 },
                    { "rate", 0.5 },
                    { "speed", 0.7 },
                    { "hit", 1.6 },
                    { "dodge", 0.8 }
                } },
                { "AR", new Dictionary<string, double>() {
                    { "hp", 1 },
                    { "pow", 1 },
                    { "rate", 1 },
                    { "speed", 1 },
                    { "hit", 1 },
                    { "dodge", 1 }
                } },
                { "MG", new Dictionary<string, double>() {
                    { "hp", 1.5 },
                    { "pow", 1.8 },
                    { "rate", 1.6 },
                    { "speed", 0.4 },
                    { "hit", 0.6 },
                    { "dodge", 0.6 }
                } },
                { "SG", new Dictionary<string, double>() {
                    { "hp", 2 },
                    { "pow", 0.7 },
                    { "rate", 0.4 },
                    { "speed", 0.6 },
                    { "hit", 0.3 },
                    { "dodge", 0.3 },
                    { "armor", 1 }
                } },
            };
        private static Dictionary<string, Dictionary<string, double[]>> dollGrows = new Dictionary<string, Dictionary<string, double[]>>()
            {
                { "Basic", new Dictionary<string, double[]>() {
                    { "armor", new double[] { 2, 0.161 } },
                    { "dodge", new double[] { 5 } },
                    { "hit", new double[] { 5 } },
                    { "hp", new double[] { 55, 0.555 } },
                    { "pow", new double[] { 16 } },
                    { "rate", new double[] { 45 } },
                    { "speed", new double[] { 10 } },
                }},
                { "Grow", new Dictionary<string, double[]>()
                {
                    { "dodge", new double[] { 0.303, 0 } },
                    { "hit", new double[] { 0.303, 0 } },
                    { "pow", new double[] { 0.242, 0 } },
                    { "rate", new double[] { 0.181, 0 } },
                }},
            };
        private static Dictionary<string, Dictionary<string, double[]>> dollGrowsAfter100 = new Dictionary<string, Dictionary<string, double[]>>()
            {
                { "Basic", new Dictionary<string, double[]>() {
                    { "armor", new double[] { 13.979, 0.04 } },
                    { "dodge", new double[] { 5 } },
                    { "hit", new double[] { 5 } },
                    { "hp", new double[] { 96.283, 0.138 } },
                    { "pow", new double[] { 16 } },
                    { "rate", new double[] { 45 } },
                    { "speed", new double[] { 10 } },
                }},
                { "Grow", new Dictionary<string, double[]>()
                {
                    { "dodge", new double[] { 0.075, 22.572 } },
                    { "hit", new double[] { 0.075, 22.572 } },
                    { "pow", new double[] { 0.06, 18.018 } },
                    { "rate", new double[] { 0.022, 15.741 } },
                }},
            };

        public static int[] GetStat(int no, int level, int favor = 50) {
            int[] result = new int[] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };

            try
            {
                JObject dolldata = JsonUtil.get("doll");
                dolldata = (JObject)dolldata[no.ToString()];
                Debug.WriteLine(dolldata.ToString());
                //장탄 수
                if (dolldata.ContainsKey("bullet"))
                    result[7] = int.Parse(dolldata["bullet"].ToString());
                //치명률
                if (dolldata.ContainsKey("crit"))
                    result[8] = int.Parse(dolldata["crit"].ToString());

                Dictionary<string, double> dollStat = new Dictionary<string, double>();
                foreach (string attr in attrList) {
                    if (dolldata.ContainsKey(attr)) {
                        double stat = double.Parse(dolldata[attr].ToString());
                        if (stat > 0) {
                            dollStat.Add(attr, stat);
                        }
                    }
                }

                double grow = 0;
                if (dolldata.ContainsKey("grow"))
                    grow = double.Parse(dolldata["grow"].ToString());

                string type = dolldata["type"].ToString();
                Dictionary<string, double> dollAttr = dollAttrs[type];

                Dictionary<string, double[]> dollBasicStat = level > 100 ? dollGrowsAfter100["Basic"] : dollGrows["Basic"];
                Dictionary<string, double[]> dollGrowStat = level > 100 ? dollGrowsAfter100["Grow"] : dollGrows["Grow"];

                for (int i = 0; i < attrList.Length; i++) {
                    string key = attrList[i];

                    double realStat = 0;

                    double stat = 0;
                    if (dollStat.ContainsKey(key))
                        stat = dollStat[key];

                    double[] basicData;
                    if (dollBasicStat.ContainsKey(key))
                        basicData = dollBasicStat[key];
                    else
                        basicData = new double[] { 0 };

                    double attr = 0;
                    if (dollAttr.ContainsKey(key))
                        attr = dollAttr[key];

                    if (basicData.Length > 1)
                        realStat = Math.Ceiling((((basicData[0] + ((level - 1) * basicData[1])) * attr) * stat) / 100);
                    else
                        realStat = Math.Ceiling(((basicData[0] * attr) * stat) / 100);

                    if (dollGrowStat.ContainsKey(key))
                    {
                        double[] growData = dollGrowStat[key];
                        realStat += Math.Ceiling(((((growData[1] + ((level - 1) * growData[0])) * attr * stat) * grow) / 100) / 100);
                    }

                    if ("pow".Equals(key) || "hit".Equals(key) || "dodge".Equals(key))
                        realStat += Math.Sign(GetFavorBonusRatio(favor)) * Math.Ceiling(Math.Abs(realStat * GetFavorBonusRatio(favor)));

                    result[i] = Convert.ToInt32(realStat);
                }
            }
            catch { }
            Debug.WriteLine(result.ToString());
            return result;
        }

        public static double GetFavorBonusRatio(int favor)
        {
            if (favor < 10)
            {
                return -0.05;
            }
            else if (favor < 90)
            {
                return 0;
            }
            else if (favor < 140)
            {
                return 0.05;
            }
            else if (favor < 190)
            {
                return 0.1;
            }
            return 0.15;
        }
    }

}
