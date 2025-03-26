using Hunext.IMio.ApiProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class DettaglioRapportino
    {
        public int IdRapp_T { get; set; }
        public int IdRapp_R { get; set; }
        public int OwnUM { get; set; }
        public DateTime DataUM { get; set; }
        public DateTime Rapp_Dt { get; set; }
        public double Rapp_Num { get; set; }
        public double Riga { get; set; }
        public string RigaDescriz { get; set; }
        public string RigaDescrizInt { get; set; }
        public string IdPersonale { get; set; }
        public double Ore { get; set; }
        public object Ore_Autorizzate { get; set; }
        public object Ore_Considerate { get; set; }
        public double PrezzoUnit { get; set; }
        public string PrezzoSconto { get; set; }
        public double PrezzoTot { get; set; }
        public double CostoUnit { get; set; }
        public string CostoSconto { get; set; }
        public double CostoTot { get; set; }
        public string IdCommessa { get; set; }
        public string IdCommessaSub { get; set; }
        public object Rapp_IdDoc_R { get; set; }
        public object OraInizio { get; set; }
        public object OraFine { get; set; }
        public string IdOrarioTp { get; set; }
        public int FatturazioneTp { get; set; }
        public int IdContratto_T { get; set; }
        public string IdRappTp { get; set; }
        public string IdCda { get; set; }
        public object IdAnag { get; set; }
        public object IdArchivioArt { get; set; }
        public object IdArticolo_Causale { get; set; }
        public object Evasione_IdDoc_R { get; set; }
        public object IdAttivita { get; set; }
        public object IdApp_T { get; set; }
        public object IdRis_T { get; set; }
        public bool ContrattoOre_NoScala_Flg { get; set; }
        public string IdCommessaDescriz { get; set; }
        public object IdCommessaSubDescriz { get; set; }

        private static string BaseUrl { get; set; } = "http://srvweb01:3359/api/Rapportini";

        public static async Task<IEnumerable<DettaglioRapportino>> GetDettaglioByRapportinoId(string DettaglioRapportinoId, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/{DettaglioRapportinoId}/Righe";

                // Esegui la richiesta GET
                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                // Verifica se la risposta è valida
                if (res != null)
                {
                    // Deserializza come una lista di DETTAGLIO_RAPPORTINO
                    return JsonConvert.DeserializeObject<IEnumerable<DettaglioRapportino>>(res);
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Errore: {ex.Message}");
                return null;
            }
        }
    }
}
