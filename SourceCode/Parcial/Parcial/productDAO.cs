using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Parcial
{
    public class productDAO
    {
          public static List<product> mostrarProductos()
                {
                    //DataTable dt = null;
                    List <product> lista= new List<product>();
                    try
                    {
                        string sql = "select * from  product";
                        DataTable dt = ConexionBD.realizarConsulta(sql);
                        foreach (DataRow fila in dt.Rows)
                        {
                            product usu=new product();
                            usu.idproduct = Convert.ToInt32(fila[0].ToString());
                            usu.idbusiness = Convert.ToInt32(fila[1].ToString());
                            usu.name = fila[2].ToString();
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
                public static void crearProducto(int idbusiness, string name)
                {
                    try
                    {
                        string sql = String.Format("insert into product (idbusiness,name) "
                                                   + "values({0},'{1}')", idbusiness,name);
                        ConexionBD.realizarAccion(sql);
                        MessageBox.Show("Producto creado correctamente");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Intentalo de nuevo");
                    }
                }
                //-------------------------------------ELIMINAR NEGOCIO----------------------------------------------
                public static void eliminarProducto(int id)
                {
                    try
                    {
                        string sql = String.Format(
                            
                            "delete from product where idproduct='{0}';",
                            id);
                        ConexionBD.realizarAccion(sql);
                        MessageBox.Show("Se elimino el producto y su informacion ");
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show("Ha ocurrido un error" );
                    }
                }
    }
}