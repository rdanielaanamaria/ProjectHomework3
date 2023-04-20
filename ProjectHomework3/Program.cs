using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectHomework3
{
    public class Program3
    {
        public static void Main(string[] args)
        {
            int OldIndex, NewIndex;
            Console.WriteLine("Enter the old index: ");
            OldIndex = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the new index: ");
            NewIndex = int.Parse(Console.ReadLine());

            Utilities Utilities1 = new Utilities();
            Console.WriteLine("The energy in kWh is: " + Utilities1.EnergyBill(OldIndex, NewIndex));
            Thread.Sleep(10000);

        }
    }
}