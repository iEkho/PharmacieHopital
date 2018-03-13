using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Pharmacie
{
    class BonCommandeDAO:DAO<BonCommande>
    {
        private BonCommande leBonCommande;

        public BonCommandeDAO(BonCommande leBonCommande)
        {
            this.leBonCommande = leBonCommande;
        }
        public override Boolean create(BonCommande leBonCommande){
            string requete = "insert into BonCommande values (" + leBonCommande.Id + "," + leBonCommande.LeMedicament.Id + "," + leBonCommande.QuantiteMedicament + "," + leBonCommande.DateCommande + ")";
            SqlCommand commande = new SqlCommand(requete, seConnecter());
            int resultat = commande.ExecuteNonQuery();
            return resultat != 0;
        }
    }
}
