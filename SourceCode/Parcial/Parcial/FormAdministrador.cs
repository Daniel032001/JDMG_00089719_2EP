using System;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormAdministrador : Form
    {
        public static int id, idbusiness;
        public FormAdministrador()
        {
            InitializeComponent();
            idbusiness = 0;
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = appuserDAO.cargarusuario();
            dataGridView1.Columns[0].Width = 30;
            String[] combo={"Administrador","Normal"}; 
            cmbTipoUser.DataSource = combo;
            cmbTipoUser.DropDownStyle = ComboBoxStyle.DropDownList;
            dataGridView2.DataSource = apporderDAO.leerorden();
            dataGridView4.DataSource = businessDAO.mostrarNegocios();
            dataGridView3.DataSource = productDAO.mostrarProductos();
            //falta leer pedidos del usuario especifico
        }
        //-----------------------------------AUTOFILL TEXTBOX---------------------------------------------------
       
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
             id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                        textBoxNameCompleto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                        textBoxNameUser.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                        textBoxContrasUser.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                        cmbTipoUser.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                        if (dataGridView1.CurrentRow.Cells[4].Value.ToString().Equals("Administrador"))
                        {
                            cmbTipoUser.SelectedIndex = 0;
                        }
                        else
                        {
                            cmbTipoUser.SelectedIndex = 1;
                        } 
                        
        }
        //-------------------------------BOTONES--------------------------------------------------
        
        //-------------------------------------------CREAR USUARIO---------------------
        private void buttonCrearUser_Click(object sender, EventArgs e)
        {
            if (textBoxNameCompleto.Text.Trim().Equals("") || textBoxNameUser.Text.Trim().Equals("")
                                                           || textBoxContrasUser.Text.Trim().Equals("")){
                MessageBox.Show("No puedes dejar campos vacios "); 
            }
            else {
                appuserDAO.crearusuario(textBoxNameCompleto.Text, textBoxNameUser.Text,
                    textBoxContrasUser.Text, usertype: cmbTipoUser.SelectedIndex);
                dataGridView1.DataSource = appuserDAO.cargarusuario();
                limmpiar();
            }
        }
        public void limmpiar()
        {
            textBoxNameCompleto.Clear();
            textBoxNameUser.Clear();
            id = 0;
            textBoxContrasUser.Clear();
            textBoxNameNegocio.Clear();
            textBoxDescripNegocio.Clear();
            textBoxIdNegAElim.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBoxIdProdAElim.Clear();
        }
//----------------------------------ELIMINAR USUARIO--------------------------------------------------------
        private void buttonElimUser_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecciona un usuario a Eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar este usuario?",
                    "Aviso",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    appuserDAO.eliminarusuario(id);
                    dataGridView1.DataSource = appuserDAO.cargarusuario();
                }
                limmpiar();
            }
        }
        //-------------------------------AGREGAR NEGOCIO------------------------------
        private void buttonAggNegocio_Click(object sender, EventArgs e)
        {
            if (textBoxNameNegocio.Text.Trim().Equals("") || textBoxDescripNegocio.Text.Trim().Equals("")){
                MessageBox.Show("No puedes dejar campos vacios "); 
            }
            else {
                businessDAO.crearnegocio(textBoxNameNegocio.Text, textBoxDescripNegocio.Text);
                dataGridView4.DataSource = businessDAO.mostrarNegocios();
                limmpiar();
            }
        }
        
        //-------------------------------AUTOFILL NEGOCIO-----------------------------------------
        
        //PRIMERO EL AUTOFILL
        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = 0;
            id = Convert.ToInt32(dataGridView4.CurrentRow.Cells[0].Value.ToString());
            textBoxIdNegAElim.Text = dataGridView4.CurrentRow.Cells[0].Value.ToString();
            textBoxNameNegocio.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            textBoxDescripNegocio.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();

        }
       
        //------------------------------ELIMINAR NEGOCIO-------------------------------
        
        private void buttonElimNegocio_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecciona un Negocio a Eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar este Negocio?",
                    "Aviso",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    businessDAO.eliminarnegocio(id);
                    dataGridView4.DataSource = businessDAO.mostrarNegocios();
                }
                limmpiar();
            }
        }
        //---------------------------------PRODUCTO---------------------------------------------------------
        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id = 0;
            id = Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value.ToString());
            textBoxIdProdAElim.Text = Convert.ToString(id);
            idbusiness = Convert.ToInt32(dataGridView3.CurrentRow.Cells[1].Value.ToString());
            textBox7.Text = Convert.ToString(idbusiness);
            textBox8.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            
        }
        //------------------------AGREGAR PRODUCTO--------------------------------------------
        private void buttonAggProducto_Click(object sender, EventArgs e)
        {
            if (textBox7.Text.Trim().Equals("") || textBox8.Text.Trim().Equals("")){
                MessageBox.Show("No puedes dejar campos vacios "); 
            }
            else {
                productDAO.crearProducto(idbusiness, textBox8.Text);
                dataGridView3.DataSource = productDAO.mostrarProductos();
                limmpiar();
            }
        }
        //--------------------------------ELIMINAR NEGOCIO------------------------------------


        private void buttonElimProducto_Click(object sender, EventArgs e)
        {
            if (id == 0)
            {
                MessageBox.Show("Selecciona un Producto a Eliminar");
            }
            else
            {
                if (MessageBox.Show("Estas seguro que seas eliminar este Producto?",
                    "Aviso",MessageBoxButtons.YesNoCancel)==DialogResult.Yes)
                {
                    productDAO.eliminarProducto(id);
                    dataGridView3.DataSource = productDAO.mostrarProductos();
                }
                limmpiar();
            }
        }
    }
}