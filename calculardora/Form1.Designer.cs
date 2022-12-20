
namespace calculardora
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
            this.text_num1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.text_num2 = new System.Windows.Forms.TextBox();
            this.btn_suma = new System.Windows.Forms.Button();
            this.btn_restar = new System.Windows.Forms.Button();
            this.btn_division = new System.Windows.Forms.Button();
            this.btn_Multiplicar = new System.Windows.Forms.Button();
            this.text_resultados = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Calculadora Basico";
            // 
            // text_num1
            // 
            this.text_num1.Location = new System.Drawing.Point(65, 43);
            this.text_num1.Name = "text_num1";
            this.text_num1.Size = new System.Drawing.Size(100, 21);
            this.text_num1.TabIndex = 1;
            this.text_num1.TextChanged += new System.EventHandler(this.text_num1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valor 1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 73);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "Valor 2";
            // 
            // text_num2
            // 
            this.text_num2.Location = new System.Drawing.Point(65, 73);
            this.text_num2.Name = "text_num2";
            this.text_num2.Size = new System.Drawing.Size(100, 21);
            this.text_num2.TabIndex = 3;
            // 
            // btn_suma
            // 
            this.btn_suma.Location = new System.Drawing.Point(12, 100);
            this.btn_suma.Name = "btn_suma";
            this.btn_suma.Size = new System.Drawing.Size(75, 23);
            this.btn_suma.TabIndex = 5;
            this.btn_suma.Text = "Sumar";
            this.btn_suma.UseVisualStyleBackColor = true;
            this.btn_suma.Click += new System.EventHandler(this.btn_suma_Click);
            // 
            // btn_restar
            // 
            this.btn_restar.Location = new System.Drawing.Point(93, 100);
            this.btn_restar.Name = "btn_restar";
            this.btn_restar.Size = new System.Drawing.Size(75, 23);
            this.btn_restar.TabIndex = 6;
            this.btn_restar.Text = "restar";
            this.btn_restar.UseVisualStyleBackColor = true;
            this.btn_restar.Click += new System.EventHandler(this.btn_restar_Click);
            // 
            // btn_division
            // 
            this.btn_division.Location = new System.Drawing.Point(93, 129);
            this.btn_division.Name = "btn_division";
            this.btn_division.Size = new System.Drawing.Size(75, 23);
            this.btn_division.TabIndex = 8;
            this.btn_division.Text = "Division";
            this.btn_division.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_division.UseVisualStyleBackColor = true;
            this.btn_division.Click += new System.EventHandler(this.btn_division_Click);
            // 
            // btn_Multiplicar
            // 
            this.btn_Multiplicar.Location = new System.Drawing.Point(12, 129);
            this.btn_Multiplicar.Name = "btn_Multiplicar";
            this.btn_Multiplicar.Size = new System.Drawing.Size(75, 23);
            this.btn_Multiplicar.TabIndex = 7;
            this.btn_Multiplicar.Text = "Multiplicar";
            this.btn_Multiplicar.UseVisualStyleBackColor = true;
            this.btn_Multiplicar.Click += new System.EventHandler(this.btn_Multiplicar_Click);
            // 
            // text_resultados
            // 
            this.text_resultados.Location = new System.Drawing.Point(48, 181);
            this.text_resultados.Name = "text_resultados";
            this.text_resultados.Size = new System.Drawing.Size(100, 21);
            this.text_resultados.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(280, 231);
            this.Controls.Add(this.text_resultados);
            this.Controls.Add(this.btn_division);
            this.Controls.Add(this.btn_Multiplicar);
            this.Controls.Add(this.btn_restar);
            this.Controls.Add(this.btn_suma);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.text_num2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.text_num1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Calculadora Basico";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox text_num1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox text_num2;
        private System.Windows.Forms.Button btn_suma;
        private System.Windows.Forms.Button btn_restar;
        private System.Windows.Forms.Button btn_division;
        private System.Windows.Forms.Button btn_Multiplicar;
        private System.Windows.Forms.TextBox text_resultados;
    }
}

