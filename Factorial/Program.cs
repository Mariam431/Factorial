namespace Factorial
{
    internal class Program
    {
        static int Fact(int num)
        {
            if(num == 1 && num == 0)
            {
                return 1;
            }
            while(num > 1)
             return num * Fact(num - 1);
            return 1;
        }
        static void Main(string[] args)
        {

            Console.WriteLine(Fact(5));
        }
    }
}








