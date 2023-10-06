namespace EcuacionesLneales
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textFun1 = new System.Windows.Forms.TextBox();
            this.textFun2 = new System.Windows.Forms.TextBox();
            this.Resolver = new System.Windows.Forms.Button();
            this.Nuevo = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textfin3 = new System.Windows.Forms.TextBox();
            this.OPCIONES = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textfin2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(339, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(383, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "SISTEMA DE ECUACIONES 2X2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(208, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ingrese la primera ecuación ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 296);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(217, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ingrese la segunda ecuación ";
            // 
            // textFun1
            // 
            this.textFun1.Location = new System.Drawing.Point(14, 223);
            this.textFun1.Name = "textFun1";
            this.textFun1.Size = new System.Drawing.Size(206, 26);
            this.textFun1.TabIndex = 3;
            // 
            // textFun2
            // 
            this.textFun2.Location = new System.Drawing.Point(14, 345);
            this.textFun2.Name = "textFun2";
            this.textFun2.Size = new System.Drawing.Size(206, 26);
            this.textFun2.TabIndex = 4;
            // 
            // Resolver
            // 
            this.Resolver.Location = new System.Drawing.Point(16, 527);
            this.Resolver.Name = "Resolver";
            this.Resolver.Size = new System.Drawing.Size(130, 34);
            this.Resolver.TabIndex = 5;
            this.Resolver.Text = "Resolver";
            this.Resolver.UseVisualStyleBackColor = true;
            this.Resolver.Click += new System.EventHandler(this.Resolver_Click);
            // 
            // Nuevo
            // 
            this.Nuevo.Location = new System.Drawing.Point(163, 528);
            this.Nuevo.Name = "Nuevo";
            this.Nuevo.Size = new System.Drawing.Size(130, 33);
            this.Nuevo.TabIndex = 6;
            this.Nuevo.Text = "Nuevo";
            this.Nuevo.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(422, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(273, 23);
            this.label6.TabIndex = 12;
            this.label6.Text = "¿Perpendicular o paralela?";
            // 
            // textfin3
            // 
            this.textfin3.Enabled = false;
            this.textfin3.Location = new System.Drawing.Point(426, 290);
            this.textfin3.Name = "textfin3";
            this.textfin3.Size = new System.Drawing.Size(269, 26);
            this.textfin3.TabIndex = 13;
            // 
            // OPCIONES
            // 
            this.OPCIONES.FormattingEnabled = true;
            this.OPCIONES.Items.AddRange(new object[] {
            "y=mx+b",
            "y-y1=m(x-x1)"});
            this.OPCIONES.Location = new System.Drawing.Point(12, 114);
            this.OPCIONES.Name = "OPCIONES";
            this.OPCIONES.Size = new System.Drawing.Size(321, 28);
            this.OPCIONES.TabIndex = 14;
            this.OPCIONES.Text = "Elija la opción de la forma de la ecuación";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(740, 226);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 23);
            this.label4.TabIndex = 16;
            this.label4.Text = "punto de intersección";
            // 
            // textfin2
            // 
            this.textfin2.Enabled = false;
            this.textfin2.Location = new System.Drawing.Point(744, 290);
            this.textfin2.Name = "textfin2";
            this.textfin2.Size = new System.Drawing.Size(269, 26);
            this.textfin2.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 587);
            this.Controls.Add(this.textfin2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.OPCIONES);
            this.Controls.Add(this.textfin3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Nuevo);
            this.Controls.Add(this.Resolver);
            this.Controls.Add(this.textFun2);
            this.Controls.Add(this.textFun1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textFun1;
        private System.Windows.Forms.TextBox textFun2;
        private System.Windows.Forms.Button Resolver;
        private System.Windows.Forms.Button Nuevo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textfin3;
        private System.Windows.Forms.ComboBox OPCIONES;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textfin2;
    }
}

