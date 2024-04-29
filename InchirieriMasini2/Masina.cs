using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriMasini2
{
    public enum Culoare
    {
        Rosu,
        Alb,
        Negru,
        Gri,
        Albastru
    }

    public enum Combustibil
    {
        Benzina,
        Motorina,
        Electric,
        Hybrid
    }
    public class Masina
    {
        public string Marca { get; set; }
        public string Model { get; set; }
        public int AnFabricatie { get; set; }
        public decimal PretPeZi { get; set; }
        public bool EsteDisponibila { get; set; }//proprietate auto-implemented de tip bool numita EsteDisponibila
        public  string CuloareMasina { get; set; }
        public  string TipCombustibil { get; set; }
        //Contructorul clasei Masina
        public Masina(string marca, string model, int anFabricatie, decimal pretPeZi,string  culoareMasina, string  tipCombustibil)
        {
            Marca = marca;
            Model = model;
            AnFabricatie = anFabricatie;
            PretPeZi = pretPeZi;
            EsteDisponibila = true;
            CuloareMasina = culoareMasina;
            TipCombustibil = tipCombustibil;
        }


        }
        
    }

