using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabajoCambioBilletes
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] ValuesArray = new int[] { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50 };
            //var entregado = [];
            dynamic division = 0;

            //resultado.innerHTML += e.cantidad + " billetes de $" + e.valor + "<br />";

            Console.WriteLine("Please Enter a money value: ");
            double moneyUserRequest ;

            while (!double.TryParse(Console.ReadLine(), out moneyUserRequest))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Please Enter a money value: ");
            }

            foreach (int moneyValue in ValuesArray)
            {
                if(moneyUserRequest > 0)
                {
                    division = Math.Floor(((moneyUserRequest / moneyValue))); 
                    
                    if(division > 0)
                    {
                        Console.WriteLine("Your Money amount of: $" + moneyValue + " is: " + division);
                    }

                    moneyUserRequest = moneyUserRequest - (moneyValue * division);
                }                
            }
            Console.ReadKey();
        }








    }
}
