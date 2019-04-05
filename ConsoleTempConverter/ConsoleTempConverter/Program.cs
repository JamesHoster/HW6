using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTempConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = "";
            do
            {
                
                Console.WriteLine("What Temperature is it outside?");
                string temp = Console.ReadLine();
                
                if (temp == "Exit")
                {
                    continue;
                }
                Console.WriteLine("Would you like to convert that to Farenheight or Celcius? (F or C)");
                string type = Console.ReadLine();
                int ans = Int32.Parse(temp);

                if(type == "F")
                {
                    int far = (ans * 9 / 5) + 32; 
                    Console.WriteLine("It is " + far + "F");
                }
                if(type == "C")
                {
                    int cel = (ans - 32) * 5 / 9;
                    Console.WriteLine("It is " + cel + "C");
                }



            } while (input != "Exit");
        }
    }
}
