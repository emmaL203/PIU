using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InchirieriMasini2;

namespace AplicatieInchirieriMasini3
{
    public partial class Form1 : Form
    {
        //// Text fields for various car properties
        //private TextBox textMarca;
        //private TextBox textModel;
        //private TextBox textAnFabricatie;
        //private TextBox textPretPeZi;

        //// Dropdowns for Color and Fuel Type
        //private ComboBox comboCuloare;
        //private ComboBox comboCombustibil;

        //private ListView listViewMasini;

        // Button to add new car
         private Button buttonAdaugaMasina;

        // List to hold cars
        private List<Masina> listaMasini;

        private ListView listViewMasini; // Afișează mașinile disponibile
        private TextBox textMarca, textModel, textAnFabricatie, textPretPeZi; // Detalii despre mașină
        private ComboBox comboCuloare, comboCombustibil; // Afișează culoarea și tipul de combustibil
        private Button btnAdaugaMasina; // Buton pentru adăugarea unei mașini

        public Form1()
        {
            InitializeComponent();

            // Initialize the list of cars
            listaMasini = new List<Masina>();

            // Initialize the text boxes
            textMarca = new TextBox { Location = new Point(20, 20), Width = 200 };
            textModel = new TextBox { Location = new Point(20, 60), Width = 200 };
            textAnFabricatie = new TextBox { Location = new Point(20, 100), Width = 200 };
            textPretPeZi = new TextBox { Location = new Point(20, 140), Width = 200 };

            // Initialize the dropdown for color
            comboCuloare = new ComboBox { Location = new Point(20, 180), Width = 200 };
            comboCuloare.DataSource = Enum.GetValues(typeof(Culoare));

            // Initialize the dropdown for fuel type
            comboCombustibil = new ComboBox { Location = new Point(20, 220), Width = 200 };
            comboCombustibil.DataSource = Enum.GetValues(typeof(Combustibil));

            // Initialize the ListView for displaying the cars
            listViewMasini = new ListView
            {
                Location = new Point(250, 20),
                Size = new Size(400, 200),
                View = View.Details,
                FullRowSelect = true
            };

            // Add columns to the ListView
            listViewMasini.Columns.Add("Marca", 100);
            listViewMasini.Columns.Add("Model", 100);
            listViewMasini.Columns.Add("An Fabricatie", 100);
            listViewMasini.Columns.Add("Pret Pe Zi", 100);

            // Add the controls to the form
            this.Controls.Add(textMarca);
            this.Controls.Add(textModel);
            this.Controls.Add(textAnFabricatie);
            this.Controls.Add(textPretPeZi);
            this.Controls.Add(comboCuloare);
            this.Controls.Add(comboCombustibil);

            // Button to add new car
            buttonAdaugaMasina = new Button
            {
                Text = "Adauga Masina",
                Location = new Point(20, 260),
                Size = new Size(200, 30),
            };

            


        }

        private void ButtonAdaugaMasina_Click(object sender, EventArgs e)
        {
            // Codul pentru manipularea evenimentului butonului
            // Event handler for the button
            buttonAdaugaMasina.Click += ButtonAdaugaMasina_Click;

            this.Controls.Add(buttonAdaugaMasina);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Any additional setup code can go here
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var marca = textMarca.Text;
            var model = textModel.Text;

            // Convertește de la string la int
            if (int.TryParse(textAnFabricatie.Text, out int anFabricatie) && int.TryParse(textPretPeZi.Text, out int pretPeZi))
            {
                // Obține obiectele enum și convertește la string
                var culoare = ((Culoare)comboCuloare.SelectedItem).ToString(); // Convertim la string
                var combustibil = ((Combustibil)comboCombustibil.SelectedItem).ToString(); // Convertim la string

                // Creează o nouă mașină și o adaugă în listă
                var masina = new Masina(marca, model, anFabricatie, pretPeZi, culoare, combustibil);
                listaMasini.Add(masina);

                // Conversii la string pentru enum-uri
                var culoareString = culoare.ToString(); // Culoare ca string
                var combustibilString = combustibil.ToString(); // Combustibil ca string

                // Actualizează ListView cu noua mașină
                var item = new ListViewItem(new string[]
                {
            marca, model, anFabricatie.ToString(), pretPeZi.ToString(), culoareString, combustibilString
                });

                listViewMasini.Items.Add(item); // Adaugă în ListView
            }
            else
            {
                MessageBox.Show("Anul de fabricație și prețul pe zi trebuie să fie numere întregi.");
            }
        }
    }

}

   

        

       

       