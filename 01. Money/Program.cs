using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Money
{
    class Program
    {
        static void Main(string[] args)
        {
            var bitcoin = int.Parse(Console.ReadLine());
            var chines = double.Parse(Console.ReadLine());
            var comissions = double.Parse(Console.ReadLine());
            var sum = 0.0;
            var dolars = 0.15 * chines;
            
            
            bitcoin = bitcoin * 1168;
            chines = dolars * 1.76;
            comissions = (bitcoin + chines) * comissions/100;
            sum = bitcoin + chines - comissions;
            Console.WriteLine("Сумата на Иванчо е: {0}",sum/1.95);

        }
    }
}
