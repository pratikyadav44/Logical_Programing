namespace Prime_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the Number :");
            int n = Convert.ToInt32(Console.ReadLine());
            int num = n;

            int count = 0;
            for (int i = 1; i <= num; i++)  
            {
                if(num%i==0) 
                {
                    count++;
                }

            }
            if(count == 2) 
            {
                Console.WriteLine("Given number is Prime Number");
            }
            else 
            {
                Console.WriteLine("Given nuber is not a Prime");
            }
            Console.ReadLine();
        }
    }
}