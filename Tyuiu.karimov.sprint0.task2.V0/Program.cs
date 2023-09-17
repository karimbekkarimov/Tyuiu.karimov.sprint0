using System;
using System.Collections.Generic;
using System.Data.Services;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.karimov.sprint0.task2.V0.Lib;

namespace Tyuiu.karimov.sprint0.task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Карим"));
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
