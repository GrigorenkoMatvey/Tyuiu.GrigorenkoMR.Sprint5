using System.IO;
using Tyuiu.GrigorenkoMR.Sprint5.Task0.V5.Lib;

namespace Tyuiu.GrigorenkoMR.Sprint5.Task0.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidSaveToFileTextData()
        {
            DataService ds = new DataService();
            int x = 3;

            string path = ds.SaveToFileTextData(x);
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            Assert.AreEqual(true, fileExists, "Файл не был создан!");
            string content = File.ReadAllText(path);

            string expected = "-0,223"; 
            Assert.AreEqual(expected, content, "Значение в файле не совпадает с ожидаемым.");
        }
    }
}