using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //Variables publicas
        public static int a;
        public static int b;
        public static double celsius;
        public static double fahrenheit;
        public static double resultado;

        //Función para calcular la suma de 2 números enteros
        static int Suma(int a, int b)
        {
            return a + b;
        }

        //Procedimiento que imprime la raíz cuadrada de los 10 primeros números
        static void Raiz()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("La raíz cuadrada de {0} es: {1}", i, Math.Sqrt(i));
            }
        }

        //Función para calcular la resta de 2 números enteros
        static int Resta(int a, int b)
        {
            return a - b;
        }

        //Función para calcular la multiplicacion de 2 números enteros
        static int Multiplicación(int a, int b)
        {
            return a * b;
        }

        //Función para calcular la division de 2 números enteros
        static int División(int a, int b)
        {
            return a / b;
        }

        //Función que imprime los 10 primeros números primos
        static void NumerosPrimos()
        {
            int contadorPrimo = 0;
            int contador;
            int numeroPrimo = 2;

            while (contadorPrimo < 10)
            {
                contador = 0;
                for (int i = 2; i <= numeroPrimo; i++)
                {
                    if (numeroPrimo % i == 0)
                    {
                        contador++;
                    }
                    if (contador >= 2)
                    {
                        break;
                    }
                }
                if (contador < 2)
                {
                    contadorPrimo++;
                    Console.WriteLine(numeroPrimo);
                }
                numeroPrimo++;

            }
        }

        //Función para convierte la temperatura en Fahrenheit a Celsius
        static double ConvertirFtoC(double f)
        {
           
            resultado = 5 * (f - 32) / 9;
            return resultado;
        }

        //Función para convierte la temperatura en Celsius a Fahrenheit 
        static double ConvertirCtoF(double c)
        {
            resultado = (9 * c / 5) + 32;
            return resultado;
        }

        static void Main(string[] args)
        {
            Console.Title = "Procedimientos y funciones";
            string opcion;
            do
            {
                Console.Clear();
                
                Console.WriteLine("[1] Suma de dos números");
                Console.WriteLine("[2] Imprimir la raíz cuadrada de los 10 primeros números enteros");
                Console.WriteLine("[3] Resta de dos números");
                Console.WriteLine("[4] Multiplicación de dos números");
                Console.WriteLine("[5] División de dos números");
                Console.WriteLine("[6] Imprimir los 10 primeros Números Primos");
                Console.WriteLine("[7] Convertir la temperatura en Fahrenheit a Celsius");
                Console.WriteLine("[8] Convertir la temperatura en Celsius a Fahrenheit");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("Ingrese una opción y presione ENTER");
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    
                    case "1":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La suma de {0} y {1} es {2}", a, b, Suma(a, b));
                        Console.ReadKey();
                        break;
                    case "2":
                        Console.WriteLine("Calculando...");
                        Raiz();
                        Console.ReadKey();
                        break;
                    case "3":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La resta de {0} y {1} es {2}", a, b, Resta(a, b));
                        Console.ReadKey();
                        break;
                    case "4":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La multiplicación de {0} y {1} es {2}", a, b, Multiplicación(a, b));
                        Console.ReadKey();
                        break;
                    case "5":
                        Console.WriteLine("Ingrese el primer número");
                        a = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Ingrese el segundo número");
                        b = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("La división de {0} y {1} es {2}", a, b, División(a, b));
                        Console.ReadKey();
                        break;
                    case "6":
                        Console.WriteLine("Calculando...");
                        NumerosPrimos();
                        Console.ReadKey();
                        break;
                    case "7":
                        Console.WriteLine("Ingrese la temperatura en Fahrenheit: ");
                        fahrenheit = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La temperatura en {0}°F en Celsius es {1}°C", fahrenheit, ConvertirFtoC(fahrenheit));
                        Console.ReadKey();
                        break;
                    case "8":
                        Console.WriteLine("Ingrese la temperatura en Celsius: ");
                        celsius = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("La temperatura en {0}°C en Fahrenheit es {1}°F", celsius, ConvertirCtoF(celsius));
                        Console.ReadKey();
                        break;
                }
            } while (!opcion.Equals("0"));
        Console.ReadKey();
        }
    }
}
