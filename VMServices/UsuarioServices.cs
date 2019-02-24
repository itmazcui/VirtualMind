using Common;
using System.Collections.Generic;
using VMData;

namespace VMServices
{
    public class UsuarioServices
    {
        private UsuarioData _usuarioData;

        public IList<Usuario> GetUsuarios()
        {
            _usuarioData = new UsuarioData();
            return _usuarioData.GetUsuarios();
        }
    }
}
