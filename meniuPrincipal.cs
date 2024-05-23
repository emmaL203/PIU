using InchirieriMasini2;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

namespace AplicatieInchirieriMasini3
{
    public partial class meniuPrincipal : Form
    {
        InchirieriMasini masinuta = new InchirieriMasini();
        public List<Masina> listMasini = new List<Masina>();
        public List<Inchiriere> listInchiriere = new List<Inchiriere>();
        public List<Client> listClient = new List<Client>();

        public meniuPrincipal()
        {
            InitializeComponent();
            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            masinuta.LoadDataFromFile();
            listMasini = Masina.ReadFromFile(Path.Combine(path, "masinuca.json"));
            listClient = Client.ReadFromFile(Path.Combine(path, "client.json"));
            listInchiriere = Inchiriere.ReadFromFile(Path.Combine(path, "inchiriere.json"));
        }

        private void meniuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                masinuta.LoadDataFromFile();
                MessageBox.Show("Datele au fost încărcate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la încărcarea datelor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Salveaza_Click(object sender, EventArgs e)
        {
            try
            {
                // Salvarea datelor in fisiere
                masinuta.SaveDataInFile();
                MessageBox.Show("Datele au fost salvate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("A apărut o eroare la salvarea datelor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Search_TextChanged(object sender, EventArgs e)
        {
            string filterText = Search.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(filterText))
            {
                PopulateDataGridView(listMasini);
            }
            else
            {
                var filteredList = listMasini
                    .Where(m => m.Marca.ToLower().Contains(filterText) ||
                                m.Model.ToLower().Contains(filterText) ||
                                m.CuloareMasina.ToLower().Contains(filterText) ||
                                m.TipCombustibil.ToLower().Contains(filterText))
                    .ToList();
                PopulateDataGridView(filteredList);
            }
        }

        private void PopulateDataGridView(List<Masina> masini)
        {
            dataGridViewMasini.Rows.Clear();
            foreach (var masina in masini)
            {
                dataGridViewMasini.Rows.Add(masina.Model, masina.CuloareMasina, masina.Marca, masina.PretPeZi, masina.TipCombustibil, masina.AnFabricatie, masina.EsteDisponibila);
            }
        }

        private void Adauga_Click(object sender, EventArgs e)
        {
            bool EsteDisponibila;
            string model = textBox2Model.Text;
            string marca = textBox1Marca.Text;
            int AnFabricatie;
            int.TryParse(textBox3AnFabricatie.Text, out AnFabricatie);
            decimal PretPeZi;
            decimal.TryParse(textBox1PretPeZi.Text, out PretPeZi);
            EsteDisponibila = checkBox1.Checked;
            string CuloareMasina = textBox1CuloareMasina.Text;
            string TipCombustibil = textBox2TpCombustibil.Text;

            Masina masinuca = new Masina(marca, model, AnFabricatie, PretPeZi, CuloareMasina, TipCombustibil);
            listMasini.Add(masinuca);

            string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            Masina.WriteToFile(listMasini, Path.Combine(path, "masinuca.json"));
            listMasini = Masina.ReadFromFile(Path.Combine(path, "masinuca.json"));
        }

        private void Afiseaza_Click(object sender, EventArgs e)
        {
            dataGridViewMasini.Rows.Clear();
            listMasini = Masina.ReadFromFile("masinuca.json");
            if (dataGridViewMasini.Columns.Count == 0)
            {
                dataGridViewMasini.Columns.Add("Marca", "Marca");
                dataGridViewMasini.Columns.Add("Model", "Model");
                dataGridViewMasini.Columns.Add("CuloareMasina", "Culoare");
                dataGridViewMasini.Columns.Add("PretPeZi", "PretPeZi");
                dataGridViewMasini.Columns.Add("TipCombustibil", "Combustibil");
                dataGridViewMasini.Columns.Add("AnFabricatie", "AnFabricatie");
                dataGridViewMasini.Columns.Add("EsteDisponibila", "EsteDisponibila");
            }

            foreach (var masina in listMasini)
            {
                dataGridViewMasini.Rows.Add(masina.Marca, masina.Model, masina.CuloareMasina, masina.PretPeZi, masina.TipCombustibil, masina.AnFabricatie, masina.EsteDisponibila);
            }
        }

        private void dataGridViewMasini_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Logica pentru handling click pe celulă
        }

        private void label1Marca_Click(object sender, EventArgs e)
        {
            // Logica pentru handling click pe etichetă
        }

        private void sterge_Click(object sender, EventArgs e)
        {
            if (dataGridViewMasini.SelectedRows.Count == 1)
            {
                string masinaMarca = dataGridViewMasini.SelectedRows[0].Cells[0].Value.ToString();
                string masinaModel = dataGridViewMasini.SelectedRows[0].Cells[1].Value.ToString();
                foreach (Masina masina in listMasini)
                {
                    if (masina.Marca == masinaMarca && masina.Model == masinaModel)
                    {
                        listMasini.Remove(masina);
                        break;
                    }

                }

            }
            else MessageBox.Show("NU SE STERGE!");
            
            Masina.WriteToFile(listMasini, "masinuca.json");
            listMasini = Masina.ReadFromFile("masinuca.json");
        }
    }
}
