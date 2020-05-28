using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
namespace Parcial
{
    public class apporderDAO
    {
        public static List<apporder> leerorden()
        {
            //--------------------GUARDANDO ORDENES-----------------------------------------------------------
            List<apporder> lista=new List<apporder>();
            try
            {
                string sql =String.Format(
                    " select * from apporder ");
                DataTable dt = ConexionBD.realizarConsulta(sql);
                foreach (DataRow valores in dt.Rows)
                {
                    apporder n=new apporder();
                    n.idorder = Convert.ToInt32(valores[0].ToString());
                    n.createdate = valores[1].ToString();
                    n.idproduct = Convert.ToInt32(valores[2].ToString());
                    n.idaddress =Convert.ToInt32(valores[3].ToString());
                    lista.Add(n);
                } 
            }
            catch (Exception e)
            {
                MessageBox.Show("Hubo un problema" + e);
            }
            return lista;
        }
    }
}