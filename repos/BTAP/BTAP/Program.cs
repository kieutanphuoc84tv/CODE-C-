using System;

class Program
{
    static void Main()
    {
        Console.Write("Nhap 1 so nguyen duong n: ");
        int n;

    
        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0)
        {
            Console.Write("Vui long nhap 1 so nguyen duong: ");
        }

  
        int sum = 0;
        for (int i = 1; i <= n; i++)
        {
            sum += i;
        }

        Console.WriteLine($"tong S = 1 + 2 + ... + {n} là: {sum}");
    }
}
