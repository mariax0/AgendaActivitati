using System.ComponentModel;
using System.Xml.Serialization;

namespace AgendaActivitati
{
    public partial class Form1 : Form
    {
        private Agenda agenda = new Agenda();
        private string caleFisier = "agenda.xml";
        public Form1()
        {
            InitializeComponent();
            InitializeDataGridViews();
            LoadAgendaFromFile();
            KeyPreview = true;
        }

        private void InitializeDataGridViews()
        {
            // Domenii
            dgvDomenii.AutoGenerateColumns = false;
            var colDomeniuId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id" // Maps to Domeniu.Id
            };
            var colDomeniuNume = new DataGridViewTextBoxColumn
            {
                Name = "Nume",
                HeaderText = "Nume",
                DataPropertyName = "Nume" // Maps to Domeniu.Nume
            };
            var colDomeniuDescriere = new DataGridViewTextBoxColumn
            {
                Name = "Descriere",
                HeaderText = "Descriere",
                DataPropertyName = "Descriere" // Maps to Domeniu.Descriere
            };
            dgvDomenii.Columns.AddRange(colDomeniuId, colDomeniuNume, colDomeniuDescriere);
            dgvDomenii.DataSource = agenda.Domenii;

            // Proiecte
            dgvProiecte.AutoGenerateColumns = false;
            var colProiectId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id" // Proiect.Id
            };
            var colProiectNume = new DataGridViewTextBoxColumn
            {
                Name = "Nume",
                HeaderText = "Nume",
                DataPropertyName = "Nume" // Proiect.Nume
            };
            var colProiectDataInceput = new DataGridViewTextBoxColumn
            {
                Name = "DataInceput",
                HeaderText = "Data Inceput",
                DataPropertyName = "DataInceput" // Proiect.DataInceput
            };
            var colProiectDataSfarsit = new DataGridViewTextBoxColumn
            {
                Name = "DataSfarsit",
                HeaderText = "Data Sfarsit",
                DataPropertyName = "DataSfarsit" // Proiect.DataSfarsit
            };
            dgvProiecte.Columns.AddRange(colProiectId, colProiectNume, colProiectDataInceput, colProiectDataSfarsit);
            // Proiectele vor fi actualizate in functie de domeniul selectat

            // Activitati
            dgvActivitati.AutoGenerateColumns = false;
            var colActivitateId = new DataGridViewTextBoxColumn
            {
                Name = "Id",
                HeaderText = "ID",
                DataPropertyName = "Id" // Activitate.Id
            };
            var colActivitateNume = new DataGridViewTextBoxColumn
            {
                Name = "Nume",
                HeaderText = "Nume",
                DataPropertyName = "Nume" // Activitate.Nume
            };
            var colActivitateDescriere = new DataGridViewTextBoxColumn
            {
                Name = "Descriere",
                HeaderText = "Descriere",
                DataPropertyName = "Descriere" // Activitate.Descriere
            };
            var colActivitateData = new DataGridViewTextBoxColumn
            {
                Name = "Data",
                HeaderText = "Data",
                DataPropertyName = "Data" // Activitate.Data
            };
            var colActivitateFinalizata = new DataGridViewCheckBoxColumn
            {
                Name = "Finalizata",
                HeaderText = "Finalizat?",
                DataPropertyName = "Finalizata" // Activitate.Finalizata
            };
            dgvActivitati.Columns.AddRange(colActivitateId, colActivitateNume, colActivitateDescriere, colActivitateData, colActivitateFinalizata);
            // Activitatile vor fi actualizate in functie de proiectul selectat
        }

        private void btnAddDomeniu_Click(object sender, EventArgs e)
        {
            var addForm = new AddDomeniuForm();
            if (addForm.ShowDialog() == DialogResult.OK)
            {
                agenda.Domenii.Add(addForm.Domeniu);
            }
        }
        private void btnAddProiect_Click(object sender, EventArgs e)
        {
            if (dgvDomenii.SelectedRows.Count > 0)
            {
                var domeniu = (Domeniu)dgvDomenii.SelectedRows[0].DataBoundItem;
                var addForm = new AddProiectForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    domeniu.Proiecte.Add(addForm.Proiect);
                }
            }
            else
            {
                MessageBox.Show("Selectati un domeniu!");
            }
        }

        private void btnAddActivitate_Click(object sender, EventArgs e)
        {
            if (dgvProiecte.SelectedRows.Count > 0)
            {
                var proiect = (Proiect)dgvProiecte.SelectedRows[0].DataBoundItem;
                var addForm = new AddActivitateForm();
                if (addForm.ShowDialog() == DialogResult.OK)
                {
                    proiect.Activitati.Add(addForm.Activitate);
                }
            }
            else
            {
                MessageBox.Show("Selectati un proiect!");
            }
        }


        private void dgvProiecte_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvProiecte.SelectedRows.Count > 0)
            {
                var proiect = (Proiect)dgvProiecte.SelectedRows[0].DataBoundItem;
                dgvActivitati.DataSource = null;
                dgvActivitati.DataSource = proiect.Activitati;
            }
        }

        private void dgvDomenii_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDomenii.SelectedRows.Count > 0)
            {
                var domeniu = (Domeniu)dgvDomenii.SelectedRows[0].DataBoundItem;
                dgvProiecte.DataSource = null;
                dgvProiecte.DataSource = domeniu.Proiecte;
                dgvActivitati.DataSource = null;
            }
        }

        private void SaveAgendaToFile()
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Agenda));
                using (FileStream fileStream = new FileStream(caleFisier, FileMode.Create))
                {
                    serializer.Serialize(fileStream, agenda);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la salvarea agendei: {ex.Message}");
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveAgendaToFile();
            base.OnFormClosing(e);
        }

        private void LoadAgendaFromFile()
        {
            try
            {
                if (File.Exists(caleFisier))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(Agenda));
                    using (FileStream fileStream = new FileStream(caleFisier, FileMode.Open))
                    {
                        var loadedAgenda = (Agenda)serializer.Deserialize(fileStream);
                        // Conversie List<Domeniu> la BindingList<Domeniu>
                        agenda.Domenii = new BindingList<Domeniu>(loadedAgenda.Domenii.ToList());
                        foreach (var domeniu in agenda.Domenii)
                        {
                            domeniu.Proiecte = new BindingList<Proiect>(domeniu.Proiecte.ToList());
                            foreach (var proiect in domeniu.Proiecte)
                            {
                                proiect.Activitati = new BindingList<Activitate>(proiect.Activitati.ToList());
                            }
                        }
                        dgvDomenii.DataSource = agenda.Domenii;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Eroare la incarcarea agendei: {ex.Message}");
                agenda = new Agenda();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveAgendaToFile();
            MessageBox.Show("Agenda salvata cu succes!");
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadAgendaFromFile();
            MessageBox.Show("Agenda incarcata cu succes!");
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.D)
            {
                btnAddDomeniu_Click(this, EventArgs.Empty); // Ctrl+D adauga Domeniu
            }
            else if (e.Control && e.KeyCode == Keys.P)
            {
                btnAddProiect_Click(this, EventArgs.Empty); // Ctrl+P adauga Proiect
            }
            else if (e.Control && e.KeyCode == Keys.A)
            {
                btnAddActivitate_Click(this, EventArgs.Empty); // Ctrl+A adauga Activitate
            }
        }

        private void salveazaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAgendaToFile();
            MessageBox.Show("Agenda salvata cu succes!");
        }

        private void incarcaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadAgendaFromFile();
            MessageBox.Show("Agenda incarcata cu succes!");
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void domeniuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddDomeniu_Click(sender, e);
        }

        private void proiectToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddProiect_Click(sender, e);
        }

        private void activitateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnAddActivitate_Click(sender, e);
        }

        private void stergereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDomenii.SelectedRows.Count > 0)
            {
                var domeniu = (Domeniu)dgvDomenii.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Sunteti sigur ca doriti sa stergeti '{domeniu.Nume}'?", "Confirmare Stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    agenda.Domenii.Remove(domeniu);
                    dgvProiecte.DataSource = null;
                    dgvActivitati.DataSource = null;
                }
            }
        }

        private void stergereToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDomenii.SelectedRows.Count > 0 && dgvProiecte.SelectedRows.Count > 0)
            {
                var domeniu = (Domeniu)dgvDomenii.SelectedRows[0].DataBoundItem;
                var proiect = (Proiect)dgvProiecte.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Sunteti sigur ca doriti sa stergeti '{proiect.Nume}'?", "Confirmare Stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    domeniu.Proiecte.Remove(proiect);
                    dgvActivitati.DataSource = null;
                }
            }
        }

        private void stergereToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvProiecte.SelectedRows.Count > 0 && dgvActivitati.SelectedRows.Count > 0)
            {
                var proiect = (Proiect)dgvProiecte.SelectedRows[0].DataBoundItem;
                var activitate = (Activitate)dgvActivitati.SelectedRows[0].DataBoundItem;
                if (MessageBox.Show($"Sunteti sigur ca doriti sa stergeti '{activitate.Nume}'?", "Confirmare Stergere", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    proiect.Activitati.Remove(activitate);
                }
            }
        }

        private void editareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDomenii.SelectedRows.Count > 0)
            {
                var domeniu = (Domeniu)dgvDomenii.SelectedRows[0].DataBoundItem;
                var editForm = new EditDomeniuForm(domeniu);
                editForm.ShowDialog();
                dgvDomenii.Refresh();
            }
        }

        private void editareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDomenii.SelectedRows.Count > 0 && dgvProiecte.SelectedRows.Count > 0)
            {
                var proiect = (Proiect)dgvProiecte.SelectedRows[0].DataBoundItem;
                var editForm = new EditProiectForm(proiect);
                editForm.ShowDialog();
                dgvProiecte.Refresh();
            }
        }

        private void editareToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (dgvProiecte.SelectedRows.Count > 0 && dgvActivitati.SelectedRows.Count > 0)
            {
                var activitate = (Activitate)dgvActivitati.SelectedRows[0].DataBoundItem;
                var editForm = new EditActivitateForm(activitate);
                editForm.ShowDialog();
                dgvActivitati.Refresh();
            }
        }
    }
}
