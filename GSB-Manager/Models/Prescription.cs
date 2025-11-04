using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    public class Prescription
    {

        public int Prescription_id { get; set; } // C'est une propriété (attribut), permet d'accéder en lecture et écriture via get set

        public int Users_id { get; set; }

        public int Patients_id { get; set; }

        public string Patient_full_name { get; set; }

        public int Quantity { get; set; }

        public DateTime Validity { get; set; }

        public string Full_line { get; set; }

        public string User_Full_name { get; set; }

        public Prescription() // c'est le constructeur par défaut qui permettra d'instancier Users et avoir accès à toutes ses propriétés (attributs)
        { }

        public Prescription(int prescription_id, int users_id, int patients_id, int quantity, DateTime validity) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Prescription_id = prescription_id;
            this.Users_id = users_id;
            this.Patients_id = patients_id;
            this.Quantity = quantity;
            this.Validity = validity;
        }

        public Prescription(int prescription_id, int users_id, int patients_id, int quantity, DateTime validity, string full_line, string user_full_name, string patient_full_name) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Prescription_id = prescription_id;
            this.Users_id = users_id;
            this.Patients_id = patients_id;
            this.Patient_full_name = patient_full_name;
            this.Quantity = quantity;
            this.Validity = validity;
            this.Full_line = full_line;
            this.User_Full_name = user_full_name;
        }
    }
}

