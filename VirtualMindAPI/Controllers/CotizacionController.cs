using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;
using VirtualMindAPI.Models;
using Common;
using VMServices;

namespace VirtualMindAPI.Controllers
{
    public class CotizacionController : ApiController
    {
        private ICotizacion _cotizazcion;
        
        [HttpGet]
        public string Moneda(string moneda)
        {
            var esvalido = Enum.TryParse(moneda.ToLower(), out Moneda eMoneda);

            if (esvalido)
                switch (eMoneda)
                {
                    case Common.Moneda.dolar:
                        _cotizazcion = new Dolar();
                        break;
                    case Common.Moneda.pesos:
                        _cotizazcion = new Pesos();
                        break;
                    case Common.Moneda.real:
                        _cotizazcion = new Real();
                        break;
                }
            else
                return string.Empty;

            return _cotizazcion.GetCotizacion();
        }
    }
}
