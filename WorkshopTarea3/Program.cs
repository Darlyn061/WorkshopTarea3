using System;
using System.Security.Policy;
using System.Threading;

namespace WorkshopTarea1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("=====>Menu<======");
            Console.WriteLine("1 == Numero decimal a binario");
            Console.WriteLine("2 == Numero decimal a octal");
            Console.WriteLine("=================================");

            int numero = int.Parse(Console.ReadLine());

            try
            {
                if (numero == 1)
                {
                    DeciABinario DB = new DeciABinario();
                    DB.iniciar();
                }
                else if (numero == 2)
                {
                    DeciAOctal DO = new DeciAOctal();
                    DO.Calculo2();
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

        }
    }
}