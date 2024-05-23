using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Xml;

namespace InchirieriMasini2
{
    public class InchirieriMasini
    {
        public List<Masina> listMasini = new List<Masina>();
        public List<Inchiriere> listInchiriere = new List<Inchiriere>();
        public List<Client> listClient = new List<Client>();

        public List<Masina> Masina { get { return listMasini; } }
        public List<Inchiriere> Inchiriere { get { return listInchiriere; } }
        public List<Client> ListClients { get { return listClient; } }

        public void SaveDataInFile()
        {
            try
            {
                // Save Masina list
                string masiniJson = JsonConvert.SerializeObject(listMasini);
                File.WriteAllText("masini.json", masiniJson);

                // Save Inchiriere list
                string inchirieriJson = JsonConvert.SerializeObject(listInchiriere);
                File.WriteAllText("inchirieri.json", inchirieriJson);

                // Save Client list
                string clientiJson = JsonConvert.SerializeObject(listClient);
                File.WriteAllText("clienti.json", clientiJson);
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la salvarea datelor: " + ex.Message);
            }
        }

        public void LoadDataFromFile()
        {
            try
            {
                if (File.Exists("masini.json"))
                {
                    string masiniJson = File.ReadAllText("masini.json");
                    listMasini = JsonConvert.DeserializeObject<List<Masina>>(masiniJson) ?? new List<Masina>();
                }

                if (File.Exists("inchirieri.json"))
                {
                    string inchirieriJson = File.ReadAllText("inchirieri.json");
                    listInchiriere = JsonConvert.DeserializeObject<List<Inchiriere>>(inchirieriJson) ?? new List<Inchiriere>();
                }

                if (File.Exists("clienti.json"))
                {
                    string clientiJson = File.ReadAllText("clienti.json");
                    listClient = JsonConvert.DeserializeObject<List<Client>>(clientiJson) ?? new List<Client>();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Eroare la încărcarea datelor: " + ex.Message);
            }
        }
    }
}
