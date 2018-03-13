using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Utilisateur
    {
        private Int32 id;
        private String nom, prenom, mail, MDP;


        public Utilisateur(Int32 id, String nom, String prenom, String mail, String MDP)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.MDP = MDP;
        }
        public Int32 getId()
        {
            return id;
        }

        public override string ToString()
        {
            return "nom : " + nom + " prénom : " + prenom + " mail : " + mail;
        }
    }
}
