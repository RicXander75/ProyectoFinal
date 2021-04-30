    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    namespace ProyectoFinal
    {
        class Program
        {
            static void Main(string[] args)
            {

                float pago, Interes, Capital, MPrestamo, TAnual, TMensual;
                int fila, Plazo, i;

                Console.Write("Monto prestamo: ");
                float.TryParse(Console.ReadLine(), out MPrestamo);
                Console.Write("Interes anual: ");
                float.TryParse(Console.ReadLine(), out TAnual);
                Console.Write("Plazo (Meses): ");
                int.TryParse(Console.ReadLine(), out Plazo);

                TMensual = (TAnual / 100) / 12;


                pago = TMensual + 1;
                pago = (float)Math.Pow(pago, Plazo);
                pago = pago - 1;
                pago = TMensual / pago;
                pago = TMensual + pago;
                pago = MPrestamo * pago;


                Console.WriteLine();
                fila = 1;
                Console.WriteLine();
                Console.WriteLine();
                Console.Write(" Numero de pago \t");
                Console.Write("Pago \t\t");
                Console.Write("Intereses Pagados \t\t");
                Console.Write("Capital Pagado \t\t");
                Console.Write("Monto del prestamo \t");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t0");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t{0}", MPrestamo);


                for (i = 1; i <= Plazo; i++)
                {

                    Console.Write("\t{0}\t\t", fila);

                    Console.Write("{0}\t", pago);

                    Interes = TMensual * MPrestamo;
                    Console.Write("{0}\t\t", Interes);

                    Capital = pago - Interes;
                    Console.Write("\t{0}\t", Capital);

                    MPrestamo = MPrestamo - Capital;
                    Console.Write("\t{0}\t", MPrestamo);

                    fila = fila + 1;
                    Console.WriteLine();

                }
                Console.ReadLine();
            }
        }
    }