using System.IO;


namespace GFBattleSimulator.Util
{
    class FileUtil
    {
        public static string GetFile(string path)

        {
            if (File.Exists(path))
                return File.ReadAllText(path);
            return "";
        }
    }
}
