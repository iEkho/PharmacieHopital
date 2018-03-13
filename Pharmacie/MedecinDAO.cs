using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pharmacie
{
    class MedecinDAO : DAO<Medecin>
    {
        private Medecin leMedecin;

        public MedecinDAO(Medecin leMedecin)
        {
            this.leMedecin = leMedecin;
        }
        public override Medecin find(int id)
        {
            string requete = "select * from Medecin join Service on Medecin.idService=Service.id where id=" + id;
            SqlCommand commande = new SqlCommand(requete, seConnecter());
            SqlDataReader resultat = commande.ExecuteReader();
            Medecin medecin = new Medecin();
            while (resultat.Read())
            {
                int numero = (int)resultat["id"];
                string nom = (string)resultat["Medecin.nom"];
                string prenom = (string)resultat["prenom"];
                string mail = (string)resultat["mail"];
                string numTel = (string)resultat["numTel"];
                int idService = (int)resultat["idService"];
                string nomService = (string)resultat["Service.nom"];
                int etage = (int)resultat["etage"];
                Service leService = new Service(idService, nomService, etage);
                medecin.setMedecin(numero, nom, prenom, mail, numTel, leService);
            }
            return medecin;
        }
    }
}
