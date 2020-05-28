using System.ComponentModel;

namespace Parcial02
{
    partial class SignInPrincipal
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
            System.ComponentModel.ComponentResourceManager resources =
                new System.ComponentModel.ComponentResourceManager(typeof(SignInPrincipal));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.cbUsuarios = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBienvenida = new System.Windows.Forms.Label();
            this.labelUsuarioSign = new System.Windows.Forms.Label();
            this.btnCambiarContraseña = new System.Windows.Forms.Button();
            this.btnIniciarSesion = new System.Windows.Forms.Button();
            this.LogoHugo = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.LogoHugo)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txtContraseña, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.cbUsuarios, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.labelBienvenida, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelUsuarioSign, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.btnCambiarContraseña, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.btnIniciarSesion, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.LogoHugo, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.11787F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 36.88213F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(668, 468);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtContraseña.BackColor = System.Drawing.Color.White;
            this.txtContraseña.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.txtContraseña.Location = new System.Drawing.Point(353, 332);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(296, 23);
            this.txtContraseña.TabIndex = 6;
            // 
            // cbUsuarios
            // 
            this.cbUsuarios.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbUsuarios.BackColor = System.Drawing.Color.White;
            this.cbUsuarios.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.cbUsuarios.FormattingEnabled = true;
            this.cbUsuarios.Location = new System.Drawing.Point(351, 280);
            this.cbUsuarios.Name = "cbUsuarios";
            this.cbUsuarios.Size = new System.Drawing.Size(299, 23);
            this.cbUsuarios.TabIndex = 7;
           // this.cbUsuarios.SelectedIndexChanged += new System.EventHandler(this.cbUsuarios_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 15.75F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.label3.Location = new System.Drawing.Point(3, 322);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(328, 44);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelBienvenida
            // 
            this.labelBienvenida.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))),
                ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.tableLayoutPanel1.SetColumnSpan(this.labelBienvenida, 2);
            this.labelBienvenida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelBienvenida.Font = new System.Drawing.Font("Showcard Gothic", 27.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.labelBienvenida.Location = new System.Drawing.Point(3, 165);
            this.labelBienvenida.Name = "labelBienvenida";
            this.labelBienvenida.Size = new System.Drawing.Size(662, 97);
            this.labelBienvenida.TabIndex = 2;
            this.labelBienvenida.Text = "Bienvenido a Hugo";
            this.labelBienvenida.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //this.labelBienvenida.Click += new System.EventHandler(this.labelBienvenida_Click);
            // 
            // labelUsuarioSign
            // 
            this.labelUsuarioSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuarioSign.Font = new System.Drawing.Font("Showcard Gothic", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelUsuarioSign.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.labelUsuarioSign.Location = new System.Drawing.Point(3, 262);
            this.labelUsuarioSign.Name = "labelUsuarioSign";
            this.labelUsuarioSign.Size = new System.Drawing.Size(328, 60);
            this.labelUsuarioSign.TabIndex = 3;
            this.labelUsuarioSign.Text = "Usuario:";
            this.labelUsuarioSign.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCambiarContraseña
            // 
            this.btnCambiarContraseña.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCambiarContraseña.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCambiarContraseña.Font = new System.Drawing.Font("Showcard Gothic", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnCambiarContraseña.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnCambiarContraseña.Location = new System.Drawing.Point(3, 397);
            this.btnCambiarContraseña.Name = "btnCambiarContraseña";
            this.btnCambiarContraseña.Size = new System.Drawing.Size(328, 68);
            this.btnCambiarContraseña.TabIndex = 1;
            this.btnCambiarContraseña.Text = "¿Olvidaste tu contraseña?";
            this.btnCambiarContraseña.UseVisualStyleBackColor = true;
            this.btnCambiarContraseña.Click += new System.EventHandler(this.btnCambiarContraseña_Click);
            // 
            // btnIniciarSesion
            // 
            this.btnIniciarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnIniciarSesion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnIniciarSesion.Font = new System.Drawing.Font("Showcard Gothic", 12F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnIniciarSesion.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnIniciarSesion.Location = new System.Drawing.Point(337, 397);
            this.btnIniciarSesion.Name = "btnIniciarSesion";
            this.btnIniciarSesion.Size = new System.Drawing.Size(328, 68);
            this.btnIniciarSesion.TabIndex = 8;
            this.btnIniciarSesion.Text = "Iniciar sesion";
            this.btnIniciarSesion.UseVisualStyleBackColor = true;
            this.btnIniciarSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogoHugo
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.LogoHugo, 2);
            this.LogoHugo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogoHugo.Image = ((System.Drawing.Image) (resources.GetObject("LogoHugo.Image")));
            this.LogoHugo.Location = new System.Drawing.Point(3, 3);
            this.LogoHugo.Name = "LogoHugo";
            this.LogoHugo.Size = new System.Drawing.Size(662, 159);
            this.LogoHugo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LogoHugo.TabIndex = 9;
            this.LogoHugo.TabStop = false;
            // 
            // SignInPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))), ((int) (((byte) (255)))),
                ((int) (((byte) (255)))));
            this.ClientSize = new System.Drawing.Size(668, 468);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "SignInPrincipal";
            this.Text = "SignInPrincipal";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.SignInPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.SignInPrincipal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize) (this.LogoHugo)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btnCambiarContraseña;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBienvenida;
        private System.Windows.Forms.Label labelUsuarioSign;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.ComboBox cbUsuarios;
        private System.Windows.Forms.Button btnIniciarSesion;
        private System.Windows.Forms.PictureBox LogoHugo;
    }
}