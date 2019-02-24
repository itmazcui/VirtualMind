using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Http;
using VirtualMindAPI.Controllers;
using VMServices;

namespace VMUnitTest
{
    [TestClass]
    public class VirtualMindAPI
    {
        [TestMethod]
        public void GetUsuariosServices()
        {
            var usuarios = new UsuarioServices().GetUsuarios();
            Assert.IsTrue(usuarios.Count > 0);
        }

        [TestMethod]
        public void GetCotizacionesDolarServices()
        {
            var cotizacion = new CotizacionServices().GetCotizacionDolar();
            Assert.IsFalse(cotizacion == string.Empty);
        }

        [TestMethod]
        public void GetCotizacionesDolar()
        {
            var cotizacionController = new CotizacionController();
            Assert.IsFalse(cotizacionController.Moneda("dolar") == string.Empty);
        }

        [TestMethod]
        [ExpectedException(typeof(HttpResponseException))]
        public void GetCotizacionesPesos()
        {
            var cotizacionController = new CotizacionController();
            cotizacionController.Moneda("PeSos");
        }

        [TestMethod]
        [ExpectedException(typeof(HttpResponseException))]
        public void GetCotizacionesReal()
        {
            var cotizacionController = new CotizacionController();
            cotizacionController.Moneda("real");
        }

    }
}
