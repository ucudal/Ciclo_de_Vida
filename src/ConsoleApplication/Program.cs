//--------------------------------------------------------------------------------
// <copyright file="Program.cs" company="Universidad Católica del Uruguay">
//     Copyright (c) Programación II. Derechos reservados.
// </copyright>
//--------------------------------------------------------------------------------

using System;
using ClassLibrary;

namespace ConsoleApplication
{
    /// <summary>
    /// Programa de consola de demostración.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Punto de entrada al programa principal.
        /// </summary>
        public static void Main()
        {
            var train = new Train("123sd");
            train.StartEngines();
            Console.WriteLine("Hello World!");
            //for (int i=0;i<10000001;i++)
            //{
                //Train count = new Train("qaw");
                // Console.WriteLine(count);
                //El destructor comenzará a destruir objetos.
            //}
            Train t1= new Train ("Last Train To London");
            Train t2= new Train ("Last Train To London");
            Train t3=new Train ("Runaway Train");
            Console.WriteLine(t1==t3);
            Console.WriteLine(t2==t3);
            //Por mas que t1 y t2 tengan los mismos identificadores, son distintos objetos.

        }
    }
}