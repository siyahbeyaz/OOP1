using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AracOOP.Siniflar
{
    interface IKapasite
    {
        int Kapasite { get; set; }
        int YolcuSayisi { get; set; }
        int MotorSayisi { get; set; }
        void KapasiteYaz();
    }
}
