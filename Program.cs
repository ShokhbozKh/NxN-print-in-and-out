namespace Array2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            Random rd = new Random();

            int[,] arr = new int[n,n];
             for (int i = 0; i < n; i++)
            {
                for (int j=0; j < n; j++)
                {
                    arr[i,j] = rd.Next(0,10);
                }
            }

             for(int i = 0; i < n; i++)
            {
                for(int j=0; j < n; j++)
                {
                    Console.Write(arr[i,j]  + " ");

                }
                Console.WriteLine();
                
            }
            Console.WriteLine("Matrissa tashqi ko'rinishi");

            for (int i=0; i < n; i++)
            {
                for(int j = 0; j < n; j++)
                {
                    if (i == 0 || (i==n-1))// usti va osti
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    else if ((j==n-1) || j==0) /// bosh va oxirgi ustun
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine("---- matrissa ichki ko'rinishi!");

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (!(i== 0 || (i == n - 1) || ((j == n - 1) || j == 0)))// usti va osti
                    {
                        Console.Write(arr[i, j] + " ");
                    }
                    //else if ((j == n - 1) || j == 0) /// bosh va oxirgi ustun
                    //{
                    //    Console.Write(arr[i, j] + " ");
                    //}
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}