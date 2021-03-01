using System;

namespace HomeworkLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Task 1. Enter 2 numbers:");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int result = 1;

            for (int i = 0; i < b; i++)
            {
                result *= a;
            }
            Console.WriteLine(result);

            Console.WriteLine("Task 2. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 1000; i++)
            {
                if (i % a == 0)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Task 3. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            result = 0;
            for (int i = 1; i <= a / 2; i++)
            {
                if (i * i < a)
                    result++;
            }
            Console.WriteLine(result);

            Console.WriteLine("Task 4. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            for (int i = a / 2; i > 0; i--)
            {
                if (a % i == 0)
                {
                    Console.WriteLine(i);
                    break;
                }
            }

            Console.WriteLine("Task 5. Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            result = 0;
            if (a > b)
            {
                int tmp = a;
                a = b;
                b = tmp;
            }
            for (int i = a; i < b; i++)
            {
                if (i % 7 == 0)
                {
                    result += i;
                }
            }
            Console.WriteLine(result);

            Console.WriteLine("Task 6. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            int fib1 = 1;
            int fib2 = 1;
            for (int i = 0; i < a; i++)
            {
                if (i == 0 || i == 1)
                {
                    Console.WriteLine("1");
                    continue;
                }
                Console.WriteLine(fib1+fib2);
                int temp = fib1;
                fib1 = fib2;
                fib2 += temp;
            }

            Console.WriteLine("Task 7. Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }
            Console.WriteLine(a + b);

            Console.WriteLine("Task 8. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            int l=1;
            int r=a;
            int n = 0;

            while (a != Math.Pow(n, 3))
            {
                if(n == (r + l) / 2) 
                    break;
                n = (r + l) / 2;
                if (Math.Pow(n, 3) > a)
                    r = n;
                else
                    l = n;
            }
            Console.WriteLine(n);

            Console.WriteLine("Task 9. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            result = 0;

            while (a != 0)
            {
                int tmp = a % 10;

                if (tmp % 2 != 0)
                    result++;
                a /= 10;
            }
            Console.WriteLine(result);

            Console.WriteLine("Task 10. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());
            result = 0;
            while (a != 0)
            {
                result *= 10;
                int tmp = a % 10;
                result += tmp;
                a /= 10;
            }
            Console.WriteLine(result);

            Console.WriteLine("Task 11. Enter 1 number:");
            a = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i < a; i++)
            {
                int temp = i;
                int even = 0;
                int odd = 0;
                while (temp != 0)
                {
                    int tmp = temp % 10;
                    if (tmp % 2 == 0)
                        even += tmp;
                    else
                        odd += tmp;
                    temp /= 10;
                }
                if(odd < even)
                    Console.WriteLine(i);
            }

            Console.WriteLine("Task 12. Enter 2 numbers:");
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());

            bool isEqual = false;
            while (a != 0)
            {
                int b1 = b;
                int temp = a % 10;
                while (b1 != 0)
                {
                    int tmp = b1 % 10;
                    if (temp == tmp)
                    {
                        isEqual = true;
                        break;
                    }

                    b1 /= 10;
                }
                if (isEqual)
                    break;
                a /= 10;
            }
            if(isEqual)
                Console.WriteLine("YES");
            else
                Console.WriteLine("NO");
        }
    }
}
