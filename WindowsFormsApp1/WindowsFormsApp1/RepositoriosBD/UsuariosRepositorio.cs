using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Entidades;


namespace WindowsFormsApp1.RepositoriosBD
{
    public class UsuariosRepositorio
    {
        //Datos de usuario a acceder.
        public Usuario ObtenerUsuarioAdmin()
        {
            var usuario = new Usuario();
            usuario.NombreUsuario = "admin";
            usuario.Password = "admin";
            usuario.IdUsuario = 1;

            return usuario;
        }

        public Usuario LoginSinBD(Usuario usuarioIngresado)
        {
            var usuarioPermitido = this.ObtenerUsuarioAdmin();
            if (usuarioPermitido.NombreUsuario == usuarioIngresado.NombreUsuario && usuarioPermitido.IdUsuario == usuarioIngresado.IdUsuario && usuarioPermitido.Password == usuarioIngresado.Password)
            {
                return usuarioPermitido;
            }
            return null;
        }

        public Usuario LoginBD(Usuario usuarioIngresado)
        {
            Usuario usuarioResultado = null;
            var sentenciaSql = $"SELECT * FROM EMPLEADOS WHERE usuario='{usuarioIngresado.NombreUsuario}' AND password='{usuarioIngresado.Password}'";
            var tablaResultado = DBHelper.GetDBHelper().ConsultaSQL(sentenciaSql);
            if (tablaResultado.Rows.Count == 1)
            {
                var row = tablaResultado.Rows[0];
                usuarioResultado = new Usuario();
                usuarioResultado.NombreUsuario = row["usuario"].ToString();
                usuarioResultado.IdUsuario = Convert.ToInt32(row["id_usuario"]);

               
            }
            return usuarioResultado;
        }
    }
}
