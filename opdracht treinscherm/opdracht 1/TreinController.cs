using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opdracht_1
{
    class TreinController : ITreinController
    {
        private ITreinReis Treinreis;
        public TreinController(ITreinReis treinReis)
        {
            this.Treinreis = treinReis;
        }
        
        public void VolgendStation(TreinReis reis)
        {
            reis.VolgendStation();
        }
    }
}
