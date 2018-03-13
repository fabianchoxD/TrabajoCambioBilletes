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

            int[] caja = new int[] { 50000, 20000, 10000, 5000, 2000, 1000, 500, 200, 100, 50 };
            //var entregado = [];
            dynamic division = 0;
            int papeles = 0;
            dynamic entregado = new dynamic[] { };

            //resultado.innerHTML += e.cantidad + " billetes de $" + e.valor + "<br />";

            Console.WriteLine("Please Enter an money value: ");
            double moneyUserRequest ;

            while (!double.TryParse(Console.ReadLine(), out moneyUserRequest))
            {
                Console.WriteLine("Please Enter a valid numerical value!");
                Console.WriteLine("Please Enter an money value: ");
            }

            foreach (int name in caja)
            {
                if(moneyUserRequest > 0)
                {
                    division = Math.Floor(((moneyUserRequest / name)));

                    entregado.Add(division);       
                    
                    moneyUserRequest = moneyUserRequest - (name * papeles);

                }
                Console.WriteLine(name);
            }

            foreach (int e in entregado)
            {
              
              Console.WriteLine( e + " billetes");

              
            }



            Console.ReadKey();



        }








    }
}
