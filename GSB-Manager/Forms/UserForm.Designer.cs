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
            buttonPrescriptionModify = new Button();
            buttonPrescriptionCancel = new Button();
            buttonPrescriptionRegister = new Button();
            panelPrescriptionDetails = new Panel();
            dateTimePickerPrescriptionValidity = new DateTimePicker();
            comboBoxPrescriptionPatient = new ComboBox();
            comboBoxPrescriptionMedicine = new ComboBox();
            textBoxPrescriptionPatient = new TextBox();
            labelPrescriptionPatient = new Label();
            textBoxPrescriptionDoctor = new TextBox();
            textBoxPrescriptionValidity = new TextBox();
            textBoxPrescriptionQuantity = new TextBox();
            textBoxPrescriptionMedicines = new TextBox();
            labelPrescriptionValidity = new Label();
            labelPrescriptionQuantity = new Label();
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
            tabControl.SuspendLayout();
            tabMedicines.SuspendLayout();
            panelMedicineDetails.SuspendLayout();
            tabPrescriptions.SuspendLayout();
            panelPrescriptionDetails.SuspendLayout();
            tabPatients.SuspendLayout();
            panelPatientDetails.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl
            // 
            tabControl.Controls.Add(tabMedicines);
            tabControl.Controls.Add(tabPrescriptions);
            tabControl.Controls.Add(tabPatients);
            tabControl.Dock = DockStyle.Fill;
            tabControl.Location = new Point(0, 0);
            tabControl.Margin = new Padding(3, 4, 3, 4);
            tabControl.Name = "tabControl";
            tabControl.SelectedIndex = 0;
            tabControl.Size = new Size(800, 562);
            tabControl.TabIndex = 0;
            // 
            // tabMedicines
            // 
            tabMedicines.Controls.Add(buttonMedicineModify);
            tabMedicines.Controls.Add(buttonMedicineCancel);
            tabMedicines.Controls.Add(buttonMedicineRegister);
            tabMedicines.Controls.Add(panelMedicineDetails);
            tabMedicines.Controls.Add(listMedicines);
            tabMedicines.Controls.Add(btnAddMedicine);
            tabMedicines.Controls.Add(btnEditMedicine);
            tabMedicines.Controls.Add(btnDeleteMedicine);
            tabMedicines.Location = new Point(4, 29);
            tabMedicines.Margin = new Padding(3, 4, 3, 4);
            tabMedicines.Name = "tabMedicines";
            tabMedicines.Size = new Size(792, 529);
            tabMedicines.TabIndex = 0;
            tabMedicines.Text = "Medicines";
            tabMedicines.UseVisualStyleBackColor = true;
            // 
            // buttonMedicineModify
            // 
            buttonMedicineModify.Location = new Point(480, 457);
            buttonMedicineModify.Margin = new Padding(3, 4, 3, 4);
            buttonMedicineModify.Name = "buttonMedicineModify";
            buttonMedicineModify.Size = new Size(119, 29);
            buttonMedicineModify.TabIndex = 7;
            buttonMedicineModify.Text = "Modify";
            buttonMedicineModify.Visible = false;
            buttonMedicineModify.Click += buttonMedicineModify_Click;
            // 
            // buttonMedicineCancel
            // 
            buttonMedicineCancel.Location = new Point(605, 457);
            buttonMedicineCancel.Margin = new Padding(3, 4, 3, 4);
            buttonMedicineCancel.Name = "buttonMedicineCancel";
            buttonMedicineCancel.Size = new Size(110, 29);
            buttonMedicineCancel.TabIndex = 6;
            buttonMedicineCancel.Text = "Cancel";
            buttonMedicineCancel.Visible = false;
            // 
            // buttonMedicineRegister
            // 
            buttonMedicineRegister.Location = new Point(480, 457);
            buttonMedicineRegister.Margin = new Padding(3, 4, 3, 4);
            buttonMedicineRegister.Name = "buttonMedicineRegister";
            buttonMedicineRegister.Size = new Size(119, 29);
            buttonMedicineRegister.TabIndex = 5;
            buttonMedicineRegister.Text = "Register";
            buttonMedicineRegister.Visible = false;
            buttonMedicineRegister.Click += buttonMedicineRegister_Click;
            // 
            // panelMedicineDetails
            // 
            panelMedicineDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMedicineDetails.BorderStyle = BorderStyle.FixedSingle;
            panelMedicineDetails.Controls.Add(textBoxMedicineName);
            panelMedicineDetails.Controls.Add(labelMedicineName);
            panelMedicineDetails.Controls.Add(labelMedicineDoctor);
            panelMedicineDetails.Controls.Add(textBoxMedicineDescription);
            panelMedicineDetails.Controls.Add(textBoxMedicineMolecule);
            panelMedicineDetails.Controls.Add(textBoxMedicineDosage);
            panelMedicineDetails.Controls.Add(labelMedicineMolecule);
            panelMedicineDetails.Controls.Add(labelMedicineDescription);
            panelMedicineDetails.Controls.Add(labelMedicineDosage);
            panelMedicineDetails.Controls.Add(labelMedicine);
            panelMedicineDetails.Location = new Point(10, 12);
            panelMedicineDetails.Margin = new Padding(3, 4, 3, 4);
            panelMedicineDetails.Name = "panelMedicineDetails";
            panelMedicineDetails.Size = new Size(450, 474);
            panelMedicineDetails.TabIndex = 0;
            // 
            // textBoxMedicineName
            // 
            textBoxMedicineName.Location = new Point(25, 414);
            textBoxMedicineName.Name = "textBoxMedicineName";
            textBoxMedicineName.Size = new Size(252, 27);
            textBoxMedicineName.TabIndex = 11;
            textBoxMedicineName.Visible = false;
            // 
            // labelMedicineName
            // 
            labelMedicineName.AutoSize = true;
            labelMedicineName.Location = new Point(25, 391);
            labelMedicineName.Name = "labelMedicineName";
            labelMedicineName.Size = new Size(56, 20);
            labelMedicineName.TabIndex = 10;
            labelMedicineName.Text = "Name :";
            labelMedicineName.Visible = false;
            // 
            // labelMedicineDoctor
            // 
            labelMedicineDoctor.AutoSize = true;
            labelMedicineDoctor.Location = new Point(25, 382);
            labelMedicineDoctor.Name = "labelMedicineDoctor";
            labelMedicineDoctor.Size = new Size(0, 20);
            labelMedicineDoctor.TabIndex = 9;
            // 
            // textBoxMedicineDescription
            // 
            textBoxMedicineDescription.Location = new Point(25, 178);
            textBoxMedicineDescription.Multiline = true;
            textBoxMedicineDescription.Name = "textBoxMedicineDescription";
            textBoxMedicineDescription.ReadOnly = true;
            textBoxMedicineDescription.Size = new Size(369, 103);
            textBoxMedicineDescription.TabIndex = 8;
            // 
            // textBoxMedicineMolecule
            // 
            textBoxMedicineMolecule.Location = new Point(25, 334);
            textBoxMedicineMolecule.Name = "textBoxMedicineMolecule";
            textBoxMedicineMolecule.ReadOnly = true;
            textBoxMedicineMolecule.Size = new Size(252, 27);
            textBoxMedicineMolecule.TabIndex = 7;
            // 
            // textBoxMedicineDosage
            // 
            textBoxMedicineDosage.Location = new Point(25, 81);
            textBoxMedicineDosage.Name = "textBoxMedicineDosage";
            textBoxMedicineDosage.ReadOnly = true;
            textBoxMedicineDosage.Size = new Size(125, 27);
            textBoxMedicineDosage.TabIndex = 5;
            // 
            // labelMedicineMolecule
            // 
            labelMedicineMolecule.AutoSize = true;
            labelMedicineMolecule.Location = new Point(25, 311);
            labelMedicineMolecule.Name = "labelMedicineMolecule";
            labelMedicineMolecule.Size = new Size(77, 20);
            labelMedicineMolecule.TabIndex = 4;
            labelMedicineMolecule.Text = "Molecule :";
            // 
            // labelMedicineDescription
            // 
            labelMedicineDescription.AutoSize = true;
            labelMedicineDescription.Location = new Point(25, 140);
            labelMedicineDescription.Name = "labelMedicineDescription";
            labelMedicineDescription.Size = new Size(92, 20);
            labelMedicineDescription.TabIndex = 3;
            labelMedicineDescription.Text = "Description :";
            // 
            // labelMedicineDosage
            // 
            labelMedicineDosage.AutoSize = true;
            labelMedicineDosage.Location = new Point(25, 58);
            labelMedicineDosage.Name = "labelMedicineDosage";
            labelMedicineDosage.Size = new Size(67, 20);
            labelMedicineDosage.TabIndex = 1;
            labelMedicineDosage.Text = "Dosage :";
            // 
            // labelMedicine
            // 
            labelMedicine.AutoSize = true;
            labelMedicine.Location = new Point(180, 19);
            labelMedicine.Name = "labelMedicine";
            labelMedicine.Size = new Size(70, 20);
            labelMedicine.TabIndex = 0;
            labelMedicine.Text = "Medicine";
            // 
            // listMedicines
            // 
            listMedicines.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listMedicines.HorizontalScrollbar = true;
            listMedicines.Location = new Point(480, 12);
            listMedicines.Margin = new Padding(3, 4, 3, 4);
            listMedicines.Name = "listMedicines";
            listMedicines.Size = new Size(300, 384);
            listMedicines.TabIndex = 1;
            listMedicines.SelectedIndexChanged += listMedicines_SelectedIndexChanged;
            // 
            // btnAddMedicine
            // 
            btnAddMedicine.Location = new Point(480, 425);
            btnAddMedicine.Margin = new Padding(3, 4, 3, 4);
            btnAddMedicine.Name = "btnAddMedicine";
            btnAddMedicine.Size = new Size(75, 29);
            btnAddMedicine.TabIndex = 2;
            btnAddMedicine.Text = "Add";
            btnAddMedicine.Click += btnAddMedicine_Click;
            // 
            // btnEditMedicine
            // 
            btnEditMedicine.Location = new Point(560, 425);
            btnEditMedicine.Margin = new Padding(3, 4, 3, 4);
            btnEditMedicine.Name = "btnEditMedicine";
            btnEditMedicine.Size = new Size(75, 29);
            btnEditMedicine.TabIndex = 3;
            btnEditMedicine.Text = "Edit";
            btnEditMedicine.Click += btnEditMedicine_Click;
            // 
            // btnDeleteMedicine
            // 
            btnDeleteMedicine.Location = new Point(640, 425);
            btnDeleteMedicine.Margin = new Padding(3, 4, 3, 4);
            btnDeleteMedicine.Name = "btnDeleteMedicine";
            btnDeleteMedicine.Size = new Size(75, 29);
            btnDeleteMedicine.TabIndex = 4;
            btnDeleteMedicine.Text = "Delete";
            btnDeleteMedicine.Click += btnDeleteMedicine_Click;
            // 
            // tabPrescriptions
            // 
            tabPrescriptions.Controls.Add(buttonPrescriptionModify);
            tabPrescriptions.Controls.Add(buttonPrescriptionCancel);
            tabPrescriptions.Controls.Add(buttonPrescriptionRegister);
            tabPrescriptions.Controls.Add(panelPrescriptionDetails);
            tabPrescriptions.Controls.Add(listPrescriptions);
            tabPrescriptions.Controls.Add(btnAddPrescription);
            tabPrescriptions.Controls.Add(btnEditPrescription);
            tabPrescriptions.Controls.Add(btnDeletePrescription);
            tabPrescriptions.Location = new Point(4, 29);
            tabPrescriptions.Margin = new Padding(3, 4, 3, 4);
            tabPrescriptions.Name = "tabPrescriptions";
            tabPrescriptions.Size = new Size(792, 529);
            tabPrescriptions.TabIndex = 1;
            tabPrescriptions.Text = "Prescriptions";
            tabPrescriptions.UseVisualStyleBackColor = true;
            // 
            // buttonPrescriptionModify
            // 
            buttonPrescriptionModify.Location = new Point(480, 457);
            buttonPrescriptionModify.Margin = new Padding(3, 4, 3, 4);
            buttonPrescriptionModify.Name = "buttonPrescriptionModify";
            buttonPrescriptionModify.Size = new Size(119, 29);
            buttonPrescriptionModify.TabIndex = 8;
            buttonPrescriptionModify.Text = "Modify";
            buttonPrescriptionModify.Visible = false;
            buttonPrescriptionModify.Click += buttonPrescriptionModify_Click;
            // 
            // buttonPrescriptionCancel
            // 
            buttonPrescriptionCancel.Location = new Point(605, 457);
            buttonPrescriptionCancel.Margin = new Padding(3, 4, 3, 4);
            buttonPrescriptionCancel.Name = "buttonPrescriptionCancel";
            buttonPrescriptionCancel.Size = new Size(110, 29);
            buttonPrescriptionCancel.TabIndex = 7;
            buttonPrescriptionCancel.Text = "Cancel";
            buttonPrescriptionCancel.Visible = false;
            // 
            // buttonPrescriptionRegister
            // 
            buttonPrescriptionRegister.Location = new Point(480, 457);
            buttonPrescriptionRegister.Margin = new Padding(3, 4, 3, 4);
            buttonPrescriptionRegister.Name = "buttonPrescriptionRegister";
            buttonPrescriptionRegister.Size = new Size(119, 29);
            buttonPrescriptionRegister.TabIndex = 6;
            buttonPrescriptionRegister.Text = "Register";
            buttonPrescriptionRegister.Visible = false;
            buttonPrescriptionRegister.Click += buttonPrescriptionRegister_Click;
            // 
            // panelPrescriptionDetails
            // 
            panelPrescriptionDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelPrescriptionDetails.BorderStyle = BorderStyle.FixedSingle;
            panelPrescriptionDetails.Controls.Add(dateTimePickerPrescriptionValidity);
            panelPrescriptionDetails.Controls.Add(comboBoxPrescriptionPatient);
            panelPrescriptionDetails.Controls.Add(comboBoxPrescriptionMedicine);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionPatient);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionPatient);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionDoctor);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionValidity);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionQuantity);
            panelPrescriptionDetails.Controls.Add(textBoxPrescriptionMedicines);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionValidity);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionQuantity);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionMedicines);
            panelPrescriptionDetails.Controls.Add(labelPrescriptionDoctor);
            panelPrescriptionDetails.Controls.Add(labelPrescription);
            panelPrescriptionDetails.Location = new Point(10, 12);
            panelPrescriptionDetails.Margin = new Padding(3, 4, 3, 4);
            panelPrescriptionDetails.Name = "panelPrescriptionDetails";
            panelPrescriptionDetails.Size = new Size(450, 474);
            panelPrescriptionDetails.TabIndex = 0;
            // 
            // dateTimePickerPrescriptionValidity
            // 
            dateTimePickerPrescriptionValidity.Location = new Point(27, 230);
            dateTimePickerPrescriptionValidity.Name = "dateTimePickerPrescriptionValidity";
            dateTimePickerPrescriptionValidity.Size = new Size(250, 27);
            dateTimePickerPrescriptionValidity.TabIndex = 14;
            dateTimePickerPrescriptionValidity.Visible = false;
            // 
            // comboBoxPrescriptionPatient
            // 
            comboBoxPrescriptionPatient.FormattingEnabled = true;
            comboBoxPrescriptionPatient.Location = new Point(27, 375);
            comboBoxPrescriptionPatient.Name = "comboBoxPrescriptionPatient";
            comboBoxPrescriptionPatient.Size = new Size(211, 28);
            comboBoxPrescriptionPatient.TabIndex = 13;
            comboBoxPrescriptionPatient.Visible = false;
            // 
            // comboBoxPrescriptionMedicine
            // 
            comboBoxPrescriptionMedicine.FormattingEnabled = true;
            comboBoxPrescriptionMedicine.Location = new Point(27, 100);
            comboBoxPrescriptionMedicine.Name = "comboBoxPrescriptionMedicine";
            comboBoxPrescriptionMedicine.Size = new Size(211, 28);
            comboBoxPrescriptionMedicine.TabIndex = 11;
            comboBoxPrescriptionMedicine.Visible = false;
            comboBoxPrescriptionMedicine.SelectedIndexChanged += comboBoxPrescriptionMedicine_SelectedIndexChanged;
            // 
            // textBoxPrescriptionPatient
            // 
            textBoxPrescriptionPatient.Location = new Point(27, 375);
            textBoxPrescriptionPatient.Name = "textBoxPrescriptionPatient";
            textBoxPrescriptionPatient.ReadOnly = true;
            textBoxPrescriptionPatient.Size = new Size(211, 27);
            textBoxPrescriptionPatient.TabIndex = 10;
            // 
            // labelPrescriptionPatient
            // 
            labelPrescriptionPatient.AutoSize = true;
            labelPrescriptionPatient.Location = new Point(27, 352);
            labelPrescriptionPatient.Name = "labelPrescriptionPatient";
            labelPrescriptionPatient.Size = new Size(61, 20);
            labelPrescriptionPatient.TabIndex = 9;
            labelPrescriptionPatient.Text = "Patient :";
            // 
            // textBoxPrescriptionDoctor
            // 
            textBoxPrescriptionDoctor.Location = new Point(27, 301);
            textBoxPrescriptionDoctor.Name = "textBoxPrescriptionDoctor";
            textBoxPrescriptionDoctor.ReadOnly = true;
            textBoxPrescriptionDoctor.Size = new Size(211, 27);
            textBoxPrescriptionDoctor.TabIndex = 8;
            // 
            // textBoxPrescriptionValidity
            // 
            textBoxPrescriptionValidity.Location = new Point(27, 230);
            textBoxPrescriptionValidity.Name = "textBoxPrescriptionValidity";
            textBoxPrescriptionValidity.ReadOnly = true;
            textBoxPrescriptionValidity.Size = new Size(211, 27);
            textBoxPrescriptionValidity.TabIndex = 7;
            // 
            // textBoxPrescriptionQuantity
            // 
            textBoxPrescriptionQuantity.Location = new Point(27, 154);
            textBoxPrescriptionQuantity.Name = "textBoxPrescriptionQuantity";
            textBoxPrescriptionQuantity.ReadOnly = true;
            textBoxPrescriptionQuantity.Size = new Size(109, 27);
            textBoxPrescriptionQuantity.TabIndex = 6;
            // 
            // textBoxPrescriptionMedicines
            // 
            textBoxPrescriptionMedicines.Location = new Point(27, 69);
            textBoxPrescriptionMedicines.Name = "textBoxPrescriptionMedicines";
            textBoxPrescriptionMedicines.ReadOnly = true;
            textBoxPrescriptionMedicines.Size = new Size(378, 27);
            textBoxPrescriptionMedicines.TabIndex = 5;
            // 
            // labelPrescriptionValidity
            // 
            labelPrescriptionValidity.AutoSize = true;
            labelPrescriptionValidity.Location = new Point(27, 207);
            labelPrescriptionValidity.Name = "labelPrescriptionValidity";
            labelPrescriptionValidity.Size = new Size(65, 20);
            labelPrescriptionValidity.TabIndex = 4;
            labelPrescriptionValidity.Text = "Validity :";
            // 
            // labelPrescriptionQuantity
            // 
            labelPrescriptionQuantity.AutoSize = true;
            labelPrescriptionQuantity.Location = new Point(27, 131);
            labelPrescriptionQuantity.Name = "labelPrescriptionQuantity";
            labelPrescriptionQuantity.Size = new Size(72, 20);
            labelPrescriptionQuantity.TabIndex = 3;
            labelPrescriptionQuantity.Text = "Quantity :";
            // 
            // labelPrescriptionMedicines
            // 
            labelPrescriptionMedicines.AutoSize = true;
            labelPrescriptionMedicines.Location = new Point(27, 46);
            labelPrescriptionMedicines.Name = "labelPrescriptionMedicines";
            labelPrescriptionMedicines.Size = new Size(83, 20);
            labelPrescriptionMedicines.TabIndex = 2;
            labelPrescriptionMedicines.Text = "Medicines :";
            // 
            // labelPrescriptionDoctor
            // 
            labelPrescriptionDoctor.AutoSize = true;
            labelPrescriptionDoctor.Location = new Point(27, 278);
            labelPrescriptionDoctor.Name = "labelPrescriptionDoctor";
            labelPrescriptionDoctor.Size = new Size(62, 20);
            labelPrescriptionDoctor.TabIndex = 1;
            labelPrescriptionDoctor.Text = "Doctor :";
            // 
            // labelPrescription
            // 
            labelPrescription.AutoSize = true;
            labelPrescription.Location = new Point(180, 14);
            labelPrescription.Name = "labelPrescription";
            labelPrescription.Size = new Size(87, 20);
            labelPrescription.TabIndex = 0;
            labelPrescription.Text = "Prescription";
            // 
            // listPrescriptions
            // 
            listPrescriptions.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listPrescriptions.HorizontalScrollbar = true;
            listPrescriptions.Location = new Point(480, 12);
            listPrescriptions.Margin = new Padding(3, 4, 3, 4);
            listPrescriptions.Name = "listPrescriptions";
            listPrescriptions.Size = new Size(300, 384);
            listPrescriptions.TabIndex = 1;
            listPrescriptions.SelectedIndexChanged += listPrescriptions_SelectedIndexChanged;
            // 
            // btnAddPrescription
            // 
            btnAddPrescription.Location = new Point(480, 425);
            btnAddPrescription.Margin = new Padding(3, 4, 3, 4);
            btnAddPrescription.Name = "btnAddPrescription";
            btnAddPrescription.Size = new Size(75, 29);
            btnAddPrescription.TabIndex = 2;
            btnAddPrescription.Text = "Add";
            btnAddPrescription.Click += btnAddPrescription_Click;
            // 
            // btnEditPrescription
            // 
            btnEditPrescription.Location = new Point(560, 425);
            btnEditPrescription.Margin = new Padding(3, 4, 3, 4);
            btnEditPrescription.Name = "btnEditPrescription";
            btnEditPrescription.Size = new Size(75, 29);
            btnEditPrescription.TabIndex = 3;
            btnEditPrescription.Text = "Edit";
            btnEditPrescription.Click += btnEditPrescription_Click;
            // 
            // btnDeletePrescription
            // 
            btnDeletePrescription.Location = new Point(640, 425);
            btnDeletePrescription.Margin = new Padding(3, 4, 3, 4);
            btnDeletePrescription.Name = "btnDeletePrescription";
            btnDeletePrescription.Size = new Size(75, 29);
            btnDeletePrescription.TabIndex = 4;
            btnDeletePrescription.Text = "Delete";
            btnDeletePrescription.Click += btnDeletePrescription_Click;
            // 
            // tabPatients
            // 
            tabPatients.Controls.Add(buttonPatientModify);
            tabPatients.Controls.Add(buttonPatientCancel);
            tabPatients.Controls.Add(buttonPatientRegister);
            tabPatients.Controls.Add(panelPatientDetails);
            tabPatients.Controls.Add(listPatients);
            tabPatients.Controls.Add(btnAddPatient);
            tabPatients.Controls.Add(btnEditPatient);
            tabPatients.Controls.Add(btnDeletePatient);
            tabPatients.Location = new Point(4, 29);
            tabPatients.Margin = new Padding(3, 4, 3, 4);
            tabPatients.Name = "tabPatients";
            tabPatients.Size = new Size(792, 529);
            tabPatients.TabIndex = 2;
            tabPatients.Text = "Patients";
            tabPatients.UseVisualStyleBackColor = true;
            // 
            // buttonPatientModify
            // 
            buttonPatientModify.Location = new Point(480, 457);
            buttonPatientModify.Margin = new Padding(3, 4, 3, 4);
            buttonPatientModify.Name = "buttonPatientModify";
            buttonPatientModify.Size = new Size(119, 29);
            buttonPatientModify.TabIndex = 13;
            buttonPatientModify.Text = "Modify";
            buttonPatientModify.Visible = false;
            buttonPatientModify.Click += buttonPatientModify_Click;
            // 
            // buttonPatientCancel
            // 
            buttonPatientCancel.Location = new Point(605, 457);
            buttonPatientCancel.Margin = new Padding(3, 4, 3, 4);
            buttonPatientCancel.Name = "buttonPatientCancel";
            buttonPatientCancel.Size = new Size(110, 29);
            buttonPatientCancel.TabIndex = 7;
            buttonPatientCancel.Text = "Cancel";
            buttonPatientCancel.Visible = false;
            // 
            // buttonPatientRegister
            // 
            buttonPatientRegister.Location = new Point(480, 457);
            buttonPatientRegister.Margin = new Padding(3, 4, 3, 4);
            buttonPatientRegister.Name = "buttonPatientRegister";
            buttonPatientRegister.Size = new Size(119, 29);
            buttonPatientRegister.TabIndex = 6;
            buttonPatientRegister.Text = "Register";
            buttonPatientRegister.Visible = false;
            buttonPatientRegister.Click += buttonPatientRegister_Click;
            // 
            // panelPatientDetails
            // 
            panelPatientDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelPatientDetails.BorderStyle = BorderStyle.FixedSingle;
            panelPatientDetails.Controls.Add(labelPatientFirstname);
            panelPatientDetails.Controls.Add(textBoxPatientFirstname);
            panelPatientDetails.Controls.Add(textBoxPatientName);
            panelPatientDetails.Controls.Add(labelPatientName);
            panelPatientDetails.Controls.Add(comboBoxPatientGender);
            panelPatientDetails.Controls.Add(textBoxPatientAge);
            panelPatientDetails.Controls.Add(textBoxPatientDoctor);
            panelPatientDetails.Controls.Add(textBoxPatientGender);
            panelPatientDetails.Controls.Add(labelPatientGender);
            panelPatientDetails.Controls.Add(labelPatientAge);
            panelPatientDetails.Controls.Add(label2);
            panelPatientDetails.Controls.Add(labelPatientDoctor);
            panelPatientDetails.Controls.Add(labelPatient);
            panelPatientDetails.Location = new Point(10, 12);
            panelPatientDetails.Margin = new Padding(3, 4, 3, 4);
            panelPatientDetails.Name = "panelPatientDetails";
            panelPatientDetails.Size = new Size(450, 474);
            panelPatientDetails.TabIndex = 0;
            // 
            // labelPatientFirstname
            // 
            labelPatientFirstname.AutoSize = true;
            labelPatientFirstname.Location = new Point(31, 315);
            labelPatientFirstname.Name = "labelPatientFirstname";
            labelPatientFirstname.Size = new Size(72, 20);
            labelPatientFirstname.TabIndex = 12;
            labelPatientFirstname.Text = "Firstame :";
            labelPatientFirstname.Visible = false;
            // 
            // textBoxPatientFirstname
            // 
            textBoxPatientFirstname.Location = new Point(27, 338);
            textBoxPatientFirstname.Name = "textBoxPatientFirstname";
            textBoxPatientFirstname.Size = new Size(175, 27);
            textBoxPatientFirstname.TabIndex = 11;
            textBoxPatientFirstname.Visible = false;
            // 
            // textBoxPatientName
            // 
            textBoxPatientName.Location = new Point(27, 246);
            textBoxPatientName.Name = "textBoxPatientName";
            textBoxPatientName.Size = new Size(175, 27);
            textBoxPatientName.TabIndex = 10;
            textBoxPatientName.Visible = false;
            // 
            // labelPatientName
            // 
            labelPatientName.AutoSize = true;
            labelPatientName.Location = new Point(31, 223);
            labelPatientName.Name = "labelPatientName";
            labelPatientName.Size = new Size(56, 20);
            labelPatientName.TabIndex = 9;
            labelPatientName.Text = "Name :";
            labelPatientName.Visible = false;
            // 
            // comboBoxPatientGender
            // 
            comboBoxPatientGender.FormattingEnabled = true;
            comboBoxPatientGender.Location = new Point(27, 90);
            comboBoxPatientGender.Name = "comboBoxPatientGender";
            comboBoxPatientGender.Size = new Size(151, 28);
            comboBoxPatientGender.TabIndex = 8;
            comboBoxPatientGender.Visible = false;
            // 
            // textBoxPatientAge
            // 
            textBoxPatientAge.Location = new Point(25, 171);
            textBoxPatientAge.Name = "textBoxPatientAge";
            textBoxPatientAge.ReadOnly = true;
            textBoxPatientAge.Size = new Size(153, 27);
            textBoxPatientAge.TabIndex = 7;
            // 
            // textBoxPatientDoctor
            // 
            textBoxPatientDoctor.Location = new Point(25, 246);
            textBoxPatientDoctor.Name = "textBoxPatientDoctor";
            textBoxPatientDoctor.ReadOnly = true;
            textBoxPatientDoctor.Size = new Size(153, 27);
            textBoxPatientDoctor.TabIndex = 6;
            // 
            // textBoxPatientGender
            // 
            textBoxPatientGender.Location = new Point(25, 90);
            textBoxPatientGender.Name = "textBoxPatientGender";
            textBoxPatientGender.ReadOnly = true;
            textBoxPatientGender.Size = new Size(153, 27);
            textBoxPatientGender.TabIndex = 5;
            // 
            // labelPatientGender
            // 
            labelPatientGender.AutoSize = true;
            labelPatientGender.Location = new Point(25, 67);
            labelPatientGender.Name = "labelPatientGender";
            labelPatientGender.Size = new Size(64, 20);
            labelPatientGender.TabIndex = 4;
            labelPatientGender.Text = "Gender :";
            // 
            // labelPatientAge
            // 
            labelPatientAge.AutoSize = true;
            labelPatientAge.Location = new Point(25, 148);
            labelPatientAge.Name = "labelPatientAge";
            labelPatientAge.Size = new Size(43, 20);
            labelPatientAge.TabIndex = 3;
            labelPatientAge.Text = "Age :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(178, 289);
            label2.Name = "label2";
            label2.Size = new Size(0, 20);
            label2.TabIndex = 2;
            // 
            // labelPatientDoctor
            // 
            labelPatientDoctor.AutoSize = true;
            labelPatientDoctor.Location = new Point(25, 223);
            labelPatientDoctor.Name = "labelPatientDoctor";
            labelPatientDoctor.Size = new Size(62, 20);
            labelPatientDoctor.TabIndex = 1;
            labelPatientDoctor.Text = "Doctor :";
            // 
            // labelPatient
            // 
            labelPatient.AutoSize = true;
            labelPatient.Location = new Point(194, 18);
            labelPatient.Name = "labelPatient";
            labelPatient.Size = new Size(54, 20);
            labelPatient.TabIndex = 0;
            labelPatient.Text = "Patient";
            // 
            // listPatients
            // 
            listPatients.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            listPatients.HorizontalScrollbar = true;
            listPatients.Location = new Point(480, 12);
            listPatients.Margin = new Padding(3, 4, 3, 4);
            listPatients.Name = "listPatients";
            listPatients.Size = new Size(300, 384);
            listPatients.TabIndex = 1;
            listPatients.SelectedIndexChanged += listPatients_SelectedIndexChanged;
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(480, 425);
            btnAddPatient.Margin = new Padding(3, 4, 3, 4);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(75, 29);
            btnAddPatient.TabIndex = 2;
            btnAddPatient.Text = "Add";
            btnAddPatient.Click += btnAddPatient_Click;
            // 
            // btnEditPatient
            // 
            btnEditPatient.Location = new Point(560, 425);
            btnEditPatient.Margin = new Padding(3, 4, 3, 4);
            btnEditPatient.Name = "btnEditPatient";
            btnEditPatient.Size = new Size(75, 29);
            btnEditPatient.TabIndex = 3;
            btnEditPatient.Text = "Edit";
            btnEditPatient.Click += btnEditPatient_Click;
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Location = new Point(640, 425);
            btnDeletePatient.Margin = new Padding(3, 4, 3, 4);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(75, 29);
            btnDeletePatient.TabIndex = 4;
            btnDeletePatient.Text = "Delete";
            btnDeletePatient.Click += btnDeletePatient_Click;
            // 
            // UserForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(tabControl);
            Margin = new Padding(3, 4, 3, 4);
            Name = "UserForm";
            Text = "UserForm";
            tabControl.ResumeLayout(false);
            tabMedicines.ResumeLayout(false);
            panelMedicineDetails.ResumeLayout(false);
            panelMedicineDetails.PerformLayout();
            tabPrescriptions.ResumeLayout(false);
            panelPrescriptionDetails.ResumeLayout(false);
            panelPrescriptionDetails.PerformLayout();
            tabPatients.ResumeLayout(false);
            panelPatientDetails.ResumeLayout(false);
            panelPatientDetails.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

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
        private Label labelPrescriptionQuantity;
        private Label labelPrescriptionMedicines;
        private Label labelPrescriptionDoctor;
        private TextBox textBoxPrescriptionQuantity;
        private TextBox textBoxPrescriptionMedicines;
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
    }
}