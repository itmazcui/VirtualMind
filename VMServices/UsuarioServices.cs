using Common;
using System.Collections.Generic;
using VMData;

namespace VMServices
{
    public class UsuarioServices
    {
        private UsuarioData _usuarioData;

        public UsuarioServices() {
            _usuarioData = new UsuarioData();
        }

        public IList<Usuario> GetUsuarios()
        {
            return _usuarioData.GetUsuarios();
        }

        public bool GuardarUsuario(Usuario usuario)
        {
           return _usuarioData.GuardarUsuario(usuario);
        }

        public bool EliminarUsuario(int idUsuario)
        {
            return _usuarioData.EliminarUsuario(idUsuario);
        }

        public bool ModificarUsuario(Usuario usuario)
        {
            return _usuarioData.ModificarUsuario(usuario);
        }

    }
}
