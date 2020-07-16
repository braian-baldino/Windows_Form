using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    [Serializable]
    public class Saving
    {
        public double UsdSaving { get; set; }
        public double PesoSaving { get; set; }

        public Saving()
        {

        }

        public Saving(double usd, double peso)
        {
            UsdSaving = usd;
            PesoSaving = peso;
        }
    }
}
