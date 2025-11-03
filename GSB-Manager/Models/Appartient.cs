using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    public class Appartient
    {
        public int Prescription_id { get; set; } // C'est une propriété (attribut), permet d'accéder en lecture et écriture via get set

        public int Medicine_id { get; set; }

        public Appartient() // c'est le constructeur par défaut qui permettra d'instancier Users et avoir accès à toutes ses propriétés (attributs)
        { }

        public Appartient(int prescription_id, int medicine_id) // c'est une surcharge du constructeur, ça permettrea la création d'objet Users qui sera instancié avec les valeurs passées en paramètre
        {
            this.Prescription_id = prescription_id;
            this.Medicine_id = medicine_id;
        }
    }
}
