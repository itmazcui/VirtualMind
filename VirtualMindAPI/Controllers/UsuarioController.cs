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
        public IList<Usuario> GetUsuarios()
        {
            return new UsuarioServices().GetUsuarios();
        }
    }
}
