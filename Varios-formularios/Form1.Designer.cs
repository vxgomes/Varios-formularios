namespace Varios_formularios
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxNomes = new System.Windows.Forms.TextBox();
            this.buttonInserir = new System.Windows.Forms.Button();
            this.txtBoxMultiLines = new System.Windows.Forms.TextBox();
            this.buttonLimpar = new System.Windows.Forms.Button();
            this.buttonSegundoForm = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Digite os nomes de seus convidados!!!";
            // 
            // txtBoxNomes
            // 
            this.txtBoxNomes.Location = new System.Drawing.Point(225, 95);
            this.txtBoxNomes.Name = "txtBoxNomes";
            this.txtBoxNomes.Size = new System.Drawing.Size(195, 22);
            this.txtBoxNomes.TabIndex = 1;
            // 
            // buttonInserir
            // 
            this.buttonInserir.Location = new System.Drawing.Point(482, 95);
            this.buttonInserir.Name = "buttonInserir";
            this.buttonInserir.Size = new System.Drawing.Size(75, 23);
            this.buttonInserir.TabIndex = 2;
            this.buttonInserir.Text = "Inserir";
            this.buttonInserir.UseVisualStyleBackColor = true;
            this.buttonInserir.Click += new System.EventHandler(this.buttonInserir_Click);
            // 
            // txtBoxMultiLines
            // 
            this.txtBoxMultiLines.Location = new System.Drawing.Point(225, 142);
            this.txtBoxMultiLines.Multiline = true;
            this.txtBoxMultiLines.Name = "txtBoxMultiLines";
            this.txtBoxMultiLines.Size = new System.Drawing.Size(332, 235);
            this.txtBoxMultiLines.TabIndex = 3;
            // 
            // buttonLimpar
            // 
            this.buttonLimpar.Location = new System.Drawing.Point(225, 383);
            this.buttonLimpar.Name = "buttonLimpar";
            this.buttonLimpar.Size = new System.Drawing.Size(332, 29);
            this.buttonLimpar.TabIndex = 4;
            this.buttonLimpar.Text = "Limpar";
            this.buttonLimpar.UseVisualStyleBackColor = true;
            this.buttonLimpar.Click += new System.EventHandler(this.buttonLimpar_Click);
            // 
            // buttonSegundoForm
            // 
            this.buttonSegundoForm.Location = new System.Drawing.Point(225, 415);
            this.buttonSegundoForm.Name = "buttonSegundoForm";
            this.buttonSegundoForm.Size = new System.Drawing.Size(332, 29);
            this.buttonSegundoForm.TabIndex = 5;
            this.buttonSegundoForm.Text = "Abrir Segundo Formulario";
            this.buttonSegundoForm.UseVisualStyleBackColor = true;
            this.buttonSegundoForm.Click += new System.EventHandler(this.buttonSegundoForm_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 478);
            this.Controls.Add(this.buttonSegundoForm);
            this.Controls.Add(this.buttonLimpar);
            this.Controls.Add(this.txtBoxMultiLines);
            this.Controls.Add(this.buttonInserir);
            this.Controls.Add(this.txtBoxNomes);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxNomes;
        private System.Windows.Forms.Button buttonInserir;
        private System.Windows.Forms.TextBox txtBoxMultiLines;
        private System.Windows.Forms.Button buttonLimpar;
        private System.Windows.Forms.Button buttonSegundoForm;
    }
}

