using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdtSvrCmn.Interfaces;
using AdtSvrCmn.Objects;
using System.Runtime.Serialization.Formatters.Binary;

namespace DbLoader
{
    public class DbLoader : IDbConnector
    {
        public string Path { get; set; }

        public DbLoader(string dbFilePath)
        {
            Path = dbFilePath;
        }
        public Dictionary<string, string> GetData()
        {
            BinaryFormatter bf = new BinaryFormatter();
            Dictionary<string, string> data;
            using (var fs = File.Open(Path, FileMode.Open))
            {
                data = bf.Deserialize(fs) as Dictionary<string, string>;
            }
            return data;
        }

        public bool SaveData(Dictionary<string, string> data)
        {
            if (File.Exists(Path))
            {
                File.Delete(Path);
            }
            using (var fs = File.OpenWrite(Path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, data);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }

        public bool SaveData(Dictionary<string, string> data, string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }
            using (var fs = File.OpenWrite(path))
            {
                BinaryFormatter bf = new BinaryFormatter();
                try
                {
                    bf.Serialize(fs, data);
                }
                catch (Exception)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
