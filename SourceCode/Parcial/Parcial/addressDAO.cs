using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Parcial
{
    public class addressDAO
    {
        public static List<address> mostrarDireccion()
                {
                    //DataTable dt = null;
                    List <address> lista= new List<address>();
                    try
                    {
                        string sql = "select * from  address";
                        DataTable dt = ConexionBD.realizarConsulta(sql);
                        foreach (DataRow fila in dt.Rows)
                        {
                            address usu=new address();
                            usu.idaddress = Convert.ToInt32(fila[0].ToString());
                            usu.iduser = Convert.ToInt32(fila[1].ToString());
                            usu.Address = fila[2].ToString();
                            lista.Add(usu);
                        }
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Error" + e);
                    }
                    return lista;
                }
                //-------------------------------------CREAR NEGOCIO-------------------------------------------------
                public static void crearProducto(int iduser, string Address)
                {
                    try
                    {
                        string sql = String.Format("insert into address (iduser,Address) "
                                                   + "values({0},'{1}')", iduser,Address);
                        ConexionBD.realizarAccion(sql);
                        MessageBox.Show("Direccion agregada correctamente");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Intentalo de nuevo");
                    }
                }
                //-------------------------------------ELIMINAR NEGOCIO----------------------------------------------
                public static void eliminarDireccion(int id)
                {
                    try
                    {
                        string sql = String.Format(
                            
                            "delete from address where iduser='{0}';",
                            id);
                        ConexionBD.realizarAccion(sql);
                        MessageBox.Show("Se eliminó la direccion y su informacion ");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" );
                    }
                }
    }
}