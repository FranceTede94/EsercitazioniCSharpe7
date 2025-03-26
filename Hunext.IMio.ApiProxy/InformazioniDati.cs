using System.Text;

namespace Hunext.IMio.ApiProxy
{
    public class InformazioniDati
    {
        private string _IdDitta;
        private string _UserEmail;
        private string _UserPsw;

        // Costruttore
        public InformazioniDati(string idDitta, string userEmail, string userPsw)
        {
            _IdDitta = idDitta;
            _UserEmail = userEmail;
            _UserPsw = userPsw;
        }

        //GET E SETTER DI OGNI CAMPO CREATO
        public string IdDitta { get => _IdDitta; set => _IdDitta = value; }
        public string UserEmail { get => _UserEmail; set => _UserEmail = value; }
        public string UserPsw { get => _UserPsw; set => _UserPsw = value; }


        // Metodo che restituisce l'intestazione di autorizzazione in formato Base64
        public string GetAuthorizationHeader()
        {
            string credenziali = _UserEmail + ":" + _UserPsw + ":" + IdDitta;

            // Codifica in base64
            var bytes = Encoding.UTF8.GetBytes(credenziali);
            string base64Credenziali = Convert.ToBase64String(bytes);
           
            return base64Credenziali;  // Restituisce la stringa
        }
    }
}
