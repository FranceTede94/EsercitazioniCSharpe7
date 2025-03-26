using System;  // Importa la libreria di base per funzioni comuni come la gestione degli errori
using System.Net.Http;  // Importa la libreria che permette di fare richieste HTTP
using System.Text;
using System.Threading.Tasks;  // Importa la libreria per la gestione dei task asincroni

namespace Hunext.IMio.ApiProxy
{
    // La classe è pubblica, quindi può essere utilizzata da altre parti del programma
    public class HttpClientHelper
    {
        // Questo è il metodo che esegue una richiesta HTTP GET
        public async Task<string> EseguiRichiestaGetAsync(string url, string intestazioneAutorizzazione)
        {
            // 'using' garantisce che HttpClient venga eliminato correttamente una volta usato
            using (HttpClient client = new HttpClient())
            {
                // Aggiunge l'intestazione di autorizzazione alla richiesta HTTP, per autenticarsi
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + intestazioneAutorizzazione);

                try
                {
                    // Esegue una richiesta GET all'URL specificato in modo asincrono
                    HttpResponseMessage risposta = await client.GetAsync(url);

                    // Legge il contenuto della risposta come stringa (potrebbe essere JSON o testo)
                    return await risposta.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    // Se c'è un errore durante la richiesta, cattura l'eccezione e restituisce il messaggio d'errore
                    return "Si è verificato un errore: " + ex.Message;
                }
            }
        }


        // Metodo per eseguire una richiesta POST
        public async Task<string> EseguiRichiestaPostAsync(string url, string intestazioneAutorizzazione, string jsonBody)
        {
            using (HttpClient client = new HttpClient())
            {
                client.DefaultRequestHeaders.Add("Authorization", "Basic " + intestazioneAutorizzazione);

                StringContent content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

                try
                {
                    // Esegui una richiesta POST
                    HttpResponseMessage risposta = await client.PostAsync(url, content);
                    return await risposta.Content.ReadAsStringAsync();
                }
                catch (Exception ex)
                {
                    return "Si è verificato un errore: " + ex.Message;
                }
            }
        }

    }
}
