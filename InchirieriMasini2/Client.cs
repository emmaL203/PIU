using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriMasini2
{
    public class Client
    {
        public string Nume { get; set; }
        public string Adresa { get; set; }
        public string NumarTelefon { get; set; }

        //Constructorul clasei Client
        public Client(string nume, string adresa, string numarTelefon)
        {
            Nume = nume; ;
            Adresa = adresa;
            NumarTelefon = numarTelefon;
        }
    }
}
