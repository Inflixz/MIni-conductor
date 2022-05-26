using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MIni__conductor
{
    class Program
    {
        static void Main(string[] args)
        {
            Process process = new Process();
            Catalog catalog = new Catalog();
            Interaction interaction = new Interaction();
            process.CommunicatinWitUser();
        }
    }
}