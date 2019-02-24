using Common;
using System;
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

        public bool ModificarUsuario(Usuario usuario)
        {
            var da = new DataAccess();

            var parametros = new Dictionary<string, object>();
            parametros.Add("@id_user", usuario.IdUsuario);
            parametros.Add("@apellido", usuario.Apellido);
            parametros.Add("@email", usuario.Email);
            parametros.Add("@nombre", usuario.Nombre);
            parametros.Add("@password", usuario.Password);

            var result = da.ExecuteSPBool("sp_utuser", parametros);
            return result;
        }

        public bool EliminarUsuario(int idUsuario)
        {
            var da = new DataAccess();
            var parametros = new Dictionary<string, object>();
            parametros.Add("@id_user", idUsuario);
            var result = da.ExecuteSPBool("sp_dtuser", parametros);
            return result;
        }

        public bool GuardarUsuario(Usuario usuario)
        {
            var da = new DataAccess();

            var parametros = new Dictionary<string, object>();
            parametros.Add("@apellido", usuario.Apellido);
            parametros.Add("@email", usuario.Email);
            parametros.Add("@nombre", usuario.Nombre);
            parametros.Add("@password", usuario.Password);

            var result = da.ExecuteSPBool("sp_ituser", parametros);
            return result;
        }
    }
}
