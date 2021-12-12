
namespace PANEL_ADO
{
    partial class UtilitarioCortarCodigo
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
            this.EntradaText = new System.Windows.Forms.RichTextBox();
            this.SalidaText = new System.Windows.Forms.RichTextBox();
            this.bntGenerar = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // EntradaText
            // 
            this.EntradaText.Location = new System.Drawing.Point(12, 12);
            this.EntradaText.Name = "EntradaText";
            this.EntradaText.Size = new System.Drawing.Size(845, 186);
            this.EntradaText.TabIndex = 0;
            this.EntradaText.Text = "";
            // 
            // SalidaText
            // 
            this.SalidaText.Location = new System.Drawing.Point(3, 257);
            this.SalidaText.Name = "SalidaText";
            this.SalidaText.Size = new System.Drawing.Size(845, 272);
            this.SalidaText.TabIndex = 1;
            this.SalidaText.Text = "";
            // 
            // bntGenerar
            // 
            this.bntGenerar.Location = new System.Drawing.Point(299, 217);
            this.bntGenerar.Name = "bntGenerar";
            this.bntGenerar.Size = new System.Drawing.Size(193, 23);
            this.bntGenerar.TabIndex = 2;
            this.bntGenerar.Text = "Generar";
            this.bntGenerar.Click += new System.EventHandler(this.bntGenerar_Click);
            // 
            // UtilitarioCortarCodigo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 541);
            this.Controls.Add(this.bntGenerar);
            this.Controls.Add(this.SalidaText);
            this.Controls.Add(this.EntradaText);
            this.Name = "UtilitarioCortarCodigo";
            this.Text = "UtilitarioCortarCodigo";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox EntradaText;
        private System.Windows.Forms.RichTextBox SalidaText;
        private DevExpress.XtraEditors.SimpleButton bntGenerar;
    }
}