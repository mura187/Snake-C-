using System;
using System.IO;
using System.Xml.Serialization;

namespace SnakeSerialization
{
    [Serializable]
    public class SnakeSer
    {
        public int score { get; set; }
        public SnakeSer()
        { }
        public SnakeSer(int score)
        {
            score = 75;
    
        }
    }
    class Program
    {
        static void Toomain(string[] args)
        {
            // объект для сериализации
            SnakeSer score = new SnakeSer(75);
            XmlSerializer formatter = new XmlSerializer(typeof(SnakeSer));
            using (FileStream fs = new FileStream("snake.xml", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, score);

            }
        }
    }
}

