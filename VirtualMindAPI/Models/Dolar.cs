using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using VMServices;

namespace VirtualMindAPI.Models
{
    public class Dolar : Cotizacion
    {
        public override string GetCotizacion()
        {
            return new CotizacionServices().GetCotizacionDolar();
        }
    }
}