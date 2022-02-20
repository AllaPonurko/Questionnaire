using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Questionnaire
{
     public class DbContext
    {
        public List<Entities.Person> People { get; set; } = new List<Entities.Person>();
        public Entities.Person person { get; set; } = new Entities.Person();
        private DbContext() { }

        private static DbContext _instance;
        public static DbContext getInstance()
        {
            if (_instance == null) _instance = new DbContext();
            return _instance;
        }
        
        public event Action<string> onError;


        public List<Entities.Person> Load(string fileName)
        {
            try
            {
                XmlSerializer formatter
                    = new XmlSerializer(typeof(List<Entities.Person>));

                using (FileStream fs
                    = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    People = (List < Entities.Person > )formatter.Deserialize(fs);
                }
            }
            catch (Exception ex)
            {
                onError(ex.Message);
            }
            return People;
        }

        public void Save(string fileName)
        {
            try
            {
                XmlSerializer formatter
                    = new XmlSerializer(typeof(List<Entities.Person>));

                using (FileStream fs
                    = new FileStream(fileName, FileMode.OpenOrCreate))
                {
                    formatter.Serialize(fs, People);
                }
            }
            catch (Exception ex)
            {
                onError(ex.Message);
            }

        }


    }
}