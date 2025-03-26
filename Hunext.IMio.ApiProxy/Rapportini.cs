using Hunext.IMio.ApiProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Rapportini
    {
        private static string BaseUrl { get; set; } = "http://srvweb01:3359/api/Rapportini";

        public static async Task<Rapportino> GetRapportiniById(string idRapp, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/{idRapp}";

                // Usa HttpClientHelper per eseguire la richiesta
                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<Rapportino>(res);
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


        public static async Task<Rapportini> GetRapportiniByRequest(DettagliAttivita dettaglioRapportino, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper httpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/GetRapportiniByRequest";

                // Serializza l'oggetto DocumentoDettaglio in JSON
                string jsonBody = JsonConvert.SerializeObject(dettaglioRapportino);

                // Esegui la richiesta POST
                string res = await httpClientHelper.EseguiRichiestaPostAsync(url, intestazioneAutorizzazione, jsonBody);

                // Se la risposta non è nulla, deserializza la risposta come un oggetto Documenti
                if (res != null)
                {
                    return JsonConvert.DeserializeObject<Rapportini>(res);
                }

                return null;
            }
            catch
            {
                return null;
            }
        }

    }
}
