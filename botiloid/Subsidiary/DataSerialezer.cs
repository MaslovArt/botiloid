using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace botiloid
{
    public static class DataSerialezer
    {
        /// <summary>
        /// Серриализует данные приложения
        /// </summary>
        /// <param name="playlists"></param>
        /// <param name="filename"></param>
        /// <returns></returns>
        public static bool saveInfo<T>(T Info, string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Create);
            BinaryFormatter formatter = new BinaryFormatter();
            try
            {
                formatter.Serialize(fs, Info);
            }
            catch (SerializationException)
            {
                return false;
            }
            finally
            {
                fs.Close();
            }
            return true;
        }

        /// <summary>
        /// Дессериализует файлы приложения
        /// </summary>
        /// <param name="storage">Файлы приложения</param>
        /// <param name="filename">Путь к файлу</param>
        /// <returns></returns>
        public static bool loadInfo<T>(out T storage, string filename)
        {
            FileStream fs = null;
            storage = default(T);
            fs = new FileStream(filename, FileMode.OpenOrCreate);
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                storage = (T)formatter.Deserialize(fs);
            }
            catch (SerializationException)
            {
                return false;
            }
            finally
            {
                fs.Close();
            }
            return true;
        }
    }
}
