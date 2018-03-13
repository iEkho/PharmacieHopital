using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Reserve
    {
        private Int32 id;
        private String libelle;


        public Reserve(Int32 id, String libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public Reserve()
        {

        }
        public void setReserve(Int32 id, String libelle)
        {
            this.id = id;
            this.libelle = libelle;
        }
        public Int32 getIdReserve()
        {
            return id;
        }
        public override string ToString()
        {
            return "Nom : " + libelle;
        }
    }
}
