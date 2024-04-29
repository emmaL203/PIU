using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InchirieriMasini2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int nr = 1;

            InchirieriMasini inchirieriMasini= new InchirieriMasini();

            // Citirea datelor de la tastatură pentru fiecare mașină
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("Introduceti marca masinii:");
                string marca = Console.ReadLine();

                Console.WriteLine("Introduceti modelul masinii:");
                string model = Console.ReadLine();

                Console.WriteLine("Introduceti anul fabricatiei masinii:");
                int anFabricatie = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduceți pretul pe zi al masinii:");
                decimal pretPeZi = decimal.Parse(Console.ReadLine());

                
                Console.WriteLine("Selectați culoarea mașinii (0 = Roșu, 1 = Alb, 2 = Negru):");
                string culoareMasina = Console.ReadLine();

                Console.WriteLine("Selectați tipul de combustibil (0 = Benzină, 1 = Motorină, 2 = Electric):");
                string tipCombustibil = Console.ReadLine();

                inchirieriMasini.Masina.Add( new Masina(marca, model, anFabricatie,pretPeZi, culoareMasina, tipCombustibil));

            }

            // Citirea datelor de la tastatură pentru fiecare client
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("Introduceti numele clientului:");
                string nume = Console.ReadLine();

                Console.WriteLine("Introduceti CNP-ul clientului:");
                string cnp = Console.ReadLine();

                Console.WriteLine("Introduceti numărul de telefon al clientului:");
                string numarTelefon = Console.ReadLine();

                inchirieriMasini.ListClients.Add(new Client(nume, cnp, numarTelefon));
            }

            //Citirea datelor de la tastatură pentru fiecare închiriere
            for (int i = 0; i < nr; i++)
            {
                Console.WriteLine("Selectati mașina pentru închiriere (introduceti indexul masinii):");
                int indexMasina = int.Parse(Console.ReadLine());

                Console.WriteLine("Selectati clientul pentru închiriere (introduceti indexul clientului):");
                int indexClient = int.Parse(Console.ReadLine());

                Console.WriteLine("Introduceti data de început a închirierii:");
            DateTime dataInceput = DateTime.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti data de sfârșit a închirierii:");
                DateTime dataSfarsit = DateTime.Parse(Console.ReadLine());

                inchirieriMasini.Inchiriere.Add( new Inchiriere(inchirieriMasini.Masina[indexMasina], inchirieriMasini.ListClients[indexClient], dataInceput, dataSfarsit));
            }

            // Afișarea datelor pentru fiecare mașină
            Console.WriteLine("Masinile introduse sunt:");
            foreach (Masina masina in inchirieriMasini.Masina)
            {
                Console.WriteLine($"Marca: {masina.Marca}, Model: {masina.Model}, An Fabricatie: {masina.AnFabricatie}, Pret pe zi: {masina.PretPeZi}");
            }

            // Afișarea datelor pentru fiecare client
            Console.WriteLine("Clientii introdusi sunt:");
            foreach (Client client in inchirieriMasini.ListClients)
            {
                Console.WriteLine($"Nume: {client.Nume}, Adresa: {client.Adresa}, Număr de telefon: {client.NumarTelefon}");
            }

            // Afișarea datelor pentru fiecare închiriere
            Console.WriteLine("Închirierile introduse sunt:");
            foreach (Inchiriere inchiriere in inchirieriMasini.Inchiriere)
            {
                Console.WriteLine($"Masina: {inchiriere.Masina.Marca} {inchiriere.Masina.Model}, Client: {inchiriere.Client.Nume}, Data început: {inchiriere.DataInceput}, Data sfarsit: {inchiriere.DataSfarsit}");
            }
            Console.ReadKey();
        }




    }
}
       
    

