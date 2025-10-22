using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace NewPersistens
{
    public class DataHandler
    {
        public string DataFileName { get;}
        
        public DataHandler (string dataFileName)
        {
            DataFileName = dataFileName;
        }

        public void SavePerson (Person person)
        {
            StreamWriter sw = new StreamWriter (DataFileName);
            sw.WriteLine (person.Name);
            sw.WriteLine (person.BirthDate);
            sw.WriteLine (person.Height);
            sw.WriteLine (person.IsMarried);
            sw.WriteLine (person.NoOfChildren);
            sw.Close ();
        }
        public Person LoadPerson()
        {
            StreamReader sr = new StreamReader(DataFileName);
            string name = sr.ReadLine();
            string birthDate = sr.ReadLine();
            string height = sr.ReadLine();
            string isMarried = sr.ReadLine();
            string noOfChildren = sr.ReadLine();
            sr.Close();

            Person h = new Person(name, DateTime.Parse(birthDate), double.Parse(height), bool.Parse(isMarried), int.Parse(noOfChildren));
            return h;   
        }
        public void SavePersons(Person[] persons)
        {
            using (StreamWriter sw = new StreamWriter(DataFileName))
            {
                foreach (Person person in persons)
                {
                    string line = $"{person.Name};{person.BirthDate};{person.Height};{person.IsMarried};{person.NoOfChildren}";
                    sw.WriteLine(line);
                }
            }
        }
        public Person[] LoadPersons()
        {
            List<Person> persons = new List<Person>();

            using (StreamReader sr = new StreamReader(DataFileName))
            {
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    if (string.IsNullOrWhiteSpace(line)) continue;

                    string[] parts = line.Split(';');
                    if (parts.Length != 5) continue;

                    string name = parts[0];
                    DateTime birthDate = DateTime.Parse(parts[1]);
                    double height = double.Parse(parts[2]);
                    bool isMarried = bool.Parse(parts[3]);
                    int noOfChildren = int.Parse(parts[4]);

                    Person p = new Person(name, birthDate, height, isMarried, noOfChildren);
                    persons.Add(p);
                }
            }

            return persons.ToArray();
        }

    }
}