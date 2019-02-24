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
    public class UsuarioController : ApiController
    {
        private UsuarioServices _usuarioServices;

        public UsuarioController()
        {
            _usuarioServices = new UsuarioServices();
        }

        public IList<Usuario> GetUsuarios()
        {
            return _usuarioServices.GetUsuarios();
        }

        [HttpPost]
        public bool GuardarUsuario(Usuario usuario)
        {
            return _usuarioServices.GuardarUsuario(usuario);
        }

        [HttpDelete]
        public bool EliminarUsuario(int idUsuario)
        {
            return _usuarioServices.EliminarUsuario(idUsuario);
        }

        [HttpPut]
        public bool ModificarUsuario(Usuario usuario)
        {
            return _usuarioServices.ModificarUsuario(usuario);
        }

    }
}
