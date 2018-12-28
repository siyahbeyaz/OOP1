using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP.Siniflar
{
    interface IArac
    {
        string Model { get; set; }
        string Mensei { get; set; }
        yakitturu YakitTuru { get; set; }
        int Yil { get; set; }
        int BeygirGucu { get; set; }
        aractipleri AracTipi { get; set; }
        void Yaz();
    }
}
