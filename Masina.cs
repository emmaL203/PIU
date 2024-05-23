using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace InchirieriMasini2
{
    public class Masina
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public decimal PretPeZi { get; set; }
        public bool EsteDisponibila { get; set; }
        public string CuloareMasina { get; set; }
        public string TipCombustibil { get; set; }

        // Constructor implicit pentru serializare/deserializare JSON
        public Masina() { }

        // Constructorul clasei Masina
        public Masina(string marca, string model, int anFabricatie, decimal pretPeZi, string culoareMasina, string tipCombustibil)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            PretPeZi = pretPeZi;
            EsteDisponibila = true;
            CuloareMasina = culoareMasina;
            TipCombustibil = tipCombustibil;
        }

        // Metoda pentru scrierea unei liste de masini intr-un fisier JSON
        public static void WriteToFile(List<Masina> masini, string fileName)
        {
            string json = JsonConvert.SerializeObject(masini);
            File.WriteAllText(fileName, json);
        }

        public static void AppendToFile(Masina masina, string fileName)
        {
            List<Masina> masini = ReadFromFile(fileName);
            masini.Add(masina);
            WriteToFile(masini, fileName);
        }

        public static List<Masina> ReadFromFile(string fileName)
        {
            List<Masina> masini = new List<Masina>();

            if (File.Exists(fileName))
            {
                string json = File.ReadAllText(fileName);
                masini = JsonConvert.DeserializeObject<List<Masina>>(json);
            }

            return masini;
        }
    }
}
