using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace MIni__conductor
{
    class Process
    {
        public Process()
        {
            interaction = new Interaction();
            catalog = new Catalog();
            currentPath = new StringBuilder();
        }
        Catalog catalog;
        Interaction interaction;
        StringBuilder currentPath;
        public void CommunicatinWitUser()
        {
            string currentPath2 = currentPath.ToString();
            interaction.ShowTextWrite("cd.. - движение вниз по каталогу,\n" +
                                      "cd: - движение вверх по каталогу,\n" +
                                      "dir - показать все файлы\n" +
                                      "Что бы закончить напишите end\n");
            interaction.ShowTextWrite("Введите команду:");
            string command = Console.ReadLine();
            while (command != "end")
            {
                if (command.Contains("cd.."))
                {
                    currentPath = catalog.GoDown(command, currentPath);
                }
                else if (command.Contains("cd:"))
                {
                    currentPath2 = catalog.GoUp(currentPath2);
                }
                else if (command.Contains("dir"))
                {
                    catalog.GetFiles(command);
                }
                currentPath2 = currentPath.ToString();
                interaction.ShowTextWrite($"{currentPath2}");
                command = Console.ReadLine();
            }

        }
    }
}