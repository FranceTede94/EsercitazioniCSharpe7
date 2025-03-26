using Hunext.IMio.ApiProxy;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
    public class Program
    {
        static async Task Main(string[] args)
        {

            InformazioniDati informazioniDati = new InformazioniDati("0030", "imiowebapi@hunext.com", "s6oFpU#p#eu#B1GL");

            string intestazioneAutorizzazione = informazioniDati.GetAuthorizationHeader();

            Console.WriteLine("L'Intestazione di autorizzazione è: " + intestazioneAutorizzazione);

            Console.WriteLine();


            // RITORNA L'ANAGRAFICA PER IL CODICE PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Anagrafica");
            string idAnagrafica = Console.ReadLine(); // Chiedi l'ID dell'anagrafica all'utente

            // Usa la classe ANAGRAFICHE per ottenere l'anagrafica tramite l'ID
            Anagrafica anagrafica = await Anagrafiche.GetAnagraficaById(idAnagrafica, intestazioneAutorizzazione);

            // Controlla se è stata trovata un'anagrafica
            if (anagrafica != null)
            {
                // Stampa l'intero oggetto ANAGRAFICA come JSON
                string anagraficaJson = JsonConvert.SerializeObject(anagrafica, Formatting.Indented);
                Console.WriteLine(anagraficaJson);
            }
            else
            {
                Console.WriteLine("Anagrafica non trovata.");
            }

            Console.WriteLine();


            // RITORNA I DATI CLIENTI DELL'ANAGRAFICA PER IL CODICE PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Anagrafica per ritornare i dati del cliente");
            string idAnagraficà = Console.ReadLine();

            // Ottieni i dati del cliente tramite la classe DITTA
            Ditta DatiCliente = await Ditta.GetClienteByAnagraficaId(idAnagraficà, intestazioneAutorizzazione);

            // Se DatiCliente è null, verifica cosa sta succedendo
            if (DatiCliente != null)
            {
                // Stampa l'intero oggetto DITTA come JSON
                string datiClienteJson = JsonConvert.SerializeObject(DatiCliente, Formatting.Indented);
                Console.WriteLine(datiClienteJson);
            }
            else
            {
                Console.WriteLine("Cliente non trovato.");
            }

            Console.WriteLine();


            // RITORNA L'ELENCO COMPLETO DELLE ANAGRAFICHE ATTIVE

            Console.WriteLine("Elenco Anagrafiche Attive:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Usa la classe ANAGRAFICHE per ottenere tutte le anagrafiche
            IEnumerable<Anagrafica> ElencoAnagrafiche = await Anagrafiche.GetAllAnagrafiche(intestazioneAutorizzazione);

            // Verifica se sono state trovate anagrafiche
            if (ElencoAnagrafiche != null && ElencoAnagrafiche.Any())
            {
                // Stampa l'intera lista di anagrafiche come JSON
                string ElencoAnagraficheJson = JsonConvert.SerializeObject(ElencoAnagrafiche, Formatting.Indented);
                Console.WriteLine(ElencoAnagraficheJson);
            }
            else
            {
                Console.WriteLine("Nessuna anagrafica trovata.");
            }

            Console.WriteLine();


            // RITORNA L'ELENCO COMPLETO DELLE ANAGRAFICHE CLIENTE ATTIVE

            Console.WriteLine("Elenco Anagrafiche Cliente Attive:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Usa la classe ANAGRAFICHE per ottenere tutte le anagrafiche
            IEnumerable<Anagrafica> ElencoAnagraficheClienteAttive = await Anagrafiche.GetAllAnagraficheClientiAttivi(intestazioneAutorizzazione);

            // Verifica se sono state trovate anagrafiche
            if (ElencoAnagraficheClienteAttive != null && ElencoAnagraficheClienteAttive.Any())
            {
                // Stampa l'intera lista di anagrafiche come JSON
                string ElencoAnagraficheClienteAttiveJson = JsonConvert.SerializeObject(ElencoAnagraficheClienteAttive, Formatting.Indented);
                Console.WriteLine(ElencoAnagraficheClienteAttiveJson);
            }
            else
            {
                Console.WriteLine("Nessuna anagrafica cliente attive trovata.");
            }

            Console.WriteLine();


            // RITORNA L'ARTICOLO PER IL CODICE PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Articolo");
            string idArticolo = Console.ReadLine(); // Chiedi l'ID dell'articolo all'utente

            // Usa la classe ARTICOLO per ottenere l'articolo tramite l'ID
            Articolo articolo = await Articoli.GetArticoloById(idArticolo, intestazioneAutorizzazione);

            // Controlla se è stata trovato un'articolo
            if (articolo != null)
            {
                // Stampa l'intero oggetto ARTICOLO come JSON
                string articoloJson = JsonConvert.SerializeObject(articolo, Formatting.Indented);
                Console.WriteLine(articoloJson);
            }
            else
            {
                Console.WriteLine("Articolo non trovato.");
            }

            Console.WriteLine();


            // RITORNA L'ELENCO COMPLETO DEGLI ARTICOLI ATTIVI

            Console.WriteLine("Elenco Articoli Attivi:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Usa la classe ARTICOLO per ottenere tutti gli articoli
            IEnumerable<Articolo> ElencoArticoli = await Articoli.GetAllArticolo(intestazioneAutorizzazione);

            // Verifica se sono stati trovati gli articoli
            if (ElencoArticoli != null && ElencoArticoli.Any())
            {
                // Stampa l'intera lista di articoli come JSON
                string ElencoArticoliJson = JsonConvert.SerializeObject(ElencoArticoli, Formatting.Indented);
                Console.WriteLine(ElencoArticoliJson);
            }
            else
            {
                Console.WriteLine("Nessuna articolo trovato.");
            }

            Console.WriteLine();


            // RITORNA L'ELENCO COMPLETO DEGLI ARTICOLI CODICI ATTIVI

            Console.WriteLine("Elenco Articoli Codici Attivi:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Usa la classe ARTICOLO per ottenere tutti gli articolo codici attivi
            IEnumerable<Articolo> ElencoArticoliCodiciAttivi = await Articoli.GetElencoArticoloCodiciAttivi(intestazioneAutorizzazione);

            // Verifica se sono state trovate anagrafiche
            if (ElencoArticoliCodiciAttivi != null && ElencoArticoliCodiciAttivi.Any())
            {
                // Stampa l'intera lista di anagrafiche come JSON
                string ElencoArticoliCodiciAttiviJson = JsonConvert.SerializeObject(ElencoArticoliCodiciAttivi, Formatting.Indented);
                Console.WriteLine(ElencoArticoliCodiciAttiviJson);
            }
            else
            {
                Console.WriteLine("Nessuna articolo codici attivi trovati.");
            }

            Console.WriteLine();


            // RITORNA IL CONTRATTO PER IL CODICE PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Contratto");
            string idContratto = Console.ReadLine(); // Chiedi l'ID contratto all'utente

            // Usa la classe CONTRATTO per ottenere il contratto tramite l'ID
            Contratto contratto = await Contratti.GetContrattoById(idContratto, intestazioneAutorizzazione);

            // Controlla se è stata trovato un contratto
            if (contratto != null)
            {
                // Stampa l'intero oggetto CONTRATTO come JSON
                string contrattoJson = JsonConvert.SerializeObject(contratto, Formatting.Indented);
                Console.WriteLine(contrattoJson);
            }
            else
            {
                Console.WriteLine("Contratto non trovato.");
            }

            Console.WriteLine();


            // RITORNA L'ELENCO COMPLETO DEI CONTRATTI ATTIVI

            Console.WriteLine("Elenco Contratti Attivi:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Usa la classe CONTRATTO per ottenere tutti i contratti
            IEnumerable<Contratto> ElencoContratti = await Contratti.GetAllContratti(intestazioneAutorizzazione);

            // Verifica se sono stati trovati i contratti
            if (ElencoContratti != null && ElencoContratti.Any())
            {
                // Stampa l'intera lista di contratti come JSON
                string ElencoContrattiJson = JsonConvert.SerializeObject(ElencoContratti, Formatting.Indented);
                Console.WriteLine(ElencoContrattiJson);
            }
            else
            {
                Console.WriteLine("Nessun contratto trovato.");
            }

            Console.WriteLine();


            // RITORNA LE INFORMAZIONI DEL DOCUMENTO PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Documento");
            string idDocumento = Console.ReadLine(); // Chiedi l'ID documento all'utente

            // Usa la classe DOCUMENTO per ottenere il documento tramite l'ID
            Documento documento = await Documenti.GetDocumentiById(idDocumento, intestazioneAutorizzazione);

            // Controlla se è stata trovato un documento
            if (documento != null)
            {
                // Stampa l'intero oggetto DOCUMENTO come JSON
                string documentoJson = JsonConvert.SerializeObject(documento, Formatting.Indented);
                Console.WriteLine(documentoJson);
            }
            else
            {
                Console.WriteLine("Documento non trovato.");
            }

            Console.WriteLine();



            // RITORNA IL DETTAGLIO DELLE RIGHE DI UN DETERMINATO DOCUMENTO PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Documento");
            string idDocumentoIns = Console.ReadLine();  // Chiedi l'ID documento all'utente

            // Usa la classe DETTAGLIO_DOCUMENTO per ottenere il documento tramite l'ID
            IEnumerable<DettaglioDocumento> DettagliDocumenti = await DettaglioDocumento.GetDettaglioByDocumentoId(idDocumentoIns, intestazioneAutorizzazione);

            // Controlla se sono stati trovati dei documenti
            if (DettagliDocumenti != null && DettagliDocumenti.Any())
            {
                // Stampa l'intero oggetto come JSON (lista di DETTAGLIO)
                string DettagliDocumentiJson = JsonConvert.SerializeObject(DettagliDocumenti, Formatting.Indented);
                Console.WriteLine(DettagliDocumentiJson);
            }
            else
            {
                Console.WriteLine("Documento non trovato.");
            }

            Console.WriteLine();


            // RITORNA L'ELENCO COMPLETO DEI DOCUMENTI IN BASE ALL'OGGETTO DI REQUEST PASSATO

            Console.WriteLine("Elenco Documenti Attivi in base all'oggetto di request passato:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Crea un oggetto DocumentoDettaglio con valori di esempio
            DocumentoDettaglio dettaglio = new DocumentoDettaglio
            {
                Eserc = 0,
                DocTp = "",
                IdDoc = "",
                Dt = DateTime.Parse("2024 - 01 - 24T14: 07:56.509Z"),
                RangeDtDa = DateTime.Parse("2024-01-24T14:07:56.509Z"),
                RangeDtA = DateTime.Parse("2025-03-24T14:07:56.509Z"),
                IdNum = "",
                Num = 0,
                Revisioni = true,
                IdAnag = "",
                Riferimento = "",
                ExportDtIsNull = true,
                AssOwn = 0,
                IdEntitaStato = "",
                PK_Parent = ""
            };

            // Esegui la richiesta e ottieni il documento
            Documenti documento1 = await Documenti.GetDocumentiByRequest(dettaglio, intestazioneAutorizzazione);

            // Verifica se il documento è stato restituito e stampa il risultato
            if (documento1 != null)
            {
                Console.WriteLine("Documento trovato:");
                string json = JsonConvert.SerializeObject(documento1, Formatting.Indented); // Serializza in formato JSON con indentazione
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Nessun documento trovato.");
            }



            // RITORNA LE INFORMAZIONI DEL RAPPORTINO PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Rapportino");
            string idRapportino = Console.ReadLine(); // Chiedi l'ID documento all'utente

            // Usa la classe RAPPORTINO per ottenere il rapportino tramite l'ID
            Rapportino rapportino = await Rapportini.GetRapportiniById(idRapportino, intestazioneAutorizzazione);

            // Controlla se è stata trovato un rapportino
            if (rapportino != null)
            {
                // Stampa l'intero oggetto CONTRATTO come JSON
                string rapportinoJson = JsonConvert.SerializeObject(rapportino, Formatting.Indented);
                Console.WriteLine(rapportinoJson);
            }
            else
            {
                Console.WriteLine("Rapportino non trovato.");
            }

            Console.WriteLine();



            // RITORNA IL DETTAGLIO DELLE RIGHE DI MANODOPERA DI UN DETERMINATO RAPPORTINO PASSATO COME PARAMETRO

            Console.WriteLine("Inserisci l'id Rapportino");
            string idRapportinoIns = Console.ReadLine();  // Chiedi l'ID rapportino all'utente

            // Usa la classe DETTAGLIO_RAPPORTINO per ottenere i dettagli tramite l'ID
            IEnumerable<DettaglioRapportino> DettagliRapportino = await DettaglioRapportino.GetDettaglioByRapportinoId(idRapportinoIns, intestazioneAutorizzazione);

            // Controlla se sono stati trovati dei rapportini
            if (DettagliRapportino != null && DettagliRapportino.Any())
            {
                // Stampa l'intera lista come JSON (lista di DETTAGLIO_RAPPORTINO)
                string DettagliRapportinoJson = JsonConvert.SerializeObject(DettagliRapportino, Formatting.Indented);
                Console.WriteLine(DettagliRapportinoJson);
            }
            else
            {
                Console.WriteLine("Rapportino non trovato.");
            }

            Console.WriteLine();


            // RITORNA UN ELENCO DI RAPPORTINI IN BASDE ALLA REQUEST PASSATA COME PARAMETRO

            Console.WriteLine("Elenco Rapportini Attivi in base alla request passata come parametro:");
            Console.ReadLine(); // Modo per aspettare che l'utente prema invio

            // Crea un oggetto DettaglioRapportino con valori di esempio
            DettagliAttivita dettaglioattivita = new DettagliAttivita
            {
                User = 0,
                IdAnag = "",
                RangeDtDa = DateTime.Parse("2025-03-26T08:25:53.164Z"),
                RangeDtA = DateTime.Parse("2025-03-26T08:25:53.164Z"),
                IsRappComessa = true,
                IsRappDesk = true,
                IdAttivita = 0,
                IdAsset = 0,
                IdRisorsa = 0
            };

            // Esegui la richiesta e ottieni il rapportino
            Rapportini documento2 = await Rapportini.GetRapportiniByRequest(dettaglioattivita, intestazioneAutorizzazione);

            // Verifica se il rapportino è stato restituito e stampa il risultato
            if (documento2 != null)
            {
                Console.WriteLine("Rapportino trovato:");
                string json = JsonConvert.SerializeObject(documento2, Formatting.Indented); // Serializza in formato JSON con indentazione
                Console.WriteLine(json);
            }
            else
            {
                Console.WriteLine("Nessun rapportino trovato.");
            }

        }
    }
}
