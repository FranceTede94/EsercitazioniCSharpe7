using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class DettagliAttivita
    {
        public int User { get; set; }
        public string IdAnag { get; set; }
        public DateTime RangeDtDa { get; set; }
        public DateTime RangeDtA { get; set; }
        public bool IsRappComessa { get; set; }
        public bool IsRappDesk { get; set; }
        public int IdAttivita { get; set; }
        public int IdAsset { get; set; }
        public int IdRisorsa { get; set; }
    }
}
