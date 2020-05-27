using System.ComponentModel;

namespace Parcial
{
    partial class FormAdministrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxNameCompleto = new System.Windows.Forms.TextBox();
            this.textBoxNameUser = new System.Windows.Forms.TextBox();
            this.textBoxContrasUser = new System.Windows.Forms.TextBox();
            this.cmbTipoUser = new System.Windows.Forms.ComboBox();
            this.buttonCrearUser = new System.Windows.Forms.Button();
            this.buttonElimUser = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxIdUserAElim = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNameNegocio = new System.Windows.Forms.TextBox();
            this.textBoxDescripNegocio = new System.Windows.Forms.TextBox();
            this.buttonAggNegocio = new System.Windows.Forms.Button();
            this.buttonElimNegocio = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxIdNegAElim = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.buttonAggProducto = new System.Windows.Forms.Button();
            this.buttonElimProducto = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxIdProdAElim = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(800, 450);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(792, 424);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Usuarios";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.label4, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameCompleto, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.textBoxNameUser, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.textBoxContrasUser, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.cmbTipoUser, 1, 7);
            this.tableLayoutPanel1.Controls.Add(this.buttonCrearUser, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.buttonElimUser, 0, 9);
            this.tableLayoutPanel1.Controls.Add(this.label11, 1, 9);
            this.tableLayoutPanel1.Controls.Add(this.textBoxIdUserAElim, 1, 10);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(432, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 11;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.1F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.220096F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.48325F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(357, 418);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label1.Location = new System.Drawing.Point(181, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 38);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre completo";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label2.Location = new System.Drawing.Point(181, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 38);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre de usuario";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.Location = new System.Drawing.Point(181, 152);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(173, 38);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label4.Location = new System.Drawing.Point(181, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(173, 38);
            this.label4.TabIndex = 2;
            this.label4.Text = "Tipo de usuario";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxNameCompleto
            // 
            this.textBoxNameCompleto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameCompleto.Location = new System.Drawing.Point(181, 41);
            this.textBoxNameCompleto.Name = "textBoxNameCompleto";
            this.textBoxNameCompleto.Size = new System.Drawing.Size(173, 29);
            this.textBoxNameCompleto.TabIndex = 3;
            // 
            // textBoxNameUser
            // 
            this.textBoxNameUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameUser.Location = new System.Drawing.Point(181, 117);
            this.textBoxNameUser.Name = "textBoxNameUser";
            this.textBoxNameUser.Size = new System.Drawing.Size(173, 29);
            this.textBoxNameUser.TabIndex = 3;
            // 
            // textBoxContrasUser
            // 
            this.textBoxContrasUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContrasUser.Location = new System.Drawing.Point(181, 193);
            this.textBoxContrasUser.Name = "textBoxContrasUser";
            this.textBoxContrasUser.Size = new System.Drawing.Size(173, 29);
            this.textBoxContrasUser.TabIndex = 3;
            // 
            // cmbTipoUser
            // 
            this.cmbTipoUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbTipoUser.FormattingEnabled = true;
            this.cmbTipoUser.Location = new System.Drawing.Point(181, 269);
            this.cmbTipoUser.Name = "cmbTipoUser";
            this.cmbTipoUser.Size = new System.Drawing.Size(173, 32);
            this.cmbTipoUser.TabIndex = 0;
            // 
            // buttonCrearUser
            // 
            this.buttonCrearUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonCrearUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonCrearUser.Location = new System.Drawing.Point(3, 3);
            this.buttonCrearUser.Name = "buttonCrearUser";
            this.tableLayoutPanel1.SetRowSpan(this.buttonCrearUser, 8);
            this.buttonCrearUser.Size = new System.Drawing.Size(172, 298);
            this.buttonCrearUser.TabIndex = 4;
            this.buttonCrearUser.Text = "Crear\r\nUsuario";
            this.buttonCrearUser.UseVisualStyleBackColor = true;
            this.buttonCrearUser.Click += new System.EventHandler(this.buttonCrearUser_Click);
            // 
            // buttonElimUser
            // 
            this.buttonElimUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonElimUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonElimUser.Location = new System.Drawing.Point(3, 333);
            this.buttonElimUser.Name = "buttonElimUser";
            this.tableLayoutPanel1.SetRowSpan(this.buttonElimUser, 2);
            this.buttonElimUser.Size = new System.Drawing.Size(172, 82);
            this.buttonElimUser.TabIndex = 5;
            this.buttonElimUser.Text = "Eliminar Usuario";
            this.buttonElimUser.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label11.Location = new System.Drawing.Point(181, 330);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(173, 48);
            this.label11.TabIndex = 6;
            this.label11.Text = "Ingresa ID del usuario\r\n a eliminar";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIdUserAElim
            // 
            this.textBoxIdUserAElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIdUserAElim.Location = new System.Drawing.Point(181, 381);
            this.textBoxIdUserAElim.Name = "textBoxIdUserAElim";
            this.textBoxIdUserAElim.Size = new System.Drawing.Size(173, 29);
            this.textBoxIdUserAElim.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Left;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(429, 418);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.tableLayoutPanel2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(792, 424);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Negocios";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.textBoxNameNegocio, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.textBoxDescripNegocio, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.buttonAggNegocio, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.buttonElimNegocio, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label7, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.textBoxIdNegAElim, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.label5, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 5;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(786, 418);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(3, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(229, 83);
            this.label6.TabIndex = 0;
            this.label6.Text = "Descripcion del negocio";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // textBoxNameNegocio
            // 
            this.textBoxNameNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxNameNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxNameNegocio.Location = new System.Drawing.Point(238, 3);
            this.textBoxNameNegocio.Name = "textBoxNameNegocio";
            this.textBoxNameNegocio.Size = new System.Drawing.Size(387, 31);
            this.textBoxNameNegocio.TabIndex = 1;
            // 
            // textBoxDescripNegocio
            // 
            this.textBoxDescripNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxDescripNegocio.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxDescripNegocio.Location = new System.Drawing.Point(238, 86);
            this.textBoxDescripNegocio.Name = "textBoxDescripNegocio";
            this.textBoxDescripNegocio.Size = new System.Drawing.Size(387, 31);
            this.textBoxDescripNegocio.TabIndex = 1;
            // 
            // buttonAggNegocio
            // 
            this.buttonAggNegocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel2.SetColumnSpan(this.buttonAggNegocio, 3);
            this.buttonAggNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAggNegocio.Location = new System.Drawing.Point(3, 169);
            this.buttonAggNegocio.Name = "buttonAggNegocio";
            this.buttonAggNegocio.Size = new System.Drawing.Size(780, 77);
            this.buttonAggNegocio.TabIndex = 2;
            this.buttonAggNegocio.Text = "Agregar Negocio";
            this.buttonAggNegocio.UseVisualStyleBackColor = true;
            // 
            // buttonElimNegocio
            // 
            this.buttonElimNegocio.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonElimNegocio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonElimNegocio.Location = new System.Drawing.Point(3, 252);
            this.buttonElimNegocio.Name = "buttonElimNegocio";
            this.tableLayoutPanel2.SetRowSpan(this.buttonElimNegocio, 2);
            this.buttonElimNegocio.Size = new System.Drawing.Size(229, 163);
            this.buttonElimNegocio.TabIndex = 2;
            this.buttonElimNegocio.Text = "Eliminar negocio";
            this.buttonElimNegocio.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(238, 249);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(387, 83);
            this.label7.TabIndex = 0;
            this.label7.Text = "Ingresa ID del negocio a eliminar:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxIdNegAElim
            // 
            this.textBoxIdNegAElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIdNegAElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxIdNegAElim.Location = new System.Drawing.Point(238, 335);
            this.textBoxIdNegAElim.Name = "textBoxIdNegAElim";
            this.textBoxIdNegAElim.Size = new System.Drawing.Size(387, 31);
            this.textBoxIdNegAElim.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(229, 83);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nombre del negocio";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tableLayoutPanel3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(792, 424);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Productos";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.57576F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.49495F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 17.80303F));
            this.tableLayoutPanel3.Controls.Add(this.label8, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.textBox7, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.textBox8, 1, 1);
            this.tableLayoutPanel3.Controls.Add(this.buttonAggProducto, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.buttonElimProducto, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.label10, 1, 3);
            this.tableLayoutPanel3.Controls.Add(this.textBoxIdProdAElim, 1, 4);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 5;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(792, 424);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label8.Location = new System.Drawing.Point(3, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 84);
            this.label8.TabIndex = 0;
            this.label8.Text = "Ingresa el ID del negocio al \r\nque pertenece el producto";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label9.Location = new System.Drawing.Point(3, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(252, 84);
            this.label9.TabIndex = 0;
            this.label9.Text = "Nombre del producto";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // textBox7
            // 
            this.textBox7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox7.Location = new System.Drawing.Point(261, 3);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(386, 31);
            this.textBox7.TabIndex = 1;
            // 
            // textBox8
            // 
            this.textBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBox8.Location = new System.Drawing.Point(261, 87);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(386, 31);
            this.textBox8.TabIndex = 1;
            // 
            // buttonAggProducto
            // 
            this.buttonAggProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.buttonAggProducto, 3);
            this.buttonAggProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonAggProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonAggProducto.Location = new System.Drawing.Point(3, 171);
            this.buttonAggProducto.Name = "buttonAggProducto";
            this.buttonAggProducto.Size = new System.Drawing.Size(786, 78);
            this.buttonAggProducto.TabIndex = 2;
            this.buttonAggProducto.Text = "Agregar Producto";
            this.buttonAggProducto.UseVisualStyleBackColor = true;
            // 
            // buttonElimProducto
            // 
            this.buttonElimProducto.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.buttonElimProducto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonElimProducto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.buttonElimProducto.Location = new System.Drawing.Point(3, 255);
            this.buttonElimProducto.Name = "buttonElimProducto";
            this.tableLayoutPanel3.SetRowSpan(this.buttonElimProducto, 2);
            this.buttonElimProducto.Size = new System.Drawing.Size(252, 166);
            this.buttonElimProducto.TabIndex = 2;
            this.buttonElimProducto.Text = "Eliminar Producto";
            this.buttonElimProducto.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label10.Location = new System.Drawing.Point(261, 252);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(386, 84);
            this.label10.TabIndex = 0;
            this.label10.Text = "Ingresa ID del producto a eliminar:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxIdProdAElim
            // 
            this.textBoxIdProdAElim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxIdProdAElim.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.textBoxIdProdAElim.Location = new System.Drawing.Point(261, 339);
            this.textBoxIdProdAElim.Name = "textBoxIdProdAElim";
            this.textBoxIdProdAElim.Size = new System.Drawing.Size(386, 31);
            this.textBoxIdProdAElim.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(792, 424);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Ordenes";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(792, 424);
            this.dataGridView2.TabIndex = 0;
            // 
            // FormAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAdministrador";
            this.Text = "FormAdministrador";
            this.Load += new System.EventHandler(this.FormAdministrador_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAggNegocio;
        private System.Windows.Forms.Button buttonAggProducto;
        private System.Windows.Forms.Button buttonCrearUser;
        private System.Windows.Forms.Button buttonElimNegocio;
        private System.Windows.Forms.Button buttonElimProducto;
        private System.Windows.Forms.Button buttonElimUser;
        private System.Windows.Forms.ComboBox cmbTipoUser;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBoxContrasUser;
        private System.Windows.Forms.TextBox textBoxDescripNegocio;
        private System.Windows.Forms.TextBox textBoxIdNegAElim;
        private System.Windows.Forms.TextBox textBoxIdProdAElim;
        private System.Windows.Forms.TextBox textBoxIdUserAElim;
        private System.Windows.Forms.TextBox textBoxNameCompleto;
        private System.Windows.Forms.TextBox textBoxNameNegocio;
        private System.Windows.Forms.TextBox textBoxNameUser;

        #endregion
    }
}