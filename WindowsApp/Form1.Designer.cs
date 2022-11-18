namespace WindowsApp
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
            this.btnCrearInstancias = new System.Windows.Forms.Button();
            this.btnMostrarInstancias = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCrearInstancias
            // 
            this.btnCrearInstancias.Location = new System.Drawing.Point(132, 94);
            this.btnCrearInstancias.Name = "btnCrearInstancias";
            this.btnCrearInstancias.Size = new System.Drawing.Size(117, 40);
            this.btnCrearInstancias.TabIndex = 0;
            this.btnCrearInstancias.Text = "CrearInstancias";
            this.btnCrearInstancias.UseVisualStyleBackColor = true;
            this.btnCrearInstancias.Click += new System.EventHandler(this.btnCrearInstancias_Click);
            // 
            // btnMostrarInstancias
            // 
            this.btnMostrarInstancias.Location = new System.Drawing.Point(289, 94);
            this.btnMostrarInstancias.Name = "btnMostrarInstancias";
            this.btnMostrarInstancias.Size = new System.Drawing.Size(117, 40);
            this.btnMostrarInstancias.TabIndex = 1;
            this.btnMostrarInstancias.Text = "Mostrar Instancias";
            this.btnMostrarInstancias.UseVisualStyleBackColor = true;
            this.btnMostrarInstancias.Click += new System.EventHandler(this.btnMostrarInstancias_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(436, 94);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(117, 40);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(589, 94);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(117, 40);
            this.button4.TabIndex = 3;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(753, 94);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(117, 40);
            this.button5.TabIndex = 4;
            this.button5.Text = "button5";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 511);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnMostrarInstancias);
            this.Controls.Add(this.btnCrearInstancias);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearInstancias;
        private System.Windows.Forms.Button btnMostrarInstancias;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
    }
}

