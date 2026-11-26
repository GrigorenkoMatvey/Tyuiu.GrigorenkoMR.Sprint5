using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task0.V5.Lib
{
    public class DataService : ISprint5Task0V5
    {
        public string SaveToFileTextData(int x)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), "OutPutFileTask0.txt");
            double y = Math.Log((x + 1.0) / (x + 2.0));
            y = Math.Round(y, 3);
            File.WriteAllText(path, y.ToString());
            return path;
        }
    }
}