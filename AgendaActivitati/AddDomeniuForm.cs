namespace AgendaActivitati
{
    internal class AddDomeniuForm : Form
    {
        public Domeniu Domeniu { get; private set; }

        public AddDomeniuForm()
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

            Domeniu = new Domeniu
            {
                Id = new Random().Next(1, 10000), // ID temporar
                Nume = txtNume.Text,
                Descriere = txtDescriere.Text
            };
            DialogResult = DialogResult.OK;
            Close();
        }

        private void InitializeComponent()
        {
            txtNume = new TextBox();
            txtDescriere = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnOK = new Button();
            btnCancel = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 61);
            label1.Name = "label1";
            label1.Size = new Size(202, 20);
            label1.TabIndex = 0;
            label1.Text = "Adaugati numele domeniului"; 
            // 
            // txtNume
            // 
            txtNume.Location = new Point(21, 84);
            txtNume.Name = "txtNume";
            txtNume.Size = new Size(388, 27);
            txtNume.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 143);
            label2.Name = "label2";
            label2.Size = new Size(71, 20);
            label2.TabIndex = 2;
            label2.Text = "&Descriere"; // Alt+D = txtDescriere
            // 
            // txtDescriere
            // 
            txtDescriere.Location = new Point(22, 166);
            txtDescriere.Name = "txtDescriere";
            txtDescriere.Size = new Size(387, 27);
            txtDescriere.TabIndex = 3;
            // 
            // btnOK
            // 
            btnOK.Location = new Point(40, 262);
            btnOK.Name = "btnOK";
            btnOK.Size = new Size(155, 36);
            btnOK.TabIndex = 4;
            btnOK.Text = "&OK"; // Alt+O = OK
            btnOK.UseVisualStyleBackColor = true;
            btnOK.Click += btnOK_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(221, 262);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(155, 36);
            btnCancel.TabIndex = 5;
            btnCancel.Text = "&Cancel"; // Alt+C = Cancel
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddDomeniuForm
            // 
            ClientSize = new Size(437, 345);
            Controls.Add(btnCancel);
            Controls.Add(btnOK);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtDescriere);
            Controls.Add(txtNume);
            Name = "AddDomeniuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private TextBox txtNume;
        private TextBox txtDescriere;
        private Label label1;
        private Label label2;
        private Button btnCancel;
        private Button btnOK;
    }
}