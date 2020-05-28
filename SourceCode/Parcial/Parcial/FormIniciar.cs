using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int tipo = appuserDAO.iniciarsesion(txtNombre.Text, txtContrasenia.Text); 
            switch (tipo)
            {
                case 0:
                    MessageBox.Show("Bienvenido administrador :"+txtNombre.Text);
                    this.Hide();
                    FormAdministrador admin=new FormAdministrador();
                    admin.Show();
                    break;
                case 1:
                    MessageBox.Show("Bienvenido usuario : "+txtNombre.Text);
                    this.Hide();
                    FormNormal usuarionormal=new FormNormal();
                   // usuarionormal.idcliente = UsuarioDAO.id_obtenido;
                    usuarionormal.Show();
                    break;
                default:
                    MessageBox.Show("Usuario o contraseña incorrectos");
                    break;
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            MessageBox.Show("Saliendo...");
            Application.Exit();

        }
    }
}