using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmacie
{
    class StockDAO : DAO<Stock>
    {
        private Stock leStock;

        public StockDAO(Stock leStock)
        {
            this.leStock = leStock;
        }

        public override bool update(Int32 nb)
        {
            
        }
        public override Stock find(int idReserve, int idMedicament)
        {
            string requete = "select * from Stock join Medicament on Stock.idMedicament=Medicament.id join Reserve on Stock.idReserve=Reserve.id where idReserve=" + idReserve + " AND idMedicament=" + idMedicament;
            SqlCommand commande = new SqlCommand(requete, seConnecter());
            SqlDataReader resultat = commande.ExecuteReader();
            while (resultat.Read())
            {
                int IDReserve = (int)resultat["idReserve"];
                int IDMedicament = (int)resultat["idMedicament"];
                int quantite = (int)resultat["quantite"];
                int idMedoc = (int)resultat["Medicament.id"];
                string libelle = (string)resultat["Medicament.libelle"];
                double prixUnitaire = (double)resultat["prixUnitaire"];
                string description = (string)resultat["description"];
                int idReserv = (int)resultat["Reserve.id"];
                string nom = (string)resultat["nom"];
            }
        }
    }
}
