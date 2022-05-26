using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MIni__conductor
{
    class Catalog
    {
        public Catalog()
        {
            interaction = new Interaction();

        }
        Interaction interaction;
        public void GetFiles(string path)
        {
            if (Directory.Exists(path))
            {
                interaction.ShowTextWriteLine("Файлы:");
                string[] files = Directory.GetFileSystemEntries(path);
                foreach (string t in files)
                {
                    interaction.ShowTextWriteLine(t);
                }
            }
        }
        public string GoUp(string currentPath)///метод который поднимает вверх по каталогу
        {
            string ch = "\\";
            int lastIndex = currentPath.LastIndexOf(ch);
            currentPath.Remove(lastIndex, currentPath.Length);
            return currentPath;
        }
        public StringBuilder GoDown(string path, StringBuilder currentPath)
        {
            StringBuilder GoDown = new StringBuilder(path);
            GoDown.Remove(0, 4);
            var newPath = currentPath;
            if (path.Contains(":"))
            {
                if (Directory.Exists(path))
                {
                    newPath = currentPath.Replace(currentPath.ToString(), path);
                    return newPath;
                }
                else
                {
                    interaction.ShowTextWriteLine("Такой папки/диска/пути нет");
                    return currentPath;
                }
            }
            else
            {
                newPath = currentPath.AppendFormat(path);
                if (Directory.Exists(path))
                {
                    return newPath;
                }
                else
                {
                    interaction.ShowTextWriteLine("Такой папки/диска/пути нет");
                    return currentPath;
                }
            }
        }
    }
}
