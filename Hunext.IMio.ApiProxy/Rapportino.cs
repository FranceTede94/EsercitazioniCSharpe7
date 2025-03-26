using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Rapportino
    {   
        public int IdRapp_T { get; set; }
        public int OwnUM { get; set; }
        public DateTime DataUM { get; set; }
        public string Row_Id { get; set; }
        public string IdDitta { get; set; }
        public string IdAnag { get; set; }
        public DateTime Inserimento_Dt { get; set; }
        public int Rapp_IdDoc_T { get; set; }
        public object RappDescriz { get; set; }
        public object IdSpesa_T { get; set; }
        public object IdMezzoUtilizzo_T { get; set; }
        public double Inserimento_Num { get; set; }
        public object IdNum { get; set; }
        public object IdRappTp { get; set; }
        public object IdAnag_Eva { get; set; }
        public object IdPag { get; set; }
        public object InsDt { get; set; }
        public int InsOwn { get; set; }
        public string InsProv { get; set; }
        public string TimeStamp { get; set; }
        public object SetOperazioni { get; set; }
        public object Stampa_Dt { get; set; }
        public object IdAnagDescriz { get; set; }
    }
}
