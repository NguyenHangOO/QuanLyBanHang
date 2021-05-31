using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BUS_QLBH
{
    public class WriteLog
    {
        public static List<log> Read(string path)
        {
            try
            {
                List<log> data = new List<log>();
                XmlSerializer xml = new XmlSerializer(typeof(List<log>));
                StreamReader streamReader = new StreamReader(new FileStream(AppDomain.CurrentDomain.BaseDirectory + "\\Log\\" + path, FileMode.Open));
                var dt = xml.Deserialize(streamReader);
                data = dt as List<log>;
                streamReader.Close();
                return data;
            }
            catch
            {
                return null;
            }
        }
        public static void Write(string nguoithuchien, string quyen, string tenLog)
        {
            string day = AppDomain.CurrentDomain.BaseDirectory + "\\Log\\History-" + DateTime.Now.ToString("dd-MM-yyyy") + ".xml";
            XmlSerializer xml = new XmlSerializer(typeof(List<log>));
            if (!Directory.Exists(AppDomain.CurrentDomain.BaseDirectory + "\\Log"))
            {
                Directory.CreateDirectory(AppDomain.CurrentDomain.BaseDirectory + "\\Log");
            }
            List<log> data = new List<log>();
            if (File.Exists(day))
            {
                StreamReader streamReader = new StreamReader(new FileStream(day, FileMode.Open));
                var dt = xml.Deserialize(streamReader);
                if (dt != null)
                {
                    data = dt as List<log>;
                }
                streamReader.Close();
            }

            data.Add(new log()
            {
                user = nguoithuchien + " (" + quyen + ")",
                namelog = tenLog,
                datetime = DateTime.Now.ToString()
            });
            StreamWriter streamWriter = new StreamWriter(new FileStream(day, FileMode.Create));
            xml.Serialize(streamWriter, data);
            streamWriter.Close();
        }

    }
}
