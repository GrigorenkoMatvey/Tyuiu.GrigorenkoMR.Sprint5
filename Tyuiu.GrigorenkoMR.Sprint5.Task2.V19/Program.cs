using Tyuiu.GrigorenkoMR.Sprint5.Task2.V19.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task2.V19
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Обработка двумерных массивов и файловые операции                  *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #19                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дан двумерный целочисленный массив 3 на 3 элементов, заполненный        *");
            Console.WriteLine("* значениями с клавиатуры. Заменить нечетные элементы массива на 0.       *");
            Console.WriteLine("* Результат сохранить в файл OutPutFileTask2.csv и вывести на консоль.    *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            int rows = 3;
            int columns = 3;
            int[,] mtrx = new int[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"Введите {i},{j} элемент массива: ");
                    mtrx[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine("\nИсходный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(mtrx);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");

            Console.WriteLine("\nМассив после замены нечетных элементов на 0:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write($"{mtrx[i, j]} \t");
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}