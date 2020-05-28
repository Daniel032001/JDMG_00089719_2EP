using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Parcial
{
    public class businessDAO
    {
        public static List<business> mostrarNegocios()
        {
            //DataTable dt = null;
            List <business> lista= new List<business>();
            try
            {
                string sql = "select * from business";
                DataTable dt = ConexionBD.realizarConsulta(sql);
                foreach (DataRow fila in dt.Rows)
                {
                    business usu=new business();
                    usu.idbusiness = Convert.ToInt32(fila[0].ToString());
                    usu.name = fila[1].ToString();
                    usu.description = fila[2].ToString();
                    lista.Add(usu);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error" + e);
            }
            return lista;
        }
        //-------------------------------------CREAR NEGOCIO----------------------------------------------------
        public static void crearnegocio(string name, string description)
        {
            try
            {
                string sql = String.Format("insert into business (name, description) "
                                           + "values('{0}','{1}')", name, description);
                ConexionBD.realizarAccion(sql);
                MessageBox.Show("Negocio creado correctamente");
            }
            catch (Exception e)
            {
                MessageBox.Show("Intentalo de nuevo");
            }
        }
        //-------------------------------------ELIMINAR NEGOCIO---------------------------------------------------
        public static void eliminarnegocio(int id)
        {
            try
            {
                string sql = String.Format(
                    
                    "delete from business where idbusiness='{0}';",
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