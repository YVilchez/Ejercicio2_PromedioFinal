
namespace Promedio_Final
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
            this.bt_Promedio = new System.Windows.Forms.Button();
            this.tb_Nota4 = new System.Windows.Forms.TextBox();
            this.tb_Nota3 = new System.Windows.Forms.TextBox();
            this.tb_Nota2 = new System.Windows.Forms.TextBox();
            this.tb_Nota1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_Promedio
            // 
            this.bt_Promedio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Promedio.Location = new System.Drawing.Point(322, 376);
            this.bt_Promedio.Name = "bt_Promedio";
            this.bt_Promedio.Size = new System.Drawing.Size(149, 23);
            this.bt_Promedio.TabIndex = 21;
            this.bt_Promedio.Text = "Calcular Promedio";
            this.bt_Promedio.UseVisualStyleBackColor = true;
            this.bt_Promedio.Click += new System.EventHandler(this.bt_Promedio_Click);
            // 
            // tb_Nota4
            // 
            this.tb_Nota4.Location = new System.Drawing.Point(426, 326);
            this.tb_Nota4.Name = "tb_Nota4";
            this.tb_Nota4.Size = new System.Drawing.Size(45, 20);
            this.tb_Nota4.TabIndex = 20;
            // 
            // tb_Nota3
            // 
            this.tb_Nota3.Location = new System.Drawing.Point(426, 274);
            this.tb_Nota3.Name = "tb_Nota3";
            this.tb_Nota3.Size = new System.Drawing.Size(45, 20);
            this.tb_Nota3.TabIndex = 19;
            // 
            // tb_Nota2
            // 
            this.tb_Nota2.Location = new System.Drawing.Point(426, 222);
            this.tb_Nota2.Name = "tb_Nota2";
            this.tb_Nota2.Size = new System.Drawing.Size(45, 20);
            this.tb_Nota2.TabIndex = 18;
            // 
            // tb_Nota1
            // 
            this.tb_Nota1.Location = new System.Drawing.Point(426, 172);
            this.tb_Nota1.Name = "tb_Nota1";
            this.tb_Nota1.Size = new System.Drawing.Size(45, 20);
            this.tb_Nota1.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(311, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "4 Parcial=";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(311, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "3 Parcial=";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(311, 225);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "2 Parcial= ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(311, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "1 Parcial=";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(218, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(365, 25);
            this.label2.TabIndex = 12;
            this.label2.Text = "Ingrese calificaciones de los 4 parciales: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(277, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(223, 42);
            this.label1.TabIndex = 11;
            this.label1.Text = "NOTA FINAL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bt_Promedio);
            this.Controls.Add(this.tb_Nota4);
            this.Controls.Add(this.tb_Nota3);
            this.Controls.Add(this.tb_Nota2);
            this.Controls.Add(this.tb_Nota1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_Promedio;
        private System.Windows.Forms.TextBox tb_Nota4;
        private System.Windows.Forms.TextBox tb_Nota3;
        private System.Windows.Forms.TextBox tb_Nota2;
        private System.Windows.Forms.TextBox tb_Nota1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

