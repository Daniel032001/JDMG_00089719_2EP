using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Parcial
{
    public class appuserDAO
    {
        public static int id_obtenido = 0;
        public static int iniciarsesion(string usuario, string contraseña)
        {
            DataTable dt = null;
            int tipo = -1; //admin 0,1 usuario
            try
            {
                string sql = 
                    $"select iduser,usertype from appuser where username='{usuario}' and password='{contraseña}'";
                dt = ConexionBD.realizarConsulta(sql);
                if (dt != null)
                {
                    foreach (DataRow var in dt.Rows)
                    {
                        id_obtenido = Convert.ToInt32(var[0]);
                        tipo = Convert.ToInt32(var[1]);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un error" + e);
            } 
            return tipo;
        }
        //--------------------------------------------------------------------------------------
        public static List<appuser> cargarusuario()
        {
            List <appuser> lista= new List<appuser>();
            try
            {
                string sql = "select * from appuser";
                DataTable dt = ConexionBD.realizarConsulta(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    appuser usu=new appuser();
                    usu.iduser = Convert.ToInt32(fila[0].ToString());
                    usu.fullname = fila[1].ToString();
                    usu.username = fila[2].ToString();
                    usu.password = fila[3].ToString();
                    int tipo = Convert.ToInt32(fila[4].ToString());
                    if (tipo == 1)
                    {
                        usu.usertype = "Normal";
                    }
                    else
                    {
                        usu.usertype = "Administrador";
                    }
                    lista.Add(usu);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        //----------------------------------------------------------------------------------------------------
        public static void crearusuario(string fullname,string username,string password ,int admin)
        {
            try
            {
                string sql = String.Format("insert into appuser(fullname,username,password,admin)"
                                           + "values('{0}','{1}','{2}',{3})", fullname, username, password,admin);
                ConexionBD.realizarAccion(sql);
                MessageBox.Show("Usuario creado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
        //-------------------------------------------------------------------------------------------------
        public static void eliminarusuario(int id)
        {
            try
            {
                string sql = String.Format(
                    "delete from apporder where iduser ='{0}'; " +
                    "delete from appuser where iduser='{0}';",
                    id);
                ConexionBD.realizarAccion(sql);
                MessageBox.Show("Se eliminó el usuario y su informacion ");
            }
            catch (Exception e)
            {
                MessageBox.Show("Ha ocurrido un error" + e);
            }
        }
    }
}