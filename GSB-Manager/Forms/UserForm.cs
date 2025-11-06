using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using GSB_Manager.Models;
using GSB_Manager.DAO;
using System.Text.RegularExpressions;

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

        string allocatedMedicine = "";


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
                    string no_space_name = Regex.Replace(textBoxMedicineName.Text, @"\s", "");
                    medicineDAO.CreateMedicine(_connectedUser.Users_id, no_space_name, textBoxMedicineDescription.Text, textBoxMedicineMolecule.Text, int.Parse(textBoxMedicineDosage.Text));
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
            var prescriptionDAO = new PrescriptionDAO();
            var medicineDAO = new MedicineDAO();
            if (textBoxPrescriptionMedicines.Text != string.Empty && textBoxPrescriptionQuantity.Text != string.Empty && comboBoxPrescriptionPatient.Text != string.Empty)
            {
                try
                {
                    int patientId = comboBoxPrescriptionPatient.SelectedIndex + 1;
                    int prescriptionId = prescriptionDAO.CreatePrescription(_connectedUser.Users_id, patientId, int.Parse(textBoxPrescriptionQuantity.Text), dateTimePickerPrescriptionValidity.Value);
                    var splited = allocatedMedicine.Trim().Split(" ").ToList();
                    foreach (var item in splited)
                    {
                        int medicine_id = medicineDAO.FindMedicineIdByName(item);

                        prescriptionDAO.AddMedicineToPrescription(prescriptionId, medicine_id);
                    }
                    MessageBox.Show("Prescription added successfully");
                    textBoxPrescriptionDoctor.Visible = true;
                    textBoxPrescriptionPatient.Visible = true;
                    textBoxPrescriptionQuantity.ReadOnly = true;
                    dateTimePickerPrescriptionValidity.Visible = false;
                    labelPrescriptionDoctor.Visible = true;
                    comboBoxPrescriptionPatient.Visible = false;
                    comboBoxPrescriptionMedicine.Visible = false;
                    buttonPrescriptionCancel.Visible = false;
                    buttonPrescriptionRegister.Visible = false;
                    btnAddPrescription.Visible = true;
                    btnDeletePrescription.Visible = true;
                    btnEditPrescription.Visible = true;
                    textBoxPrescriptionMedicines.Clear();
                    comboBoxPrescriptionMedicine.Items.Clear();
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

        private void btnAddPrescription_Click(object sender, EventArgs e)
        {
            textBoxPrescriptionDoctor.Visible = false;
            textBoxPrescriptionPatient.Visible = false;
            textBoxPrescriptionQuantity.ReadOnly = false;
            textBoxPrescriptionValidity.Visible = false;
            labelPrescriptionDoctor.Visible = false;

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


            var medicineDAO = new MedicineDAO();
            List<Medicine> medicines = medicineDAO.GetAllMedicine();
            medicines.ForEach(m => comboBoxPrescriptionMedicine.Items.Add(m.Name));

            var patientDAO = new PatientDAO();
            List<Patient> patients = patientDAO.GetAllPatients();
            patients.ForEach(p => comboBoxPrescriptionPatient.Items.Add(p.Full_name));
        }

        private void comboBoxPrescriptionMedicine_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = comboBoxPrescriptionMedicine.SelectedItem.ToString();
            allocatedMedicine += selectedItem + " ";
            textBoxPrescriptionMedicines.Text = allocatedMedicine;

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
            labelPatient.Text = "New Patient";
            btnAddPatient.Visible = false;
            btnDeletePatient.Visible = false;
            btnEditPatient.Visible = false;
            buttonPatientRegister.Visible = true;
            buttonPatientCancel.Visible = true;

            textBoxPatientAge.ReadOnly = false;
            textBoxPatientGender.Visible = false;
            textBoxPatientAge.Clear();
            textBoxPatientDoctor.Visible = false;
            labelPatientDoctor.Visible = false;
            labelPatientFirstname.Visible = true;
            textBoxPatientFirstname.Visible = true;
            labelPatientName.Visible = true;
            textBoxPatientName.Visible = true;


            comboBoxPatientGender.Visible = true;
            comboBoxPatientGender.Items.Add("Male");
            comboBoxPatientGender.Items.Add("Female");

        }

        private void buttonPatientRegister_Click(object sender, EventArgs e)
        {
            var patientDAO = new PatientDAO();
            if (textBoxPatientAge.Text != string.Empty && textBoxPatientFirstname.Text != string.Empty && textBoxPatientName.Text != string.Empty && comboBoxPatientGender.Text != string.Empty)
            {
                try
                {
                    patientDAO.CreatePatient(_connectedUser.Users_id, textBoxPatientName.Text, textBoxPatientFirstname.Text, int.Parse(textBoxPatientAge.Text), comboBoxPatientGender.SelectedItem.ToString());
                    MessageBox.Show("Patient added successfully");
                    btnAddPatient.Visible = true;
                    btnDeletePatient.Visible = true;
                    btnEditPatient.Visible = true;
                    buttonPatientRegister.Visible = false;
                    buttonPatientCancel.Visible = false;
                    labelPatientFirstname.Visible = false;
                    textBoxPatientFirstname.Visible = false;
                    labelPatientName.Visible = false;
                    textBoxPatientName.Visible = false;
                    comboBoxPatientGender.Visible = false;
                    textBoxPatientAge.ReadOnly = true;
                    textBoxPatientGender.Visible = true;
                    labelPatientDoctor.Visible = true;
                    textBoxPatientDoctor.Visible = true;

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

        private void btnDeleteMedicine_Click(object sender, EventArgs e)
        {
            var medicineDAO = new MedicineDAO();
            Medicine selectedMedicine = listMedicines.SelectedItem as Medicine;
            if (selectedMedicine != null)
            {
                int medicineId = selectedMedicine.Medicine_id;
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                                         );

                if (result == DialogResult.Yes)
                {
                    if (medicineDAO.DeleteMedicine(medicineId))
                    {
                        MessageBox.Show("Medicine deleted successfully.");
                        Initialise_Listbox();
                    }
                    else
                    {
                        MessageBox.Show("Error during deletion.");
                    }
                }
                else
                {
                    // Action si l'utilisateur annule
                    MessageBox.Show("Deletion cancelled.");
                }

            }
            else
            {
                MessageBox.Show("Error, medicine not found !");
            }
        }

        private void btnDeletePrescription_Click(object sender, EventArgs e)
        {
            var prescriptionDAO = new PrescriptionDAO();
            Prescription selectedPrescription = listPrescriptions.SelectedItem as Prescription;
            if (selectedPrescription != null)
            {
                int prescriptionId = selectedPrescription.Prescription_id;
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                                         );

                if (result == DialogResult.Yes)
                {
                    if (prescriptionDAO.DeletePrescription(prescriptionId))
                    {
                        MessageBox.Show("Prescription deleted successfully.");
                        Initialise_Listbox();
                    }
                    else
                    {
                        MessageBox.Show("Error during deletion.");
                    }
                }
                else
                {
                    // Action si l'utilisateur annule
                    MessageBox.Show("Deletion cancelled.");
                }

            }
            else
            {
                MessageBox.Show("Error, prescription not found !");
            }
        }

        private void btnDeletePatient_Click(object sender, EventArgs e)
        {
            var patientDAO = new PatientDAO();
            Patient selectedPatient = listPatients.SelectedItem as Patient;
            if (selectedPatient != null)
            {
                int patientId = selectedPatient.Patients_id;
                DialogResult result = MessageBox.Show(
                "Are you sure you want to delete this item?",
                "Confirmation",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
                                         );

                if (result == DialogResult.Yes)
                {
                    if (patientDAO.DeletePatient(patientId))
                    {
                        MessageBox.Show("Patient deleted successfully.");
                        Initialise_Listbox();
                    }
                    else
                    {
                        MessageBox.Show("Error during deletion.");
                    }
                }
                else
                {
                    // Action si l'utilisateur annule
                    MessageBox.Show("Deletion cancelled.");
                }

            }
            else
            {
                MessageBox.Show("Error, medicine not found !");
            }
        }
    }
}
