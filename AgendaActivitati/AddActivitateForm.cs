namespace AgendaActivitati
{
    internal class AddActivitateForm : Form
    {
        public Activitate Activitate { get; private set; }

        public AddActivitateForm()
        {
            InitializeComponent();
            KeyPreview = true; 
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);
            if (e.Control && e.KeyCode == Keys.S)
            {
                btnOK.PerformClick(); // Ctrl+S = save
            }
            else if (e.KeyCode == Keys.Escape)
            {
                btnCancel.PerformClick(); // Escape = cancel
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Numele este obligatoriu!");
                return;
            }

            Activitate = new Activitate
            {
                Id = new Random().Next(1, 10000), // ID temporar
                Nume = txtNume.Text,
                Descriere = txtDescriere.Text,
                Data = dtpData.Value,
                Finalizata = chkFinalizata.Checked
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNume = new TextBox();
            label2 = new Label();
            txtDescriere = new TextBox();
            label3 = new Label();
            dtpData = new DateTimePicker();
            label4 = new Label();
            chkFinalizata = new CheckBox();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 32);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Numele activitatii"; 
            // 
            // txtNume
            // 
            txtNume.Location = new Point(27, 55);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(391, 27);
            txtNume.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 106);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "&Descriere"; // Alt+D = txtDescriere
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 191);
            label3.Name = "label3";
            label3.Size = new Size(41, 20);
            label3.TabIndex = 4;
            label3.Text = "D&ata"; // Alt+A = dtpData
            // 
            // dtpData
            // 
            dtpData.Location = new Point(87, 191);
            dtpData.Name = "dtpData";
            dtpData.Size = new Size(331, 27);
            dtpData.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(87, 252);
            label4.Name = "label4";
            label4.Size = new Size(183, 20);
            label4.TabIndex = 6;
            label4.Text = "Activitatea este &finalizata?"; // Alt+F = chkFinalizata
            // 
            // chkFinalizata
            // 
            chkFinalizata.AutoSize = true;
            chkFinalizata.Location = new Point(276, 255);
            chkFinalizata.Name = "chkFinalizata";
            chkFinalizata.Size = new Size(18, 17);
            chkFinalizata.TabIndex = 7;
            chkFinalizata.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(58, 329);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(147, 34);
            btnOK.TabIndex = 8;
            btnOK.Text = "&OK"; // Alt+O = OK
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(235, 329);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 34);
            btnCancel.TabIndex = 9;
            btnCancel.Text = "&Cancel"; // Alt+C = Cancel
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddActivitateForm
            // 
            ClientSize = new Size(452, 429);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(chkFinalizata);
            Controls.Add(label4);
            Controls.Add(dtpData);
            Controls.Add(label3);
            Controls.Add(txtDescriere);
            Controls.Add(label2);
            Controls.Add(txtNume);
            Controls.Add(label1);
            Name = "AddActivitateForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private Label label1;
        private TextBox txtNume;
        private TextBox txtDescriere;
        private Label label3;
        private DateTimePicker dtpData;
        private Label label4;
        private CheckBox chkFinalizata;
        private Button btnOK;
        private Button btnCancel;
        private Label label2;
    }
}