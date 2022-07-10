using System;

namespace modul4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //задание 1
            Console.WriteLine("задание 1");
            Console.Write("Введите количество строк в матрице: ");
            int row = int.Parse(Console.ReadLine());
            Console.Write("Введите количество столбцов в матрице: ");
            int column = int.Parse(Console.ReadLine());
            int[,] matrix = new int[row, column];
            int summ = 0;
            Random randomize = new Random();
            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    matrix[i, j] = randomize.Next(10);
                    Console.Write($"{matrix[i, j]} ");
                    summ += matrix[i, j];
                }
                Console.WriteLine();
            }
            Console.WriteLine($"Сумма всех элементов в матрице: {summ}");
            Console.ReadKey();

            //задание 2
            Console.WriteLine("\nзадание 2");
            Console.Write("Введите длину последовательности: ");
            int sequence = int.Parse(Console.ReadLine());
            int[] array = new int[sequence];
            int min = int.MinValue;
            for (int i = 0; i < sequence; i++)
            {
                Console.Write($"Введите {i + 1} число последовательности: ");
                array[i] = int.Parse(Console.ReadLine());

            }
            Console.Write("Получилась последовательность: ");
            foreach (int e in array)
            {
                Console.Write($"{e} ");
            }
            for (int i = 0; i < 1; i++)
            {
                if (array[0] <= int.MaxValue)
                {
                    min = array[0];
                }
                else
                {
                    Console.WriteLine("Значение больше максимального");
                }
            }
            for (int i = 0; i < sequence; i++)
            {
                if (array[i] <= min)
                {
                    min = array[i];
                }
                else
                {
                    continue;
                }
            }
            Console.WriteLine($"\nМинимальное число в последовательности: {min}");
            Console.ReadKey();

            //задание 3
            Console.WriteLine("\nзадание 3");
            Console.Write("Игра Угадай число\nВведите максимальное целое число диапазона: ");
            int max = int.Parse(Console.ReadLine());
            Random randomize1 = new Random();
            int randNumber = randomize1.Next(max);            
            Console.Write("Программа сгенерировала случайное число\nПопробуйте угадать это число: ");
            int tryNumber = int.Parse(Console.ReadLine());
            while (true)
            {
                if (tryNumber < randNumber)
                {
                    Console.Write("Введённое число меньше загаданного\nПопробуйте ещё раз: ");
                    string tryNumberString = Console.ReadLine();
                    if (tryNumberString == "")
                    {
                        Console.WriteLine("Спасибо за игру!");
                        Console.WriteLine($"Загаданное число было: {randNumber}");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        tryNumber = int.Parse(tryNumberString);
                    }
                }
                else if (tryNumber > randNumber)
                {
                    Console.Write("Введённое число больше загаданного\nПопробуйте ещё раз: ");
                    string tryNumberString = Console.ReadLine();
                    if (tryNumberString == "")
                    {
                        Console.WriteLine("Спасибо за игру!");
                        Console.WriteLine($"Загаданное число было: {randNumber}");
                        Console.ReadKey();
                        break;
                    }
                    else
                    {
                        tryNumber = int.Parse(tryNumberString);
                    }
                }
                else if (tryNumber == randNumber)
                {
                    Console.WriteLine("Поздравляем, Вы угадали!");
                    Console.ReadKey();
                    break;
                }
            }
        }
    }
}
