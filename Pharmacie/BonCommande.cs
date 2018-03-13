using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class BonCommande
    {
        private Int32 id, quantiteMedicament;

        public Int32 Id
        {
            get { return id; }
            set { id = value; }
        }

        public Int32 QuantiteMedicament
        {
            get { return quantiteMedicament; }
            set { quantiteMedicament = value; }
        }
        private DateTime dateCommande;

        public DateTime DateCommande
        {
            get { return dateCommande; }
            set { dateCommande = value; }
        }
        private Medicament leMedicament;

        internal Medicament LeMedicament
        {
            get { return leMedicament; }
            set { leMedicament = value; }
        }
        private Utilisateur lUtilisateur;

        internal Utilisateur LUtilisateur
        {
            get { return lUtilisateur; }
            set { lUtilisateur = value; }
        }

        public BonCommande(Int32 id, Int32 quantiteMedicament, DateTime dateCommande, Medicament leMedicament, Utilisateur lUtilisateur)
        {
            this.id = id;
            this.quantiteMedicament = quantiteMedicament;
            this.dateCommande = dateCommande;
            this.leMedicament = leMedicament;
            this.lUtilisateur = lUtilisateur;
        }

        public override string ToString()
        {
            return "Medicament : " + leMedicament.ToString() + " quantité : " + quantiteMedicament + " date : " + dateCommande.ToShortDateString() + " commandeur : " + lUtilisateur.ToString();
        }
    }
}
