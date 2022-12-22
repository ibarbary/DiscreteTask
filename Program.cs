using System.Data.Common;

internal class Program
{
    private static void Main(string[] args)
    {
        //1)Program to find Prime Numbers from n1 to n2
        Console.Write("Enter n1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter n2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        bool prime = true;
        for (int i = n1; i <= n2; ++i)
        {
            for (int j = 2; j <= i/2; ++j)
            {
                if (i % j == 0)
                {
                    prime = false;
                    break;
                }
            }

            if (prime == true && i > 1)
                Console.WriteLine(i);
            else
                prime = true;
        }

        //2)Program to find Perfect Numbers from n1 to n2
        /*Console.Write("Enter n1: ");
        int n1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter n2: ");
        int n2 = Convert.ToInt32(Console.ReadLine());

        for (int i = n1; i <= n2; ++i)
        {
            int sum = 0;
            for (int j = 1; j <=i/2; ++j)
            {
                if (i % j == 0)
                {
                    sum = sum + j;
                }
            }

            if (sum == i && i > 0)
            Console.WriteLine(i);
        }*/
    }
}
