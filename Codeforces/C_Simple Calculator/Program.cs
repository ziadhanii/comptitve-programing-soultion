namespace C_Simple_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int x = int.Parse(input[0]);
            long y = long.Parse(input[1]); 

            Console.WriteLine($"{x} + {y} = {x + y}");
            Console.WriteLine($"{x} * {y} = {x * y}");
            Console.WriteLine($"{x} - {y} = {x - y}");
        }
    }
}
