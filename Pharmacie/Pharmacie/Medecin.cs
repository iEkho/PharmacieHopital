using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Medecin
    {
        private Int32 id;
        private String nom, prenom, mail, telephone;
        private Service service;

        public Medecin(Int32 id, String nom, String prenom, String mail, String telephone, Service service)
        {
            this.id = id;
            this.nom = nom;
            this.prenom = prenom;
            this.mail = mail;
            this.telephone = telephone;
            this.service = service;
        }

        public override string ToString()
        {
            return "nom : " + nom + " prenom : " + prenom + " mail : " + mail + " telephone : " + telephone + " service " + service.ToString();
        }
    }
}
