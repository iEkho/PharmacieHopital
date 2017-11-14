using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pharmacie
{
    class MedicamentDAO : DAO<Medicament>
    {
        private Medicament medoc;

        public MedicamentDAO(Medicament medoc)
        {
            this.medoc = medoc;
        }

    }
}
