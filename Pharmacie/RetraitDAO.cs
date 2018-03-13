using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmacie
{
    class RetraitDAO : DAO<Retrait>
    {
        private Retrait leRetrait;


        public RetraitDAO(Retrait leRetrait)
        {
            this.leRetrait = leRetrait;
        }
        public override bool create(Retrait leRetrait)
        {
            string requete = "insert into Retrait values("+leRetrait.getleMedecin().getId()+","+leRetrait.getlUtilisateur().getId()+","+leRetrait.getleMedicament().getIdMedicament()+","+leRetrait.getQtte()+","+leRetrait.getDate()+")";
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
        public override bool delete(Retrait leRetrait)
        {
            string requete = "delete from 'Retrait' where id=" + leRetrait.getId();
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

    }
}
