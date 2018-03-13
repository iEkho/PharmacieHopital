using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmacie
{
    class BonCommandeDAO : DAO<BonCommande>
    {
        private BonCommande leBon;

        public BonCommandeDAO(BonCommande leBon)
        {
            this.leBon=leBon;
        }
        public override bool create(BonCommande leBon)
        {
            string requete = "insert into BonCommande values(" + leBon.getUtilisateur().getId() + "," + leBon.getMedicament().getIdMedicament() + "," + leBon.getQuantite() + "," + leBon.getDateCommande()+")";
            SqlCommand commande = new SqlCommand(requete, seConnecter());
            Int32 nb = commande.ExecuteNonQuery();
            if (nb != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public override BonCommande find(int id)
        {
            string requete = "select * from BonCommande join Utilisateur on BonCommande.idUtilisateur=Utilisateur.id join Medicament on BonCommande.idMedicament=Medicament.id where id=" + id;
            SqlCommand commande = new SqlCommand(requete, seConnecter());
            SqlDataReader resultat = commande.ExecuteReader();
            BonCommande leBon = new BonCommande();
            while (resultat.Read())
            {
                int idCommande = (int)resultat["id"];
                int idUti = (int)resultat["idUtilisateur"];
                string nomUti = (string)resultat["nom"];
                string prenomUti = (string)resultat["prenom"];
                string adrMail = (string)resultat["adrMail"];
                string mdp = (string)resultat["mdp"];
                int IDMedicament = (int)resultat["idMedicament"];
                int quantite = (int)resultat["quantite"];
                int idMedoc = (int)resultat["Medicament.id"];
                string libelle = (string)resultat["Medicament.libelle"];
                double prixUnitaire = (double)resultat["prixUnitaire"];
                string description = (string)resultat["description"];
                int qtte = (int)resultat["quantiteMedicament"];
                DateTime dateCommande = (DateTime)resultat["dateCommande"];
                leBon.setBonCommande(idCommande, qtte, dateCommande, new Medicament(IDMedicament, libelle, prixUnitaire, description), new Utilisateur(idUti, nomUti, prenomUti, adrMail, mdp));
            }
            return leBon;
        }

    }
}
