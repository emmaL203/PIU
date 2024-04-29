using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriMasini2
{
    public class InchirieriMasini
    {
        public List<Masina> listMasini =new List<Masina> ();
        public List<Inchiriere> listInchiriere = new List<Inchiriere>();
        public List<Client> listClient= new List<Client>();

        public List<Masina> Masina { get { return listMasini; } }
       public  List<Inchiriere> Inchiriere { get { return listInchiriere; } }
       public  List<Client> ListClients { get {  return listClient; } }




    }
}
