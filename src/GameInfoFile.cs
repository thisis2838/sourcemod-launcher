using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sourcemod_launcher
{
    struct GameInfoKey
    {
        public string Name;
        public string Value;
        public GameInfoKey(string name, string value)
        {
            Name = name;
            Value = value;
        }
        public override string ToString()
        {
            return $"\t{Name}\t\t{Value}";
        }
    }
    class GameInfoFile
    {
        static private char[] _ignoreChars = new char[4] { ' ', '\t', '{', '}' };
        public string FilePath;
        public List<GameInfoKey> Keys;
        public GameInfoFile(string filePath)
        {
            Keys = new List<GameInfoKey>();

            if (!File.Exists(filePath))
                throw new Exception("Game Info does not exist!");

            FilePath = filePath;

            var gameInfo = File.OpenText(filePath);

            string line = "";
            while ((line = gameInfo.ReadLine()) != null)
            {
                GameInfoKey key = GetKey(line);

                if (key.Name == "searchpaths")
                    break;

                if (!string.IsNullOrEmpty(key.Name))
                    Keys.Add(key);
            }

            gameInfo.Close();
        }

        private GameInfoKey GetKey(string line)
        {
            line = "@" + line;

            string key = "";
            string value = "";
            bool k2v = false;
            bool notIgnore = false;

            for (int i = 1; i < line.Length; i++)
            {
                char b = i + 1 != line.Length ? line[i + 1] : '\0';
                char c = line[i];

                if (c == '"')
                    notIgnore = !notIgnore;

                if (!notIgnore && _ignoreChars.Contains(c))
                {
                    if (key != "")
                        k2v = true;
                    continue;
                }

                if (b == '/' && c == '/')
                    break;

                if (k2v)
                    value += c;
                else key += c;
            }

            key = key.ToLower().Trim('"');
            return new GameInfoKey(key, value);
        }

        public void WriteKeys(params GameInfoKey[] keys)
        {
            var gameInfo = File.OpenText(FilePath);

            string line = "";
            StringBuilder newGameInfo = new StringBuilder();
            bool hitLimit = false;
            while ((line = gameInfo.ReadLine()) != null)
            {
                GameInfoKey key = GetKey(line);

                if (key.Name == "searchpaths")
                    hitLimit = true;

                if (!hitLimit)
                    foreach (GameInfoKey writekey in keys)
                        if (key.Name == writekey.Name)
                        {
                            newGameInfo.AppendLine(writekey.ToString());
                            goto end;
                        }

                newGameInfo.AppendLine(line);

                end:
                ;
            }

            string origPath = Path.Combine(Directory.GetParent(FilePath).FullName, "gameinfo_original.txt");

            if (!File.Exists(origPath))
                File.Copy(FilePath, origPath);

            gameInfo.Close();
            File.WriteAllText(FilePath, newGameInfo.ToString());

        }

        public string GetValue(string key)
        {
            if (Keys.Any(x => x.Name == key))
                return Keys.Where(x => x.Name.ToLower() == key).First().Value;
            return "";
        }
    }
}
