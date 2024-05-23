using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace InchirieriMasini2
{
    public class Client
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string NumarTelefon { get; set; }

        // Constructor implicit pentru serializare/deserializare JSON
        public Client() { }

        // Constructor pentru initializarea obiectului Client
        public Client(string nume, string adresa, string numarTelefon)
        {
            Nume = nume;
            Adresa = adresa;
            NumarTelefon = numarTelefon;
        }

        // Metoda pentru scrierea unei liste de clienti intr-un fisier JSON
        public static void WriteToFile(List<Client> clienti, string filePath)
        {
            string jsonString = JsonConvert.SerializeObject(clienti);
            File.WriteAllText(filePath, jsonString);
        }

        // Metoda pentru adaugarea unui client intr-un fisier JSON
        public static void AppendToFile(Client client, string filename)
        {
            List<Client> clientiExistenti = ReadFromFile(filename);
            clientiExistenti.Add(client);
            WriteToFile(clientiExistenti, filename);
        }

        // Metoda pentru citirea unei liste de clienti dintr-un fisier JSON
        public static List<Client> ReadFromFile(string filename)
        {
            List<Client> clienti= new List<Client>();
            if (File.Exists(filename))
            {
               string jsonString = File.ReadAllText(filename);
             clienti = JsonConvert.DeserializeObject<List<Client>>(jsonString);
           
            }
                 return clienti;
            
        }
    }
}
