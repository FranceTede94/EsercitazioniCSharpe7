using Hunext.IMio.ApiProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class DettaglioDocumento
    {
        public int IdDoc_T { get; set; }
        public int IdDoc_R { get; set; }
        public int OwnUM { get; set; }
        public DateTime DataUM { get; set; }
        public double Riga { get; set; }
        public string RigaDescriz { get; set; }
        public string RigaDescrizInt { get; set; }
        public string IdArchivioArt { get; set; }
        public object IdArticolo { get; set; }
        public string Iva_IdIva { get; set; }
        public double Iva_Aliq { get; set; }
        public object IdMagazzino { get; set; }
        public object IdMagazzinoColl { get; set; }
        public double Qta { get; set; }
        public double DistintaQta { get; set; }
        public double PrezzoUnit { get; set; }
        public double PrezzoUnitMat { get; set; }
        public double PrezzoUnitMan { get; set; }
        public double PrezzoUnitSpeRip { get; set; }
        public bool PrezzoUnit_EditManuale { get; set; }
        public string PrezzoSconto { get; set; }
        public double PrezzoScontoVal { get; set; }
        public double PrezzoTot { get; set; }
        public double PrezzoTotMan { get; set; }
        public double PrezzoTotMat { get; set; }
        public double PrezzoTotSpeRip { get; set; }
        public double CostoUnit { get; set; }
        public double CostoUnitMat { get; set; }
        public double CostoUnitMan { get; set; }
        public double CostoUnitSpeRip { get; set; }
        public string CostoSconto { get; set; }
        public double CostoScontoVal { get; set; }
        public double CostoTot { get; set; }
        public double CostoTotMan { get; set; }
        public double CostoTotMat { get; set; }
        public double CostoTotSpeRip { get; set; }
        public double CostoUnitAnalisiComm { get; set; }
        public DateTime ConsegnaDt { get; set; }
        public object IdUm { get; set; }
        public string IdPdcConto { get; set; }
        public string IdCommessa { get; set; }
        public string IdCommessaSub { get; set; }
        public string IdDivisione { get; set; }
        public bool ForzaEvasione_Flg { get; set; }
        public bool AnnullaEvasione_Flg { get; set; }
        public string IdRif_MRP { get; set; }
        public int OmaggioTp { get; set; }
        public double ValoreUnitOrig { get; set; }
        public string ScontoOrig { get; set; }
        public string IdContropartita { get; set; }
        public int StampaTp { get; set; }
        public bool StampaAnnulla_Flg { get; set; }
        public bool StampaAnnullaValori_Flg { get; set; }
        public bool StampaAnnullaDettValori_Flg { get; set; }
        public object IdDoc_R_Master { get; set; }
        public object IdDoc_R_Totale { get; set; }
        public int RigaTp { get; set; }
        public int RitenutaTp { get; set; }
        public double Ricarica { get; set; }
        public int ListinoScaglioniTp { get; set; }
        public object IdContratto_T { get; set; }
        public object IdAccantonamento { get; set; }
        public bool Forfait_Flg { get; set; }
        public double Qta_Alt { get; set; }
        public object IdUm_Alt { get; set; }
        public object IdUm_Lst { get; set; }
        public object EconCompDt { get; set; }
        public string IdDitta { get; set; }
        public int Eserc { get; set; }
        public DateTime Dt { get; set; }
        public double Riga_PesoLordo { get; set; }
        public double Riga_PesoNetto { get; set; }
        public double Riga_Volume { get; set; }
        public int Riga_Colli { get; set; }
        public double Riga_Lunghezza { get; set; }
        public double Riga_Larghezza { get; set; }
        public double Riga_Altezza { get; set; }
        public double Riga_Spessore { get; set; }
        public string Raggruppamento { get; set; }
        public int Calcolo_Flg { get; set; }
        public string Riga_IdPersonale { get; set; }
        public object Preventivo_IdDoc_R { get; set; }
        public bool Consuntivo_Econ_Flg { get; set; }
        public bool StampaFabbisogno_Flg { get; set; }
        public bool Tesoreria_Anticipo_Flg { get; set; }
        public int RigaTotaleTp { get; set; }
        public string IdArticolo_CodiceExt { get; set; }
        public string IdArticolo_DescrizExt { get; set; }
        public string IdArticolo_IntegrazioneTp { get; set; }
        public bool EscludiAnalisiValori_Flg { get; set; }
        public bool EvasioneValore_Flg { get; set; }
        public List<object> Partite { get; set; }

        private static string BaseUrl { get; set; } = "http://srvweb01:3359/api/Documenti";

        public static async Task<IEnumerable<DettaglioDocumento>> GetDettaglioByDocumentoId(string DettaglioDocumentoId, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/{DettaglioDocumentoId}/Righe";

                // Esegui la richiesta GET
                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                // Verifica se la risposta è valida
                if (!string.IsNullOrEmpty(res))
                {
                    // Deserializza come una lista di DETTAGLIO
                    return JsonConvert.DeserializeObject<IEnumerable<DettaglioDocumento>>(res);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }
    }
}
