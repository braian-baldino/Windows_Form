using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace ClassLibrary.Serializer
{
    public static class Xml<T> where T: class, new()
    {
        /// <summary>
        /// Saves the given data in an XML file on My Documents.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool SaveXml(string fileName, T data)
        {
            if (!string.IsNullOrEmpty(fileName) && !ReferenceEquals(data,null))
            {
                try
                {
                    string myDocuments = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    XmlTextWriter xmlWriter = new XmlTextWriter(Path.Combine(myDocuments + "/" + fileName), Encoding.UTF8);
                    XmlSerializer serializer = new XmlSerializer(typeof(T));

                    serializer.Serialize(xmlWriter, data);
                    xmlWriter.Close();
                    return true;
                }
                catch (Exception e)
                {
                    throw new Exception("Serialization Error", e);
                }
            }
            return false;
        }

        /// <summary>
        /// Saves the given data in a binary XML file in My Documents.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool SaveBinaryXml(string fileName, T data)
        {
            bool retorno = false;
            if (!string.IsNullOrEmpty(fileName) && !ReferenceEquals(data, null))
            {
                try
                {
                    string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    string path = Path.Combine(myDocs, "Accountant App");
                    Directory.CreateDirectory(path);
                    FileStream fs = new FileStream(Path.Combine(path, fileName), FileMode.Create);
                    BinaryFormatter ser = new BinaryFormatter();

                    ser.Serialize(fs, data);
                    fs.Close();
                    retorno = true;
                }
                catch (Exception ex)
                {

                    throw new Exception("Binary Serialization Error.", ex);
                }
            }
            return retorno;
        }

        /// <summary>
        /// Reads data from a binary file in Accountant App in My Documents.
        /// </summary>
        /// <param name="fileName"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        public static bool ReadBinary(string fileName, out T data)
        {
            data = default(T);
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    foreach (string _dir in Directory.GetDirectories(myDocs))
                    {
                        if(_dir == (myDocs + "\\" + "Accountant App"))
                        {
                            foreach (string item in Directory.GetFiles(_dir))
                            {
                                if (item == (_dir + "\\" + fileName))
                                {
                                    FileStream fStream = new FileStream(item, FileMode.Open);
                                    BinaryFormatter serializer = new BinaryFormatter();
                                    data = (T)serializer.Deserialize(fStream);
                                    fStream.Close();
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error en serializacion", e);
                }
            }
            return false;
        }

        public static bool ReadXml(string fileName, out T data)
        {
            data = default(T);
            if (!string.IsNullOrEmpty(fileName))
            {
                try
                {
                    string myDocs = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
                    foreach (string _dir in Directory.GetDirectories(myDocs))
                    {
                        if (_dir == (myDocs + "\\" + "Accountant App"))
                        {
                            foreach (string item in Directory.GetFiles(_dir))
                            {
                                if (item == (_dir + "\\" + fileName))
                                {
                                    FileStream fStream = new FileStream(item, FileMode.Open);
                                    XmlSerializer serializer = new XmlSerializer(typeof (T));
                                    data = (T)serializer.Deserialize(fStream);
                                    fStream.Close();
                                    return true;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    throw new Exception("Error en serializacion", e);
                }
            }
            return false;
        }
    }
}
