using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using lab10;

namespace FileService
{
    public class FileService<T> : IFileService<T> where T : class
    {
        public IEnumerable<T> ReadFile(string fileName)
        {
            string path = $@"C:\Users\engen\Desktop\dumpster\isp\labs\lab10\{fileName}";
            JsonSerializer serializer = new JsonSerializer();
            using (StreamReader fs = File.OpenText(path))
            {
                List<Employee> newList = (List<Employee>)serializer.Deserialize(fs, typeof(List<Employee>));
                Console.WriteLine($"Music of humanity was reborn\nMy congratulations!!!");
                return (IEnumerable<T>)newList;
            }
        }

        public void SaveData(IEnumerable<T> data, string fileName)
        {
            string path = $@"C:\Users\engen\Desktop\dumpster\isp\labs\lab10\{fileName}";
            JsonSerializer serializer = new JsonSerializer();
            using (StreamWriter fs = File.CreateText(path))
            {
                serializer.Serialize(fs, data);
                Console.WriteLine("Music of humans has been saved to file");
            }
        }
    }
}
