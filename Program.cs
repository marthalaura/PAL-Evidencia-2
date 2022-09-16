// Lopez Bouchspies Martha Laura
// Grupo 69 LTI
using System;

namespace Evidencia2
{
    class Program
    {
        static void Main(string[] args)
        {
            string opcion;
            bool principal = true;

            while (principal) {
                Console.Clear();
                Console.WriteLine("-------- MENU ---------");
                Console.WriteLine("[1] Division y residuo");
                Console.WriteLine("[2] Calcular area de una figura");
                Console.WriteLine("[3] Raiz de un valor");
                Console.WriteLine("[4] Serie Fibonacci");
                Console.WriteLine("[5] Calculadora de divisas");
                Console.WriteLine("[0] Salir");
                Console.WriteLine("-----------------------");
                Console.Write("Ingrese una opcion: ");
                opcion = Console.ReadLine();
                Console.Clear();
                switch(opcion)
                {
                case "1":
                    double numero1, numero2, resultado, residuo;

                    Console.Write("Ingrese el primer numero: ");
                    numero1 = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese el segundo numero: ");
                    numero2 = Convert.ToDouble(Console.ReadLine());
                    resultado = numero1 / numero2;
                    Console.WriteLine("El resultado de la division es: " + resultado);
                    residuo = numero1 % numero2;
                    Console.WriteLine("El residuo de la division es: " + residuo);

                    Console.WriteLine("\nPresione ENTER para volver al menu principal");
                    Console.ReadKey();
                    break;

                case "2":
                    bool caso2 = true;
                    while (caso2) {
                        Console.Clear();
                        Console.WriteLine("---- CALCULAR AREA DE UNA FIGURA ----");
                        Console.WriteLine("[1] Cuadrado");
                        Console.WriteLine("[2] Rectangulo");
                        Console.WriteLine("[3] Circulo");
                        Console.WriteLine("[4] Rombo");
                        Console.WriteLine("[0] Regresar al Menu Principal");
                        Console.WriteLine("-------------------------------------");
                        Console.Write("Ingrese una opcion: ");
                        opcion = Console.ReadLine();
                        Console.Clear();
                        switch(opcion)
                        {
                        case "1":
                            double area = 0, lado = 0;
                            Console.WriteLine("Area de un Cuadrado.");
                            Console.Write("Ingrese el lado del cuadrado: ");
                            lado = Convert.ToInt32(Console.ReadLine());
                            area = lado * lado;
                            Console.WriteLine("El area del cuadrado es: " + area);
                            break;

                        case "2":
                            double arearec = 0, br = 0, hr = 0;
                            Console.WriteLine("Area de un Rectangulo.");
                            Console.Write("Ingrese la base del rectangulo: ");
                            br = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Ingrese la altura del rectangulo: ");
                            hr = Convert.ToInt32(Console.ReadLine());
                            arearec = br * hr;
                            Console.WriteLine("El area del rectangulo es: " + arearec);
                            break;

                        case "3":
                            double r = 0, radio_cuadrado = 0, pi = 3.1416, area_circulo = 0;
                            Console.WriteLine("Area de un Circulo");
                            Console.Write("Ingrese el radio del circulo: ");
                            r = Convert.ToDouble(Console.ReadLine());
                            radio_cuadrado = r * r ;
                            area_circulo = pi * radio_cuadrado;
                            Console.WriteLine("El area del circulo es: " + area_circulo);
                            break;

                        case "4":
                            double dmayor = 0, dmenor = 0, diagonales = 0, area_rombo = 0;
                            Console.WriteLine("Area de un rombo");
                            Console.Write("Ingrese diagonal mayor: ");
                            dmayor = Convert.ToDouble(Console.ReadLine());
                            Console.Write("Ingrese diagonal menor: ");
                            dmenor = Convert.ToDouble(Console.ReadLine());
                            diagonales = dmayor * dmenor;
                            area_rombo = diagonales/2;
                            Console.WriteLine("El area del rombo es: " + area_rombo);
                            break;

                        case "0":
                            caso2 = false;
                            break;

                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                        }

                    if (opcion != "0") {
                        Console.WriteLine("\nPresione ENTER para regresar al menu");
                        Console.ReadKey();}
                    }
                    break;

                case "3":
                    double valor = 0, raiz = 0, resultado_raiz = 0;
                    Console.Write("Ingrese el valor del cual desea obtener la raiz: ");
                    valor = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Ingrese la raiz que desee obtener: ");
                    raiz = Convert.ToDouble(Console.ReadLine());
                    resultado_raiz = Math.Pow(valor, (1/raiz));
                    Console.WriteLine("El resultado de la raiz " + raiz + " del numero " + valor + " es: " + resultado_raiz);

                    Console.WriteLine("\nPresione ENTER para volver al menu principal");
                    Console.ReadKey();
                    break;

                case "4":
                    int a, b, limite, i, auxiliar;
                    Console.Write("Ingrese el numero de numeros de Fibonacci que desea mostrar: ");
                    limite = int.Parse(Console.ReadLine());
                    Console.WriteLine("--------------");
                    a = 0;
                    b = 1;
                    for (i = 0; i < limite; i++)
                    {
                        auxiliar = a;
                        Console.WriteLine(a);
                        a = b;
                        b = auxiliar + a;
                    }

                    Console.WriteLine("\nPresione ENTER para volver al menu principal");
                    Console.ReadKey();
                    break;

                case "5":
                double dinero = 0;
                string moneda = "";
                bool caso5 = true;
                while (caso5) {
                    Console.Clear();
                    Console.WriteLine("------ CALCULADORA DE DIVISAS ------");
                    Console.WriteLine("[1] Dolar USA");
                    Console.WriteLine("[2] Euro");
                    Console.WriteLine("[3] Libra Esterlina");
                    Console.WriteLine("[4] Yen");
                    Console.WriteLine("[0] Regresar al Menu Principal");
                    Console.WriteLine("------------------------------------");
                    Console.Write("Ingrese una opcion: ");
                    opcion = Console.ReadLine();
                    Console.Clear();
                    if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4") {
                        Console.Write("Cuánto dinero deseas convertir: ");
                        dinero = Convert.ToDouble(Console.ReadLine());
                    }
                    switch (opcion) {
                        case "1":
                            moneda = "Dolares USA";
                            dinero = dinero * 20.19;
                            break;
                        case "2":
                            moneda = "Euros";
                            dinero = dinero * 20.27;
                            break;
                        case "3":
                            moneda = "Libras Esterlinas";
                            dinero = dinero * 23.42;
                            break;
                        case "4":
                            moneda = "Yenes";
                            dinero = dinero * 0.14;
                            break;
                        case "0":
                            caso5 = false;
                            break;
                        default:
                            Console.WriteLine("Opcion invalida");
                            break;
                    }
                    if (opcion == "1" || opcion == "2" || opcion == "3" || opcion == "4") {
                        Console.WriteLine("Tu conversión de " + moneda + " a Pesos Mexicanos es de: $" + dinero);
                    }
                    if (opcion != "0") {
                        Console.WriteLine("\nPresione ENTER para regresar al menu");
                        Console.ReadKey();
                    }
                }
                break;

                case "0":
                    principal = false;
                    break;

                default:
                    Console.WriteLine("Opcion invalida");
                    Console.WriteLine("\nPresione ENTER para regresar al menu principal");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}