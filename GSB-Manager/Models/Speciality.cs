using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSB_Manager.Models
{
    /// <summary>
    /// Représente une spécialité médicale (ex : Cardiologie, Psychologie...).
    /// </summary>
    public class Speciality
    {
        public int Speciality_id { get; set; } // C'est une propriété (attribut), permet d'accéder en lecture et écriture via get set

        public string Name { get; set; }

        public Speciality() // c'est le constructeur par défaut qui permettra d'instancier Speciality et avoir accès à toutes ses propriétés (attributs)
        { }

        public Speciality(int speciality_id, string name) // surcharge du constructeur, instancie une spécialité avec les valeurs passées en paramètre
        {
            this.Speciality_id = speciality_id;
            this.Name = name;
        }
    }
}
