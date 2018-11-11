using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using DbLoader;
using System.Collections.Generic;
using System.IO;

namespace DbLoaderTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestOpeningDbFile()
        {
            DbLoader.DbLoader loader = new DbLoader.DbLoader(@"C:\Data\Programming\GitHub Repo's\DBEditor\MuseADTServerDbEditor\DbLoaderTest\db.bin");
            var data = loader.GetData();
            string value;
            data.TryGetValue("דוד", out value);
            Assert.AreEqual(value.ToLower(), "david");
        }
        [TestMethod]
        public void TestFileSave()
        {
            Dictionary<string, string> data = new Dictionary<string, string>();
            data.Add("test", "testv");
            DbLoader.DbLoader dbLoader = new DbLoader.DbLoader(@"c:\tmp\db.bin");
            if (File.Exists(@"c:\tmp\db.bin"))
            {
                File.Delete(@"c:\tmp\db.bin");
            }
            dbLoader.SaveData(data);
            var newData = dbLoader.GetData();
            string value;
            newData.TryGetValue("test", out value);
            Assert.AreEqual(value, "testv");
        }
    }
}
