namespace Proyecto
{
    partial class FormInicio
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
            this.components = new System.ComponentModel.Container();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureLogo = new System.Windows.Forms.PictureBox();
            this.labelHora = new System.Windows.Forms.Label();
            this.panelFechaHora = new System.Windows.Forms.Panel();
            this.labelFecha = new System.Windows.Forms.Label();
            this.timerFechaHora = new System.Windows.Forms.Timer(this.components);
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).BeginInit();
            this.panelFechaHora.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureLogo);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(750, 340);
            this.panelLogo.TabIndex = 2;
            // 
            // pictureLogo
            // 
            this.pictureLogo.BackgroundImage = global::Proyecto.Properties.Resources.logoDefinitivo;
            this.pictureLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureLogo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureLogo.Location = new System.Drawing.Point(0, 41);
            this.pictureLogo.Name = "pictureLogo";
            this.pictureLogo.Size = new System.Drawing.Size(750, 299);
            this.pictureLogo.TabIndex = 1;
            this.pictureLogo.TabStop = false;
            this.pictureLogo.Click += new System.EventHandler(this.pictureLogo_Click);
            // 
            // labelHora
            // 
            this.labelHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.labelHora.Font = new System.Drawing.Font("Century Gothic", 32F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(126)))), ((int)(((byte)(249)))));
            this.labelHora.Location = new System.Drawing.Point(0, 73);
            this.labelHora.Name = "labelHora";
            this.labelHora.Size = new System.Drawing.Size(750, 82);
            this.labelHora.TabIndex = 3;
            this.labelHora.Text = "00:00:00";
            this.labelHora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelFechaHora
            // 
            this.panelFechaHora.Controls.Add(this.labelFecha);
            this.panelFechaHora.Controls.Add(this.labelHora);
            this.panelFechaHora.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelFechaHora.Location = new System.Drawing.Point(0, 305);
            this.panelFechaHora.Name = "panelFechaHora";
            this.panelFechaHora.Size = new System.Drawing.Size(750, 155);
            this.panelFechaHora.TabIndex = 3;
            // 
            // labelFecha
            // 
            this.labelFecha.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelFecha.Font = new System.Drawing.Font("Century Gothic", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.labelFecha.Location = new System.Drawing.Point(0, 0);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(750, 73);
            this.labelFecha.TabIndex = 4;
            this.labelFecha.Text = ".";
            this.labelFecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerFechaHora
            // 
            this.timerFechaHora.Enabled = true;
            this.timerFechaHora.Tick += new System.EventHandler(this.timerFechaHora_Tick);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(750, 460);
            this.Controls.Add(this.panelFechaHora);
            this.Controls.Add(this.panelLogo);
            this.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormInicio";
            this.Text = "Form2";
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureLogo)).EndInit();
            this.panelFechaHora.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label labelHora;
        private System.Windows.Forms.Panel panelFechaHora;
        private System.Windows.Forms.Label labelFecha;
        private System.Windows.Forms.Timer timerFechaHora;
        private System.Windows.Forms.PictureBox pictureLogo;
    }
}