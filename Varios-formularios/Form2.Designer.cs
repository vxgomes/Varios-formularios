namespace Varios_formularios
{
    partial class form2
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
            this.txtBoxMultiLines = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxMultiLines
            // 
            this.txtBoxMultiLines.Location = new System.Drawing.Point(208, 99);
            this.txtBoxMultiLines.Multiline = true;
            this.txtBoxMultiLines.Name = "txtBoxMultiLines";
            this.txtBoxMultiLines.Size = new System.Drawing.Size(355, 248);
            this.txtBoxMultiLines.TabIndex = 0;
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtBoxMultiLines);
            this.Name = "form2";
            this.Text = "Segundo Formulario Exemplo";
            this.Load += new System.EventHandler(this.txtBoxMultiLines_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxMultiLines;
    }
}