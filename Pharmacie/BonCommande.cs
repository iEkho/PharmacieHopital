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
        private DateTime dateCommande;
        private Medicament leMedicament;
        private Utilisateur lUtilisateur;

        public BonCommande(Int32 id, Int32 quantiteMedicament, DateTime dateCommande, Medicament leMedicament, Utilisateur lUtilisateur)
        {
            this.id = id;
            this.quantiteMedicament = quantiteMedicament;
            this.dateCommande = dateCommande;
            this.leMedicament = leMedicament;
            this.lUtilisateur = lUtilisateur;
        }
        public BonCommande()
        {

        }
        public void setBonCommande(Int32 id, Int32 quantiteMedicament, DateTime dateCommande, Medicament leMedicament, Utilisateur lUtilisateur)
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
        public Utilisateur getUtilisateur()
        {
            return lUtilisateur;
        }
        public Medicament getMedicament()
        {
            return leMedicament;
        }
        public DateTime getDateCommande()
        {
            return dateCommande;
        }
        public Int32 getQuantite()
        {
            return quantiteMedicament;
        }
    }
}
