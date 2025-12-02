using GSB_Manager.DAO;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using GSB_Manager.Forms;

namespace GSB_Manager.Forms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            try
            {
                // var UserDAO = new UserDAO();
                //  var connectedUser = UserDAO.Login("paul.martin@example.com", "5e884898da28047151d0e56f8dc6292773603d0d6aabbdd62a11ef721d1542d8");
                var PatientDAO = new PatientDAO();
                /* var patients = PatientDAO.GetAllPatients();
                foreach(var patient in patients)
                {
                    MessageBox.Show(patient.Name);

                }
                var patient = PatientDAO.GetPatientById(1);
                MessageBox.Show(patient.Name);
                var createdPatient = PatientDAO.CreatePatient(1, "stucked", "hugo", 20, "masculin");
                MessageBox.Show(createdPatient.Name);*/



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            var UserDAO = new UserDAO();
            var connectedUser = UserDAO.Login(textBoxEmail.Text, textBoxPassword.Text);
            if (connectedUser.Firstname == string.Empty)
            {
                MessageBox.Show("Échec de la connexion. Vérifiez vos identifiants.");
                return;
            }
            else {
               // MessageBox.Show("Bienvenue " + connectedUser.Firstname + " " + connectedUser.Name);
               var userForm = new UserForm(connectedUser);
               userForm.Show();
               this.Hide();
            }
        }
    }
}
