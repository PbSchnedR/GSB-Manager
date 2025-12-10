namespace GSB_Manager.Forms
{
    partial class UserForm
    {
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabMedicines;
        private System.Windows.Forms.TabPage tabPrescriptions;
        private System.Windows.Forms.TabPage tabPatients;

        // Components for Medicines
        private System.Windows.Forms.ListBox listMedicines;
        private System.Windows.Forms.Panel panelMedicineDetails;
        private System.Windows.Forms.Button btnAddMedicine;
        private System.Windows.Forms.Button btnEditMedicine;
        private System.Windows.Forms.Button btnDeleteMedicine;

        // Components for Prescriptions
        private System.Windows.Forms.ListBox listPrescriptions;
        private System.Windows.Forms.Panel panelPrescriptionDetails;
        private System.Windows.Forms.Button btnAddPrescription;
        private System.Windows.Forms.Button btnEditPrescription;
        private System.Windows.Forms.Button btnDeletePrescription;

        // Components for Patients
        private System.Windows.Forms.ListBox listPatients;
        private System.Windows.Forms.Panel panelPatientDetails;
        private System.Windows.Forms.Button btnAddPatient;
        private System.Windows.Forms.Button btnEditPatient;
        private System.Windows.Forms.Button btnDeletePatient;

        // Taille de référence (la taille par défaut)
        private readonly Size referenceSize = new Size(1200, 700);

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tabControl = new TabControl();
            tabMedicines = new TabPage();
            buttonMedicineModify = new Button();
            buttonMedicineCancel = new Button();
            buttonMedicineRegister = new Button();
            panelMedicineDetails = new Panel();
            textBoxMedicineName = new TextBox();
            labelMedicineName = new Label();
            labelMedicineDoctor = new Label();
            textBoxMedicineDescription = new TextBox();
            textBoxMedicineMolecule = new TextBox();
            textBoxMedicineDosage = new TextBox();
            labelMedicineMolecule = new Label();
            labelMedicineDescription = new Label();
            labelMedicineDosage = new Label();
            labelMedicine = new Label();
            listMedicines = new ListBox();
            btnAddMedicine = new Button();
            btnEditMedicine = new Button();
            btnDeleteMedicine = new Button();
            tabPrescriptions = new TabPage();
            buttonPrescriptionGenerate = new Button();
            buttonPrescriptionModify = new Button();
            buttonPrescriptionCancel = new Button();
            buttonPrescriptionRegister = new Button();
            panelPrescriptionDetails = new Panel();
            dataPrescriptionMedicines = new DataGridView();
            dateTimePickerPrescriptionValidity = new DateTimePicker();
            comboBoxPrescriptionPatient = new ComboBox();
            comboBoxPrescriptionMedicine = new ComboBox();
            textBoxPrescriptionPatient = new TextBox();
            labelPrescriptionPatient = new Label();
            textBoxPrescriptionDoctor = new TextBox();
            textBoxPrescriptionValidity = new TextBox();
            labelPrescriptionValidity = new Label();
            labelPrescriptionMedicines = new Label();
            labelPrescriptionDoctor = new Label();
            labelPrescription = new Label();
            listPrescriptions = new ListBox();
            btnAddPrescription = new Button();
            btnEditPrescription = new Button();
            btnDeletePrescription = new Button();
            tabPatients = new TabPage();
            buttonPatientModify = new Button();
            buttonPatientCancel = new Button();
            buttonPatientRegister = new Button();
            panelPatientDetails = new Panel();
            labelPatientFirstname = new Label();
            textBoxPatientFirstname = new TextBox();
            textBoxPatientName = new TextBox();
            labelPatientName = new Label();
            comboBoxPatientGender = new ComboBox();
            textBoxPatientAge = new TextBox();
            textBoxPatientDoctor = new TextBox();
            textBoxPatientGender = new TextBox();
            labelPatientGender = new Label();
            labelPatientAge = new Label();
            label2 = new Label();
            labelPatientDoctor = new Label();
            labelPatient = new Label();
            listPatients = new ListBox();
            btnAddPatient = new Button();
            btnEditPatient = new Button();
            btnDeletePatient = new Button();
            tabPageManager = new TabPage();
            buttonUserDelete = new Button();
            buttonUserModify = new Button();
            buttonUserCancel = new Button();
            buttonUserRegister = new Button();
            panel1 = new Panel();
            labelUserPassword = new Label();
            textBoxUserPassword = new TextBox();
            labelUserFirstname = new Label();
            textBoxUserFirstname = new TextBox();
            textBoxUserName = new TextBox();
            labelUserName = new Label();
            comboBoxUserRole = new ComboBox();
            textBoxUserEmail = new TextBox();
            textBoxUserRole = new TextBox();
            labelUserRole = new Label();
            labelUserEmail = new Label();
            label7 = new Label();
            label6 = new Label();
            labelUser = new Label();
            listUsers = new ListBox();
            buttonUserAdd = new Button();
            buttonUserEdit = new Button();

            tabControl.SuspendLayout();
            tabMedicines.SuspendLayout();
            panelMedicineDetails.SuspendLayout();
            tabPrescriptions.SuspendLayout();
            panelPrescriptionDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataPrescriptionMedicines).BeginInit();
            tabPatients.SuspendLayout();
            panelPatientDetails.SuspendLayout();
            tabPageManager.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();

            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1200, 700);
            BackColor = Color.FromArgb(15, 23, 42);
            MinimumSize = new Size(800, 600);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserForm";
            Text = "GSB Manager - Dashboard";
            Resize += UserForm_Resize;

            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMedicines);
            tabControl.Controls.Add(tabPrescriptions);
            tabControl.Controls.Add(tabPatients);
            tabControl.Controls.Add(tabPageManager);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(1200, 700);
            tabControl.TabIndex = 0;
            tabControl.ItemSize = new Size(120, 40);
            tabControl.SizeMode = TabSizeMode.Fixed;
            tabControl.Font = new Font("Segoe UI Semibold", 11F, FontStyle.Bold, GraphicsUnit.Point);
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabControl.DrawItem += tabControl_DrawItem;
            tabControl.BackColor = Color.FromArgb(15, 23, 42);
            tabControl.Paint += tabControl_Paint;

            // Appliquer le style dark à tous les onglets
            ApplyDarkThemeToTab(tabMedicines, "Medicines");
            ApplyDarkThemeToTab(tabPrescriptions, "Prescriptions");
            ApplyDarkThemeToTab(tabPatients, "Patients");
            ApplyDarkThemeToTab(tabPageManager, "Manager");

            // MEDICINES TAB
            SetupMedicinesTab();

            // PRESCRIPTIONS TAB
            SetupPrescriptionsTab();

            // PATIENTS TAB
            SetupPatientsTab();

            // MANAGER TAB
            SetupManagerTab();

            tabControl.ResumeLayout(false);
            tabMedicines.ResumeLayout(false);
            panelMedicineDetails.ResumeLayout(false);
            panelMedicineDetails.PerformLayout();
            tabPrescriptions.ResumeLayout(false);
            panelPrescriptionDetails.ResumeLayout(false);
            panelPrescriptionDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataPrescriptionMedicines).EndInit();
            tabPatients.ResumeLayout(false);
            panelPatientDetails.ResumeLayout(false);
            panelPatientDetails.PerformLayout();
            tabPageManager.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        private void ApplyDarkThemeToTab(TabPage tab, string title)
        {
            tab.BackColor = Color.FromArgb(15, 23, 42);
            tab.ForeColor = Color.FromArgb(226, 232, 240);
            tab.Text = title;
            tab.UseVisualStyleBackColor = true;
        }

        private void SetupMedicinesTab()
        {
            tabMedicines.Controls.Add(buttonMedicineModify);
            tabMedicines.Controls.Add(buttonMedicineCancel);
            tabMedicines.Controls.Add(buttonMedicineRegister);
            tabMedicines.Controls.Add(panelMedicineDetails);
            tabMedicines.Controls.Add(listMedicines);
            tabMedicines.Controls.Add(btnAddMedicine);
            tabMedicines.Controls.Add(btnEditMedicine);
            tabMedicines.Controls.Add(btnDeleteMedicine);

            // panelMedicineDetails
            panelMedicineDetails.BackColor = Color.FromArgb(30, 41, 59);
            panelMedicineDetails.BorderStyle = BorderStyle.None;
            panelMedicineDetails.Location = new Point(20, 20);
            panelMedicineDetails.Size = new Size(500, 550);
            panelMedicineDetails.Paint += panel_Paint;

            // labelMedicine (titre)
            labelMedicine.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicine.ForeColor = Color.FromArgb(226, 232, 240);
            labelMedicine.Location = new Point(20, 20);
            labelMedicine.AutoSize = true;
            labelMedicine.Text = "Medicine Details";

            // Labels et TextBox dans le panel
            SetupMedicineControls();

            // listMedicines
            listMedicines.BackColor = Color.FromArgb(30, 41, 59);
            listMedicines.ForeColor = Color.FromArgb(226, 232, 240);
            listMedicines.BorderStyle = BorderStyle.None;
            listMedicines.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            listMedicines.Location = new Point(550, 20);
            listMedicines.Size = new Size(600, 480);
            listMedicines.SelectedIndexChanged += listMedicines_SelectedIndexChanged;

            // Boutons
            SetupMedicineButtons();
        }

        private void SetupMedicineControls()
        {
            // labelMedicineDosage
            labelMedicineDosage.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicineDosage.ForeColor = Color.FromArgb(148, 163, 184);
            labelMedicineDosage.Location = new Point(25, 70);
            labelMedicineDosage.AutoSize = true;
            labelMedicineDosage.Text = "Dosage :";

            textBoxMedicineDosage.BackColor = Color.FromArgb(51, 65, 85);
            textBoxMedicineDosage.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxMedicineDosage.BorderStyle = BorderStyle.FixedSingle;
            textBoxMedicineDosage.Font = new Font("Segoe UI", 10F);
            textBoxMedicineDosage.Location = new Point(25, 95);
            textBoxMedicineDosage.Size = new Size(200, 27);
            textBoxMedicineDosage.ReadOnly = true;

            // labelMedicineDescription
            labelMedicineDescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicineDescription.ForeColor = Color.FromArgb(148, 163, 184);
            labelMedicineDescription.Location = new Point(25, 140);
            labelMedicineDescription.AutoSize = true;
            labelMedicineDescription.Text = "Description :";

            textBoxMedicineDescription.BackColor = Color.FromArgb(51, 65, 85);
            textBoxMedicineDescription.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxMedicineDescription.BorderStyle = BorderStyle.FixedSingle;
            textBoxMedicineDescription.Font = new Font("Segoe UI", 10F);
            textBoxMedicineDescription.Location = new Point(25, 165);
            textBoxMedicineDescription.Size = new Size(450, 100);
            textBoxMedicineDescription.Multiline = true;
            textBoxMedicineDescription.ReadOnly = true;

            // labelMedicineMolecule
            labelMedicineMolecule.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicineMolecule.ForeColor = Color.FromArgb(148, 163, 184);
            labelMedicineMolecule.Location = new Point(25, 285);
            labelMedicineMolecule.AutoSize = true;
            labelMedicineMolecule.Text = "Molecule :";

            textBoxMedicineMolecule.BackColor = Color.FromArgb(51, 65, 85);
            textBoxMedicineMolecule.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxMedicineMolecule.BorderStyle = BorderStyle.FixedSingle;
            textBoxMedicineMolecule.Font = new Font("Segoe UI", 10F);
            textBoxMedicineMolecule.Location = new Point(25, 310);
            textBoxMedicineMolecule.Size = new Size(300, 27);
            textBoxMedicineMolecule.ReadOnly = true;

            // labelMedicineName
            labelMedicineName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point);
            labelMedicineName.ForeColor = Color.FromArgb(148, 163, 184);
            labelMedicineName.Location = new Point(25, 355);
            labelMedicineName.AutoSize = true;
            labelMedicineName.Text = "Name :";
            labelMedicineName.Visible = false;

            textBoxMedicineName.BackColor = Color.FromArgb(51, 65, 85);
            textBoxMedicineName.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxMedicineName.BorderStyle = BorderStyle.FixedSingle;
            textBoxMedicineName.Font = new Font("Segoe UI", 10F);
            textBoxMedicineName.Location = new Point(25, 380);
            textBoxMedicineName.Size = new Size(300, 27);
            textBoxMedicineName.Visible = false;

            labelMedicineDoctor.AutoSize = true;
            labelMedicineDoctor.Location = new Point(25, 420);
            labelMedicineDoctor.Text = "";

            panelMedicineDetails.Controls.Add(labelMedicine);
            panelMedicineDetails.Controls.Add(labelMedicineDosage);
            panelMedicineDetails.Controls.Add(textBoxMedicineDosage);
            panelMedicineDetails.Controls.Add(labelMedicineDescription);
            panelMedicineDetails.Controls.Add(textBoxMedicineDescription);
            panelMedicineDetails.Controls.Add(labelMedicineMolecule);
            panelMedicineDetails.Controls.Add(textBoxMedicineMolecule);
            panelMedicineDetails.Controls.Add(labelMedicineName);
            panelMedicineDetails.Controls.Add(textBoxMedicineName);
            panelMedicineDetails.Controls.Add(labelMedicineDoctor);
        }

        private void SetupMedicineButtons()
        {
            // Style pour tous les boutons
            btnAddMedicine.FlatStyle = FlatStyle.Flat;
            btnAddMedicine.FlatAppearance.BorderSize = 0;
            btnAddMedicine.BackColor = Color.FromArgb(16, 185, 129);
            btnAddMedicine.ForeColor = Color.White;
            btnAddMedicine.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddMedicine.Location = new Point(550, 520);
            btnAddMedicine.Size = new Size(100, 40);
            btnAddMedicine.Text = "Add";
            btnAddMedicine.Cursor = Cursors.Hand;
            btnAddMedicine.Click += btnAddMedicine_Click;
            StyleButton(btnAddMedicine);

            btnEditMedicine.FlatStyle = FlatStyle.Flat;
            btnEditMedicine.FlatAppearance.BorderSize = 0;
            btnEditMedicine.BackColor = Color.FromArgb(59, 130, 246);
            btnEditMedicine.ForeColor = Color.White;
            btnEditMedicine.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEditMedicine.Location = new Point(660, 520);
            btnEditMedicine.Size = new Size(100, 40);
            btnEditMedicine.Text = "Edit";
            btnEditMedicine.Cursor = Cursors.Hand;
            btnEditMedicine.Click += btnEditMedicine_Click;
            StyleButton(btnEditMedicine);

            btnDeleteMedicine.FlatStyle = FlatStyle.Flat;
            btnDeleteMedicine.FlatAppearance.BorderSize = 0;
            btnDeleteMedicine.BackColor = Color.FromArgb(239, 68, 68);
            btnDeleteMedicine.ForeColor = Color.White;
            btnDeleteMedicine.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDeleteMedicine.Location = new Point(770, 520);
            btnDeleteMedicine.Size = new Size(100, 40);
            btnDeleteMedicine.Text = "Delete";
            btnDeleteMedicine.Cursor = Cursors.Hand;
            btnDeleteMedicine.Click += btnDeleteMedicine_Click;
            StyleButton(btnDeleteMedicine);

            // Boutons d'action spéciaux
            buttonMedicineRegister.FlatStyle = FlatStyle.Flat;
            buttonMedicineRegister.FlatAppearance.BorderSize = 0;
            buttonMedicineRegister.BackColor = Color.FromArgb(16, 185, 129);
            buttonMedicineRegister.ForeColor = Color.White;
            buttonMedicineRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonMedicineRegister.Location = new Point(30, 590);
            buttonMedicineRegister.Size = new Size(130, 40);
            buttonMedicineRegister.Text = "Register";
            buttonMedicineRegister.Cursor = Cursors.Hand;
            buttonMedicineRegister.Visible = false;
            buttonMedicineRegister.Click += buttonMedicineRegister_Click;
            StyleButton(buttonMedicineRegister);

            buttonMedicineModify.FlatStyle = FlatStyle.Flat;
            buttonMedicineModify.FlatAppearance.BorderSize = 0;
            buttonMedicineModify.BackColor = Color.FromArgb(16, 185, 129);
            buttonMedicineModify.ForeColor = Color.White;
            buttonMedicineModify.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonMedicineModify.Location = new Point(30, 590);
            buttonMedicineModify.Size = new Size(130, 40);
            buttonMedicineModify.Text = "Modify";
            buttonMedicineModify.Cursor = Cursors.Hand;
            buttonMedicineModify.Visible = false;
            buttonMedicineModify.Click += buttonMedicineModify_Click;
            StyleButton(buttonMedicineModify);

            buttonMedicineCancel.FlatStyle = FlatStyle.Flat;
            buttonMedicineCancel.FlatAppearance.BorderSize = 0;
            buttonMedicineCancel.BackColor = Color.FromArgb(100, 116, 139);
            buttonMedicineCancel.ForeColor = Color.White;
            buttonMedicineCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonMedicineCancel.Location = new Point(170, 590);
            buttonMedicineCancel.Size = new Size(130, 40);
            buttonMedicineCancel.Text = "Cancel";
            buttonMedicineCancel.Cursor = Cursors.Hand;
            buttonMedicineCancel.Visible = false;
            buttonMedicineCancel.Click += buttonMedicineCancel_Click;
            StyleButton(buttonMedicineCancel);
        }

        private void SetupPrescriptionsTab()
        {
            // Configuration similaire aux Medicines mais adaptée aux Prescriptions
            tabPrescriptions.Controls.Add(buttonPrescriptionGenerate);
            tabPrescriptions.Controls.Add(buttonPrescriptionModify);
            tabPrescriptions.Controls.Add(buttonPrescriptionCancel);
            tabPrescriptions.Controls.Add(buttonPrescriptionRegister);
            tabPrescriptions.Controls.Add(panelPrescriptionDetails);
            tabPrescriptions.Controls.Add(listPrescriptions);
            tabPrescriptions.Controls.Add(btnAddPrescription);
            tabPrescriptions.Controls.Add(btnEditPrescription);
            tabPrescriptions.Controls.Add(btnDeletePrescription);

            // Panel
            panelPrescriptionDetails.BackColor = Color.FromArgb(30, 41, 59);
            panelPrescriptionDetails.BorderStyle = BorderStyle.None;
            panelPrescriptionDetails.Location = new Point(20, 20);
            panelPrescriptionDetails.Size = new Size(500, 550);
            panelPrescriptionDetails.Paint += panel_Paint;

            // Setup controls (similaire à Medicines)
            SetupPrescriptionControls();

            // ListBox
            listPrescriptions.BackColor = Color.FromArgb(30, 41, 59);
            listPrescriptions.ForeColor = Color.FromArgb(226, 232, 240);
            listPrescriptions.BorderStyle = BorderStyle.None;
            listPrescriptions.Font = new Font("Segoe UI", 10F);
            listPrescriptions.Location = new Point(550, 20);
            listPrescriptions.Size = new Size(600, 480);
            listPrescriptions.SelectedIndexChanged += listPrescriptions_SelectedIndexChanged;

            SetupPrescriptionButtons();
        }

        private void SetupPrescriptionControls()
        {
            labelPrescription.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelPrescription.ForeColor = Color.FromArgb(226, 232, 240);
            labelPrescription.Location = new Point(20, 20);
            labelPrescription.AutoSize = true;
            labelPrescription.Text = "Prescription Details";

            labelPrescriptionMedicines.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrescriptionMedicines.ForeColor = Color.FromArgb(148, 163, 184);
            labelPrescriptionMedicines.Location = new Point(25, 70);
            labelPrescriptionMedicines.AutoSize = true;
            labelPrescriptionMedicines.Text = "Medicines :";

            dataPrescriptionMedicines.BackgroundColor = Color.FromArgb(51, 65, 85);
            dataPrescriptionMedicines.ForeColor = Color.FromArgb(226, 232, 240);
            dataPrescriptionMedicines.GridColor = Color.FromArgb(71, 85, 105);
            dataPrescriptionMedicines.BorderStyle = BorderStyle.None;
            dataPrescriptionMedicines.Location = new Point(25, 95);
            dataPrescriptionMedicines.Size = new Size(450, 150);
            dataPrescriptionMedicines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataPrescriptionMedicines.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataPrescriptionMedicines.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
            dataPrescriptionMedicines.EnableHeadersVisualStyles = false;
            dataPrescriptionMedicines.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dataPrescriptionMedicines.ColumnHeadersDefaultCellStyle.ForeColor = Color.FromArgb(226, 232, 240);
            dataPrescriptionMedicines.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            dataPrescriptionMedicines.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb(30, 41, 59);
            dataPrescriptionMedicines.DefaultCellStyle.BackColor = Color.FromArgb(51, 65, 85);
            dataPrescriptionMedicines.DefaultCellStyle.ForeColor = Color.FromArgb(226, 232, 240);
            dataPrescriptionMedicines.DefaultCellStyle.SelectionBackColor = Color.FromArgb(16, 185, 129);
            dataPrescriptionMedicines.DefaultCellStyle.SelectionForeColor = Color.White;
            dataPrescriptionMedicines.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(45, 59, 79);
            dataPrescriptionMedicines.RowHeadersDefaultCellStyle.BackColor = Color.FromArgb(30, 41, 59);
            dataPrescriptionMedicines.RowHeadersDefaultCellStyle.ForeColor = Color.FromArgb(226, 232, 240);
            dataPrescriptionMedicines.RowHeadersVisible = false;
            dataPrescriptionMedicines.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;

            // ComboBox pour sélectionner un médicament
            comboBoxPrescriptionMedicine.BackColor = Color.FromArgb(51, 65, 85);
            comboBoxPrescriptionMedicine.ForeColor = Color.FromArgb(226, 232, 240);
            comboBoxPrescriptionMedicine.FlatStyle = FlatStyle.Flat;
            comboBoxPrescriptionMedicine.Font = new Font("Segoe UI", 10F);
            comboBoxPrescriptionMedicine.Location = new Point(25, 255);
            comboBoxPrescriptionMedicine.Size = new Size(300, 28);
            comboBoxPrescriptionMedicine.Visible = false;
            comboBoxPrescriptionMedicine.SelectedIndexChanged += comboBoxPrescriptionMedicine_SelectedIndexChanged;

            // Validity
            labelPrescriptionValidity.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrescriptionValidity.ForeColor = Color.FromArgb(148, 163, 184);
            labelPrescriptionValidity.Location = new Point(25, 295);
            labelPrescriptionValidity.AutoSize = true;
            labelPrescriptionValidity.Text = "Validity :";

            textBoxPrescriptionValidity.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPrescriptionValidity.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPrescriptionValidity.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrescriptionValidity.Font = new Font("Segoe UI", 10F);
            textBoxPrescriptionValidity.Location = new Point(25, 320);
            textBoxPrescriptionValidity.Size = new Size(250, 27);
            textBoxPrescriptionValidity.ReadOnly = true;

            dateTimePickerPrescriptionValidity.CalendarMonthBackground = Color.FromArgb(51, 65, 85);
            dateTimePickerPrescriptionValidity.CalendarForeColor = Color.FromArgb(226, 232, 240);
            dateTimePickerPrescriptionValidity.Font = new Font("Segoe UI", 10F);
            dateTimePickerPrescriptionValidity.Location = new Point(25, 320);
            dateTimePickerPrescriptionValidity.Size = new Size(250, 27);
            dateTimePickerPrescriptionValidity.Visible = false;

            // Doctor
            labelPrescriptionDoctor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrescriptionDoctor.ForeColor = Color.FromArgb(148, 163, 184);
            labelPrescriptionDoctor.Location = new Point(25, 360);
            labelPrescriptionDoctor.AutoSize = true;
            labelPrescriptionDoctor.Text = "Doctor :";

            textBoxPrescriptionDoctor.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPrescriptionDoctor.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPrescriptionDoctor.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrescriptionDoctor.Font = new Font("Segoe UI", 10F);
            textBoxPrescriptionDoctor.Location = new Point(25, 385);
            textBoxPrescriptionDoctor.Size = new Size(250, 27);
            textBoxPrescriptionDoctor.ReadOnly = true;

            // Patient
            labelPrescriptionPatient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPrescriptionPatient.ForeColor = Color.FromArgb(148, 163, 184);
            labelPrescriptionPatient.Location = new Point(25, 425);
            labelPrescriptionPatient.AutoSize = true;
            labelPrescriptionPatient.Text = "Patient :";

            textBoxPrescriptionPatient.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPrescriptionPatient.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPrescriptionPatient.BorderStyle = BorderStyle.FixedSingle;
            textBoxPrescriptionPatient.Font = new Font("Segoe UI", 10F);
            textBoxPrescriptionPatient.Location = new Point(25, 450);
            textBoxPrescriptionPatient.Size = new Size(250, 27);
            textBoxPrescriptionPatient.ReadOnly = true;

            comboBoxPrescriptionPatient.BackColor = Color.FromArgb(51, 65, 85);
            comboBoxPrescriptionPatient.ForeColor = Color.FromArgb(226, 232, 240);
            comboBoxPrescriptionPatient.FlatStyle = FlatStyle.Flat;
            comboBoxPrescriptionPatient.Font = new Font("Segoe UI", 10F);
            comboBoxPrescriptionPatient.Location = new Point(25, 450);
            comboBoxPrescriptionPatient.Size = new Size(250, 28);
            comboBoxPrescriptionPatient.Visible = false;

            panelPrescriptionDetails.Controls.Add(labelPrescription);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionMedicines);
            panelPrescriptionDetails.Controls.Add(dataPrescriptionMedicines);
            panelPrescriptionDetails.Controls.Add(comboBoxPrescriptionMedicine);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionValidity);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionValidity);
            panelPrescriptionDetails.Controls.Add(dateTimePickerPrescriptionValidity);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionDoctor);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionDoctor);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionPatient);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionPatient);
            panelPrescriptionDetails.Controls.Add(comboBoxPrescriptionPatient);
        }

        private void SetupPrescriptionButtons()
        {
            btnAddPrescription.FlatStyle = FlatStyle.Flat;
            btnAddPrescription.FlatAppearance.BorderSize = 0;
            btnAddPrescription.BackColor = Color.FromArgb(16, 185, 129);
            btnAddPrescription.ForeColor = Color.White;
            btnAddPrescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddPrescription.Location = new Point(550, 520);
            btnAddPrescription.Size = new Size(100, 40);
            btnAddPrescription.Text = "Add";
            btnAddPrescription.Cursor = Cursors.Hand;
            btnAddPrescription.Click += btnAddPrescription_Click;
            StyleButton(btnAddPrescription);

            btnEditPrescription.FlatStyle = FlatStyle.Flat;
            btnEditPrescription.FlatAppearance.BorderSize = 0;
            btnEditPrescription.BackColor = Color.FromArgb(59, 130, 246);
            btnEditPrescription.ForeColor = Color.White;
            btnEditPrescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEditPrescription.Location = new Point(660, 520);
            btnEditPrescription.Size = new Size(100, 40);
            btnEditPrescription.Text = "Edit";
            btnEditPrescription.Cursor = Cursors.Hand;
            btnEditPrescription.Click += btnEditPrescription_Click;
            StyleButton(btnEditPrescription);

            btnDeletePrescription.FlatStyle = FlatStyle.Flat;
            btnDeletePrescription.FlatAppearance.BorderSize = 0;
            btnDeletePrescription.BackColor = Color.FromArgb(239, 68, 68);
            btnDeletePrescription.ForeColor = Color.White;
            btnDeletePrescription.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDeletePrescription.Location = new Point(770, 520);
            btnDeletePrescription.Size = new Size(100, 40);
            btnDeletePrescription.Text = "Delete";
            btnDeletePrescription.Cursor = Cursors.Hand;
            btnDeletePrescription.Click += btnDeletePrescription_Click;
            StyleButton(btnDeletePrescription);

            buttonPrescriptionGenerate.FlatStyle = FlatStyle.Flat;
            buttonPrescriptionGenerate.FlatAppearance.BorderSize = 0;
            buttonPrescriptionGenerate.BackColor = Color.FromArgb(168, 85, 247);
            buttonPrescriptionGenerate.ForeColor = Color.White;
            buttonPrescriptionGenerate.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPrescriptionGenerate.Location = new Point(890, 520);
            buttonPrescriptionGenerate.Size = new Size(150, 40);
            buttonPrescriptionGenerate.Text = "Generate PDF";
            buttonPrescriptionGenerate.Cursor = Cursors.Hand;
            buttonPrescriptionGenerate.Click += buttonPrescriptionGenerate_Click;
            StyleButton(buttonPrescriptionGenerate);

            buttonPrescriptionRegister.FlatStyle = FlatStyle.Flat;
            buttonPrescriptionRegister.FlatAppearance.BorderSize = 0;
            buttonPrescriptionRegister.BackColor = Color.FromArgb(16, 185, 129);
            buttonPrescriptionRegister.ForeColor = Color.White;
            buttonPrescriptionRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPrescriptionRegister.Location = new Point(30, 590);
            buttonPrescriptionRegister.Size = new Size(130, 40);
            buttonPrescriptionRegister.Text = "Register";
            buttonPrescriptionRegister.Cursor = Cursors.Hand;
            buttonPrescriptionRegister.Visible = false;
            buttonPrescriptionRegister.Click += buttonPrescriptionRegister_Click;
            StyleButton(buttonPrescriptionRegister);

            buttonPrescriptionModify.FlatStyle = FlatStyle.Flat;
            buttonPrescriptionModify.FlatAppearance.BorderSize = 0;
            buttonPrescriptionModify.BackColor = Color.FromArgb(16, 185, 129);
            buttonPrescriptionModify.ForeColor = Color.White;
            buttonPrescriptionModify.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPrescriptionModify.Location = new Point(30, 590);
            buttonPrescriptionModify.Size = new Size(130, 40);
            buttonPrescriptionModify.Text = "Modify";
            buttonPrescriptionModify.Cursor = Cursors.Hand;
            buttonPrescriptionModify.Visible = false;
            buttonPrescriptionModify.Click += buttonPrescriptionModify_Click;
            StyleButton(buttonPrescriptionModify);

            buttonPrescriptionCancel.FlatStyle = FlatStyle.Flat;
            buttonPrescriptionCancel.FlatAppearance.BorderSize = 0;
            buttonPrescriptionCancel.BackColor = Color.FromArgb(100, 116, 139);
            buttonPrescriptionCancel.ForeColor = Color.White;
            buttonPrescriptionCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPrescriptionCancel.Location = new Point(170, 590);
            buttonPrescriptionCancel.Size = new Size(130, 40);
            buttonPrescriptionCancel.Text = "Cancel";
            buttonPrescriptionCancel.Cursor = Cursors.Hand;
            buttonPrescriptionCancel.Visible = false;
            buttonPrescriptionCancel.Click += buttonPrescriptionCancel_Click;
            StyleButton(buttonPrescriptionCancel);
        }

        private void SetupPatientsTab()
        {
            // Configuration similaire
            tabPatients.Controls.Add(buttonPatientModify);
            tabPatients.Controls.Add(buttonPatientCancel);
            tabPatients.Controls.Add(buttonPatientRegister);
            tabPatients.Controls.Add(panelPatientDetails);
            tabPatients.Controls.Add(listPatients);
            tabPatients.Controls.Add(btnAddPatient);
            tabPatients.Controls.Add(btnEditPatient);
            tabPatients.Controls.Add(btnDeletePatient);

            panelPatientDetails.BackColor = Color.FromArgb(30, 41, 59);
            panelPatientDetails.BorderStyle = BorderStyle.None;
            panelPatientDetails.Location = new Point(20, 20);
            panelPatientDetails.Size = new Size(500, 550);
            panelPatientDetails.Paint += panel_Paint;

            SetupPatientControls();

            listPatients.BackColor = Color.FromArgb(30, 41, 59);
            listPatients.ForeColor = Color.FromArgb(226, 232, 240);
            listPatients.BorderStyle = BorderStyle.None;
            listPatients.Font = new Font("Segoe UI", 10F);
            listPatients.Location = new Point(550, 20);
            listPatients.Size = new Size(600, 480);
            listPatients.SelectedIndexChanged += listPatients_SelectedIndexChanged;

            SetupPatientButtons();
        }

        private void SetupPatientControls()
        {
            labelPatient.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelPatient.ForeColor = Color.FromArgb(226, 232, 240);
            labelPatient.Location = new Point(20, 20);
            labelPatient.AutoSize = true;
            labelPatient.Text = "Patient Details";

            // Gender
            labelPatientGender.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPatientGender.ForeColor = Color.FromArgb(148, 163, 184);
            labelPatientGender.Location = new Point(25, 70);
            labelPatientGender.AutoSize = true;
            labelPatientGender.Text = "Gender :";

            textBoxPatientGender.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPatientGender.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPatientGender.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatientGender.Font = new Font("Segoe UI", 10F);
            textBoxPatientGender.Location = new Point(25, 95);
            textBoxPatientGender.Size = new Size(200, 27);
            textBoxPatientGender.ReadOnly = true;

            comboBoxPatientGender.BackColor = Color.FromArgb(51, 65, 85);
            comboBoxPatientGender.ForeColor = Color.FromArgb(226, 232, 240);
            comboBoxPatientGender.FlatStyle = FlatStyle.Flat;
            comboBoxPatientGender.Font = new Font("Segoe UI", 10F);
            comboBoxPatientGender.Location = new Point(25, 95);
            comboBoxPatientGender.Size = new Size(200, 28);
            comboBoxPatientGender.Visible = false;

            // Age
            labelPatientAge.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPatientAge.ForeColor = Color.FromArgb(148, 163, 184);
            labelPatientAge.Location = new Point(25, 140);
            labelPatientAge.AutoSize = true;
            labelPatientAge.Text = "Age :";

            textBoxPatientAge.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPatientAge.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPatientAge.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatientAge.Font = new Font("Segoe UI", 10F);
            textBoxPatientAge.Location = new Point(25, 165);
            textBoxPatientAge.Size = new Size(150, 27);
            textBoxPatientAge.ReadOnly = true;

            // Doctor
            labelPatientDoctor.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPatientDoctor.ForeColor = Color.FromArgb(148, 163, 184);
            labelPatientDoctor.Location = new Point(25, 210);
            labelPatientDoctor.AutoSize = true;
            labelPatientDoctor.Text = "Doctor :";

            textBoxPatientDoctor.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPatientDoctor.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPatientDoctor.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatientDoctor.Font = new Font("Segoe UI", 10F);
            textBoxPatientDoctor.Location = new Point(25, 235);
            textBoxPatientDoctor.Size = new Size(250, 27);
            textBoxPatientDoctor.ReadOnly = true;

            // Name
            labelPatientName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPatientName.ForeColor = Color.FromArgb(148, 163, 184);
            labelPatientName.Location = new Point(25, 280);
            labelPatientName.AutoSize = true;
            labelPatientName.Text = "Name :";
            labelPatientName.Visible = false;

            textBoxPatientName.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPatientName.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPatientName.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatientName.Font = new Font("Segoe UI", 10F);
            textBoxPatientName.Location = new Point(25, 305);
            textBoxPatientName.Size = new Size(250, 27);
            textBoxPatientName.Visible = false;

            // Firstname
            labelPatientFirstname.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelPatientFirstname.ForeColor = Color.FromArgb(148, 163, 184);
            labelPatientFirstname.Location = new Point(25, 350);
            labelPatientFirstname.AutoSize = true;
            labelPatientFirstname.Text = "Firstname :";
            labelPatientFirstname.Visible = false;

            textBoxPatientFirstname.BackColor = Color.FromArgb(51, 65, 85);
            textBoxPatientFirstname.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxPatientFirstname.BorderStyle = BorderStyle.FixedSingle;
            textBoxPatientFirstname.Font = new Font("Segoe UI", 10F);
            textBoxPatientFirstname.Location = new Point(25, 375);
            textBoxPatientFirstname.Size = new Size(250, 27);
            textBoxPatientFirstname.Visible = false;

            label2.AutoSize = true;
            label2.Location = new Point(25, 420);
            label2.Text = "";

            panelPatientDetails.Controls.Add(labelPatient);
            panelPatientDetails.Controls.Add(labelPatientGender);
            panelPatientDetails.Controls.Add(textBoxPatientGender);
            panelPatientDetails.Controls.Add(comboBoxPatientGender);
            panelPatientDetails.Controls.Add(labelPatientAge);
            panelPatientDetails.Controls.Add(textBoxPatientAge);
            panelPatientDetails.Controls.Add(labelPatientDoctor);
            panelPatientDetails.Controls.Add(textBoxPatientDoctor);
            panelPatientDetails.Controls.Add(labelPatientName);
            panelPatientDetails.Controls.Add(textBoxPatientName);
            panelPatientDetails.Controls.Add(labelPatientFirstname);
            panelPatientDetails.Controls.Add(textBoxPatientFirstname);
            panelPatientDetails.Controls.Add(label2);
        }

        private void SetupPatientButtons()
        {
            btnAddPatient.FlatStyle = FlatStyle.Flat;
            btnAddPatient.FlatAppearance.BorderSize = 0;
            btnAddPatient.BackColor = Color.FromArgb(16, 185, 129);
            btnAddPatient.ForeColor = Color.White;
            btnAddPatient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnAddPatient.Location = new Point(550, 520);
            btnAddPatient.Size = new Size(100, 40);
            btnAddPatient.Text = "Add";
            btnAddPatient.Cursor = Cursors.Hand;
            btnAddPatient.Click += btnAddPatient_Click;
            StyleButton(btnAddPatient);

            btnEditPatient.FlatStyle = FlatStyle.Flat;
            btnEditPatient.FlatAppearance.BorderSize = 0;
            btnEditPatient.BackColor = Color.FromArgb(59, 130, 246);
            btnEditPatient.ForeColor = Color.White;
            btnEditPatient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnEditPatient.Location = new Point(660, 520);
            btnEditPatient.Size = new Size(100, 40);
            btnEditPatient.Text = "Edit";
            btnEditPatient.Cursor = Cursors.Hand;
            btnEditPatient.Click += btnEditPatient_Click;
            StyleButton(btnEditPatient);

            btnDeletePatient.FlatStyle = FlatStyle.Flat;
            btnDeletePatient.FlatAppearance.BorderSize = 0;
            btnDeletePatient.BackColor = Color.FromArgb(239, 68, 68);
            btnDeletePatient.ForeColor = Color.White;
            btnDeletePatient.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            btnDeletePatient.Location = new Point(770, 520);
            btnDeletePatient.Size = new Size(100, 40);
            btnDeletePatient.Text = "Delete";
            btnDeletePatient.Cursor = Cursors.Hand;
            btnDeletePatient.Click += btnDeletePatient_Click;
            StyleButton(btnDeletePatient);

            buttonPatientRegister.FlatStyle = FlatStyle.Flat;
            buttonPatientRegister.FlatAppearance.BorderSize = 0;
            buttonPatientRegister.BackColor = Color.FromArgb(16, 185, 129);
            buttonPatientRegister.ForeColor = Color.White;
            buttonPatientRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPatientRegister.Location = new Point(30, 590);
            buttonPatientRegister.Size = new Size(130, 40);
            buttonPatientRegister.Text = "Register";
            buttonPatientRegister.Cursor = Cursors.Hand;
            buttonPatientRegister.Visible = false;
            buttonPatientRegister.Click += buttonPatientRegister_Click;
            StyleButton(buttonPatientRegister);

            buttonPatientModify.FlatStyle = FlatStyle.Flat;
            buttonPatientModify.FlatAppearance.BorderSize = 0;
            buttonPatientModify.BackColor = Color.FromArgb(16, 185, 129);
            buttonPatientModify.ForeColor = Color.White;
            buttonPatientModify.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPatientModify.Location = new Point(30, 590);
            buttonPatientModify.Size = new Size(130, 40);
            buttonPatientModify.Text = "Modify";
            buttonPatientModify.Cursor = Cursors.Hand;
            buttonPatientModify.Visible = false;
            buttonPatientModify.Click += buttonPatientModify_Click;
            StyleButton(buttonPatientModify);

            buttonPatientCancel.FlatStyle = FlatStyle.Flat;
            buttonPatientCancel.FlatAppearance.BorderSize = 0;
            buttonPatientCancel.BackColor = Color.FromArgb(100, 116, 139);
            buttonPatientCancel.ForeColor = Color.White;
            buttonPatientCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonPatientCancel.Location = new Point(170, 590);
            buttonPatientCancel.Size = new Size(130, 40);
            buttonPatientCancel.Text = "Cancel";
            buttonPatientCancel.Cursor = Cursors.Hand;
            buttonPatientCancel.Visible = false;
            buttonPatientCancel.Click += buttonPatientCancel_Click;
            StyleButton(buttonPatientCancel);
        }

        private void SetupManagerTab()
        {
            tabPageManager.Controls.Add(buttonUserDelete);
            tabPageManager.Controls.Add(buttonUserModify);
            tabPageManager.Controls.Add(buttonUserCancel);
            tabPageManager.Controls.Add(buttonUserRegister);
            tabPageManager.Controls.Add(panel1);
            tabPageManager.Controls.Add(listUsers);
            tabPageManager.Controls.Add(buttonUserAdd);
            tabPageManager.Controls.Add(buttonUserEdit);

            panel1.BackColor = Color.FromArgb(30, 41, 59);
            panel1.BorderStyle = BorderStyle.None;
            panel1.Location = new Point(20, 20);
            panel1.Size = new Size(500, 550);
            panel1.Paint += panel_Paint;

            SetupManagerControls();

            listUsers.BackColor = Color.FromArgb(30, 41, 59);
            listUsers.ForeColor = Color.FromArgb(226, 232, 240);
            listUsers.BorderStyle = BorderStyle.None;
            listUsers.Font = new Font("Segoe UI", 10F);
            listUsers.Location = new Point(550, 20);
            listUsers.Size = new Size(600, 480);
            listUsers.SelectedIndexChanged += listUsers_SelectedIndexChanged;

            SetupManagerButtons();
        }

        private void SetupManagerControls()
        {
            labelUser.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelUser.ForeColor = Color.FromArgb(226, 232, 240);
            labelUser.Location = new Point(20, 20);
            labelUser.AutoSize = true;
            labelUser.Text = "User Details";

            // Role
            labelUserRole.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUserRole.ForeColor = Color.FromArgb(148, 163, 184);
            labelUserRole.Location = new Point(25, 70);
            labelUserRole.AutoSize = true;
            labelUserRole.Text = "Role :";

            textBoxUserRole.BackColor = Color.FromArgb(51, 65, 85);
            textBoxUserRole.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxUserRole.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserRole.Font = new Font("Segoe UI", 10F);
            textBoxUserRole.Location = new Point(25, 95);
            textBoxUserRole.Size = new Size(200, 27);
            textBoxUserRole.ReadOnly = true;

            comboBoxUserRole.BackColor = Color.FromArgb(51, 65, 85);
            comboBoxUserRole.ForeColor = Color.FromArgb(226, 232, 240);
            comboBoxUserRole.FlatStyle = FlatStyle.Flat;
            comboBoxUserRole.Font = new Font("Segoe UI", 10F);
            comboBoxUserRole.Location = new Point(25, 95);
            comboBoxUserRole.Size = new Size(200, 28);
            comboBoxUserRole.Visible = false;

            // Email
            labelUserEmail.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUserEmail.ForeColor = Color.FromArgb(148, 163, 184);
            labelUserEmail.Location = new Point(25, 140);
            labelUserEmail.AutoSize = true;
            labelUserEmail.Text = "Email :";

            textBoxUserEmail.BackColor = Color.FromArgb(51, 65, 85);
            textBoxUserEmail.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxUserEmail.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserEmail.Font = new Font("Segoe UI", 10F);
            textBoxUserEmail.Location = new Point(25, 165);
            textBoxUserEmail.Size = new Size(300, 27);
            textBoxUserEmail.ReadOnly = true;

            // Name
            labelUserName.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUserName.ForeColor = Color.FromArgb(148, 163, 184);
            labelUserName.Location = new Point(25, 210);
            labelUserName.AutoSize = true;
            labelUserName.Text = "Name :";
            labelUserName.Visible = false;

            textBoxUserName.BackColor = Color.FromArgb(51, 65, 85);
            textBoxUserName.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxUserName.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserName.Font = new Font("Segoe UI", 10F);
            textBoxUserName.Location = new Point(25, 235);
            textBoxUserName.Size = new Size(250, 27);
            textBoxUserName.Visible = false;

            // Firstname
            labelUserFirstname.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUserFirstname.ForeColor = Color.FromArgb(148, 163, 184);
            labelUserFirstname.Location = new Point(25, 280);
            labelUserFirstname.AutoSize = true;
            labelUserFirstname.Text = "Firstname :";
            labelUserFirstname.Visible = false;

            textBoxUserFirstname.BackColor = Color.FromArgb(51, 65, 85);
            textBoxUserFirstname.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxUserFirstname.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserFirstname.Font = new Font("Segoe UI", 10F);
            textBoxUserFirstname.Location = new Point(25, 305);
            textBoxUserFirstname.Size = new Size(250, 27);
            textBoxUserFirstname.Visible = false;

            // Password
            labelUserPassword.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            labelUserPassword.ForeColor = Color.FromArgb(148, 163, 184);
            labelUserPassword.Location = new Point(25, 350);
            labelUserPassword.AutoSize = true;
            labelUserPassword.Text = "Password :";
            labelUserPassword.Visible = false;

            textBoxUserPassword.BackColor = Color.FromArgb(51, 65, 85);
            textBoxUserPassword.ForeColor = Color.FromArgb(226, 232, 240);
            textBoxUserPassword.BorderStyle = BorderStyle.FixedSingle;
            textBoxUserPassword.Font = new Font("Segoe UI", 10F);
            textBoxUserPassword.Location = new Point(25, 375);
            textBoxUserPassword.Size = new Size(250, 27);
            textBoxUserPassword.Visible = false;

            label6.AutoSize = true;
            label6.Location = new Point(25, 420);
            label6.Text = "";

            label7.AutoSize = true;
            label7.Location = new Point(25, 440);
            label7.Text = "";

            panel1.Controls.Add(labelUser);
            panel1.Controls.Add(labelUserRole);
            panel1.Controls.Add(textBoxUserRole);
            panel1.Controls.Add(comboBoxUserRole);
            panel1.Controls.Add(labelUserEmail);
            panel1.Controls.Add(textBoxUserEmail);
            panel1.Controls.Add(labelUserName);
            panel1.Controls.Add(textBoxUserName);
            panel1.Controls.Add(labelUserFirstname);
            panel1.Controls.Add(textBoxUserFirstname);
            panel1.Controls.Add(labelUserPassword);
            panel1.Controls.Add(textBoxUserPassword);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label7);
        }

        private void SetupManagerButtons()
        {
            buttonUserAdd.FlatStyle = FlatStyle.Flat;
            buttonUserAdd.FlatAppearance.BorderSize = 0;
            buttonUserAdd.BackColor = Color.FromArgb(16, 185, 129);
            buttonUserAdd.ForeColor = Color.White;
            buttonUserAdd.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonUserAdd.Location = new Point(550, 520);
            buttonUserAdd.Size = new Size(100, 40);
            buttonUserAdd.Text = "Add";
            buttonUserAdd.Cursor = Cursors.Hand;
            buttonUserAdd.Click += buttonUserAdd_Click;
            StyleButton(buttonUserAdd);

            buttonUserEdit.FlatStyle = FlatStyle.Flat;
            buttonUserEdit.FlatAppearance.BorderSize = 0;
            buttonUserEdit.BackColor = Color.FromArgb(59, 130, 246);
            buttonUserEdit.ForeColor = Color.White;
            buttonUserEdit.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonUserEdit.Location = new Point(660, 520);
            buttonUserEdit.Size = new Size(100, 40);
            buttonUserEdit.Text = "Edit";
            buttonUserEdit.Cursor = Cursors.Hand;
            buttonUserEdit.Click += buttonUserEdit_Click;
            StyleButton(buttonUserEdit);

            buttonUserDelete.FlatStyle = FlatStyle.Flat;
            buttonUserDelete.FlatAppearance.BorderSize = 0;
            buttonUserDelete.BackColor = Color.FromArgb(239, 68, 68);
            buttonUserDelete.ForeColor = Color.White;
            buttonUserDelete.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonUserDelete.Location = new Point(770, 520);
            buttonUserDelete.Size = new Size(100, 40);
            buttonUserDelete.Text = "Delete";
            buttonUserDelete.Cursor = Cursors.Hand;
            buttonUserDelete.Click += buttonUserDelete_Click;
            StyleButton(buttonUserDelete);

            buttonUserRegister.FlatStyle = FlatStyle.Flat;
            buttonUserRegister.FlatAppearance.BorderSize = 0;
            buttonUserRegister.BackColor = Color.FromArgb(16, 185, 129);
            buttonUserRegister.ForeColor = Color.White;
            buttonUserRegister.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonUserRegister.Location = new Point(30, 590);
            buttonUserRegister.Size = new Size(130, 40);
            buttonUserRegister.Text = "Register";
            buttonUserRegister.Cursor = Cursors.Hand;
            buttonUserRegister.Visible = false;
            buttonUserRegister.Click += buttonUserRegister_Click;
            StyleButton(buttonUserRegister);

            buttonUserModify.FlatStyle = FlatStyle.Flat;
            buttonUserModify.FlatAppearance.BorderSize = 0;
            buttonUserModify.BackColor = Color.FromArgb(16, 185, 129);
            buttonUserModify.ForeColor = Color.White;
            buttonUserModify.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonUserModify.Location = new Point(30, 590);
            buttonUserModify.Size = new Size(130, 40);
            buttonUserModify.Text = "Modify";
            buttonUserModify.Cursor = Cursors.Hand;
            buttonUserModify.Visible = false;
            buttonUserModify.Click += buttonUserModify_Click;
            StyleButton(buttonUserModify);

            buttonUserCancel.FlatStyle = FlatStyle.Flat;
            buttonUserCancel.FlatAppearance.BorderSize = 0;
            buttonUserCancel.BackColor = Color.FromArgb(100, 116, 139);
            buttonUserCancel.ForeColor = Color.White;
            buttonUserCancel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold);
            buttonUserCancel.Location = new Point(170, 590);
            buttonUserCancel.Size = new Size(130, 40);
            buttonUserCancel.Text = "Cancel";
            buttonUserCancel.Cursor = Cursors.Hand;
            buttonUserCancel.Visible = false;
            buttonUserCancel.Click += buttonUserCancel_Click;
            StyleButton(buttonUserCancel);
        }

        #endregion

        // Méthode pour dessiner les panneaux avec coins arrondis
        private void panel_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = sender as Panel;
            if (panel == null) return;

            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            using (var path = new System.Drawing.Drawing2D.GraphicsPath())
            {
                int radius = 12;
                Rectangle rect = new Rectangle(0, 0, panel.Width, panel.Height);

                path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                path.CloseFigure();

                panel.Region = new Region(path);

                using (var brush = new SolidBrush(Color.FromArgb(30, 41, 59)))
                {
                    e.Graphics.FillPath(brush, path);
                }

                using (var borderPen = new Pen(Color.FromArgb(71, 85, 105), 1))
                {
                    e.Graphics.DrawPath(borderPen, path);
                }
            }
        }

        // Dessiner les onglets personnalisés
        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage page = tabControl.TabPages[e.Index];
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            Rectangle tabRect = tabControl.GetTabRect(e.Index);
            bool selected = (e.Index == tabControl.SelectedIndex);

            // Remplir tout le fond de la zone des onglets
            using (var bgBrush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                e.Graphics.FillRectangle(bgBrush, e.Bounds);
            }

            // Couleur de fond de l'onglet
            Color backColor = selected ? Color.FromArgb(16, 185, 129) : Color.FromArgb(30, 41, 59);
            using (var brush = new SolidBrush(backColor))
            {
                e.Graphics.FillRectangle(brush, tabRect);
            }

            // Texte
            Color textColor = selected ? Color.White : Color.FromArgb(148, 163, 184);
            TextRenderer.DrawText(e.Graphics, page.Text, tabControl.Font, tabRect,
                textColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);

            // Bordure inférieure pour l'onglet sélectionné
            if (selected)
            {
                using (var pen = new Pen(Color.FromArgb(16, 185, 129), 3))
                {
                    e.Graphics.DrawLine(pen, tabRect.Left, tabRect.Bottom - 1,
                        tabRect.Right, tabRect.Bottom - 1);
                }
            }
        }

        // Peindre le fond du TabControl en sombre
        private void tabControl_Paint(object sender, PaintEventArgs e)
        {
            // Peindre tout le fond du TabControl en sombre
            using (var brush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                e.Graphics.FillRectangle(brush, tabControl.ClientRectangle);
            }

            // Peindre la zone des onglets
            Rectangle tabAreaRect = new Rectangle(0, 0, tabControl.Width, tabControl.ItemSize.Height + 4);
            using (var brush = new SolidBrush(Color.FromArgb(15, 23, 42)))
            {
                e.Graphics.FillRectangle(brush, tabAreaRect);
            }
        }

        // Style pour les boutons avec coins arrondis
        private void StyleButton(Button btn)
        {
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (var path = new System.Drawing.Drawing2D.GraphicsPath())
                {
                    int radius = 6;
                    Rectangle rect = new Rectangle(0, 0, btn.Width, btn.Height);

                    path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
                    path.AddArc(rect.Right - radius, rect.Y, radius, radius, 270, 90);
                    path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
                    path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
                    path.CloseFigure();

                    btn.Region = new Region(path);
                    using (var brush = new SolidBrush(btn.BackColor))
                    {
                        e.Graphics.FillPath(brush, path);
                    }
                }
                TextRenderer.DrawText(e.Graphics, btn.Text, btn.Font, btn.ClientRectangle,
                    btn.ForeColor, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
            };
        }

        private void UserForm_Resize(object sender, EventArgs e)
        {
            float scaleX = (float)ClientSize.Width / referenceSize.Width;
            float scaleY = (float)ClientSize.Height / referenceSize.Height;
            float scale = Math.Min(scaleX, scaleY);

            tabControl.ItemSize = new Size((int)(120 * scaleX), (int)(40 * scaleY));
            tabControl.Font = new Font("Segoe UI Semibold", 11F * scale, FontStyle.Bold);

            // Appliquer le scaling sur tous les onglets
            ScaleMedicinesTab(scaleX, scaleY, scale);
            ScalePrescriptionsTab(scaleX, scaleY, scale);
            ScalePatientsTab(scaleX, scaleY, scale);
            ScaleManagerTab(scaleX, scaleY, scale);
        }

        private void ScaleMedicinesTab(float scaleX, float scaleY, float scale)
        {
            panelMedicineDetails.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));
            panelMedicineDetails.Size = new Size((int)(500 * scaleX), (int)(550 * scaleY));

            // Scaling des contrôles dans le panel
            labelMedicine.Font = new Font("Segoe UI", 18F * scale, FontStyle.Bold);
            labelMedicine.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));

            labelMedicineDosage.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelMedicineDosage.Location = new Point((int)(25 * scaleX), (int)(70 * scaleY));

            textBoxMedicineDosage.Font = new Font("Segoe UI", 10F * scale);
            textBoxMedicineDosage.Location = new Point((int)(25 * scaleX), (int)(95 * scaleY));
            textBoxMedicineDosage.Size = new Size((int)(200 * scaleX), (int)(27 * scaleY));

            labelMedicineDescription.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelMedicineDescription.Location = new Point((int)(25 * scaleX), (int)(140 * scaleY));

            textBoxMedicineDescription.Font = new Font("Segoe UI", 10F * scale);
            textBoxMedicineDescription.Location = new Point((int)(25 * scaleX), (int)(165 * scaleY));
            textBoxMedicineDescription.Size = new Size((int)(450 * scaleX), (int)(100 * scaleY));

            labelMedicineMolecule.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelMedicineMolecule.Location = new Point((int)(25 * scaleX), (int)(285 * scaleY));

            textBoxMedicineMolecule.Font = new Font("Segoe UI", 10F * scale);
            textBoxMedicineMolecule.Location = new Point((int)(25 * scaleX), (int)(310 * scaleY));
            textBoxMedicineMolecule.Size = new Size((int)(300 * scaleX), (int)(27 * scaleY));

            labelMedicineName.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelMedicineName.Location = new Point((int)(25 * scaleX), (int)(355 * scaleY));

            textBoxMedicineName.Font = new Font("Segoe UI", 10F * scale);
            textBoxMedicineName.Location = new Point((int)(25 * scaleX), (int)(380 * scaleY));
            textBoxMedicineName.Size = new Size((int)(300 * scaleX), (int)(27 * scaleY));

            listMedicines.Location = new Point((int)(550 * scaleX), (int)(20 * scaleY));
            listMedicines.Size = new Size((int)(600 * scaleX), (int)(480 * scaleY));
            listMedicines.Font = new Font("Segoe UI", 10F * scale);

            ScaleButton(btnAddMedicine, 550, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(btnEditMedicine, 660, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(btnDeleteMedicine, 770, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(buttonMedicineRegister, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonMedicineModify, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonMedicineCancel, 170, 590, 130, 40, scaleX, scaleY, scale);
        }

        private void ScalePrescriptionsTab(float scaleX, float scaleY, float scale)
        {
            panelPrescriptionDetails.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));
            panelPrescriptionDetails.Size = new Size((int)(500 * scaleX), (int)(550 * scaleY));

            // Scaling des contrôles dans le panel
            labelPrescription.Font = new Font("Segoe UI", 18F * scale, FontStyle.Bold);
            labelPrescription.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));

            labelPrescriptionMedicines.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPrescriptionMedicines.Location = new Point((int)(25 * scaleX), (int)(70 * scaleY));

            dataPrescriptionMedicines.Font = new Font("Segoe UI", 9F * scale);
            dataPrescriptionMedicines.Location = new Point((int)(25 * scaleX), (int)(95 * scaleY));
            dataPrescriptionMedicines.Size = new Size((int)(450 * scaleX), (int)(150 * scaleY));
            dataPrescriptionMedicines.ColumnHeadersHeight = (int)(30 * scaleY);
            dataPrescriptionMedicines.RowTemplate.Height = (int)(25 * scaleY);
            dataPrescriptionMedicines.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI Semibold", 9F * scale, FontStyle.Bold);
            dataPrescriptionMedicines.DefaultCellStyle.Font = new Font("Segoe UI", 9F * scale);

            comboBoxPrescriptionMedicine.Font = new Font("Segoe UI", 10F * scale);
            comboBoxPrescriptionMedicine.Location = new Point((int)(25 * scaleX), (int)(255 * scaleY));
            comboBoxPrescriptionMedicine.Size = new Size((int)(300 * scaleX), (int)(28 * scaleY));

            labelPrescriptionValidity.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPrescriptionValidity.Location = new Point((int)(25 * scaleX), (int)(295 * scaleY));

            textBoxPrescriptionValidity.Font = new Font("Segoe UI", 10F * scale);
            textBoxPrescriptionValidity.Location = new Point((int)(25 * scaleX), (int)(320 * scaleY));
            textBoxPrescriptionValidity.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            dateTimePickerPrescriptionValidity.Font = new Font("Segoe UI", 10F * scale);
            dateTimePickerPrescriptionValidity.Location = new Point((int)(25 * scaleX), (int)(320 * scaleY));
            dateTimePickerPrescriptionValidity.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            labelPrescriptionDoctor.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPrescriptionDoctor.Location = new Point((int)(25 * scaleX), (int)(360 * scaleY));

            textBoxPrescriptionDoctor.Font = new Font("Segoe UI", 10F * scale);
            textBoxPrescriptionDoctor.Location = new Point((int)(25 * scaleX), (int)(385 * scaleY));
            textBoxPrescriptionDoctor.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            labelPrescriptionPatient.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPrescriptionPatient.Location = new Point((int)(25 * scaleX), (int)(425 * scaleY));

            textBoxPrescriptionPatient.Font = new Font("Segoe UI", 10F * scale);
            textBoxPrescriptionPatient.Location = new Point((int)(25 * scaleX), (int)(450 * scaleY));
            textBoxPrescriptionPatient.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            comboBoxPrescriptionPatient.Font = new Font("Segoe UI", 10F * scale);
            comboBoxPrescriptionPatient.Location = new Point((int)(25 * scaleX), (int)(450 * scaleY));
            comboBoxPrescriptionPatient.Size = new Size((int)(250 * scaleX), (int)(28 * scaleY));

            listPrescriptions.Location = new Point((int)(550 * scaleX), (int)(20 * scaleY));
            listPrescriptions.Size = new Size((int)(600 * scaleX), (int)(480 * scaleY));
            listPrescriptions.Font = new Font("Segoe UI", 10F * scale);

            ScaleButton(btnAddPrescription, 550, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(btnEditPrescription, 660, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(btnDeletePrescription, 770, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPrescriptionGenerate, 890, 520, 150, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPrescriptionRegister, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPrescriptionModify, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPrescriptionCancel, 170, 590, 130, 40, scaleX, scaleY, scale);
        }

        private void ScalePatientsTab(float scaleX, float scaleY, float scale)
        {
            panelPatientDetails.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));
            panelPatientDetails.Size = new Size((int)(500 * scaleX), (int)(550 * scaleY));

            // Scaling des contrôles dans le panel
            labelPatient.Font = new Font("Segoe UI", 18F * scale, FontStyle.Bold);
            labelPatient.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));

            labelPatientGender.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPatientGender.Location = new Point((int)(25 * scaleX), (int)(70 * scaleY));

            textBoxPatientGender.Font = new Font("Segoe UI", 10F * scale);
            textBoxPatientGender.Location = new Point((int)(25 * scaleX), (int)(95 * scaleY));
            textBoxPatientGender.Size = new Size((int)(200 * scaleX), (int)(27 * scaleY));

            comboBoxPatientGender.Font = new Font("Segoe UI", 10F * scale);
            comboBoxPatientGender.Location = new Point((int)(25 * scaleX), (int)(95 * scaleY));
            comboBoxPatientGender.Size = new Size((int)(200 * scaleX), (int)(28 * scaleY));

            labelPatientAge.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPatientAge.Location = new Point((int)(25 * scaleX), (int)(140 * scaleY));

            textBoxPatientAge.Font = new Font("Segoe UI", 10F * scale);
            textBoxPatientAge.Location = new Point((int)(25 * scaleX), (int)(165 * scaleY));
            textBoxPatientAge.Size = new Size((int)(150 * scaleX), (int)(27 * scaleY));

            labelPatientDoctor.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPatientDoctor.Location = new Point((int)(25 * scaleX), (int)(210 * scaleY));

            textBoxPatientDoctor.Font = new Font("Segoe UI", 10F * scale);
            textBoxPatientDoctor.Location = new Point((int)(25 * scaleX), (int)(235 * scaleY));
            textBoxPatientDoctor.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            labelPatientName.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPatientName.Location = new Point((int)(25 * scaleX), (int)(280 * scaleY));

            textBoxPatientName.Font = new Font("Segoe UI", 10F * scale);
            textBoxPatientName.Location = new Point((int)(25 * scaleX), (int)(305 * scaleY));
            textBoxPatientName.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            labelPatientFirstname.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelPatientFirstname.Location = new Point((int)(25 * scaleX), (int)(350 * scaleY));

            textBoxPatientFirstname.Font = new Font("Segoe UI", 10F * scale);
            textBoxPatientFirstname.Location = new Point((int)(25 * scaleX), (int)(375 * scaleY));
            textBoxPatientFirstname.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            listPatients.Location = new Point((int)(550 * scaleX), (int)(20 * scaleY));
            listPatients.Size = new Size((int)(600 * scaleX), (int)(480 * scaleY));
            listPatients.Font = new Font("Segoe UI", 10F * scale);

            ScaleButton(btnAddPatient, 550, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(btnEditPatient, 660, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(btnDeletePatient, 770, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPatientRegister, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPatientModify, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonPatientCancel, 170, 590, 130, 40, scaleX, scaleY, scale);
        }

        private void ScaleManagerTab(float scaleX, float scaleY, float scale)
        {
            panel1.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));
            panel1.Size = new Size((int)(500 * scaleX), (int)(550 * scaleY));

            // Scaling des contrôles dans le panel
            labelUser.Font = new Font("Segoe UI", 18F * scale, FontStyle.Bold);
            labelUser.Location = new Point((int)(20 * scaleX), (int)(20 * scaleY));

            labelUserRole.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelUserRole.Location = new Point((int)(25 * scaleX), (int)(70 * scaleY));

            textBoxUserRole.Font = new Font("Segoe UI", 10F * scale);
            textBoxUserRole.Location = new Point((int)(25 * scaleX), (int)(95 * scaleY));
            textBoxUserRole.Size = new Size((int)(200 * scaleX), (int)(27 * scaleY));

            comboBoxUserRole.Font = new Font("Segoe UI", 10F * scale);
            comboBoxUserRole.Location = new Point((int)(25 * scaleX), (int)(95 * scaleY));
            comboBoxUserRole.Size = new Size((int)(200 * scaleX), (int)(28 * scaleY));

            labelUserEmail.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelUserEmail.Location = new Point((int)(25 * scaleX), (int)(140 * scaleY));

            textBoxUserEmail.Font = new Font("Segoe UI", 10F * scale);
            textBoxUserEmail.Location = new Point((int)(25 * scaleX), (int)(165 * scaleY));
            textBoxUserEmail.Size = new Size((int)(300 * scaleX), (int)(27 * scaleY));

            labelUserName.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelUserName.Location = new Point((int)(25 * scaleX), (int)(210 * scaleY));

            textBoxUserName.Font = new Font("Segoe UI", 10F * scale);
            textBoxUserName.Location = new Point((int)(25 * scaleX), (int)(235 * scaleY));
            textBoxUserName.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            labelUserFirstname.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelUserFirstname.Location = new Point((int)(25 * scaleX), (int)(280 * scaleY));

            textBoxUserFirstname.Font = new Font("Segoe UI", 10F * scale);
            textBoxUserFirstname.Location = new Point((int)(25 * scaleX), (int)(305 * scaleY));
            textBoxUserFirstname.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            labelUserPassword.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
            labelUserPassword.Location = new Point((int)(25 * scaleX), (int)(350 * scaleY));

            textBoxUserPassword.Font = new Font("Segoe UI", 10F * scale);
            textBoxUserPassword.Location = new Point((int)(25 * scaleX), (int)(375 * scaleY));
            textBoxUserPassword.Size = new Size((int)(250 * scaleX), (int)(27 * scaleY));

            listUsers.Location = new Point((int)(550 * scaleX), (int)(20 * scaleY));
            listUsers.Size = new Size((int)(600 * scaleX), (int)(480 * scaleY));
            listUsers.Font = new Font("Segoe UI", 10F * scale);

            ScaleButton(buttonUserAdd, 550, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(buttonUserEdit, 660, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(buttonUserDelete, 770, 520, 100, 40, scaleX, scaleY, scale);
            ScaleButton(buttonUserRegister, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonUserModify, 30, 590, 130, 40, scaleX, scaleY, scale);
            ScaleButton(buttonUserCancel, 170, 590, 130, 40, scaleX, scaleY, scale);
        }

        private void ScaleButton(Button btn, int x, int y, int w, int h, float scaleX, float scaleY, float scale)
        {
            btn.Location = new Point((int)(x * scaleX), (int)(y * scaleY));
            btn.Size = new Size((int)(w * scaleX), (int)(h * scaleY));
            btn.Font = new Font("Segoe UI Semibold", 10F * scale, FontStyle.Bold);
        }

        // Déclaration des autres contrôles
        private Label labelMedicine;
        private Label labelMedicineMolecule;
        private Label labelMedicineDescription;
        private Label labelMedicineDosage;
        private TextBox textBoxMedicineDosage;
        private TextBox textBoxMedicineDescription;
        private TextBox textBoxMedicineMolecule;
        private Button buttonMedicineRegister;
        private Button buttonMedicineCancel;
        private Label labelPrescription;
        private Label labelMedicineDoctor;
        private Label labelPrescriptionMedicines;
        private Label labelPrescriptionDoctor;
        private Label labelPrescriptionValidity;
        private TextBox textBoxPrescriptionDoctor;
        private TextBox textBoxPrescriptionValidity;
        private Label labelPatientGender;
        private Label labelPatientAge;
        private Label label2;
        private Label labelPatientDoctor;
        private Label labelPatient;
        private TextBox textBoxPatientAge;
        private TextBox textBoxPatientDoctor;
        private TextBox textBoxPatientGender;
        private TextBox textBoxPrescriptionPatient;
        private Label labelPrescriptionPatient;
        private TextBox textBoxMedicineName;
        private Label labelMedicineName;
        private ComboBox comboBoxPrescriptionMedicine;
        private Button buttonPrescriptionCancel;
        private Button buttonPrescriptionRegister;
        private ComboBox comboBoxPrescriptionPatient;
        private Button buttonPatientCancel;
        private Button buttonPatientRegister;
        private DateTimePicker dateTimePickerPrescriptionValidity;
        private ComboBox comboBoxPatientGender;
        private TextBox textBoxPatientName;
        private Label labelPatientName;
        private Label labelPatientFirstname;
        private TextBox textBoxPatientFirstname;
        private Button buttonMedicineModify;
        private Button buttonPrescriptionModify;
        private Button buttonPatientModify;
        private TabPage tabPageManager;
        private Button buttonUserModify;
        private Button buttonUserCancel;
        private Button buttonUserRegister;
        private Panel panel1;
        private Label label6;
        private Label labelUser;
        private ListBox listUsers;
        private Button buttonUserAdd;
        private Button buttonUserEdit;
        private Label labelUserFirstname;
        private TextBox textBoxUserFirstname;
        private TextBox textBoxUserName;
        private Label labelUserName;
        private ComboBox comboBoxUserRole;
        private TextBox textBoxUserEmail;
        private TextBox textBoxUserRole;
        private Label labelUserRole;
        private Label labelUserEmail;
        private Label label7;
        private Label labelUserPassword;
        private TextBox textBoxUserPassword;
        private Button buttonPrescriptionGenerate;
        private Button buttonUserDelete;
        private DataGridView dataPrescriptionMedicines;
    }
}