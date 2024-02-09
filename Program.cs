namespace Notas__Ver_files;

enum Operation { Soma, Subtracao, Multiplicacao, Divisao }
class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("Entre o tipo de operação a ser realizada:");
        Console.WriteLine("0 - Soma");
        Console.WriteLine("1 - Subtração");
        Console.WriteLine("2 - Multiplicação");
        Console.WriteLine("3 - Divisão");
        Operation op = (Operation)Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre o primeiro número:");
        long x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Entre o segundo número:");
        long y = Convert.ToInt32(Console.ReadLine());

        switch (op)
        {
            case Operation.Soma:
                Console.WriteLine("Resultado: " + (x + y));
                break;
            case Operation.Subtracao:
                Console.WriteLine("Resultado: " + (x - y));
                break;
            case Operation.Multiplicacao:
                Console.WriteLine("Resultado: " + (x * y));
                break;
            case Operation.Divisao:
                Console.WriteLine("Resultado: " + (x / y));
                break;
            default:
                Console.WriteLine("Operação inválida");
                break;
        }
        
        
    }
}
