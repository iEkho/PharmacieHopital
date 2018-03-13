using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections;

namespace Pharmacie
{
    class Passerelle
    {
        public static SqlConnection ouvrirConnexion()
        {
            string chaineConnexion = "Data Source = WIN-921C8FKTGAE; Initial Catalog=slam2018PPEpharmacieFDAL; User ID=desprez; password=desprez";
            SqlConnection maConnexion = new SqlConnection(chaineConnexion);
            maConnexion.Open();
            return maConnexion;
        }

        public static List<Medicament> getLesMedicament()
        {
            List<Medicament> laListe = new List<Medicament>();
            SqlConnection connexion = ouvrirConnexion();
            String requete = "select * from Medicament";
            SqlCommand commande = new SqlCommand(requete, connexion);
            SqlDataReader resultat = commande.ExecuteReader();
            while (resultat.Read())
            {
                Int32 id = (Int32)resultat["id"];
                String libelle = (String)resultat["libelle"];
                Double prixU = (Double)resultat["prixUnitaire"];
                String description = (String)resultat["description"];
                Medicament leMedoc = new Medicament(id, libelle, prixU, description);
                laListe.Add(leMedoc);
            }
            return laListe;
        }

        public static List<Medecin> getLesMedecins()
        {
            List<Medecin> laListe = new List<Medecin>();
            SqlConnection connexion = ouvrirConnexion();
            String requete = "select * from Medecin join Service on Medecin.idService = Service.id";
            SqlCommand commande = new SqlCommand(requete, connexion);
            SqlDataReader resultat = commande.ExecuteReader();
            while (resultat.Read())
            {
                Int32 id = (Int32)resultat["id"];
                String nom = (String)resultat["Medecin.nom"];
                String prenom = (String)resultat["prenom"];
                String mail = (String)resultat["mail"];
                String tel = (String)resultat["numTel"];
                Int32 idService = (Int32)resultat["Service.id"];
                String nomService = (String)resultat["Service.nom"];
                Int32 etage = (Int32)resultat["etage"];
                Service leService = new Service(idService, nomService, etage);
                Medecin leMedecin = new Medecin(id, nom, prenom, mail, tel, leService);
                laListe.Add(leMedecin);
            }
            return laListe;
        }
    }
}
