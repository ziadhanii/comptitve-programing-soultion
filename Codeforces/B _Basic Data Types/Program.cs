namespace B__Basic_Data_Types
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split();

            int i = int.Parse(input[0]);
            long ll = long.Parse(input[1]);
            char ch = char.Parse(input[2]);
            float f = float.Parse(input[3]);
            double d = double.Parse(input[4]);

            Console.WriteLine(i);
            Console.WriteLine(ll);
            Console.WriteLine(ch);
            Console.WriteLine(f);
            Console.WriteLine(d);
        }
    }
}
