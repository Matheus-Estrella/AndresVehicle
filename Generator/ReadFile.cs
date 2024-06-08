using Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tools
{
    public class ReadFile
    {
        public static List<T> GetData<T>() where T : Generic, new()
        {
            T gen = new T();
            string path = gen.GetPath();
            string file = gen.GetFile();

            if (!File.Exists(path + file))
            {
                throw new FileNotFoundException($"O arquivo '{file}' não foi encontrado no diretório '{path}'.");
            }

            string jsonContent = File.ReadAllText(path + file);

            List<T> lista = JsonConvert.DeserializeObject<List<T>>(jsonContent);

            return lista;
        }
    }
}
