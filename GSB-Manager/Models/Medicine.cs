using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    public class Medicine
    {
        public int Medicine_id { get; set; } // C'est une propriété (attribut), permet d'accéder en lecture et écriture via get set

        public int user_id { get; set; }

        public int Dosage { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Molecule { get; set; }
        public Medicine() // c'est le constructeur par défaut qui permettra d'instancier Users et avoir accès à toutes ses propriétés (attributs)
        { }

        public Medicine(int medicine_id, int user_id, int dosage, string name, string description, string molecule) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
           this.Medicine_id = medicine_id;
           this.user_id = user_id;
           this.Dosage = dosage;
           this.Name = name;
           this.Description = description;
           this.Molecule = molecule;
        }

        public Medicine(int medicine_id, int dosage, string name) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Medicine_id = medicine_id;
            this.Dosage = dosage;
            this.Name = name;
        }
    }
}
