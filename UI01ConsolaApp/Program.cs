using BLLClassLibrary1;

public class Program
{

    static void Main(string[] args)
    {
        while (true)
        {
            mostrarmenu();
            int opcion;
            if (int.TryParse(Console.ReadLine(), out opcion) && opcion >= 1 && opcion <= 8)
            {
                if (opcion == 7 || opcion == 8)
                {
                    //para las opciones 7 y 8 (par o impar)  pedir solo un numero
                    realizarOperacion(opcion, true);
                }
                else
                {
                    try
                    {
                        realizarOperacion(opcion, false);
                    }
                    catch (ArgumentException ex)
                    {
                        Console.WriteLine($"Error: {ex.Message}");
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Error inseperado: {ex.Message}");
                    }

                }
            }
            else
            {
                Console.WriteLine("por favor, ingrese un numero valido (1-8).");

            }

            Console.WriteLine("presione enter para volver al menu o 'q' para salir.");
            string input = Console.ReadLine();
            if (input.ToLower() == "q")
            {
                break;
            }
        }

    }
    /// <summary>
    /// Mostrar el menu de las operaciones aritmeticas
    /// </summary>
    static void mostrarmenu()
    {
        Console.WriteLine("seleccione una operacion:");
        Console.WriteLine("1. suma");
        Console.WriteLine("2. resta");
        Console.WriteLine("3. multiplicacion");
        Console.WriteLine("4. division");
        Console.WriteLine("5. exponenciacion");
        Console.WriteLine("6. porcentaje");
        Console.WriteLine("7. verificar si es par");
        Console.WriteLine("8. verificar si es impar");
        Console.Write("ingrese el numero de la operacion: ");
    }

    static void realizarOperacion(int opcion, bool esparImpar)
    {
        double num1, num2, resultado;
        if (!esparImpar)
        {
            Console.Write("ingrese el primer numero:");
            if (double.TryParse(Console.ReadLine(), out num1))
            {
                Console.Write("ingrese el segundo numero numero:");
                if (double.TryParse(Console.ReadLine(), out num2))
                {
                    switch (opcion)
                    {
                        case 1:
                            resultado = OperacionesMatematicas.suma(num1, num2);
                            Console.WriteLine($"resultado: {resultado}");
                            break;
                        case 2:
                            resultado = OperacionesMatematicas.resta(num1, num2);
                            Console.WriteLine($"resultado: {resultado}");
                            break;
                        case 3:
                            resultado = OperacionesMatematicas.multiplicacion(num1, num2);
                            Console.WriteLine($"resultado: {resultado}");
                            break;
                        case 4:
                            resultado = OperacionesMatematicas.division(num1, num2);
                            Console.WriteLine($"resultado: {resultado}");
                            break;
                        case 5:
                            resultado = OperacionesMatematicas.Exponenciacion(num1, num2);
                            Console.WriteLine($"resultado: {resultado}");
                            break;
                        case 6:
                            resultado = OperacionesMatematicas.porcentaje(num1, num2);
                            Console.WriteLine($"resultado: {resultado}");
                            break;

                        default:
                            Console.WriteLine("opcion no valida.");
                            break;
                    }
                }
                else
                {
                    throw new ArgumentException("el segundo numero no es valido.");
                }
            }
            else
            {
                throw new ArgumentException("el primer numero no es valido.");
            }
        }
        else
        {
            Console.Write("ingrese el numero: ");
            if (double.TryParse(Console.ReadLine(), out num1))
            {
                switch (opcion)
                {
                    case 7:
                        Console.WriteLine($"¿es{num1} par? {OperacionesMatematicas.espar((int)num1)}");
                        break;

                    case 8:
                        Console.WriteLine($"¿es{num1} Impar? {OperacionesMatematicas.esimpar((int)num1)}");
                        break;

                    default:
                        Console.WriteLine("opcion no valida.");
                        break;
                }
            }
            else
            {
                throw new ArgumentException("el numero no es valido. ");
            }
        }
    }
}