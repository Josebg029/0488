namespace Calc
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            num1 = new TextBox();
            num2 = new TextBox();
            res = new TextBox();
            suma = new Button();
            resta = new Button();
            multi = new Button();
            division = new Button();
            raiz = new Button();
            poten = new Button();
            limpiar = new Button();
            label2 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(273, 95);
            label1.Name = "label1";
            label1.Size = new Size(128, 15);
            label1.TabIndex = 0;
            label1.Text = "Calculadora Aritmetica";
            // 
            // num1
            // 
            num1.Location = new Point(149, 152);
            num1.Name = "num1";
            num1.Size = new Size(100, 23);
            num1.TabIndex = 1;
            // 
            // num2
            // 
            num2.Location = new Point(149, 226);
            num2.Name = "num2";
            num2.Size = new Size(100, 23);
            num2.TabIndex = 2;
            // 
            // res
            // 
            res.Location = new Point(149, 329);
            res.Name = "res";
            res.Size = new Size(100, 23);
            res.TabIndex = 3;
            // 
            // suma
            // 
            suma.Location = new Point(366, 152);
            suma.Name = "suma";
            suma.Size = new Size(75, 23);
            suma.TabIndex = 4;
            suma.Text = "+";
            suma.UseVisualStyleBackColor = true;
            suma.Click += suma_Click;
            // 
            // resta
            // 
            resta.Location = new Point(486, 152);
            resta.Name = "resta";
            resta.Size = new Size(75, 23);
            resta.TabIndex = 5;
            resta.Text = "-";
            resta.UseVisualStyleBackColor = true;
            resta.Click += resta_Click;
            // 
            // multi
            // 
            multi.Location = new Point(366, 225);
            multi.Name = "multi";
            multi.Size = new Size(75, 23);
            multi.TabIndex = 6;
            multi.Text = "*";
            multi.UseVisualStyleBackColor = true;
            multi.Click += multi_Click;
            // 
            // division
            // 
            division.Location = new Point(486, 225);
            division.Name = "division";
            division.Size = new Size(75, 23);
            division.TabIndex = 7;
            division.Text = "/";
            division.UseVisualStyleBackColor = true;
            division.Click += division_Click;
            // 
            // raiz
            // 
            raiz.Location = new Point(366, 292);
            raiz.Name = "raiz";
            raiz.Size = new Size(75, 23);
            raiz.TabIndex = 8;
            raiz.Text = "Raiz";
            raiz.UseVisualStyleBackColor = true;
            raiz.Click += raiz_Click;
            // 
            // poten
            // 
            poten.Location = new Point(486, 292);
            poten.Name = "poten";
            poten.Size = new Size(75, 23);
            poten.TabIndex = 9;
            poten.Text = "Potencia";
            poten.UseVisualStyleBackColor = true;
            poten.Click += poten_Click;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(426, 390);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(75, 23);
            limpiar.TabIndex = 10;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(166, 279);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 11;
            label2.Text = "Resultado";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(limpiar);
            Controls.Add(poten);
            Controls.Add(raiz);
            Controls.Add(division);
            Controls.Add(multi);
            Controls.Add(resta);
            Controls.Add(suma);
            Controls.Add(res);
            Controls.Add(num2);
            Controls.Add(num1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox num1;
        private TextBox num2;
        private TextBox res;
        private Button suma;
        private Button resta;
        private Button multi;
        private Button division;
        private Button raiz;
        private Button poten;
        private Button limpiar;
        private Label label2;
    }
}
