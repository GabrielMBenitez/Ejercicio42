using System;

namespace Ejercicio42
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Conversión de grados");

            Console.WriteLine("");

            Console.WriteLine("Los grados deben ser mayores a 15");
            Console.Write("Ingrese los grados en temperatura Celsius que quiera convertir: ");
            var grados = Convert.ToDouble(Console.ReadLine());

            if (grados >= 15)
            {
                Console.WriteLine("Selección de medidas.");
                Console.WriteLine("1 = Farenheit");
                Console.WriteLine("2 = Kelvin");
                Console.WriteLine("3 = Reamur");
                Console.WriteLine("4 = Rankine");
                Console.Write("Ingrese la medida a la cual quiere la conversión: ");
                var medida = Convert.ToInt16(Console.ReadLine());



                if (medida >= 1 || medida <= 4)
                {
                    if (medida == 1)
                    {
                        Console.WriteLine($"La temperatura en Farenheit es {funcionfaren(grados)}");
                    }
                    else
                    {
                        if (medida == 2)
                        {
                            Console.WriteLine($"La temperatura en Kelvin es {funcionkelvin(grados)}");
                        }
                        else
                        {
                            if (medida == 3)
                            {
                                Console.WriteLine($"La temperatura en Reaumur es {funcionreaumur(grados)}");
                            }
                            else
                            {
                                if (medida == 4)
                                {
                                    Console.WriteLine($"La temperatura en Rankine es {funcionrankine(grados)}");
                                }
                                else
                                {
                                    Console.Write("Formato mlal ingresado, fuera de las posibilidades");
                                }


                            }
                        }
                    }
                }
               
            }
            else
            {
                Console.Write("Grados mal ingresados.");
            }


            Console.ReadKey();

        }


        private static double funcionfaren(double grados)
        {
            grados = grados * 1.8 + 32;
            return grados;
        }
        private static double funcionkelvin(double grados)
        {
            grados = grados + 273.15;
            return grados;
        }
        private static double funcionreaumur(double grados)
        {
            grados = grados * 0.8;
            return grados;
        }
        private static double funcionrankine(double grados)
        {
            grados = grados * 1.8 + 491.67;
            return grados;
        }


    }
}
