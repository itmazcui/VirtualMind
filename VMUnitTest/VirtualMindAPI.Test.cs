using Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
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
        public void GuardarUsuario()
        {
            var usuario = new Usuario();
            usuario.Apellido = "Lopez";
            usuario.Nombre = "Juan";
            usuario.Email = "email@email.com";
            usuario.Password = "prueba123";

            var todoOk = new UsuarioServices().GuardarUsuario(usuario);
            Assert.IsTrue(todoOk);
        }

        [TestMethod]
        public void ModificarUsuario()
        {
            var usuario = new Usuario();

            usuario.Apellido = "Lopez";
            usuario.Nombre = "Juan";
            usuario.Email = "email@email.com";
            usuario.Password = "prueba123";

            usuario = new UsuarioServices().GetUsuarios().Where(x => x.Apellido == usuario.Apellido &&
                                                                x.Email == usuario.Email &&
                                                                x.Nombre == usuario.Nombre &&
                                                                x.Password == usuario.Password).Single();

            usuario.Nombre = "Jose";

            var todoOk = new UsuarioServices().ModificarUsuario(usuario);
            Assert.IsTrue(todoOk);

        }

        [TestMethod]
        public void EliminarUsuario()
        {
            var usuario = new Usuario();
            usuario.Apellido = "Lopez";
            usuario.Nombre = "Jose";
            usuario.Email = "email@email.com";
            usuario.Password = "prueba123";

            usuario = new UsuarioServices().GetUsuarios().Where(x => x.Apellido == usuario.Apellido &&
                                                                x.Email == usuario.Email &&
                                                                x.Nombre == usuario.Nombre &&
                                                                x.Password == usuario.Password).Single();

            var todoOk = new UsuarioServices().EliminarUsuario(usuario.IdUsuario);
            Assert.IsTrue(todoOk);

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
