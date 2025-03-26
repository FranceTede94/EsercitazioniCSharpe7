using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Contratto
    {
        public int IdContratto_T { get; set; }
        public int OwnUM { get; set; }
        public DateTime? DataUM { get; set; }
        public string Row_Id { get; set; }
        public string IdDitta { get; set; }
        public string IdContrattoTp { get; set; }
        public int Num { get; set; }
        public string Descriz { get; set; }
        public string DescrizInt { get; set; }
        public string IdAnagTp { get; set; }
        public string IdAnag { get; set; }
        public int Validita { get; set; }
        public object IdIva { get; set; }
        public string IdPag { get; set; }
        public object Banca_Prog { get; set; }
        public DateTime? Contratto_InizioDt { get; set; }
        public object Contratto_FineDt { get; set; }
        public DateTime? Stipula_Dt { get; set; }
        public string Riferimento { get; set; }
        public double Riferimento_Num { get; set; }
        public object Riferimento_Dt { get; set; }
        public object IdCommessa { get; set; }
        public object Istat_Tp { get; set; }
        public int IdDoc_T { get; set; }
        public int IdProc { get; set; }
        public bool EscludiPrimaPeriodicitaStoDoc_Flg { get; set; }
        public string IdPeriodicita { get; set; }
        public object IdAnag_Agente { get; set; }
        public object IdRid { get; set; }
        public object DestProg_Merce { get; set; }
        public bool InvioEmailAuto_Flg { get; set; }
        public object IdAnag_Eva { get; set; }
        public object FatturazioneTp { get; set; }
        public string IdPeriodicita_Descriz { get; set; }
        public DateTime? UltimoRinnovoDt { get; set; }
        public DateTime? ProssimoRinnovoDt { get; set; }
        public double Importo { get; set; }
    }
}
