namespace AgendaActivitati
{
    internal class EditProiectForm : Form
    {
        private Proiect proiect; 
        private Label label1;
        private TextBox txtNume;
        private Label label2;
        private DateTimePicker dtpDataInceput;
        private Label label3;
        private DateTimePicker dtpDataSfarsit;
        private Button btnCancel;
        private Button btnOK;

        public EditProiectForm(Proiect proiect)
        {
            this.proiect = proiect; 
            InitializeComponent();
            KeyPreview = true;

            txtNume.Text = proiect.Nume;
            dtpDataInceput.Value = proiect.DataInceput;
            dtpDataSfarsit.Value = proiect.DataSfarsit;
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
                btnCancel.PerformClick(); // Esc = cancel
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNume.Text))
            {
                MessageBox.Show("Numele este obligatoriu!");
                return;
            }
            if (dtpDataSfarsit.Value < dtpDataInceput.Value)
            {
                MessageBox.Show("Data de sfârșit trebuie să fie după data de început!");
                return;
            }
            
            proiect.Nume = txtNume.Text;
            proiect.DataInceput = dtpDataInceput.Value;
            proiect.DataSfarsit = dtpDataSfarsit.Value;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void InitializeComponent()
        {
            label1 = new Label();
            txtNume = new TextBox();
            label2 = new Label();
            dtpDataInceput = new DateTimePicker();
            label3 = new Label();
            dtpDataSfarsit = new DateTimePicker();
            btnCancel = new Button();
            btnOK = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 62);
            label1.Name = "label1";
            label1.Size = new Size(198, 20);
            label1.TabIndex = 0;
            label1.Text = "Numele proiectului";
            // 
            // txtNume
            // 
            txtNume.Location = new Point(30, 85);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(312, 27);
            txtNume.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 148);
            label2.Name = "label2";
            label2.Size = new Size(115, 20);
            label2.TabIndex = 2;
            label2.Text = "Data de &inceput"; // Alt+I = dtpDataInceput
            // 
            // dtpDataInceput
            // 
            dtpDataInceput.Location = new Point(30, 171);
            dtpDataInceput.Name = "dtpDataInceput";
            dtpDataInceput.Size = new Size(312, 27);
            dtpDataInceput.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 236);
            label3.Name = "label3";
            label3.Size = new Size(105, 20);
            label3.TabIndex = 4;
            label3.Text = "Data de &sfarsit"; // Alt+S = dtpDataSfarsit
            // 
            // dtpDataSfarsit
            // 
            dtpDataSfarsit.Location = new Point(30, 259);
            dtpDataSfarsit.Name = "dtpDataSfarsit";
            dtpDataSfarsit.Size = new Size(312, 27);
            dtpDataSfarsit.TabIndex = 5;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(195, 371);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(147, 34);
            btnCancel.TabIndex = 6;
            btnCancel.Text = "&Cancel"; // Alt+C = Cancel
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(30, 371);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(136, 34);
            btnOK.TabIndex = 7;
            btnOK.Text = "&OK"; // Alt+O = OK
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // EditProiectForm
            // 
            ClientSize = new Size(370, 483);
            Controls.Add(btnOK);
            Controls.Add(btnCancel);
            Controls.Add(dtpDataSfarsit);
            Controls.Add(label3);
            Controls.Add(dtpDataInceput);
            Controls.Add(label2);
            Controls.Add(txtNume);
            Controls.Add(label1);
            Name = "EditProiectForm";
            Text = "Editeaza Proiect"; 
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}