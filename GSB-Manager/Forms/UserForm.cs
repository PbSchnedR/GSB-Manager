using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GSB_Manager.Models;
using GSB_Manager.DAO;

namespace GSB_Manager.Forms
{
    public partial class UserForm : Form
    {
        private User _connectedUser;
        public UserForm(User connectedUser)
        {
            InitializeComponent();
            Initialise_Listbox();
            _connectedUser = connectedUser;
        }

        private void Initialise_Listbox()
        {
            var medicineDAO = new MedicineDAO();
            var medicines = medicineDAO.GetAllMedicine();

            listMedicines.DataSource = medicines;
            listMedicines.DisplayMember = "Name";

            var patientDAO = new PatientDAO();
            var patients = patientDAO.GetAllPatients();

            listPatients.DataSource = patients;
            listPatients.DisplayMember = "Full_name";

            var prescriptionDAO = new PrescriptionDAO();
            var prescriptions = prescriptionDAO.GetAllPrescription();

            listPrescriptions.DataSource = prescriptions;
            listPrescriptions.DisplayMember = "Full_line";
        }

        private void Handle_listbox_change()
        {
            Medicine selectedMedicine = listMedicines.SelectedItem as Medicine;
            if (selectedMedicine != null)
            {
                textBoxMedicineDosage.Text = selectedMedicine.Dosage.ToString();
                labelMedicine.Text = selectedMedicine.Name;
                textBoxMedicineDescription.Text = selectedMedicine.Description;
                textBoxMedicineMolecule.Text = selectedMedicine.Molecule;
            }

            Prescription selectedPrescription = listPrescriptions.SelectedItem as Prescription;

            if (selectedPrescription != null)
            {
                labelPrescription.Text = selectedPrescription.Prescription_id.ToString();
                textBoxPrescriptionQuantity.Text = selectedPrescription.Quantity.ToString();
                textBoxPrescriptionValidity.Text = selectedPrescription.Validity.ToString("d");
                textBoxPrescriptionDoctor.Text = selectedPrescription.User_Full_name;
                textBoxPrescriptionPatient.Text = selectedPrescription.Patient_full_name;


                PrescriptionDAO prescriptionDAO = new PrescriptionDAO();
                List<string> prescription_medicines = prescriptionDAO.GetPrescriptionMedicines(selectedPrescription.Prescription_id);
                string parsed_medicines = string.Join(", ", prescription_medicines);
                textBoxPrescriptionMedicines.Text = parsed_medicines;
            }


            Patient selectedPatient = listPatients.SelectedItem as Patient;
            if (selectedPatient != null)
            {
                labelPatient.Text = selectedPatient.Full_name;
                textBoxPatientAge.Text = selectedPatient.Age.ToString();
                textBoxPatientDoctor.Text = selectedPatient.Users_id.ToString();
                textBoxPatientGender.Text = selectedPatient.Gender.ToString();
                textBoxPatientDoctor.Text = selectedPatient.Full_User_Name;

            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            btnAddMedicine.Visible = false;
            btnDeleteMedicine.Visible = false;
            btnEditMedicine.Visible = false;
            buttonMedicineRegister.Visible = true;
            buttonMedicineCancel.Visible = true;
            textBoxMedicineName.Visible = true;
            labelMedicineName.Visible = true;

            textBoxMedicineDosage.ReadOnly = false;
            textBoxMedicineDescription.ReadOnly = false;
            textBoxMedicineMolecule.ReadOnly = false;

            textBoxMedicineDosage.Clear();
            textBoxMedicineDescription.Clear();
            textBoxMedicineMolecule.Clear();
            labelMedicine.Text = "New medicine";
        }

        private void listMedicines_SelectedIndexChanged(object sender, EventArgs e)
        {
            Handle_listbox_change();
        }

        private void listPrescriptions_SelectedIndexChanged(object sender, EventArgs e)
        {
            Handle_listbox_change();
        }

        private void listPatients_SelectedIndexChanged(object sender, EventArgs e)
        {
            Handle_listbox_change();
        }

        private void buttonMedicineRegister_Click(object sender, EventArgs e)
        {
            var medicineDAO = new MedicineDAO();
            if (textBoxMedicineDescription.Text != string.Empty && textBoxMedicineDosage.Text != string.Empty && textBoxMedicineMolecule.Text != string.Empty && textBoxMedicineName.Text != string.Empty)
            {
                try
                {
                    medicineDAO.CreateMedicine(_connectedUser.Users_id, textBoxMedicineName.Text, textBoxMedicineDescription.Text, textBoxMedicineMolecule.Text, int.Parse(textBoxMedicineDosage.Text));
                    MessageBox.Show("Medicine added successfully");
                    btnAddMedicine.Visible = true;
                    btnDeleteMedicine.Visible = true;
                    btnEditMedicine.Visible = true;
                    buttonMedicineRegister.Visible = false;
                    buttonMedicineCancel.Visible = false;
                    textBoxMedicineName.Visible = false;
                    labelMedicineName.Visible = false;

                    textBoxMedicineDosage.ReadOnly = true;
                    textBoxMedicineDescription.ReadOnly = true;
                    textBoxMedicineMolecule.ReadOnly = true;
                    Initialise_Listbox();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Please fill the fields correctly");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please fill all the fields");
            }
        }

        private void buttonPrescriptionRegister_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            textBoxPrescriptionDoctor.Visible = false;
            textBoxPrescriptionPatient.Visible = false;
            textBoxPrescriptionQuantity.ReadOnly = false;
            textBoxPrescriptionValidity.Visible = false;

            comboBoxPrescriptionDoctor.Visible = true;
            comboBoxPrescriptionPatient.Visible = true;
            comboBoxPrescriptionMedicine.Visible = true;
            dateTimePickerPrescriptionValidity.Visible = true;

            btnAddPrescription.Visible = false;
            btnDeletePrescription.Visible = false;
            btnEditPrescription.Visible = false;
            buttonPrescriptionRegister.Visible = true;
            buttonPrescriptionCancel.Visible = true;

            textBoxPrescriptionQuantity.Clear();
            textBoxPrescriptionMedicines.Clear();


            var userDAO = new UserDAO();
            List<User> doctors = userDAO.GetAllDoctors();
            doctors.ForEach(d => comboBoxPrescriptionDoctor.Items.Add(d.Full_name));

            var medicineDAO = new MedicineDAO();
            List<Medicine> medicines = medicineDAO.GetAllMedicine();
            medicines.ForEach(m => comboBoxPrescriptionMedicine.Items.Add(m.Name));

            var patientDAO = new PatientDAO();
            List<Patient> patients = patientDAO.GetAllPatients();
            patients.ForEach(p => comboBoxPrescriptionPatient.Items.Add(p.Full_name));
        }
    }
}
