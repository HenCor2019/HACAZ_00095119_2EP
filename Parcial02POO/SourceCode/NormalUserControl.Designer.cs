using System.ComponentModel;

namespace Parcial02
{
    partial class AuxUserTwo
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.labelOrdenar = new System.Windows.Forms.Label();
            this.cbOrdenar = new System.Windows.Forms.ComboBox();
            this.Eliminar = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.btnActualizarPedidos = new System.Windows.Forms.Button();
            this.labelPedidos = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbEliminar = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnActualizarDir = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnEliminarDireccion = new System.Windows.Forms.Button();
            this.cbEliminarDireccion = new System.Windows.Forms.ComboBox();
            this.btnActualizarDirecciones = new System.Windows.Forms.Button();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.LabelDireccion = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtAgregar = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.Eliminar.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.tabPage6.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.Eliminar);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(833, 463);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(825, 435);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Pedidos";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Cyan;
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.53247F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.46753F));
            this.tableLayoutPanel2.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 156F));
            this.tableLayoutPanel2.Controls.Add(this.dataGridView1, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.btnActualizar, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 2;
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.04545F));
            this.tableLayoutPanel2.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.95454F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(819, 429);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableLayoutPanel2.SetColumnSpan(this.dataGridView1, 3);
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(813, 350);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnActualizar
            // 
            this.btnActualizar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizar.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnActualizar.Location = new System.Drawing.Point(665, 3);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(151, 67);
            this.btnActualizar.TabIndex = 1;
            this.btnActualizar.Text = "Actualizar datos";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.tableLayoutPanel1);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 435);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Ordenar";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Cyan;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnOrdenar, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelOrdenar, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cbOrdenar, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20.19704F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 79.80296F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 54F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(819, 429);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.btnOrdenar, 2);
            this.btnOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnOrdenar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnOrdenar.Location = new System.Drawing.Point(3, 377);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(813, 49);
            this.btnOrdenar.TabIndex = 0;
            this.btnOrdenar.Text = "Agregrar orden";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // labelOrdenar
            // 
            this.labelOrdenar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelOrdenar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelOrdenar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.labelOrdenar.Location = new System.Drawing.Point(3, 56);
            this.labelOrdenar.Name = "labelOrdenar";
            this.labelOrdenar.Size = new System.Drawing.Size(403, 225);
            this.labelOrdenar.TabIndex = 1;
            this.labelOrdenar.Text = "Productos";
            this.labelOrdenar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbOrdenar
            // 
            this.cbOrdenar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbOrdenar.FormattingEnabled = true;
            this.cbOrdenar.Location = new System.Drawing.Point(499, 157);
            this.cbOrdenar.Name = "cbOrdenar";
            this.cbOrdenar.Size = new System.Drawing.Size(229, 23);
            this.cbOrdenar.TabIndex = 2;
            // 
            // Eliminar
            // 
            this.Eliminar.Controls.Add(this.tableLayoutPanel3);
            this.Eliminar.Location = new System.Drawing.Point(4, 24);
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.Padding = new System.Windows.Forms.Padding(3);
            this.Eliminar.Size = new System.Drawing.Size(825, 435);
            this.Eliminar.TabIndex = 2;
            this.Eliminar.Text = "Eliminar";
            this.Eliminar.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.BackColor = System.Drawing.Color.Cyan;
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.35501F));
            this.tableLayoutPanel3.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.64499F));
            this.tableLayoutPanel3.Controls.Add(this.btnActualizarPedidos, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.labelPedidos, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.btnEliminar, 0, 3);
            this.tableLayoutPanel3.Controls.Add(this.cbEliminar, 1, 1);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 4;
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 21.45749F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 78.54251F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 125F));
            this.tableLayoutPanel3.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(819, 429);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // btnActualizarPedidos
            // 
            this.btnActualizarPedidos.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnActualizarPedidos.Font = new System.Drawing.Font("Showcard Gothic", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarPedidos.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnActualizarPedidos.Location = new System.Drawing.Point(423, 3);
            this.btnActualizarPedidos.Name = "btnActualizarPedidos";
            this.btnActualizarPedidos.Size = new System.Drawing.Size(393, 47);
            this.btnActualizarPedidos.TabIndex = 0;
            this.btnActualizarPedidos.Text = "Actualizar pedidos";
            this.btnActualizarPedidos.UseVisualStyleBackColor = true;
            this.btnActualizarPedidos.Click += new System.EventHandler(this.btnActualizarPedidos_Click);
            // 
            // labelPedidos
            // 
            this.labelPedidos.BackColor = System.Drawing.Color.Cyan;
            this.labelPedidos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelPedidos.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelPedidos.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.labelPedidos.Location = new System.Drawing.Point(3, 53);
            this.labelPedidos.Name = "labelPedidos";
            this.labelPedidos.Size = new System.Drawing.Size(414, 194);
            this.labelPedidos.TabIndex = 1;
            this.labelPedidos.Text = "Pedidos";
            this.labelPedidos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnEliminar
            // 
            this.btnEliminar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel3.SetColumnSpan(this.btnEliminar, 2);
            this.btnEliminar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnEliminar.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnEliminar.Location = new System.Drawing.Point(3, 375);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(813, 51);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar pedido";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbEliminar
            // 
            this.cbEliminar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbEliminar.FormattingEnabled = true;
            this.cbEliminar.Location = new System.Drawing.Point(480, 138);
            this.cbEliminar.Name = "cbEliminar";
            this.cbEliminar.Size = new System.Drawing.Size(278, 23);
            this.cbEliminar.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.tabControl2);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(825, 435);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Direcciones";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage6);
            this.tabControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl2.Location = new System.Drawing.Point(3, 3);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(819, 429);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Cyan;
            this.tabPage4.Controls.Add(this.btnActualizarDir);
            this.tabPage4.Controls.Add(this.dataGridView2);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(811, 401);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "Mis direcciones";
            // 
            // btnActualizarDir
            // 
            this.btnActualizarDir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnActualizarDir.Font = new System.Drawing.Font("Showcard Gothic", 9.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarDir.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnActualizarDir.Location = new System.Drawing.Point(563, 6);
            this.btnActualizarDir.Name = "btnActualizarDir";
            this.btnActualizarDir.Size = new System.Drawing.Size(147, 46);
            this.btnActualizarDir.TabIndex = 1;
            this.btnActualizarDir.Text = "Actualizar";
            this.btnActualizarDir.UseVisualStyleBackColor = true;
            this.btnActualizarDir.Click += new System.EventHandler(this.btnActualizarDir_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode =
                System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(0, 58);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(730, 343);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.Cyan;
            this.tabPage5.Controls.Add(this.btnEliminarDireccion);
            this.tabPage5.Controls.Add(this.cbEliminarDireccion);
            this.tabPage5.Controls.Add(this.btnActualizarDirecciones);
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(811, 401);
            this.tabPage5.TabIndex = 1;
            this.tabPage5.Text = "Eliminar";
            // 
            // btnEliminarDireccion
            // 
            this.btnEliminarDireccion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEliminarDireccion.Font = new System.Drawing.Font("Showcard Gothic", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnEliminarDireccion.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnEliminarDireccion.Location = new System.Drawing.Point(245, 208);
            this.btnEliminarDireccion.Name = "btnEliminarDireccion";
            this.btnEliminarDireccion.Size = new System.Drawing.Size(261, 44);
            this.btnEliminarDireccion.TabIndex = 2;
            this.btnEliminarDireccion.Text = "Eliminar direccion";
            this.btnEliminarDireccion.UseVisualStyleBackColor = true;
            this.btnEliminarDireccion.Click += new System.EventHandler(this.btnEliminarDireccion_Click);
            // 
            // cbEliminarDireccion
            // 
            this.cbEliminarDireccion.FormattingEnabled = true;
            this.cbEliminarDireccion.Location = new System.Drawing.Point(138, 148);
            this.cbEliminarDireccion.Name = "cbEliminarDireccion";
            this.cbEliminarDireccion.Size = new System.Drawing.Size(453, 23);
            this.cbEliminarDireccion.TabIndex = 1;
            // 
            // btnActualizarDirecciones
            // 
            this.btnActualizarDirecciones.Font = new System.Drawing.Font("Showcard Gothic", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnActualizarDirecciones.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnActualizarDirecciones.Location = new System.Drawing.Point(595, 6);
            this.btnActualizarDirecciones.Name = "btnActualizarDirecciones";
            this.btnActualizarDirecciones.Size = new System.Drawing.Size(153, 42);
            this.btnActualizarDirecciones.TabIndex = 0;
            this.btnActualizarDirecciones.Text = "Actualizar";
            this.btnActualizarDirecciones.UseVisualStyleBackColor = true;
            this.btnActualizarDirecciones.Click += new System.EventHandler(this.btnActualizarDirecciones_Click);
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.Cyan;
            this.tabPage6.Controls.Add(this.LabelDireccion);
            this.tabPage6.Controls.Add(this.btnAgregar);
            this.tabPage6.Controls.Add(this.txtAgregar);
            this.tabPage6.Location = new System.Drawing.Point(4, 24);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(811, 401);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "Agregar";
            // 
            // LabelDireccion
            // 
            this.LabelDireccion.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.LabelDireccion.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.LabelDireccion.Location = new System.Drawing.Point(150, 60);
            this.LabelDireccion.Name = "LabelDireccion";
            this.LabelDireccion.Size = new System.Drawing.Size(408, 45);
            this.LabelDireccion.TabIndex = 2;
            this.LabelDireccion.Text = "Nueva direccion";
            this.LabelDireccion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnAgregar.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.btnAgregar.Location = new System.Drawing.Point(234, 241);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(276, 67);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click_1);
            // 
            // txtAgregar
            // 
            this.txtAgregar.BackColor = System.Drawing.Color.White;
            this.txtAgregar.Location = new System.Drawing.Point(170, 149);
            this.txtAgregar.Name = "txtAgregar";
            this.txtAgregar.Size = new System.Drawing.Size(389, 23);
            this.txtAgregar.TabIndex = 0;
            // 
            // AuxUserTwo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tabControl1);
            this.Name = "AuxUserTwo";
            this.Size = new System.Drawing.Size(833, 463);
            this.Load += new System.EventHandler(this.TabPedidos_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.Eliminar.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView2)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage6.ResumeLayout(false);
            this.tabPage6.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.ComboBox cbOrdenar;
        private System.Windows.Forms.Label labelOrdenar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.TabPage Eliminar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button btnActualizarPedidos;
        private System.Windows.Forms.ComboBox cbEliminar;
        private System.Windows.Forms.Label labelPedidos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox txtAgregar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label LabelDireccion;
        private System.Windows.Forms.Button btnActualizarDirecciones;
        private System.Windows.Forms.Button btnEliminarDireccion;
        private System.Windows.Forms.ComboBox cbEliminarDireccion;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnActualizarDir;
    }
}