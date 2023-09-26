
using System;
class Program
{
    static void Main()
    { 
        Console.WriteLine("Оберіть завдання:");
        Console.WriteLine("1. Розв'язання рівняння y = √(x - b) / (2 * b) - tg(x / b^2)");
        Console.WriteLine("2. Обчислення зворотньої величини для добутку чисел");
        Console.WriteLine("3. Обчислення f(m) за умовою");
        Console.Write("Введіть номер завдання: ");
        int choice = int.Parse(Console.ReadLine());

        switch (choice)
        {
            case 1:
                SolveEquationTask(); // Виклик методу для розв'язання рівняння
                break;
            case 2:
                CalculateInverseProductTask(); // Виклик методу для обчислення зворотньої величини
                break;
            case 3:
                CalculateFTask(); // Виклик методу для обчислення f(m)
                break;
            default:
                Console.WriteLine("Невірний номер завдання.");
                break;
        }
    }

    static void SolveSTask()
    {
        Console.WriteLine("Розв'язання рівняння y = √(x - b) / (2 * b) - tg(x / b^2)");
        Console.Write("Введіть значення b: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Введіть значення x: ");
        double x = double.Parse(Console.ReadLine());

        double y = CalculateY(x, b); // Обчислення результату рівняння

        Console.WriteLine($"Результат рівняння: y = {y}");
    }

    static double CalculateY(double x, double b)
    {
        return Math.Sqrt(x - b) / (2 * b) - Math.Tan(x / (b * b)); // Обчислення y за формулою
    }

    static void CalculateInverseProductTask()
    {
        Console.Write("Введіть натуральне число n: ");
        int n = int.Parse(Console.ReadLine());

        // Ініціалізуємо масив для зберігання чисел b1, b2, ..., bn
        double[] b = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Введіть b{i + 1}: ");
            b[i] = double.Parse(Console.ReadLine());
        }

        double result = CalculateInverseProduct(n, b); // Обчислення зворотньої величини

        Console.WriteLine($"Зворотня величина для добутку чисел, що задовольняють умову: {result}");
    }

    static double CalculateInverseProduct(int n, double[] b)
    {
        double product = 1.0; // Початкове значення добутку

        for (int k = 0; k < n; k++)
        {
            if (k + 1 < b[k] && b[k] < Factorial(k))
            {
                // Якщо умова виконується, додаємо обернену величину до добутку
                product /= b[k];
            }
        }

        return product; // Повертаємо результат
    }

    static double Factorial(int k)
    {
        // Рекурсивна функція для обчислення факторіала числа k
        if (k == 0)
        {
            return 1.0;
        }
        else
        {
            return k * Factorial(k - 1);
        }
    }

    static void CalculateFTask()
    {
        Console.Write("Введіть натуральне число a: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Введіть натуральне число c: ");
        int c = int.Parse(Console.ReadLine());

        Console.Write("Введіть натуральне число m: ");
        int m = int.Parse(Console.ReadLine());

        int result = CalculateF(m, a, c); // Обчислення f(m)

        Console.WriteLine($"f(m) = {result}");
    }

    static int CalculateF(int n, int a, int c)
    {
        if (n >= 0 && n <= 9)
        {
            return n;
        }
        else
        {
            int g_n = CalculateG(n - 1, a, c);
            return n - 1 - g_n + CalculateF(g_n, a, c);
        }
    }

    static int CalculateG(int n, int a, int c)
    {
        // Функція g(n) обчислюється як n = (a * n + c) % m
        return (a * n + c) % n;
    }
}
