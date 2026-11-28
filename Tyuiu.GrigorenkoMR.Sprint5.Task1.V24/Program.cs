using Tyuiu.GrigorenkoMR.Sprint5.Task1.V24.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task1.V24
{
    class Program
    {
        static void Main(string[] args)
        {
            int startValue = -5;
            int stopValue = 5;

            DataService ds = new DataService();

            Console.Title = "Спринт #5 | Выполнил: Григоренко М. Р. | ИСПб - 26 - 1";
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #5                                                               *");
            Console.WriteLine("* Тема: Табулирование функции и файловые операции                         *");
            Console.WriteLine("* Задание #1                                                              *");
            Console.WriteLine("* Вариант #24                                                             *");
            Console.WriteLine("* Выполнил: Григоренко Матвей Романович | ИСПб - 26 - 1                   *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                *");
            Console.WriteLine("* Дана функция F(x) = 3cos(x)/(4x-0.5) + sin(x) - 5x - 2                  *");
            Console.WriteLine("* Произвести табулирование на [-5; 5] с шагом 1. Проверка на 0.           *");
            Console.WriteLine("* Результат сохранить в файл и вывести на консоль в таблицу.              *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
            Console.WriteLine("***************************************************************************");

            Console.WriteLine("Старт шага = " + startValue);
            Console.WriteLine("Конец шага = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(startValue, stopValue);
            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!\n");

            Console.WriteLine("Таблица значений:");
            Console.WriteLine("+-------+--------+");
            Console.WriteLine("|   X   |  F(x)  |");
            Console.WriteLine("+-------+--------+");

            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 4 * x - 0.5;
                double y = 0;
                if (denominator != 0)
                {
                    y = (3 * Math.Cos(x)) / denominator + Math.Sin(x) - 5 * x - 2;
                }
                y = Math.Round(y, 2);

                Console.WriteLine($"| {x,5} | {y,6} |");
            }
            Console.WriteLine("+-------+--------+");

            Console.ReadKey();
        }
    }
}