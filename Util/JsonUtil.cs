using System.Collections.Generic;
using System.Reflection;
using System.IO;
using Newtonsoft.Json.Linq;
using System.Windows;
using System;
using System.Diagnostics;
using System.Text;

namespace GFBattleSimulator.Util
{
    class JsonUtil
    {
        static Dictionary<string, JObject> jsonDb = new Dictionary<string, JObject>();

        public static JObject get(string db)
        {
            if (jsonDb.ContainsKey(db))
                return jsonDb[db];

            string dir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string file = string.Format("{0}/Resource/db/{1}.json", dir, db);
            if (File.Exists(file))
            {
                try
                {
                    string str = CompressUtil.Decompress(FileUtil.GetFile(file));
                    JObject json = JObject.Parse(str);
                    jsonDb.Add(db, json);
                    return jsonDb[db];
                }
                catch { }
            }
            return new JObject();
        }
    }

    public class JsonParse
    {
        public static JArray JArrayRead(String dir)
        {
            JArray arr;
            try
            {
                string buff = System.IO.File.ReadAllText(dir);
                arr = JArray.Parse(buff);
            }
            catch
            {
                MessageBox.Show("파일을 불러올 수 없습니다.", "GFBattleSimulator Alert");
                arr = null;
            }

            return arr;
        }

        public static JObject JObjectRead(String dir)
        {
            JObject obj;
            try
            {
                string buff = System.IO.File.ReadAllText(dir);
                obj = JObject.Parse(buff);
            }
            catch
            {
                MessageBox.Show("파일을 불러올 수 없습니다.", "GFBattleSimulator Alert");
                obj = null;
            }

            return obj;
        }
    }
}
