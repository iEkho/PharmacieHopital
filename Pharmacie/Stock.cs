using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class Stock
    {
        private Int32 quantite;
        private Medicament leMedicament;
        private Reserve laReserve;

        public Stock(Int32 quantite, Medicament leMedicament, Reserve laReserve)
        {
            this.quantite = quantite;
            this.leMedicament = leMedicament;
            this.laReserve = laReserve;
        }
        public Stock()
        {

        }
        public void setStock(Int32 quantite, Medicament leMedicament, Reserve laReserve)
        {
            this.quantite = quantite;
            this.leMedicament = leMedicament;
            this.laReserve = laReserve;
        }
        public Reserve getlaReserve()
        {
            return laReserve;
        }
        public Int32 getQuantite()
        {
            return quantite;
        }
        public Medicament getleMedicament()
        {
            return leMedicament;
        }

        public override string ToString()
        {
            return "Medicament : " + leMedicament.ToString() + " Reserve : " + laReserve.ToString() + " quantité : " + quantite;
        }
    }
}
