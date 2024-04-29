using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriMasini2
{
    public class Inchiriere
    {
        public Masina Masina { get; set; }
        public Client Client { get; set; }
        public DateTime DataInceput { get; set; }
        public DateTime DataSfarsit { get; set; }

        public Inchiriere(Masina masina, Client client, DateTime dataInceput, DateTime dataSfarsit)
        {
            Masina = masina;
            Client = client;
            DataInceput = dataInceput;
            DataSfarsit = dataSfarsit;
        }
    }
}
