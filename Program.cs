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

        }
    }
}
