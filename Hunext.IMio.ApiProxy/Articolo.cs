using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Articolo
    {
            public List<Link> links { get; set; }
            public string IdArticolo { get; set; }
            public string SQLiteId { get; set; }
            public string IdFamiglia_Descriz { get; set; }
            public string IdMerceologico_Descriz { get; set; }
            public object IdCda { get; set; }
            public string IdArchivioArt { get; set; }
            public int OwnUM { get; set; }
            public DateTime? DataUM { get; set; }
            public string Descriz { get; set; }
            public string Descriz_Breve { get; set; }
            public object Descriz_Web { get; set; }
            public object IdArticolo_Nome { get; set; }
            public string Row_Id { get; set; }
            public DateTime? InsDt { get; set; }
            public int InsOwn { get; set; }
            public string InsProv { get; set; }
            public object IdIva_Acq { get; set; }
            public object IdIva_Ven { get; set; }
            public object IdUm { get; set; }
            public object IdUm_Lst_Acq { get; set; }
            public object IdUm_Lst_Ven { get; set; }
            public object UtilFineDt { get; set; }
            public string BarCode { get; set; }
            public string IdMerceologico { get; set; }
            public string RicFacile { get; set; }
            public bool CheckDisp_Flg { get; set; }
            public object IdAnag_Produttore { get; set; }
            public string IdArticolo_Produttore { get; set; }
            public string BarCode_Produttore { get; set; }
            public object IdAnag_Fornitore { get; set; }
            public object RagSociale_Fornitore { get; set; }
            public object Descriz_Fornitore { get; set; }
            public string IdArticoloTp { get; set; }
            public string IdFamiglia { get; set; }
            public object Spesa_IdCostoTp { get; set; }
            public bool Partite_Flg { get; set; }
            public object IdArticolo_Fatturazione { get; set; }
            public object IdArticolo_Magazzino { get; set; }
            public bool RinnovoContrattoLst_Flg { get; set; }
            public bool Obsoleto_Flg { get; set; }
            public bool MRP_Flg { get; set; }
            public string IdArticolo_Old { get; set; }
            public string RitProf_StampaGrpTp { get; set; }
            public bool Rit_EscludiCalcolo { get; set; }
            public bool StampaForfait_Flg { get; set; }
            public int ListinoScaglioniTp_Ven { get; set; }
            public int ListinoScaglioniTp_Acq { get; set; }
            public double PesoLordo { get; set; }
            public double PesoNetto { get; set; }
            public double Volume { get; set; }
            public int Colli { get; set; }
            public double Lunghezza { get; set; }
            public double Larghezza { get; set; }
            public double Altezza { get; set; }
            public int FabbisognoTp { get; set; }
            public double PezziConfezione { get; set; }
            public string IdConfezione { get; set; }
            public double Scarto { get; set; }
            public double Diametro { get; set; }
            public double Spessore { get; set; }
            public object IdPesoSpecifico { get; set; }
            public string ImballoTp { get; set; }
            public int FattScadenzaTp { get; set; }
            public bool RicVisibile { get; set; }
            public object IdArticolo_Base { get; set; }
            public int PrevSpe_CalcoloTp { get; set; }
            public string TimeStamp { get; set; }
            public object TimeStampString { get; set; }
            public int ExportTp { get; set; }
            public int OmaggioTp { get; set; }
            public object IdConfigArticolo { get; set; }
            public string IdMagazzino_Default { get; set; }
            public object IdIva_Cor { get; set; }
            public object IdClasseSconto { get; set; }
            public object IdClasseStatistica { get; set; }
            public object IdArticolo_Raee { get; set; }
            public bool DistintaFantasma_Flg { get; set; }
        
    }
}
