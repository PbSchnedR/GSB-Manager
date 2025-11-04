using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    public class Patient
    {
        public int Patients_id { get; set; } // C'est une propriété (attribut), permet d'accéder en lecture et écriture via get set

        public int Users_id { get; set; }

        public string Name { get; set; }

        public string Firstname { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }

        public string Full_name { get; set; }

        public string Full_User_Name { get; set; }

        public Patient() // c'est le constructeur par défaut qui permettra d'instancier Users et avoir accès à toutes ses propriétés (attributs)
        { }

        public Patient(int patients_id, int users_id, string name, string firstname, int age, string gender) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Patients_id = patients_id;
            this.Users_id = users_id;
            this.Name = name;
            this.Firstname = firstname;
            this.Age = age;
            this.Gender = gender;
        }

        public Patient(int patients_id, int users_id, string name, string firstname, int age, string gender, string full_name, string full_user_name) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Patients_id = patients_id;
            this.Users_id = users_id;
            this.Name = name;
            this.Firstname = firstname;
            this.Age = age;
            this.Gender = gender;
            this.Full_name = full_name;
            this.Full_User_Name = full_user_name;

        }
    }
}
