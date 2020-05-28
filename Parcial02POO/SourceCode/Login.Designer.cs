using System.ComponentModel;

namespace Parcial02
{
    partial class Login
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnRegresaSign = new System.Windows.Forms.Button();
            this.btnNuevaContra = new System.Windows.Forms.Button();
            this.labelUsuarioNew = new System.Windows.Forms.Label();
            this.labelNuevaContra = new System.Windows.Forms.Label();
            this.txtNuevaContra = new System.Windows.Forms.TextBox();
            this.cbUsuarioNew = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (128)))),
                ((int) (((byte) (255)))), ((int) (((byte) (255)))));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(
                new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.btnRegresaSign, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.btnNuevaContra, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.labelUsuarioNew, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.labelNuevaContra, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtNuevaContra, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.cbUsuarioNew, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.26203F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.73797F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 48F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.RowStyles.Add(
                new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(650, 430);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnRegresaSign
            // 
            this.btnRegresaSign.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegresaSign.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRegresaSign.Font = new System.Drawing.Font("Showcard Gothic", 14.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnRegresaSign.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnRegresaSign.Location = new System.Drawing.Point(3, 386);
            this.btnRegresaSign.Name = "btnRegresaSign";
            this.btnRegresaSign.Size = new System.Drawing.Size(319, 41);
            this.btnRegresaSign.TabIndex = 0;
            this.btnRegresaSign.Text = "Regresar";
            this.btnRegresaSign.UseVisualStyleBackColor = true;
            this.btnRegresaSign.Click += new System.EventHandler(this.btnRegresaSign_Click);
            // 
            // btnNuevaContra
            // 
            this.btnNuevaContra.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnNuevaContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnNuevaContra.Font = new System.Drawing.Font("Showcard Gothic", 14.25F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnNuevaContra.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.btnNuevaContra.Location = new System.Drawing.Point(328, 386);
            this.btnNuevaContra.Name = "btnNuevaContra";
            this.btnNuevaContra.Size = new System.Drawing.Size(319, 41);
            this.btnNuevaContra.TabIndex = 1;
            this.btnNuevaContra.Text = "Actualizar";
            this.btnNuevaContra.UseVisualStyleBackColor = true;
            this.btnNuevaContra.Click += new System.EventHandler(this.btnNuevaContra_Click);
            // 
            // labelUsuarioNew
            // 
            this.labelUsuarioNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelUsuarioNew.Font = new System.Drawing.Font("Showcard Gothic", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelUsuarioNew.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.labelUsuarioNew.Location = new System.Drawing.Point(3, 176);
            this.labelUsuarioNew.Name = "labelUsuarioNew";
            this.labelUsuarioNew.Size = new System.Drawing.Size(319, 64);
            this.labelUsuarioNew.TabIndex = 2;
            this.labelUsuarioNew.Text = "Usuario";
            this.labelUsuarioNew.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelNuevaContra
            // 
            this.labelNuevaContra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelNuevaContra.Font = new System.Drawing.Font("Showcard Gothic", 15.75F,
                System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.labelNuevaContra.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (64)))),
                ((int) (((byte) (64)))), ((int) (((byte) (64)))));
            this.labelNuevaContra.Location = new System.Drawing.Point(3, 240);
            this.labelNuevaContra.Name = "labelNuevaContra";
            this.labelNuevaContra.Size = new System.Drawing.Size(319, 48);
            this.labelNuevaContra.TabIndex = 3;
            this.labelNuevaContra.Text = "Nueva contraseña";
            this.labelNuevaContra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtNuevaContra
            // 
            this.txtNuevaContra.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txtNuevaContra.Location = new System.Drawing.Point(346, 252);
            this.txtNuevaContra.Name = "txtNuevaContra";
            this.txtNuevaContra.Size = new System.Drawing.Size(282, 23);
            this.txtNuevaContra.TabIndex = 4;
            // 
            // cbUsuarioNew
            // 
            this.cbUsuarioNew.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbUsuarioNew.FormattingEnabled = true;
            this.cbUsuarioNew.Location = new System.Drawing.Point(346, 179);
            this.cbUsuarioNew.Name = "cbUsuarioNew";
            this.cbUsuarioNew.Size = new System.Drawing.Size(282, 23);
            this.cbUsuarioNew.TabIndex = 5;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(650, 430);
            this.Load += new System.EventHandler(this.Login_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labelNuevaContra;
        private System.Windows.Forms.Label labelUsuarioNew;
        private System.Windows.Forms.ComboBox cbUsuarioNew;
        private System.Windows.Forms.TextBox txtNuevaContra;
        private System.Windows.Forms.Button btnRegresaSign;
        private System.Windows.Forms.Button btnNuevaContra;
    }
}