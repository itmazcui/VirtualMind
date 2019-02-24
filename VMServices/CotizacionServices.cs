using System.Net;

namespace VMServices
{
    public class CotizacionServices
    {
        public string GetCotizacionDolar()
        {
            return new WebClient().DownloadString("http://www.bancoprovincia.com.ar/Principal/Dolar");
        }
    }
}
