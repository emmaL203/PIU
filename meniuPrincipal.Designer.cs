namespace AplicatieInchirieriMasini3
{
    partial class meniuPrincipal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(meniuPrincipal));
            this.Search = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Adauga = new System.Windows.Forms.Button();
            this.Salveaza = new System.Windows.Forms.Button();
            this.Afiseaza = new System.Windows.Forms.Button();
            this.sterge = new System.Windows.Forms.Button();
            this.label1Marca = new System.Windows.Forms.Label();
            this.textBox1Marca = new System.Windows.Forms.TextBox();
            this.ModelLabel2 = new System.Windows.Forms.Label();
            this.label3AnFabricatie = new System.Windows.Forms.Label();
            this.textBox2Model = new System.Windows.Forms.TextBox();
            this.textBox3AnFabricatie = new System.Windows.Forms.TextBox();
            this.label5CuloareMasina = new System.Windows.Forms.Label();
            this.label3EsteDisponibila = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2TipCombustibil = new System.Windows.Forms.Label();
            this.groupBox1PretPeZi = new System.Windows.Forms.GroupBox();
            this.textBox1CuloareMasina = new System.Windows.Forms.TextBox();
            this.textBox2TpCombustibil = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1PretPeZi = new System.Windows.Forms.TextBox();
            this.masinaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewMasini = new System.Windows.Forms.DataGridView();
            this.groupBox1PretPeZi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).BeginInit();
            this.SuspendLayout();
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(66, 9);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(435, 22);
            this.Search.TabIndex = 1;
            this.Search.TextChanged += new System.EventHandler(this.Search_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "search";
            // 
            // Adauga
            // 
            this.Adauga.Location = new System.Drawing.Point(601, 7);
            this.Adauga.Name = "Adauga";
            this.Adauga.Size = new System.Drawing.Size(90, 26);
            this.Adauga.TabIndex = 3;
            this.Adauga.Text = "Adauga";
            this.Adauga.UseVisualStyleBackColor = true;
            this.Adauga.Click += new System.EventHandler(this.Adauga_Click);
            // 
            // Salveaza
            // 
            this.Salveaza.Location = new System.Drawing.Point(507, 7);
            this.Salveaza.Name = "Salveaza";
            this.Salveaza.Size = new System.Drawing.Size(88, 27);
            this.Salveaza.TabIndex = 4;
            this.Salveaza.Text = "Salveaza";
            this.Salveaza.UseVisualStyleBackColor = true;
            this.Salveaza.Click += new System.EventHandler(this.Salveaza_Click);
            // 
            // Afiseaza
            // 
            this.Afiseaza.Location = new System.Drawing.Point(697, 8);
            this.Afiseaza.Name = "Afiseaza";
            this.Afiseaza.Size = new System.Drawing.Size(89, 26);
            this.Afiseaza.TabIndex = 5;
            this.Afiseaza.Text = "Afiseaza";
            this.Afiseaza.UseVisualStyleBackColor = true;
            this.Afiseaza.Click += new System.EventHandler(this.Afiseaza_Click);
            // 
            // sterge
            // 
            this.sterge.Location = new System.Drawing.Point(792, 9);
            this.sterge.Name = "sterge";
            this.sterge.Size = new System.Drawing.Size(89, 26);
            this.sterge.TabIndex = 6;
            this.sterge.Text = "Sterge";
            this.sterge.UseVisualStyleBackColor = true;
            this.sterge.Click += new System.EventHandler(this.sterge_Click);
            // 
            // label1Marca
            // 
            this.label1Marca.AutoSize = true;
            this.label1Marca.BackColor = System.Drawing.SystemColors.ControlText;
            this.label1Marca.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1Marca.Location = new System.Drawing.Point(34, 27);
            this.label1Marca.Name = "label1Marca";
            this.label1Marca.Size = new System.Drawing.Size(48, 16);
            this.label1Marca.TabIndex = 7;
            this.label1Marca.Text = "Marca:";
            this.label1Marca.Click += new System.EventHandler(this.label1Marca_Click);
            // 
            // textBox1Marca
            // 
            this.textBox1Marca.Location = new System.Drawing.Point(123, 21);
            this.textBox1Marca.Name = "textBox1Marca";
            this.textBox1Marca.Size = new System.Drawing.Size(100, 22);
            this.textBox1Marca.TabIndex = 8;
            // 
            // ModelLabel2
            // 
            this.ModelLabel2.AutoSize = true;
            this.ModelLabel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.ModelLabel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ModelLabel2.Location = new System.Drawing.Point(34, 61);
            this.ModelLabel2.Name = "ModelLabel2";
            this.ModelLabel2.Size = new System.Drawing.Size(45, 16);
            this.ModelLabel2.TabIndex = 9;
            this.ModelLabel2.Text = "Model";
            // 
            // label3AnFabricatie
            // 
            this.label3AnFabricatie.AutoSize = true;
            this.label3AnFabricatie.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3AnFabricatie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3AnFabricatie.Location = new System.Drawing.Point(34, 123);
            this.label3AnFabricatie.Name = "label3AnFabricatie";
            this.label3AnFabricatie.Size = new System.Drawing.Size(83, 16);
            this.label3AnFabricatie.TabIndex = 10;
            this.label3AnFabricatie.Text = "AnFabricatie";
            // 
            // textBox2Model
            // 
            this.textBox2Model.Location = new System.Drawing.Point(123, 55);
            this.textBox2Model.Name = "textBox2Model";
            this.textBox2Model.Size = new System.Drawing.Size(100, 22);
            this.textBox2Model.TabIndex = 11;
            // 
            // textBox3AnFabricatie
            // 
            this.textBox3AnFabricatie.Location = new System.Drawing.Point(123, 120);
            this.textBox3AnFabricatie.Name = "textBox3AnFabricatie";
            this.textBox3AnFabricatie.Size = new System.Drawing.Size(100, 22);
            this.textBox3AnFabricatie.TabIndex = 12;
            // 
            // label5CuloareMasina
            // 
            this.label5CuloareMasina.AutoSize = true;
            this.label5CuloareMasina.BackColor = System.Drawing.SystemColors.ControlText;
            this.label5CuloareMasina.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5CuloareMasina.Location = new System.Drawing.Point(34, 182);
            this.label5CuloareMasina.Name = "label5CuloareMasina";
            this.label5CuloareMasina.Size = new System.Drawing.Size(98, 16);
            this.label5CuloareMasina.TabIndex = 13;
            this.label5CuloareMasina.Text = "CuloareMasina";
            // 
            // label3EsteDisponibila
            // 
            this.label3EsteDisponibila.AutoSize = true;
            this.label3EsteDisponibila.BackColor = System.Drawing.SystemColors.ControlText;
            this.label3EsteDisponibila.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3EsteDisponibila.Location = new System.Drawing.Point(34, 152);
            this.label3EsteDisponibila.Name = "label3EsteDisponibila";
            this.label3EsteDisponibila.Size = new System.Drawing.Size(102, 16);
            this.label3EsteDisponibila.TabIndex = 14;
            this.label3EsteDisponibila.Text = "EsteDisponibila";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Location = new System.Drawing.Point(146, 152);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 20);
            this.checkBox1.TabIndex = 15;
            this.checkBox1.Text = "da/nu";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // label2TipCombustibil
            // 
            this.label2TipCombustibil.AutoSize = true;
            this.label2TipCombustibil.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2TipCombustibil.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2TipCombustibil.Location = new System.Drawing.Point(34, 213);
            this.label2TipCombustibil.Name = "label2TipCombustibil";
            this.label2TipCombustibil.Size = new System.Drawing.Size(97, 16);
            this.label2TipCombustibil.TabIndex = 18;
            this.label2TipCombustibil.Text = "TipCombustibil";
            // 
            // groupBox1PretPeZi
            // 
            this.groupBox1PretPeZi.BackColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1PretPeZi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1PretPeZi.BackgroundImage")));
            this.groupBox1PretPeZi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.groupBox1PretPeZi.Controls.Add(this.textBox1PretPeZi);
            this.groupBox1PretPeZi.Controls.Add(this.label2);
            this.groupBox1PretPeZi.Controls.Add(this.textBox2TpCombustibil);
            this.groupBox1PretPeZi.Controls.Add(this.textBox1CuloareMasina);
            this.groupBox1PretPeZi.Controls.Add(this.textBox1Marca);
            this.groupBox1PretPeZi.Controls.Add(this.label2TipCombustibil);
            this.groupBox1PretPeZi.Controls.Add(this.label1Marca);
            this.groupBox1PretPeZi.Controls.Add(this.ModelLabel2);
            this.groupBox1PretPeZi.Controls.Add(this.label3AnFabricatie);
            this.groupBox1PretPeZi.Controls.Add(this.checkBox1);
            this.groupBox1PretPeZi.Controls.Add(this.textBox2Model);
            this.groupBox1PretPeZi.Controls.Add(this.label3EsteDisponibila);
            this.groupBox1PretPeZi.Controls.Add(this.textBox3AnFabricatie);
            this.groupBox1PretPeZi.Controls.Add(this.label5CuloareMasina);
            this.groupBox1PretPeZi.Location = new System.Drawing.Point(329, 217);
            this.groupBox1PretPeZi.Name = "groupBox1PretPeZi";
            this.groupBox1PretPeZi.Size = new System.Drawing.Size(445, 256);
            this.groupBox1PretPeZi.TabIndex = 19;
            this.groupBox1PretPeZi.TabStop = false;
            this.groupBox1PretPeZi.Text = "groupBox1";
            // 
            // textBox1CuloareMasina
            // 
            this.textBox1CuloareMasina.Location = new System.Drawing.Point(138, 179);
            this.textBox1CuloareMasina.Name = "textBox1CuloareMasina";
            this.textBox1CuloareMasina.Size = new System.Drawing.Size(100, 22);
            this.textBox1CuloareMasina.TabIndex = 19;
            // 
            // textBox2TpCombustibil
            // 
            this.textBox2TpCombustibil.Location = new System.Drawing.Point(137, 213);
            this.textBox2TpCombustibil.Name = "textBox2TpCombustibil";
            this.textBox2TpCombustibil.Size = new System.Drawing.Size(100, 22);
            this.textBox2TpCombustibil.TabIndex = 20;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ControlText;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(34, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 21;
            this.label2.Text = " Pret pe zi";
            // 
            // textBox1PretPeZi
            // 
            this.textBox1PretPeZi.Location = new System.Drawing.Point(123, 89);
            this.textBox1PretPeZi.Name = "textBox1PretPeZi";
            this.textBox1PretPeZi.Size = new System.Drawing.Size(100, 22);
            this.textBox1PretPeZi.TabIndex = 22;
            // 
            // masinaBindingSource
            // 
            this.masinaBindingSource.DataSource = typeof(InchirieriMasini2.Masina);
            // 
            // dataGridViewMasini
            // 
            this.dataGridViewMasini.AllowDrop = true;
            this.dataGridViewMasini.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMasini.Location = new System.Drawing.Point(48, 45);
            this.dataGridViewMasini.Name = "dataGridViewMasini";
            this.dataGridViewMasini.RowHeadersWidth = 51;
            this.dataGridViewMasini.RowTemplate.Height = 24;
            this.dataGridViewMasini.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewMasini.Size = new System.Drawing.Size(1023, 166);
            this.dataGridViewMasini.TabIndex = 20;
            this.dataGridViewMasini.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewMasini_CellContentClick);
            // 
            // meniuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImage = global::AplicatieInchirieriMasini3.Properties.Resources.glc;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1100, 542);
            this.Controls.Add(this.dataGridViewMasini);
            this.Controls.Add(this.groupBox1PretPeZi);
            this.Controls.Add(this.sterge);
            this.Controls.Add(this.Afiseaza);
            this.Controls.Add(this.Salveaza);
            this.Controls.Add(this.Adauga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Search);
            this.DoubleBuffered = true;
            this.Name = "meniuPrincipal";
            this.Text = "meniuPrincipal";
            this.Load += new System.EventHandler(this.meniuPrincipal_Load);
            this.groupBox1PretPeZi.ResumeLayout(false);
            this.groupBox1PretPeZi.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masinaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMasini)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Search;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Adauga;
        private System.Windows.Forms.Button Salveaza;
        private System.Windows.Forms.Button Afiseaza;
        private System.Windows.Forms.BindingSource masinaBindingSource;
        private System.Windows.Forms.Button sterge;
        private System.Windows.Forms.Label label1Marca;
        private System.Windows.Forms.TextBox textBox1Marca;
        private System.Windows.Forms.Label ModelLabel2;
        private System.Windows.Forms.Label label3AnFabricatie;
        private System.Windows.Forms.TextBox textBox2Model;
        private System.Windows.Forms.TextBox textBox3AnFabricatie;
        private System.Windows.Forms.Label label5CuloareMasina;
        private System.Windows.Forms.Label label3EsteDisponibila;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2TipCombustibil;
        private System.Windows.Forms.GroupBox groupBox1PretPeZi;
        private System.Windows.Forms.TextBox textBox2TpCombustibil;
        private System.Windows.Forms.TextBox textBox1CuloareMasina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1PretPeZi;
        private System.Windows.Forms.DataGridView dataGridViewMasini;
    }
}