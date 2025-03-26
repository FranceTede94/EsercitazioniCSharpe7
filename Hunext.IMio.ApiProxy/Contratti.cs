using Hunext.IMio.ApiProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
   public class Contratti
    {
        private static string BaseUrl { get; set; } = "http://srvweb01:3359/api/Contratti";

        public static async Task<Contratto> GetContrattoById(string idContr, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/{idContr}";

                // Usa HttpClientHelper per eseguire la richiesta
                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<Contratto>(res);
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


        public static async Task<IEnumerable<Contratto>> GetAllContratti(string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}";

                // Usa HttpClientHelper per eseguire la richiesta
                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<IEnumerable<Contratto>>(res);
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
