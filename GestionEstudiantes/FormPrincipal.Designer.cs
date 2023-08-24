namespace Proyecto
{
    partial class FormPrincipal
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.panelLateral = new System.Windows.Forms.Panel();
            this.buttonMenuOpciones = new System.Windows.Forms.Button();
            this.panelBarraLateral = new System.Windows.Forms.Panel();
            this.buttonSalir = new System.Windows.Forms.Button();
            this.buttonVentanaBuscar = new System.Windows.Forms.Button();
            this.buttonVentanaPresentar = new System.Windows.Forms.Button();
            this.buttonVentanaIngresar = new System.Windows.Forms.Button();
            this.labelOpciones = new System.Windows.Forms.Label();
            this.panelVentanas = new System.Windows.Forms.Panel();
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.buttonInicio = new System.Windows.Forms.Button();
            this.buttonCerrar = new System.Windows.Forms.Button();
            this.panelPrincipal.SuspendLayout();
            this.panelLateral.SuspendLayout();
            this.panelBarraLateral.SuspendLayout();
            this.panelBarraSuperior.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelPrincipal.Controls.Add(this.panelLateral);
            this.panelPrincipal.Controls.Add(this.panelVentanas);
            this.panelPrincipal.Controls.Add(this.panelBarraSuperior);
            this.panelPrincipal.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelPrincipal.Location = new System.Drawing.Point(0, 0);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(1000, 500);
            this.panelPrincipal.TabIndex = 0;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelLateral.Controls.Add(this.buttonMenuOpciones);
            this.panelLateral.Controls.Add(this.panelBarraLateral);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 40);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(250, 460);
            this.panelLateral.TabIndex = 6;
            // 
            // buttonMenuOpciones
            // 
            this.buttonMenuOpciones.BackgroundImage = global::Proyecto.Properties.Resources.menu;
            this.buttonMenuOpciones.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonMenuOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonMenuOpciones.FlatAppearance.BorderSize = 0;
            this.buttonMenuOpciones.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMenuOpciones.Location = new System.Drawing.Point(189, 0);
            this.buttonMenuOpciones.Name = "buttonMenuOpciones";
            this.buttonMenuOpciones.Size = new System.Drawing.Size(61, 50);
            this.buttonMenuOpciones.TabIndex = 1;
            this.buttonMenuOpciones.UseVisualStyleBackColor = true;
            this.buttonMenuOpciones.Click += new System.EventHandler(this.buttonMenuOpciones_Click);
            // 
            // panelBarraLateral
            // 
            this.panelBarraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBarraLateral.Controls.Add(this.buttonSalir);
            this.panelBarraLateral.Controls.Add(this.buttonVentanaBuscar);
            this.panelBarraLateral.Controls.Add(this.buttonVentanaPresentar);
            this.panelBarraLateral.Controls.Add(this.buttonVentanaIngresar);
            this.panelBarraLateral.Controls.Add(this.labelOpciones);
            this.panelBarraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelBarraLateral.Location = new System.Drawing.Point(0, 0);
            this.panelBarraLateral.Name = "panelBarraLateral";
            this.panelBarraLateral.Size = new System.Drawing.Size(189, 460);
            this.panelBarraLateral.TabIndex = 1;
            // 
            // buttonSalir
            // 
            this.buttonSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonSalir.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSalir.FlatAppearance.BorderSize = 0;
            this.buttonSalir.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSalir.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSalir.ForeColor = System.Drawing.Color.White;
            this.buttonSalir.Location = new System.Drawing.Point(0, 373);
            this.buttonSalir.Name = "buttonSalir";
            this.buttonSalir.Size = new System.Drawing.Size(189, 84);
            this.buttonSalir.TabIndex = 5;
            this.buttonSalir.Text = "SALIR";
            this.buttonSalir.UseVisualStyleBackColor = false;
            this.buttonSalir.Click += new System.EventHandler(this.buttonSalir_Click);
            // 
            // buttonVentanaBuscar
            // 
            this.buttonVentanaBuscar.AutoSize = true;
            this.buttonVentanaBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonVentanaBuscar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentanaBuscar.FlatAppearance.BorderSize = 0;
            this.buttonVentanaBuscar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonVentanaBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonVentanaBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentanaBuscar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentanaBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonVentanaBuscar.Location = new System.Drawing.Point(0, 283);
            this.buttonVentanaBuscar.Name = "buttonVentanaBuscar";
            this.buttonVentanaBuscar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonVentanaBuscar.Size = new System.Drawing.Size(189, 90);
            this.buttonVentanaBuscar.TabIndex = 4;
            this.buttonVentanaBuscar.Text = "Buscar un Alumno";
            this.buttonVentanaBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentanaBuscar.UseVisualStyleBackColor = false;
            this.buttonVentanaBuscar.Click += new System.EventHandler(this.buttonVentanaBuscar_Click);
            // 
            // buttonVentanaPresentar
            // 
            this.buttonVentanaPresentar.AutoSize = true;
            this.buttonVentanaPresentar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.buttonVentanaPresentar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentanaPresentar.FlatAppearance.BorderSize = 0;
            this.buttonVentanaPresentar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonVentanaPresentar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonVentanaPresentar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentanaPresentar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentanaPresentar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonVentanaPresentar.Location = new System.Drawing.Point(0, 193);
            this.buttonVentanaPresentar.Name = "buttonVentanaPresentar";
            this.buttonVentanaPresentar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonVentanaPresentar.Size = new System.Drawing.Size(189, 90);
            this.buttonVentanaPresentar.TabIndex = 3;
            this.buttonVentanaPresentar.Text = "Presentar Alumnos";
            this.buttonVentanaPresentar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentanaPresentar.UseVisualStyleBackColor = false;
            this.buttonVentanaPresentar.Click += new System.EventHandler(this.buttonVentanaPresentar_Click);
            // 
            // buttonVentanaIngresar
            // 
            this.buttonVentanaIngresar.AutoSize = true;
            this.buttonVentanaIngresar.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonVentanaIngresar.FlatAppearance.BorderSize = 0;
            this.buttonVentanaIngresar.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonVentanaIngresar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.buttonVentanaIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVentanaIngresar.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonVentanaIngresar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.buttonVentanaIngresar.Location = new System.Drawing.Point(0, 103);
            this.buttonVentanaIngresar.Name = "buttonVentanaIngresar";
            this.buttonVentanaIngresar.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonVentanaIngresar.Size = new System.Drawing.Size(189, 90);
            this.buttonVentanaIngresar.TabIndex = 2;
            this.buttonVentanaIngresar.Text = "Ingresar o Actualizar Alumno";
            this.buttonVentanaIngresar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonVentanaIngresar.UseVisualStyleBackColor = false;
            this.buttonVentanaIngresar.Click += new System.EventHandler(this.buttonVentanaIngresar_Click);
            // 
            // labelOpciones
            // 
            this.labelOpciones.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.labelOpciones.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelOpciones.Font = new System.Drawing.Font("Century Gothic", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelOpciones.ForeColor = System.Drawing.Color.White;
            this.labelOpciones.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelOpciones.Location = new System.Drawing.Point(0, 0);
            this.labelOpciones.Name = "labelOpciones";
            this.labelOpciones.Size = new System.Drawing.Size(189, 103);
            this.labelOpciones.TabIndex = 0;
            this.labelOpciones.Text = "PANEL DE OPCIONES";
            this.labelOpciones.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelVentanas
            // 
            this.panelVentanas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panelVentanas.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelVentanas.Location = new System.Drawing.Point(250, 40);
            this.panelVentanas.Name = "panelVentanas";
            this.panelVentanas.Size = new System.Drawing.Size(750, 460);
            this.panelVentanas.TabIndex = 2;
            this.panelVentanas.Paint += new System.Windows.Forms.PaintEventHandler(this.panelVentanas_Paint);
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.panelBarraSuperior.Controls.Add(this.buttonInicio);
            this.panelBarraSuperior.Controls.Add(this.buttonCerrar);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(1000, 40);
            this.panelBarraSuperior.TabIndex = 0;
            // 
            // buttonInicio
            // 
            this.buttonInicio.BackgroundImage = global::Proyecto.Properties.Resources.img_inicio;
            this.buttonInicio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonInicio.FlatAppearance.BorderSize = 0;
            this.buttonInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInicio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonInicio.Location = new System.Drawing.Point(10, 5);
            this.buttonInicio.Name = "buttonInicio";
            this.buttonInicio.Size = new System.Drawing.Size(35, 30);
            this.buttonInicio.TabIndex = 0;
            this.buttonInicio.UseVisualStyleBackColor = true;
            this.buttonInicio.Click += new System.EventHandler(this.buttonInicio_Click);
            // 
            // buttonCerrar
            // 
            this.buttonCerrar.BackgroundImage = global::Proyecto.Properties.Resources.CerrarBlanco;
            this.buttonCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonCerrar.FlatAppearance.BorderSize = 0;
            this.buttonCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCerrar.Location = new System.Drawing.Point(953, 4);
            this.buttonCerrar.Name = "buttonCerrar";
            this.buttonCerrar.Size = new System.Drawing.Size(35, 30);
            this.buttonCerrar.TabIndex = 2;
            this.buttonCerrar.UseVisualStyleBackColor = true;
            this.buttonCerrar.Click += new System.EventHandler(this.buttonCerrar_Click);
            // 
            // FormPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1000, 500);
            this.Controls.Add(this.panelPrincipal);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Estudiantes";
            this.panelPrincipal.ResumeLayout(false);
            this.panelLateral.ResumeLayout(false);
            this.panelBarraLateral.ResumeLayout(false);
            this.panelBarraLateral.PerformLayout();
            this.panelBarraSuperior.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Panel panelBarraLateral;
        private System.Windows.Forms.Label labelOpciones;
        private System.Windows.Forms.Button buttonVentanaIngresar;
        private System.Windows.Forms.Button buttonVentanaPresentar;
        private System.Windows.Forms.Button buttonSalir;
        private System.Windows.Forms.Button buttonVentanaBuscar;
        private System.Windows.Forms.Panel panelVentanas;
        private System.Windows.Forms.Button buttonCerrar;
        private System.Windows.Forms.Button buttonMenuOpciones;
        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button buttonInicio;
    }
}

