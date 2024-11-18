
namespace WFAPOO12
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtLadoB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLadoA = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtLadoC = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F);
            this.lblResultado.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.lblResultado.Location = new System.Drawing.Point(64, 328);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(2, 38);
            this.lblResultado.TabIndex = 73;
            this.lblResultado.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label1.Location = new System.Drawing.Point(33, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 72;
            this.label1.Text = "Digite o 3° Lado:";
            // 
            // txtLadoB
            // 
            this.txtLadoB.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLadoB.Location = new System.Drawing.Point(195, 129);
            this.txtLadoB.Name = "txtLadoB";
            this.txtLadoB.Size = new System.Drawing.Size(206, 38);
            this.txtLadoB.TabIndex = 71;
            this.txtLadoB.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label2.Location = new System.Drawing.Point(33, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 25);
            this.label2.TabIndex = 70;
            this.label2.Text = "Digite o 1° Lado:";
            // 
            // txtLadoA
            // 
            this.txtLadoA.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLadoA.Location = new System.Drawing.Point(195, 60);
            this.txtLadoA.Name = "txtLadoA";
            this.txtLadoA.Size = new System.Drawing.Size(206, 38);
            this.txtLadoA.TabIndex = 69;
            this.txtLadoA.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.5F);
            this.label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label3.Location = new System.Drawing.Point(64, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(337, 31);
            this.label3.TabIndex = 68;
            this.label3.Text = "Descubra o Tipo do Triângulo";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnCalcular.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnCalcular.Location = new System.Drawing.Point(137, 270);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(200, 46);
            this.btnCalcular.TabIndex = 67;
            this.btnCalcular.Text = "DESCOBRIR";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.label4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.label4.Location = new System.Drawing.Point(33, 211);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Digite o 2° Lado:";
            // 
            // txtLadoC
            // 
            this.txtLadoC.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.txtLadoC.Location = new System.Drawing.Point(195, 202);
            this.txtLadoC.Name = "txtLadoC";
            this.txtLadoC.Size = new System.Drawing.Size(206, 38);
            this.txtLadoC.TabIndex = 74;
            this.txtLadoC.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(467, 381);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtLadoC);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLadoB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLadoA);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCalcular);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtLadoB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLadoA;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtLadoC;
    }
}

