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
            buttonMedicineRegister = new Button();
            panelMedicineDetails = new Panel();
            textBoxMedicineDescription = new TextBox();
            textBoxMedicineMolecule = new TextBox();
            textBoxMoleculeName = new TextBox();
            textBoxMedicineDosage = new TextBox();
            labelMedicineMolecule = new Label();
            labelMedicineDescription = new Label();
            labelMedicineName = new Label();
            labelMedicineDosage = new Label();
            labelMedicine = new Label();
            listMedicines = new ListBox();
            btnAddMedicine = new Button();
            btnEditMedicine = new Button();
            btnDeleteMedicine = new Button();
            tabPrescriptions = new TabPage();
            panelPrescriptionDetails = new Panel();
            listPrescriptions = new ListBox();
            btnAddPrescription = new Button();
            btnEditPrescription = new Button();
            btnDeletePrescription = new Button();
            tabPatients = new TabPage();
            panelPatientDetails = new Panel();
            listPatients = new ListBox();
            btnAddPatient = new Button();
            btnEditPatient = new Button();
            btnDeletePatient = new Button();
            buttonMedicineCancel = new Button();
            tabControl.SuspendLayout();
            tabMedicines.SuspendLayout();
            panelMedicineDetails.SuspendLayout();
            tabPrescriptions.SuspendLayout();
            tabPatients.SuspendLayout();
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
            // buttonMedicineRegister
            // 
            buttonMedicineRegister.Location = new Point(480, 457);
            buttonMedicineRegister.Margin = new Padding(3, 4, 3, 4);
            buttonMedicineRegister.Name = "buttonMedicineRegister";
            buttonMedicineRegister.Size = new Size(119, 29);
            buttonMedicineRegister.TabIndex = 5;
            buttonMedicineRegister.Text = "Register";
            buttonMedicineRegister.Visible = false;
            // 
            // panelMedicineDetails
            // 
            panelMedicineDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelMedicineDetails.BorderStyle = BorderStyle.FixedSingle;
            panelMedicineDetails.Controls.Add(textBoxMedicineDescription);
            panelMedicineDetails.Controls.Add(textBoxMedicineMolecule);
            panelMedicineDetails.Controls.Add(textBoxMoleculeName);
            panelMedicineDetails.Controls.Add(textBoxMedicineDosage);
            panelMedicineDetails.Controls.Add(labelMedicineMolecule);
            panelMedicineDetails.Controls.Add(labelMedicineDescription);
            panelMedicineDetails.Controls.Add(labelMedicineName);
            panelMedicineDetails.Controls.Add(labelMedicineDosage);
            panelMedicineDetails.Controls.Add(labelMedicine);
            panelMedicineDetails.Location = new Point(10, 12);
            panelMedicineDetails.Margin = new Padding(3, 4, 3, 4);
            panelMedicineDetails.Name = "panelMedicineDetails";
            panelMedicineDetails.Size = new Size(450, 474);
            panelMedicineDetails.TabIndex = 0;
            // 
            // textBoxMedicineDescription
            // 
            textBoxMedicineDescription.Location = new Point(25, 249);
            textBoxMedicineDescription.Multiline = true;
            textBoxMedicineDescription.Name = "textBoxMedicineDescription";
            textBoxMedicineDescription.ReadOnly = true;
            textBoxMedicineDescription.Size = new Size(369, 103);
            textBoxMedicineDescription.TabIndex = 8;
            // 
            // textBoxMedicineMolecule
            // 
            textBoxMedicineMolecule.Location = new Point(25, 401);
            textBoxMedicineMolecule.Name = "textBoxMedicineMolecule";
            textBoxMedicineMolecule.ReadOnly = true;
            textBoxMedicineMolecule.Size = new Size(252, 27);
            textBoxMedicineMolecule.TabIndex = 7;
            // 
            // textBoxMoleculeName
            // 
            textBoxMoleculeName.Location = new Point(25, 177);
            textBoxMoleculeName.Name = "textBoxMoleculeName";
            textBoxMoleculeName.ReadOnly = true;
            textBoxMoleculeName.Size = new Size(252, 27);
            textBoxMoleculeName.TabIndex = 6;
            // 
            // textBoxMedicineDosage
            // 
            textBoxMedicineDosage.Location = new Point(25, 104);
            textBoxMedicineDosage.Name = "textBoxMedicineDosage";
            textBoxMedicineDosage.ReadOnly = true;
            textBoxMedicineDosage.Size = new Size(125, 27);
            textBoxMedicineDosage.TabIndex = 5;
            // 
            // labelMedicineMolecule
            // 
            labelMedicineMolecule.AutoSize = true;
            labelMedicineMolecule.Location = new Point(25, 378);
            labelMedicineMolecule.Name = "labelMedicineMolecule";
            labelMedicineMolecule.Size = new Size(77, 20);
            labelMedicineMolecule.TabIndex = 4;
            labelMedicineMolecule.Text = "Molecule :";
            // 
            // labelMedicineDescription
            // 
            labelMedicineDescription.AutoSize = true;
            labelMedicineDescription.Location = new Point(25, 226);
            labelMedicineDescription.Name = "labelMedicineDescription";
            labelMedicineDescription.Size = new Size(92, 20);
            labelMedicineDescription.TabIndex = 3;
            labelMedicineDescription.Text = "Description :";
            // 
            // labelMedicineName
            // 
            labelMedicineName.AutoSize = true;
            labelMedicineName.Location = new Point(25, 154);
            labelMedicineName.Name = "labelMedicineName";
            labelMedicineName.Size = new Size(56, 20);
            labelMedicineName.TabIndex = 2;
            labelMedicineName.Text = "Name :";
            // 
            // labelMedicineDosage
            // 
            labelMedicineDosage.AutoSize = true;
            labelMedicineDosage.Location = new Point(25, 81);
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
            // 
            // btnDeleteMedicine
            // 
            btnDeleteMedicine.Location = new Point(640, 425);
            btnDeleteMedicine.Margin = new Padding(3, 4, 3, 4);
            btnDeleteMedicine.Name = "btnDeleteMedicine";
            btnDeleteMedicine.Size = new Size(75, 29);
            btnDeleteMedicine.TabIndex = 4;
            btnDeleteMedicine.Text = "Delete";
            // 
            // tabPrescriptions
            // 
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
            // panelPrescriptionDetails
            // 
            panelPrescriptionDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelPrescriptionDetails.BorderStyle = BorderStyle.FixedSingle;
            panelPrescriptionDetails.Location = new Point(10, 12);
            panelPrescriptionDetails.Margin = new Padding(3, 4, 3, 4);
            panelPrescriptionDetails.Name = "panelPrescriptionDetails";
            panelPrescriptionDetails.Size = new Size(450, 474);
            panelPrescriptionDetails.TabIndex = 0;
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
            // 
            // btnAddPrescription
            // 
            btnAddPrescription.Location = new Point(480, 425);
            btnAddPrescription.Margin = new Padding(3, 4, 3, 4);
            btnAddPrescription.Name = "btnAddPrescription";
            btnAddPrescription.Size = new Size(75, 29);
            btnAddPrescription.TabIndex = 2;
            btnAddPrescription.Text = "Add";
            // 
            // btnEditPrescription
            // 
            btnEditPrescription.Location = new Point(560, 425);
            btnEditPrescription.Margin = new Padding(3, 4, 3, 4);
            btnEditPrescription.Name = "btnEditPrescription";
            btnEditPrescription.Size = new Size(75, 29);
            btnEditPrescription.TabIndex = 3;
            btnEditPrescription.Text = "Edit";
            // 
            // btnDeletePrescription
            // 
            btnDeletePrescription.Location = new Point(640, 425);
            btnDeletePrescription.Margin = new Padding(3, 4, 3, 4);
            btnDeletePrescription.Name = "btnDeletePrescription";
            btnDeletePrescription.Size = new Size(75, 29);
            btnDeletePrescription.TabIndex = 4;
            btnDeletePrescription.Text = "Delete";
            // 
            // tabPatients
            // 
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
            // panelPatientDetails
            // 
            panelPatientDetails.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            panelPatientDetails.BorderStyle = BorderStyle.FixedSingle;
            panelPatientDetails.Location = new Point(10, 12);
            panelPatientDetails.Margin = new Padding(3, 4, 3, 4);
            panelPatientDetails.Name = "panelPatientDetails";
            panelPatientDetails.Size = new Size(450, 474);
            panelPatientDetails.TabIndex = 0;
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
            // 
            // btnAddPatient
            // 
            btnAddPatient.Location = new Point(480, 425);
            btnAddPatient.Margin = new Padding(3, 4, 3, 4);
            btnAddPatient.Name = "btnAddPatient";
            btnAddPatient.Size = new Size(75, 29);
            btnAddPatient.TabIndex = 2;
            btnAddPatient.Text = "Add";
            // 
            // btnEditPatient
            // 
            btnEditPatient.Location = new Point(560, 425);
            btnEditPatient.Margin = new Padding(3, 4, 3, 4);
            btnEditPatient.Name = "btnEditPatient";
            btnEditPatient.Size = new Size(75, 29);
            btnEditPatient.TabIndex = 3;
            btnEditPatient.Text = "Edit";
            // 
            // btnDeletePatient
            // 
            btnDeletePatient.Location = new Point(640, 425);
            btnDeletePatient.Margin = new Padding(3, 4, 3, 4);
            btnDeletePatient.Name = "btnDeletePatient";
            btnDeletePatient.Size = new Size(75, 29);
            btnDeletePatient.TabIndex = 4;
            btnDeletePatient.Text = "Delete";
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
            tabPatients.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label labelMedicine;
        private Label labelMedicineMolecule;
        private Label labelMedicineDescription;
        private Label labelMedicineName;
        private Label labelMedicineDosage;
        private TextBox textBoxMedicineDosage;
        private TextBox textBoxMedicineDescription;
        private TextBox textBoxMedicineMolecule;
        private TextBox textBoxMoleculeName;
        private Button buttonMedicineRegister;
        private Button buttonMedicineCancel;
    }
}