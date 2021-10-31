using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sourcemod_launcher.src
{
    class SettingsFile
    {
        public List<string> Entries;
        private string _filePath;
        public SettingsFile(string path)
        {
            Entries = new List<string>();
            if (!File.Exists(path))
            {
                File.Create(path);
                return;
            }

            _filePath = path;
            string line = "";
            var file = File.OpenText(path);
            while ((line = file.ReadLine()) != null)
                Entries.Add(line);
            file.Close();
        }

        public void AddEntry(string entry)
        {
            if (Entries.Contains(entry))
                return;
            Entries.Add(entry);
        }

        public void RemoveEntry(string entry)
        {
            if (!Entries.Contains(entry))
                return;
            Entries.Remove(entry);
        }

        public void WriteSettings()
        {
            if (!File.Exists(_filePath))
                return;

            StringBuilder builder = new StringBuilder();
            foreach (string entry in Entries.Distinct())
                builder.AppendLine(entry);

            File.WriteAllText(_filePath, builder.ToString());
        }

        private void Pad(int to)
        {
            if (Entries.Count <= to)
                for (int i = Entries.Count; i <= to; i++)
                    Entries.Add("");
        }

        public string Get(int index)
        {
            Pad(index);
            return Entries[index];
        }

        public void Set(int index, string input)
        {
            Pad(index);
            Entries[index] = input;
        }
    }
}
