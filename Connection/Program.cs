using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GGConnector;

namespace Connection {
    class Program {
        static void Main(string[] args) {
            var gg = new GG();

            var welcome = gg.Connect();

            while (!welcome.IsCompleted) {
                System.Threading.Thread.Sleep(1);
            }

            Console.WriteLine("GG say welcome!");
            Console.ReadLine();
        }
    }
}
