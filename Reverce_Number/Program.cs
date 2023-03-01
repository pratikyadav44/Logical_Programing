namespace Reverce_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the no : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;
            int result = 0;
            int rem;

            while (num != 0)
            {
                rem = num % 10;
                result = result*10 + rem;
                num = num / 10;
            }
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}