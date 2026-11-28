using System.IO;
using Tyuiu.GrigorenkoMR.Sprint5.Task1.V24.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task1.V24.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            int start = -5;
            int stop = 5;

            // Формируем ожидаемый путь так же, как в библиотеке
            string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask1.txt");

            DataService ds = new DataService();
            string res = ds.SaveToFileTextData(start, stop);

            // Проверяем, что метод вернул правильный путь
            Assert.AreEqual(path, res);

            // Проверяем, что файл физически существует
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            Assert.AreEqual(true, fileExists);
        }
    }
}