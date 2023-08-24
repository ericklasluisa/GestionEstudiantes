namespace Proyecto
{
    partial class FormVerEstudiantes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewEstudiantes = new System.Windows.Forms.ListView();
            this.btnOrdenarPorApellido = new System.Windows.Forms.Button();
            this.btnOrdenarPorPromedio = new System.Windows.Forms.Button();
            this.btnVerEstudiantes = new System.Windows.Forms.Button();
            this.btnCalcularPromedios = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.listViewEstudiantes);
            this.panel1.Controls.Add(this.btnOrdenarPorApellido);
            this.panel1.Controls.Add(this.btnOrdenarPorPromedio);
            this.panel1.Controls.Add(this.btnVerEstudiantes);
            this.panel1.Controls.Add(this.btnCalcularPromedios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 460);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.label1.Location = new System.Drawing.Point(101, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(525, 44);
            this.label1.TabIndex = 5;
            this.label1.Text = "Visualización de estudiantes";
            // 
            // listViewEstudiantes
            // 
            this.listViewEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.listViewEstudiantes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewEstudiantes.ForeColor = System.Drawing.Color.White;
            this.listViewEstudiantes.HideSelection = false;
            this.listViewEstudiantes.Location = new System.Drawing.Point(12, 92);
            this.listViewEstudiantes.Name = "listViewEstudiantes";
            this.listViewEstudiantes.Size = new System.Drawing.Size(726, 272);
            this.listViewEstudiantes.TabIndex = 4;
            this.listViewEstudiantes.UseCompatibleStateImageBehavior = false;
            this.listViewEstudiantes.SelectedIndexChanged += new System.EventHandler(this.listViewEstudiantes_SelectedIndexChanged);
            this.listViewEstudiantes.Click += new System.EventHandler(this.listViewEstudiantes_Click);
            // 
            // btnOrdenarPorApellido
            // 
            this.btnOrdenarPorApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnOrdenarPorApellido.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnOrdenarPorApellido.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorApellido.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPorApellido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.btnOrdenarPorApellido.Location = new System.Drawing.Point(549, 379);
            this.btnOrdenarPorApellido.Name = "btnOrdenarPorApellido";
            this.btnOrdenarPorApellido.Size = new System.Drawing.Size(153, 65);
            this.btnOrdenarPorApellido.TabIndex = 3;
            this.btnOrdenarPorApellido.Text = "Ordenar por apellido";
            this.btnOrdenarPorApellido.UseVisualStyleBackColor = false;
            this.btnOrdenarPorApellido.Click += new System.EventHandler(this.btnOrdenarPorApellido_Click);
            // 
            // btnOrdenarPorPromedio
            // 
            this.btnOrdenarPorPromedio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnOrdenarPorPromedio.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnOrdenarPorPromedio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOrdenarPorPromedio.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOrdenarPorPromedio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.btnOrdenarPorPromedio.Location = new System.Drawing.Point(370, 379);
            this.btnOrdenarPorPromedio.Name = "btnOrdenarPorPromedio";
            this.btnOrdenarPorPromedio.Size = new System.Drawing.Size(162, 65);
            this.btnOrdenarPorPromedio.TabIndex = 3;
            this.btnOrdenarPorPromedio.Text = "Ordenar por promedio";
            this.btnOrdenarPorPromedio.UseVisualStyleBackColor = false;
            this.btnOrdenarPorPromedio.Click += new System.EventHandler(this.btnOrdenarPorPromedio_Click);
            // 
            // btnVerEstudiantes
            // 
            this.btnVerEstudiantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnVerEstudiantes.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnVerEstudiantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerEstudiantes.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstudiantes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.btnVerEstudiantes.Location = new System.Drawing.Point(164, 391);
            this.btnVerEstudiantes.Name = "btnVerEstudiantes";
            this.btnVerEstudiantes.Size = new System.Drawing.Size(186, 41);
            this.btnVerEstudiantes.TabIndex = 2;
            this.btnVerEstudiantes.Text = "Ver estudiantes";
            this.btnVerEstudiantes.UseVisualStyleBackColor = false;
            this.btnVerEstudiantes.Click += new System.EventHandler(this.btnVerEstudiantes_Click);
            // 
            // btnCalcularPromedios
            // 
            this.btnCalcularPromedios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(30)))), ((int)(((byte)(54)))));
            this.btnCalcularPromedios.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnCalcularPromedios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularPromedios.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcularPromedios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(226)))), ((int)(((byte)(178)))));
            this.btnCalcularPromedios.Location = new System.Drawing.Point(30, 379);
            this.btnCalcularPromedios.Name = "btnCalcularPromedios";
            this.btnCalcularPromedios.Size = new System.Drawing.Size(118, 66);
            this.btnCalcularPromedios.TabIndex = 1;
            this.btnCalcularPromedios.Text = "Calcular promedios";
            this.btnCalcularPromedios.UseVisualStyleBackColor = false;
            this.btnCalcularPromedios.Click += new System.EventHandler(this.btnCalcularPromedios_Click);
            // 
            // FormVerEstudiantes
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(750, 460);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormVerEstudiantes";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnVerEstudiantes;
        private System.Windows.Forms.Button btnCalcularPromedios;
        private System.Windows.Forms.Button btnOrdenarPorPromedio;
        private System.Windows.Forms.Button btnOrdenarPorApellido;
        private System.Windows.Forms.ListView listViewEstudiantes;
        private System.Windows.Forms.Label label1;
    }
}

