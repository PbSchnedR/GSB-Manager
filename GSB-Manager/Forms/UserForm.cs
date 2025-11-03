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
        public UserForm(User connectedUser)
        {
            InitializeComponent();
            Initialise_Listbox();
            Initialise_content();
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
            listPatients.DisplayMember = "FullName";

            var prescriptionDAO = new PrescriptionDAO();
            var prescriptions = prescriptionDAO.GetAllPrescription();

            listPrescriptions.DataSource = prescriptions;
            listPrescriptions.DisplayMember = "FullLine";
        }

        private void Initialise_content() { 
           Medicine selectedMedicine = listMedicines.SelectedItem as Medicine;
            if(selectedMedicine != null)
            {
                textBoxMedicineDosage.Text = selectedMedicine.Dosage.ToString();
                labelMedicine.Text = selectedMedicine.Name;
                textBoxMedicineDescription.Text = selectedMedicine.Description;
                textBoxMedicineMolecule.Text = selectedMedicine.Molecule;
            }
        }

        private void btnAddMedicine_Click(object sender, EventArgs e)
        {
            btnAddMedicine.Visible = false;
            btnDeleteMedicine.Visible = false;
            btnEditMedicine.Visible = false;
        }

      
    }
}
