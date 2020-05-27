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
    }
}