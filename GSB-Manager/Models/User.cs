using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    public class User
    {
        public int user_id { get; set; } // C'est une propriété (attribut), permet d'accéder en lecture et écriture via get set

        public string Name { get; set; }

        public string Firstname { get; set; }

        public string Full_name
        {
            get { return $"{Firstname} {Name}"; }
        }

        public string Email { get; set; }

        public string Password { get; set; }

        public bool Role { get; set; }
        public User() // c'est le constructeur par défaut qui permettra d'instancier Users et avoir accès à toutes ses propriétés (attributs)
        {      }

        public User(int user_id, string name, string firstname, bool role) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.user_id = user_id;
            this.Name = name;
            this.Firstname = firstname;
            this.Role = role;
        }

        public User(string name, string firstname) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Name = name;
            this.Firstname = firstname;
        }

        public User(int user_id, string name, string firstname, string email, bool role) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.user_id = user_id;
            this.Name = name;
            this.Firstname = firstname;
            this.Email = email;
            this.Role = role;
        }
    }
}
