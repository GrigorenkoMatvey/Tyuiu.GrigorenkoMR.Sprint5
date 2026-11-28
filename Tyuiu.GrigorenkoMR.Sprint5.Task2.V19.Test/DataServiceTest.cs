using System.IO;
using Tyuiu.GrigorenkoMR.Sprint5.Task2.V19.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task2.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckedExistsFile()
        {
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask2.csv");

            int[,] mtrx = new int[3, 3] {
                { 9, 2, 5 },
                { 8, 8, 2 },
                { 7, 4, 8 }
            };

            DataService ds = new DataService();
            ds.SaveToFileTextData(mtrx);

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;

            Assert.AreEqual(wait, fileExists, "Файл не был создан по указанному пути!");
        }
    }
}