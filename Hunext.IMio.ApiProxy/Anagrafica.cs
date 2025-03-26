using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Anagrafica
    {
        public List<Link> links { get; set; }
        public string IdAnag { get; set; }
        public int OwnUM { get; set; }
        public DateTime? DataUM { get; set; }
        public string Row_Id { get; set; }
        public DateTime? InsDt { get; set; }
        public int InsOwn { get; set; }
        public string InsProv { get; set; }
        public object UtilFineDt { get; set; }
        public string CodFiscale { get; set; }
        public string CodFiscaleEstero { get; set; }
        public string PartIva { get; set; }
        public object IdNatGiu { get; set; }
        public string RagSociale { get; set; }
        public string RagSocialeCompleta { get; set; }
        public string Cognome { get; set; }
        public string Nome { get; set; }
        public string Sesso { get; set; }
        public object NascitaDt { get; set; }
        public object NascitaIdComune { get; set; }
        public string NascitaComune { get; set; }
        public string NascitaIdProv { get; set; }
        public object NascitaIdStato { get; set; }
        public string IdCittadinanza { get; set; }
        public string Tipologia { get; set; }
        public string Indirizzo { get; set; }
        public string NumCivico { get; set; }
        public string FrazLoc { get; set; }
        public string Comune { get; set; }
        public object IdComune { get; set; }
        public object IdProv { get; set; }
        public string Cap { get; set; }
        public object IdStato { get; set; }
        public string TelefonoPref { get; set; }
        public string Telefono { get; set; }
        public string FaxPref { get; set; }
        public string Fax { get; set; }
        public string DomFiscTipologia { get; set; }
        public string DomFiscIndirizzo { get; set; }
        public string DomFiscNumCivico { get; set; }
        public string DomFiscFrazLoc { get; set; }
        public string DomFiscComune { get; set; }
        public object DomFiscIdComune { get; set; }
        public object DomFiscIdProv { get; set; }
        public string DomFiscCap { get; set; }
        public object DomFiscIdStato { get; set; }
        public string DomFiscTelefonoPref { get; set; }
        public string DomFiscTelefono { get; set; }
        public string DomFiscFaxPref { get; set; }
        public string DomFiscFax { get; set; }
        public string SedeAttTipologia { get; set; }
        public string SedeAttIndirizzo { get; set; }
        public string SedeAttNumCivico { get; set; }
        public string SedeAttFrazLoc { get; set; }
        public string SedeAttComune { get; set; }
        public string SedeAttIdComune { get; set; }
        public string SedeAttIdProv { get; set; }
        public string SedeAttCap { get; set; }
        public string SedeAttIDStato { get; set; }
        public string SedeAttTelefonoPref { get; set; }
        public string SedeAttTelefono { get; set; }
        public string SedeAttFaxPref { get; set; }
        public string SedeAttFax { get; set; }
        public string Sito { get; set; }
        public string IdAnag_Old { get; set; }
        public string IndirizzoCompleto { get; set; }
        public string IndirizzoNumCivico { get; set; }
        public string Localita { get; set; }
        public int StpIndirizzo { get; set; }
        public bool LG_Stp_No_Flg { get; set; }
        public string IdLingua { get; set; }
        public int ComOperazioniIva_Flg { get; set; }
        public bool BollaDoganale_Flg { get; set; }
        public int AnagTp { get; set; }
        public bool ProcConcorsuale_Flg { get; set; }
        public string IdIPA { get; set; }
        public int SplitPayment_Flg { get; set; }
        public object PartIvaIdStato { get; set; }
        public int DatiFatture_Flg { get; set; }
        public string TimeStamp { get; set; }
        public object TimeStampString { get; set; }

    }
}
