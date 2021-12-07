using System;
using Entidades;
using System.Collections.Generic;
namespace Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            Controlador controlador = new Controlador();
         

            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.AddMinutes(10));
            Console.WriteLine(DateTime.Now.AddHours(1));


             


        }
    }
}
