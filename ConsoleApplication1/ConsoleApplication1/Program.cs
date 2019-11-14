using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var db = new OOPCSEntities();
            var expenditures = db.Expenditures.ToArray();

            int sum = 0;

            foreach (var expenditure in expenditures)
            {
                sum = sum + expenditure.Price;
            }

            // same ideal, diffrent way to code

           // for (int i = 0; i < expenditures.Length; i++)
          //  {
          //      sum = sum + expenditures[i].Price; 
          //  }

            Console.WriteLine("So tien da su dung = " + sum);
        }
    }
}
