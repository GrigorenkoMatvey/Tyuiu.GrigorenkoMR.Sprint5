using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task1.V24.Lib
{
    public class DataService : ISprint5Task1V24
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            FileInfo fileInfo = new FileInfo(path);
            if (fileInfo.Exists)
            {
                File.Delete(path);
            }

            double y;
            string strY;
            for (int x = startValue; x <= stopValue; x++)
            {
                double denominator = 4 * x - 0.5;
                if (denominator == 0)
                {
                    y = 0;
                }
                else
                {
                    y = (3 * Math.Cos(x)) / denominator + Math.Sin(x) - 5 * x - 2;
                }
                y = Math.Round(y, 2);
                strY = Convert.ToString(y);

                // Запись в файл (с переносом строки, кроме последнего элемента)
                if (x != stopValue)
                {
                    File.AppendAllText(path, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(path, strY);
                }
            }
            return path;
        }
    }
}