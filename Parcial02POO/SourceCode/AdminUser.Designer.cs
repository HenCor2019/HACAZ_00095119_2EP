using System.ComponentModel;

namespace Parcial02
{
    partial class AdminUser
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btCerrarSesion = new System.Windows.Forms.Button();
            this.labeUsuario = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.84856F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.15143F));
            this.tableLayoutPanel1.Controls.Add(this.btCerrarSesion, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.labeUsuario, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.96859F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 84.03141F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(832, 562);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btCerrarSesion
            // 
            this.btCerrarSesion.Anchor =
                ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top |
                                                       System.Windows.Forms.AnchorStyles.Right)));
            this.btCerrarSesion.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btCerrarSesion.Font = new System.Drawing.Font("Showcard Gothic", 6F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btCerrarSesion.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btCerrarSesion.Location = new System.Drawing.Point(705, 3);
            this.btCerrarSesion.Name = "btCerrarSesion";
            this.btCerrarSesion.Size = new System.Drawing.Size(124, 26);
            this.btCerrarSesion.TabIndex = 0;
            this.btCerrarSesion.Text = "[cerrar sesion]";
            this.btCerrarSesion.UseVisualStyleBackColor = true;
            this.btCerrarSesion.Click += new System.EventHandler(this.btCerrarSesion_Click);
            // 
            // labeUsuario
            // 
            this.labeUsuario.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labeUsuario.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular,
                System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labeUsuario.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))), ((int) (((byte) (64)))),
                ((int) (((byte) (64)))));
            this.labeUsuario.Location = new System.Drawing.Point(3, 0);
            this.labeUsuario.Name = "labeUsuario";
            this.labeUsuario.Size = new System.Drawing.Size(550, 89);
            this.labeUsuario.TabIndex = 1;
            this.labeUsuario.Text = "label1";
            this.labeUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AdminUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(832, 562);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AdminUser";
            this.Text = "AdminUser";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AdminUser_FormClosed);
            this.Load += new System.EventHandler(this.AdminUser_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button btCerrarSesion;
        private System.Windows.Forms.Label labeUsuario;
    }
}