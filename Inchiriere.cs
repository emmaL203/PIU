using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace InchirieriMasini2
{
    public class Inchiriere
    {
        public Masina Masina { get; set; }
        public Client Client { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }

        // Constructor implicit pentru serializare/deserializare JSON
        public Inchiriere() { }

        public Inchiriere(DateTime dataInceput, DateTime dataSfarsit)
        {
            DataInceput = dataInceput;
            DataSfarsit = dataSfarsit;
        }

        public Inchiriere(Masina masina, Client client, DateTime dataInceput, DateTime dataSfarsit)
        {
            Masina = masina;
            Client = client;
            DataInceput = dataInceput;
            DataSfarsit = dataSfarsit;
        }

        // Metoda pentru scrierea unei liste de inchirieri intr-un fisier JSON
        public static void WriteToFile(List<Inchiriere> inchirieri, string filePath)
        {
            string jsonString = JsonConvert.SerializeObject(inchirieri, Formatting.Indented);
            File.WriteAllText(filePath, jsonString);
        }

        // Metoda pentru adaugarea unei inchirieri intr-un fisier JSON
        public static void AppendToFile(Inchiriere inchiriere, string filePath)
        {
            List<Inchiriere> inchirieriExistent = ReadFromFile(filePath);
            inchirieriExistent.Add(inchiriere);
            WriteToFile(inchirieriExistent, filePath);
        }

        // Metoda pentru citirea unei liste de inchirieri dintr-un fisier JSON
        public static List<Inchiriere> ReadFromFile(string filePath)
        {
            List<Inchiriere> inchirieri= new List<Inchiriere>();
            if (File.Exists(filePath))
            { string jsonString = File.ReadAllText(filePath);
          inchirieri = JsonConvert.DeserializeObject<List<Inchiriere>>(jsonString);
            }

           
            return inchirieri;
        }
    }
}
