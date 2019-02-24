using Common;
using System.Collections.Generic;
using System.Data;
using VMData.Settings;

namespace VMData
{
    public class UsuarioData
    {
        public IList<Usuario> GetUsuarios()
        {
            var da = new DataAccess();
            var usuarios = new List<Usuario>();

            var result = da.ExecuteSP("sp_tuser");

            foreach (DataRow item in result.Rows)
            {
                var usuario = new Usuario();
                usuario.IdUsuario = int.Parse(item["id_user"].ToString());
                usuario.Nombre = item["Nombre"].ToString();
                usuario.Apellido = item["Apellido"].ToString();
                usuario.Email = item["Email"].ToString();
                usuario.Password = item["Password"].ToString();

                usuarios.Add(usuario);
            }

            return usuarios;
        }
    }
}
