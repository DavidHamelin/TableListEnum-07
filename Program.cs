using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TabEx07
{
    class Program
    {
        enum week { Lundi, Mardi, Mercredi, Jeudi, Vendredi, Samedi, Dimanche }

        static void Main(string[] args)
        {
            foreach (string allTheWeek in Enum.GetNames(typeof(week)))
            {
                Console.WriteLine(allTheWeek);
            }
            Console.WriteLine(Environment.NewLine + Enum.GetName(typeof(week), 4));

            /* Différentes techniques
            
            Console.WriteLine(week.Lundi);
            Console.WriteLine(week.Mardi);
            Console.WriteLine(week.Mercredi);
            Console.WriteLine(week.Jeudi);
            Console.WriteLine(week.Vendredi);
            Console.WriteLine(week.Samedi);
            Console.WriteLine(week.Dimanche);

            Console.WriteLine((week)4);

            Console.WriteLine(Enum.GetName(typeof(week)).GetValue(4));*/
        }
    }
}
