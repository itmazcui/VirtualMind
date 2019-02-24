using System.Net;
using System.Web.Http;

namespace VirtualMindAPI
{
    public abstract class Cotizacion : ICotizacion
    {
        public virtual string GetCotizacion()
        {
            throw new HttpResponseException(HttpStatusCode.Unauthorized);
        }
    }
}