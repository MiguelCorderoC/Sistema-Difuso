namespace Front
{
    partial class Form1
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
            this.lblCalificacion = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblAño = new System.Windows.Forms.Label();
            this.txtCalificacion = new System.Windows.Forms.TextBox();
            this.txtGenero = new System.Windows.Forms.TextBox();
            this.txtAño = new System.Windows.Forms.TextBox();
            this.btnRecomendacion = new System.Windows.Forms.Button();
            this.btnGrafica = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblSistemaDifuso = new System.Windows.Forms.Label();
            this.lblRecomendacionPelicula = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblCalificacion
            // 
            this.lblCalificacion.AutoSize = true;
            this.lblCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCalificacion.ForeColor = System.Drawing.Color.White;
            this.lblCalificacion.Location = new System.Drawing.Point(20, 150);
            this.lblCalificacion.Name = "lblCalificacion";
            this.lblCalificacion.Size = new System.Drawing.Size(130, 26);
            this.lblCalificacion.TabIndex = 0;
            this.lblCalificacion.Text = "Calificacion:";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGenero.ForeColor = System.Drawing.Color.Snow;
            this.lblGenero.Location = new System.Drawing.Point(20, 219);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(90, 26);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "Genero:";
            // 
            // lblAño
            // 
            this.lblAño.AutoSize = true;
            this.lblAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAño.ForeColor = System.Drawing.SystemColors.Control;
            this.lblAño.Location = new System.Drawing.Point(20, 285);
            this.lblAño.Name = "lblAño";
            this.lblAño.Size = new System.Drawing.Size(57, 26);
            this.lblAño.TabIndex = 2;
            this.lblAño.Text = "Año:";
            // 
            // txtCalificacion
            // 
            this.txtCalificacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalificacion.Location = new System.Drawing.Point(155, 150);
            this.txtCalificacion.Name = "txtCalificacion";
            this.txtCalificacion.Size = new System.Drawing.Size(159, 32);
            this.txtCalificacion.TabIndex = 3;
            // 
            // txtGenero
            // 
            this.txtGenero.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGenero.Location = new System.Drawing.Point(156, 213);
            this.txtGenero.Name = "txtGenero";
            this.txtGenero.Size = new System.Drawing.Size(158, 32);
            this.txtGenero.TabIndex = 4;
            // 
            // txtAño
            // 
            this.txtAño.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAño.Location = new System.Drawing.Point(156, 279);
            this.txtAño.Name = "txtAño";
            this.txtAño.Size = new System.Drawing.Size(158, 32);
            this.txtAño.TabIndex = 5;
            // 
            // btnRecomendacion
            // 
            this.btnRecomendacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnRecomendacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecomendacion.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnRecomendacion.Location = new System.Drawing.Point(25, 380);
            this.btnRecomendacion.Name = "btnRecomendacion";
            this.btnRecomendacion.Size = new System.Drawing.Size(198, 39);
            this.btnRecomendacion.TabIndex = 6;
            this.btnRecomendacion.Text = "Recomendacion";
            this.btnRecomendacion.UseVisualStyleBackColor = false;
            // 
            // btnGrafica
            // 
            this.btnGrafica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnGrafica.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafica.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnGrafica.Location = new System.Drawing.Point(251, 380);
            this.btnGrafica.Name = "btnGrafica";
            this.btnGrafica.Size = new System.Drawing.Size(198, 39);
            this.btnGrafica.TabIndex = 7;
            this.btnGrafica.Text = "Grafica";
            this.btnGrafica.UseVisualStyleBackColor = false;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(183)))), ((int)(((byte)(42)))));
            this.btnLista.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLista.Location = new System.Drawing.Point(477, 380);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(198, 39);
            this.btnLista.TabIndex = 8;
            this.btnLista.Text = "Lista";
            this.btnLista.UseVisualStyleBackColor = false;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lblResultado.Location = new System.Drawing.Point(377, 162);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(116, 26);
            this.lblResultado.TabIndex = 9;
            this.lblResultado.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResultado.Location = new System.Drawing.Point(382, 213);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(293, 32);
            this.txtResultado.TabIndex = 10;
            // 
            // lblSistemaDifuso
            // 
            this.lblSistemaDifuso.AutoSize = true;
            this.lblSistemaDifuso.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSistemaDifuso.ForeColor = System.Drawing.Color.Snow;
            this.lblSistemaDifuso.Location = new System.Drawing.Point(289, 9);
            this.lblSistemaDifuso.Name = "lblSistemaDifuso";
            this.lblSistemaDifuso.Size = new System.Drawing.Size(160, 26);
            this.lblSistemaDifuso.TabIndex = 11;
            this.lblSistemaDifuso.Text = "Sistema Difuso";
            // 
            // lblRecomendacionPelicula
            // 
            this.lblRecomendacionPelicula.AutoSize = true;
            this.lblRecomendacionPelicula.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecomendacionPelicula.ForeColor = System.Drawing.Color.White;
            this.lblRecomendacionPelicula.Location = new System.Drawing.Point(227, 35);
            this.lblRecomendacionPelicula.Name = "lblRecomendacionPelicula";
            this.lblRecomendacionPelicula.Size = new System.Drawing.Size(291, 26);
            this.lblRecomendacionPelicula.TabIndex = 12;
            this.lblRecomendacionPelicula.Text = "Recomendacion de peliculas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(706, 488);
            this.Controls.Add(this.txtCalificacion);
            this.Controls.Add(this.lblCalificacion);
            this.Controls.Add(this.lblRecomendacionPelicula);
            this.Controls.Add(this.lblSistemaDifuso);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnGrafica);
            this.Controls.Add(this.btnRecomendacion);
            this.Controls.Add(this.txtAño);
            this.Controls.Add(this.txtGenero);
            this.Controls.Add(this.lblAño);
            this.Controls.Add(this.lblGenero);
            this.Name = "Form1";
            this.Text = "App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCalificacion;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblAño;
        private System.Windows.Forms.TextBox txtCalificacion;
        private System.Windows.Forms.TextBox txtGenero;
        private System.Windows.Forms.TextBox txtAño;
        private System.Windows.Forms.Button btnRecomendacion;
        private System.Windows.Forms.Button btnGrafica;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblSistemaDifuso;
        private System.Windows.Forms.Label lblRecomendacionPelicula;
    }
}

