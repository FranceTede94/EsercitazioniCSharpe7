using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class DocumentoDettaglio
    {
        public int Eserc { get; set; }
        public string DocTp { get; set; }
        public string IdDoc { get; set; }
        public DateTime Dt { get; set; }
        public DateTime RangeDtDa { get; set; }
        public DateTime RangeDtA { get; set; }
        public string IdNum { get; set; }
        public int Num { get; set; }
        public bool Revisioni { get; set; }
        public string IdAnag { get; set; }
        public string Riferimento { get; set; }
        public bool ExportDtIsNull { get; set; }
        public int AssOwn { get; set; }
        public string IdEntitaStato { get; set; }
        public string PK_Parent { get; set; }
    }
}
