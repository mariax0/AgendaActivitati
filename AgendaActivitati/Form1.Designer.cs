namespace AgendaActivitati
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
                this.chartPanel?.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            tabControl1 = new TabControl();
            tabPage2 = new TabPage();
            btnAddDomeniu = new Button();
            dgvDomenii = new DataGridView();
            contextMenuDomenii = new ContextMenuStrip(components);
            stergereToolStripMenuItem = new ToolStripMenuItem();
            editareToolStripMenuItem = new ToolStripMenuItem();
            tabPage1 = new TabPage();
            btnAddProiect = new Button();
            dgvProiecte = new DataGridView();
            contextMenuProiecte = new ContextMenuStrip(components);
            stergereToolStripMenuItem1 = new ToolStripMenuItem();
            editareToolStripMenuItem1 = new ToolStripMenuItem();
            tabPage3 = new TabPage();
            btnAddActivitate = new Button();
            dgvActivitati = new DataGridView();
            contextMenuActivitati = new ContextMenuStrip(components);
            stergereToolStripMenuItem2 = new ToolStripMenuItem();
            editareToolStripMenuItem2 = new ToolStripMenuItem();
            tabPage4 = new TabPage();
            chartPanel = new Panel();
            btnSave = new Button();
            btnLoad = new Button();
            menuStrip = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            salveazaToolStripMenuItem = new ToolStripMenuItem();
            incarcaToolStripMenuItem = new ToolStripMenuItem();
            eToolStripMenuItem = new ToolStripMenuItem();
            adaugaDateToolStripMenuItem = new ToolStripMenuItem();
            domeniuToolStripMenuItem = new ToolStripMenuItem();
            proiectToolStripMenuItem = new ToolStripMenuItem();
            activitateToolStripMenuItem = new ToolStripMenuItem();
            btnPrint = new Button();
            tabControl1.SuspendLayout();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvDomenii).BeginInit();
            contextMenuDomenii.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProiecte).BeginInit();
            contextMenuProiecte.SuspendLayout();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvActivitati).BeginInit();
            contextMenuActivitati.SuspendLayout();
            tabPage4.SuspendLayout();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Location = new Point(0, 31);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(708, 448);
            tabControl1.TabIndex = 0;
            tabControl1.SelectedIndexChanged += tabControl1_SelectedIndexChanged;
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnAddDomeniu);
            tabPage2.Controls.Add(dgvDomenii);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(700, 415);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Domenii";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnAddDomeniu
            // 
            btnAddDomeniu.Location = new Point(193, 360);
            btnAddDomeniu.Name = "btnAddDomeniu";
            btnAddDomeniu.Size = new Size(291, 44);
            btnAddDomeniu.TabIndex = 2;
            btnAddDomeniu.Text = "Adauga domeniu";
            btnAddDomeniu.UseVisualStyleBackColor = true;
            btnAddDomeniu.Click += btnAddDomeniu_Click;
            // 
            // dgvDomenii
            // 
            dgvDomenii.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDomenii.ContextMenuStrip = contextMenuDomenii;
            dgvDomenii.Location = new Point(6, 6);
            dgvDomenii.Name = "dgvDomenii";
            dgvDomenii.RowHeadersWidth = 51;
            dgvDomenii.Size = new Size(688, 348);
            dgvDomenii.TabIndex = 0;
            dgvDomenii.SelectionChanged += dgvDomenii_SelectionChanged;
            // 
            // contextMenuDomenii
            // 
            contextMenuDomenii.ImageScalingSize = new Size(20, 20);
            contextMenuDomenii.Items.AddRange(new ToolStripItem[] { stergereToolStripMenuItem, editareToolStripMenuItem });
            contextMenuDomenii.Name = "contextMenuDomenii";
            contextMenuDomenii.Size = new Size(135, 52);
            // 
            // stergereToolStripMenuItem
            // 
            stergereToolStripMenuItem.Name = "stergereToolStripMenuItem";
            stergereToolStripMenuItem.Size = new Size(134, 24);
            stergereToolStripMenuItem.Text = "Stergere";
            stergereToolStripMenuItem.Click += stergereToolStripMenuItem_Click;
            // 
            // editareToolStripMenuItem
            // 
            editareToolStripMenuItem.Name = "editareToolStripMenuItem";
            editareToolStripMenuItem.Size = new Size(134, 24);
            editareToolStripMenuItem.Text = "Editare";
            editareToolStripMenuItem.Click += editareToolStripMenuItem_Click;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnAddProiect);
            tabPage1.Controls.Add(dgvProiecte);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(700, 415);
            tabPage1.TabIndex = 2;
            tabPage1.Text = "Proiecte";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnAddProiect
            // 
            btnAddProiect.Location = new Point(195, 360);
            btnAddProiect.Name = "btnAddProiect";
            btnAddProiect.Size = new Size(283, 44);
            btnAddProiect.TabIndex = 1;
            btnAddProiect.Text = "Adauga proiect";
            btnAddProiect.UseVisualStyleBackColor = true;
            btnAddProiect.Click += btnAddProiect_Click;
            // 
            // dgvProiecte
            // 
            dgvProiecte.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProiecte.ContextMenuStrip = contextMenuProiecte;
            dgvProiecte.Location = new Point(6, 6);
            dgvProiecte.Name = "dgvProiecte";
            dgvProiecte.RowHeadersWidth = 51;
            dgvProiecte.Size = new Size(688, 348);
            dgvProiecte.TabIndex = 0;
            dgvProiecte.SelectionChanged += dgvProiecte_SelectionChanged;
            // 
            // contextMenuProiecte
            // 
            contextMenuProiecte.ImageScalingSize = new Size(20, 20);
            contextMenuProiecte.Items.AddRange(new ToolStripItem[] { stergereToolStripMenuItem1, editareToolStripMenuItem1 });
            contextMenuProiecte.Name = "contextMenuProiecte";
            contextMenuProiecte.Size = new Size(135, 52);
            // 
            // stergereToolStripMenuItem1
            // 
            stergereToolStripMenuItem1.Name = "stergereToolStripMenuItem1";
            stergereToolStripMenuItem1.Size = new Size(134, 24);
            stergereToolStripMenuItem1.Text = "Stergere";
            stergereToolStripMenuItem1.Click += stergereToolStripMenuItem1_Click;
            // 
            // editareToolStripMenuItem1
            // 
            editareToolStripMenuItem1.Name = "editareToolStripMenuItem1";
            editareToolStripMenuItem1.Size = new Size(134, 24);
            editareToolStripMenuItem1.Text = "Editare";
            editareToolStripMenuItem1.Click += editareToolStripMenuItem1_Click;
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(btnAddActivitate);
            tabPage3.Controls.Add(dgvActivitati);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(700, 415);
            tabPage3.TabIndex = 3;
            tabPage3.Text = "Activitati";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnAddActivitate
            // 
            btnAddActivitate.Location = new Point(192, 361);
            btnAddActivitate.Name = "btnAddActivitate";
            btnAddActivitate.Size = new Size(288, 44);
            btnAddActivitate.TabIndex = 2;
            btnAddActivitate.Text = "Adauga activitate";
            btnAddActivitate.UseVisualStyleBackColor = true;
            btnAddActivitate.Click += btnAddActivitate_Click;
            // 
            // dgvActivitati
            // 
            dgvActivitati.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvActivitati.ContextMenuStrip = contextMenuActivitati;
            dgvActivitati.Location = new Point(6, 6);
            dgvActivitati.Name = "dgvActivitati";
            dgvActivitati.RowHeadersWidth = 51;
            dgvActivitati.Size = new Size(687, 349);
            dgvActivitati.TabIndex = 0;
            // 
            // contextMenuActivitati
            // 
            contextMenuActivitati.ImageScalingSize = new Size(20, 20);
            contextMenuActivitati.Items.AddRange(new ToolStripItem[] { stergereToolStripMenuItem2, editareToolStripMenuItem2 });
            contextMenuActivitati.Name = "contextMenuActivitati";
            contextMenuActivitati.Size = new Size(135, 52);
            // 
            // stergereToolStripMenuItem2
            // 
            stergereToolStripMenuItem2.Name = "stergereToolStripMenuItem2";
            stergereToolStripMenuItem2.Size = new Size(134, 24);
            stergereToolStripMenuItem2.Text = "Stergere";
            stergereToolStripMenuItem2.Click += stergereToolStripMenuItem2_Click;
            // 
            // editareToolStripMenuItem2
            // 
            editareToolStripMenuItem2.Name = "editareToolStripMenuItem2";
            editareToolStripMenuItem2.Size = new Size(134, 24);
            editareToolStripMenuItem2.Text = "Editare";
            editareToolStripMenuItem2.Click += editareToolStripMenuItem2_Click;
            // 
            // tabPage4
            // 
            tabPage4.Controls.Add(chartPanel);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(700, 415);
            tabPage4.TabIndex = 4;
            tabPage4.Text = "Statistici";
            tabPage4.UseVisualStyleBackColor = true;
            // 
            // chartPanel
            // 
            chartPanel.Location = new Point(3, 3);
            chartPanel.Name = "chartPanel";
            chartPanel.Size = new Size(691, 409);
            chartPanel.TabIndex = 0;
            chartPanel.Paint += chartPanel_Paint;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(12, 485);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(199, 44);
            btnSave.TabIndex = 2;
            btnSave.Text = "Salveaza date";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // btnLoad
            // 
            btnLoad.Location = new Point(252, 485);
            btnLoad.Name = "btnLoad";
            btnLoad.Size = new Size(199, 44);
            btnLoad.TabIndex = 3;
            btnLoad.Text = "Incarca date";
            btnLoad.UseVisualStyleBackColor = true;
            // 
            // menuStrip
            // 
            menuStrip.BackColor = SystemColors.Control;
            menuStrip.Dock = DockStyle.None;
            menuStrip.ImageScalingSize = new Size(20, 20);
            menuStrip.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, adaugaDateToolStripMenuItem });
            menuStrip.Location = new Point(524, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(174, 28);
            menuStrip.TabIndex = 4;
            menuStrip.Text = "menuStrip";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.BackColor = SystemColors.ControlDark;
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salveazaToolStripMenuItem, incarcaToolStripMenuItem, eToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(57, 24);
            fisierToolStripMenuItem.Text = "&Fisier";
            // 
            // salveazaToolStripMenuItem
            // 
            salveazaToolStripMenuItem.Name = "salveazaToolStripMenuItem";
            salveazaToolStripMenuItem.Size = new Size(224, 26);
            salveazaToolStripMenuItem.Text = "Salvare date";
            salveazaToolStripMenuItem.Click += salveazaToolStripMenuItem_Click;
            // 
            // incarcaToolStripMenuItem
            // 
            incarcaToolStripMenuItem.Name = "incarcaToolStripMenuItem";
            incarcaToolStripMenuItem.Size = new Size(224, 26);
            incarcaToolStripMenuItem.Text = "Incarcare date";
            incarcaToolStripMenuItem.Click += incarcaToolStripMenuItem_Click;
            // 
            // eToolStripMenuItem
            // 
            eToolStripMenuItem.Name = "eToolStripMenuItem";
            eToolStripMenuItem.Size = new Size(224, 26);
            eToolStripMenuItem.Text = "Inchidere";
            eToolStripMenuItem.Click += eToolStripMenuItem_Click;
            // 
            // adaugaDateToolStripMenuItem
            // 
            adaugaDateToolStripMenuItem.BackColor = SystemColors.ControlDark;
            adaugaDateToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { domeniuToolStripMenuItem, proiectToolStripMenuItem, activitateToolStripMenuItem });
            adaugaDateToolStripMenuItem.Name = "adaugaDateToolStripMenuItem";
            adaugaDateToolStripMenuItem.Size = new Size(109, 24);
            adaugaDateToolStripMenuItem.Text = "&Adauga date";
            // 
            // domeniuToolStripMenuItem
            // 
            domeniuToolStripMenuItem.Name = "domeniuToolStripMenuItem";
            domeniuToolStripMenuItem.Size = new Size(155, 26);
            domeniuToolStripMenuItem.Text = "Domeniu";
            domeniuToolStripMenuItem.Click += domeniuToolStripMenuItem_Click;
            // 
            // proiectToolStripMenuItem
            // 
            proiectToolStripMenuItem.Name = "proiectToolStripMenuItem";
            proiectToolStripMenuItem.Size = new Size(155, 26);
            proiectToolStripMenuItem.Text = "Proiect";
            proiectToolStripMenuItem.Click += proiectToolStripMenuItem_Click;
            // 
            // activitateToolStripMenuItem
            // 
            activitateToolStripMenuItem.Name = "activitateToolStripMenuItem";
            activitateToolStripMenuItem.Size = new Size(155, 26);
            activitateToolStripMenuItem.Text = "Activitate";
            activitateToolStripMenuItem.Click += activitateToolStripMenuItem_Click;
            // 
            // btnPrint
            // 
            btnPrint.Location = new Point(489, 485);
            btnPrint.Name = "btnPrint";
            btnPrint.Size = new Size(199, 44);
            btnPrint.TabIndex = 5;
            btnPrint.Text = "Printeaza date";
            btnPrint.UseVisualStyleBackColor = true;
            btnPrint.Click += btnPrint_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(709, 541);
            Controls.Add(btnPrint);
            Controls.Add(btnLoad);
            Controls.Add(tabControl1);
            Controls.Add(btnSave);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "Form1";
            Text = "Agenda";
            tabControl1.ResumeLayout(false);
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvDomenii).EndInit();
            contextMenuDomenii.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProiecte).EndInit();
            contextMenuProiecte.ResumeLayout(false);
            tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvActivitati).EndInit();
            contextMenuActivitati.ResumeLayout(false);
            tabPage4.ResumeLayout(false);
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage2;
        private DataGridView dgvDomenii;
        private TabPage tabPage1;
        private DataGridView dgvProiecte;
        private TabPage tabPage3;
        private DataGridView dgvActivitati;
        private Button btnAddDomeniu;
        private Button btnAddProiect;
        private Button btnAddActivitate;
        private Button btnSave;
        private Button btnLoad;
        private MenuStrip menuStrip;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem salveazaToolStripMenuItem;
        private ToolStripMenuItem incarcaToolStripMenuItem;
        private ToolStripMenuItem adaugaDateToolStripMenuItem;
        private ToolStripMenuItem eToolStripMenuItem;
        private ToolStripMenuItem domeniuToolStripMenuItem;
        private ToolStripMenuItem proiectToolStripMenuItem;
        private ToolStripMenuItem activitateToolStripMenuItem;
        private ContextMenuStrip contextMenuDomenii;
        private ContextMenuStrip contextMenuProiecte;
        private ContextMenuStrip contextMenuActivitati;
        private ToolStripMenuItem stergereToolStripMenuItem;
        private ToolStripMenuItem editareToolStripMenuItem;
        private ToolStripMenuItem stergereToolStripMenuItem1;
        private ToolStripMenuItem editareToolStripMenuItem1;
        private ToolStripMenuItem stergereToolStripMenuItem2;
        private ToolStripMenuItem editareToolStripMenuItem2;
        private Button btnPrint;
        private TabPage tabPage4;
        private Panel chartPanel;
    }
}
