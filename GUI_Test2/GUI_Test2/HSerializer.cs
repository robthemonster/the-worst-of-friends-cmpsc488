using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace WOF
{
    public partial class HSerializer
    {
        public static void Serialize(string filename, object[] objs)
        {
            var stream = File.Open(filename, FileMode.Create);
            BinaryFormatter bFormatter = new BinaryFormatter();
            {
                int count = objs.Length;
                bFormatter.Serialize(stream, count);
                for (int i = 0; i < count; i++)
                {
                    bFormatter.Serialize(stream, objs[i]);
                }
            }
            stream.Flush();
            stream.Close();
        }
        public static object[] Deserialize(string filename)
        {
            object[] objs;
            Stream stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read);
            BinaryFormatter bFormatter = new BinaryFormatter();
            {
                int count = (int)bFormatter.Deserialize(stream);
                objs = new object[count];
                for (int i = 0; i < count; i++)
                {
                    objs[i] = bFormatter.Deserialize(stream);
                }
            }
            stream.Close();
            return objs;
        }
    }
}
