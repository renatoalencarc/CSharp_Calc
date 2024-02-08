namespace Notas__Ver_files;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Entre o tipo de operação a ser realizada:");
        Console.WriteLine("1 - Soma");
        Console.WriteLine("2 - Subtração");
        Console.WriteLine("3 - Multiplicação");
        Console.WriteLine("4 - Divisão");
        long op = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre o primeiro número:");
        long x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre o segundo número:");
        long y = Convert.ToInt32(Console.ReadLine());

        switch (Convert.ToInt32(op) > 0)
        {
            case 1:
                Console.WriteLine("Resultado: " + Convert.ToInt32((x + y)));
                break;
            case 2:
                Console.WriteLine("Resultado: " + Convert.ToInt32((x - y)));
                break;
            case 3:
                Console.WriteLine("Resultado: " + Convert.ToInt32((x * y)));
                break;
            case 4:
                Console.WriteLine("Resultado: " + Convert.ToInt32((x / y)));
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }
        
        
    }
}
