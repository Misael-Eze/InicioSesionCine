namespace InicioSesion
{
    partial class MenuPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.lklInicioSesion = new System.Windows.Forms.LinkLabel();
            this.lblInicioSesion = new System.Windows.Forms.Label();
            this.lblSubTitulo = new System.Windows.Forms.Label();
            this.btnEntrarALaApp = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Vineta BT", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.lblBienvenida.Location = new System.Drawing.Point(103, 9);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(215, 32);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Cineapolis";
            // 
            // lklInicioSesion
            // 
            this.lklInicioSesion.AutoSize = true;
            this.lklInicioSesion.Font = new System.Drawing.Font("Constantia", 11F, System.Drawing.FontStyle.Italic);
            this.lklInicioSesion.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lklInicioSesion.Location = new System.Drawing.Point(244, 168);
            this.lklInicioSesion.Name = "lklInicioSesion";
            this.lklInicioSesion.Size = new System.Drawing.Size(95, 18);
            this.lklInicioSesion.TabIndex = 1;
            this.lklInicioSesion.TabStop = true;
            this.lklInicioSesion.Text = "Iniciar Sesión";
            this.lklInicioSesion.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lklInicioSesion_LinkClicked);
            // 
            // lblInicioSesion
            // 
            this.lblInicioSesion.AutoSize = true;
            this.lblInicioSesion.Font = new System.Drawing.Font("Constantia", 12F);
            this.lblInicioSesion.Location = new System.Drawing.Point(72, 167);
            this.lblInicioSesion.Name = "lblInicioSesion";
            this.lblInicioSesion.Size = new System.Drawing.Size(166, 19);
            this.lblInicioSesion.TabIndex = 2;
            this.lblInicioSesion.Text = "¿Ya tienes una cuenta?";
            // 
            // lblSubTitulo
            // 
            this.lblSubTitulo.AutoSize = true;
            this.lblSubTitulo.Location = new System.Drawing.Point(57, 41);
            this.lblSubTitulo.Name = "lblSubTitulo";
            this.lblSubTitulo.Size = new System.Drawing.Size(303, 13);
            this.lblSubTitulo.TabIndex = 3;
            this.lblSubTitulo.Text = "\"Donde las historias cobran vida y los corazones se conectan\"";
            // 
            // btnEntrarALaApp
            // 
            this.btnEntrarALaApp.BackColor = System.Drawing.Color.Transparent;
            this.btnEntrarALaApp.Font = new System.Drawing.Font("Constantia", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEntrarALaApp.Location = new System.Drawing.Point(163, 88);
            this.btnEntrarALaApp.Name = "btnEntrarALaApp";
            this.btnEntrarALaApp.Size = new System.Drawing.Size(75, 27);
            this.btnEntrarALaApp.TabIndex = 4;
            this.btnEntrarALaApp.Text = "Ingresar";
            this.btnEntrarALaApp.UseVisualStyleBackColor = false;
            this.btnEntrarALaApp.Click += new System.EventHandler(this.btnEntrarALaApp_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.ClientSize = new System.Drawing.Size(408, 246);
            this.Controls.Add(this.btnEntrarALaApp);
            this.Controls.Add(this.lblSubTitulo);
            this.Controls.Add(this.lblInicioSesion);
            this.Controls.Add(this.lklInicioSesion);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "MenuPrincipal";
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.LinkLabel lklInicioSesion;
        private System.Windows.Forms.Label lblInicioSesion;
        private System.Windows.Forms.Label lblSubTitulo;
        private System.Windows.Forms.Button btnEntrarALaApp;
    }
}

