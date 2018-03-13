using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Service
    {
        private Int32 id, etage;
        private String nom;

        public Service(Int32 id, String nom, Int32 etage )
        {
            this.id = id;
            this.nom = nom;
            this.etage = etage;
        }
        public override string ToString()
        {
            return "service : "+nom + " étage n° " + etage;
        }
    }
}
