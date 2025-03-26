using Newtonsoft.Json;
using System;
using System.Buffers.Text;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hunext.IMio.ApiProxy
{
        public class Ditta
        {
            public string IdDitta { get; set; }
            public string IdAnag { get; set; }
            public int OwnUM { get; set; }
            public DateTime DataUM { get; set; }
            public string Row_Id { get; set; }
            public DateTime UtilFineDt { get; set; }
            public string IdCategCont { get; set; }
            public string IdPag { get; set; }
            public string Scad_GGTipici { get; set; }
            public string Scad_MesiEsclusi { get; set; }
            public int Scad_MesiEsclusiPostGG { get; set; }
            public int Scad_Posticipo { get; set; }
            public string Ban_IdPdcConto { get; set; }
            public string IdListino { get; set; }
            public string Sconto { get; set; }
            public string ScontoMerce { get; set; }
            public bool Evasione_Flg { get; set; }
            public bool EvasioneFattScadenzaTp_Flg { get; set; }
            public object IdAnag_Vet { get; set; }
            public string IdTrasporto { get; set; }
            public string IdPorto { get; set; }
            public string IdSpedizione { get; set; }
            public string IdResaMerce { get; set; }
            public string IdIva { get; set; }
            public object IdContropartita { get; set; }
            public int Banca_Prog_Ditta { get; set; }
            public object Scad_IdClassePartita { get; set; }
            public bool Rit_EscludiPrivato_Flg { get; set; }
            public bool RitProf_EscludiGestSep_Flg { get; set; }
            public bool RitProf_EscludiCassaPrev_Flg { get; set; }
            public object IdRitTp { get; set; }
            public int Enas_IdContributo { get; set; }
            public object IdValuta { get; set; }
            public object GiornoChiusura01 { get; set; }
            public string ChiusuraTp01 { get; set; }
            public object GiornoChiusura02 { get; set; }
            public string ChiusuraTp02 { get; set; }
            public string IntegrazioneTp { get; set; }
            public bool RaggruppaDestinazione_Flg { get; set; }
            public double Ricarica { get; set; }
            public double Ricarica_Spese { get; set; }
            public object IdAnag_Old { get; set; }
            public object IdAnag_Eva { get; set; }
            public object Orario_Apertura { get; set; }
            public object Orario_Scarico { get; set; }
            public object IdListino_Rapp { get; set; }
            public string TimeStamp { get; set; }
            public object TimeStampString { get; set; }


        private static string BaseUrl { get; set; } = "http://srvweb01:3359/api/Anagrafiche";

        public static async Task<Ditta> GetClienteByAnagraficaId(string AnagraficaIdCliente, string intestazioneAutorizzazione)
        {
            try
            {
                HttpClientHelper HttpClientHelper = new HttpClientHelper();
                string url = $"{BaseUrl}/{AnagraficaIdCliente}/DatiCli";

                var res = await HttpClientHelper.EseguiRichiestaGetAsync(url, intestazioneAutorizzazione);

                if (res != null)
                {
                    return JsonConvert.DeserializeObject<Ditta>(res);
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