using System;
using System.Windows.Forms;

namespace Parcial
{
    public partial class FormAdministrador : Form
    {
        public static int id;
        public FormAdministrador()
        {
            InitializeComponent();
        }

        private void FormAdministrador_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = appuserDAO.cargarusuario();
            dataGridView1.Columns[0].Width = 30;
            String[] combo={"Administrador","Normal"}; 
            cmbTipoUser.DataSource = combo;
            cmbTipoUser.DropDownStyle = ComboBoxStyle.DropDownList;
           // dataGridView2.DataSource = appuserDAO.;
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
                        textBoxIdUserAElim.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
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

        private void buttonCrearUser_Click(object sender, EventArgs e)
        {
            if (textBoxNameCompleto.Text.Trim().Equals("") || textBoxNameUser.Text.Trim().Equals("")
                                                           || textBoxContrasUser.Text.Trim().Equals("")){
                MessageBox.Show("No puedes dejar campos vacios "); 
            }
            else {
                appuserDAO.crearusuario(textBoxNameCompleto.Text, textBoxNameUser.Text,
                    textBoxContrasUser.Text, cmbTipoUser.SelectedIndex);
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
            /*txtProducto.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            idinventario = 0;*/
        }
    }
}