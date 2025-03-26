using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;
using Hunext.IMio.ApiProxy;

namespace Hunext.IMio.ApiProxy
{
    public class Anagrafiche
    {
        private static string BaseUrl { get; set; } = "http://srvweb01:3359/api/Anagrafiche";

        // Usa HttpClientHelper per fare la richiesta GET
        public static async Task<Anagrafica> GetAnagraficaById(string idAnag, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/{idAnag}";

                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<Anagrafica>(res);
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

        public static async Task<IEnumerable<Anagrafica>> GetAllAnagrafiche(string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}";

                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<List<Anagrafica>>(res);
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


        public static async Task<IEnumerable<Anagrafica>> GetAllAnagraficheClientiAttivi(string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/Clienti";

                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<List<Anagrafica>>(res);
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





