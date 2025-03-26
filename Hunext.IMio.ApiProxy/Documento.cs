using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Documento
    {
        public List<Link> links { get; set; }
        public int IdDoc_T { get; set; }
        public string IdDitta { get; set; }
        public int Eserc { get; set; }
        public string IdDoc { get; set; }
        public DateTime Dt { get; set; }
        public double Num { get; set; }
        public bool Attivo_Flg { get; set; }
        public string IdEntitaStato { get; set; }
        public string IdNum { get; set; }
        public int OwnUM { get; set; }
        public DateTime DataUM { get; set; }
        public string Row_Id { get; set; }
        public object InsDt { get; set; }
        public int InsOwn { get; set; }
        public string InsProv { get; set; }
        public object PK_Parent { get; set; }
        public object Doc_Dt { get; set; }
        public double Doc_Num { get; set; }
        public string Doc_Num_T { get; set; }
        public string IdAnagTp { get; set; }
        public string IdAnag { get; set; }
        public string IdPag { get; set; }
        public bool ForzaFattScadenzaTp { get; set; }
        public object IdAnag_Vet { get; set; }
        public string IdArchivioArt { get; set; }
        public string IdListino { get; set; }
        public string ScontoListino { get; set; }
        public DateTime Inserimento_Dt { get; set; }
        public object Stampa_Dt { get; set; }
        public object Email_Dt { get; set; }
        public object Contabilizza_Dt { get; set; }
        public object InizioTrasp_Dt { get; set; }
        public object InizioTrasp_Ora { get; set; }
        public object Consegna_Dt { get; set; }
        public object Ritiro_Dt { get; set; }
        public object ValiditaInizio_Dt { get; set; }
        public object ValiditaFine_Dt { get; set; }
        public object ExportF24_Dt { get; set; }
        public string ScontoMerce { get; set; }
        public string ScontoFinanz { get; set; }
        public double ScontoMerceVal { get; set; }
        public double ScontoFinanzVal { get; set; }
        public string IdTrasporto { get; set; }
        public string IdPorto { get; set; }
        public string IdSpedizione { get; set; }
        public string IdResaMerce { get; set; }
        public string Aspetto { get; set; }
        public int Colli { get; set; }
        public double PesoLordo { get; set; }
        public double PesoNetto { get; set; }
        public double Volume { get; set; }
        public string Riferimento { get; set; }
        public object Riferimento_Dt { get; set; }
        public string Riferimento_Nominativo { get; set; }
        public double TotaleDoc { get; set; }
        public object DestProg_IdDitta { get; set; }
        public object DestProg_Merce { get; set; }
        public object DestProg_Documento { get; set; }
        public object DestProg_Cantiere { get; set; }
        public object Iva_CompDt { get; set; }
        public double TotaleOmaggio { get; set; }
        public double Arrotondamento { get; set; }
        public object IdPersonale { get; set; }
        public int NumDec { get; set; }
        public string IdPdcConto_Ricavo_SAL { get; set; }
        public bool PrNotaRitenuta_SAL_Flg { get; set; }
        public bool PrNotaOrdine_SAL_Flg { get; set; }
        public double ImponibileFatturato_SAL { get; set; }
        public bool ImponibileFatturatoForza_SAL_Flg { get; set; }
        public double AnticipoContratto_ImponibileForzato_SAL { get; set; }
        public double AnticipoContratto_Perc_SAL { get; set; }
        public double AnticipoContratto_SAL { get; set; }
        public double Anticipo { get; set; }
        public object IdDivisione { get; set; }
        public int StampaValoriTp { get; set; }
        public double NumRC { get; set; }
        public double SvincoloRitenuta { get; set; }
        public object IdCigCup { get; set; }
        public object ExportDt { get; set; }
        public double Ricarica { get; set; }
        public double ConsuntivoAvanzamento { get; set; }
        public object IdAnag_Rapp { get; set; }
        public double Tesoreria_Anticipo_Perc { get; set; }
        public object IdRid { get; set; }
        public object IdAnag_Eva { get; set; }
        public object SetOperazioni { get; set; }
        public int SplitPayment_Flg { get; set; }
        public string TimeStamp { get; set; }
        public object TimeStampString { get; set; }
        public object IdDocDescriz { get; set; }
        public object RagSociale { get; set; }
        public object Note { get; set; }
        public object NoteInt { get; set; }
        public object DocumentoRighe { get; set; }
        public object DocumentoNote { get; set; }
        public object DocumentoFirme { get; set; }
    }
}
