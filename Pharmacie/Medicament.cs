using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Medicament
    {
        private Int32 id;
        private String libelle, description;
        private Double prixUnitaire;


        public Medicament(Int32 id, String libelle, Double prixUnitaire, String description)
        {
            this.id = id;
            this.libelle = libelle;
            this.prixUnitaire = prixUnitaire;
            this.description = description;
        }
        public Medicament()
        {

        }
        public void setMedicament(Int32 id, String libelle, Double prixUnitaire, String description)
        {
            this.id = id;
            this.libelle = libelle;
            this.prixUnitaire = prixUnitaire;
            this.description = description;
        }
        public Int32 getIdMedicament()
        {
            return id;
        }
        public override string ToString()
        {
            return "Medicament : " + libelle + " prix unitaire : " + prixUnitaire + " description : " + description;
        }
    }
}
