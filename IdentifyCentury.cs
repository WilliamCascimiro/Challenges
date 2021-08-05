using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges
{
    public class IdentifyCentury
    {
        public void Execute()
        {
            string year;
            int integer;

            do
            {
                Console.WriteLine("Inform The Year!");
                year = Console.ReadLine();
            } while (!Int32.TryParse(year, out integer));

            int century = (Convert.ToInt32(year) / 100);
            double increment = (Convert.ToDouble(year) % 100.0);

            if (increment > 0)
                century++;

            Console.WriteLine("Century" + century);
        }

    }
}
