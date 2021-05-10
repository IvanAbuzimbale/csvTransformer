
namespace csvTransformer
{
    partial class FormPregled
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPregled));
            this.BtnUcitajDokument = new System.Windows.Forms.Button();
            this.rtbIspisPodataka = new System.Windows.Forms.RichTextBox();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.btnFiltriraj = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnUcitajDokument
            // 
            this.BtnUcitajDokument.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnUcitajDokument.Location = new System.Drawing.Point(12, 11);
            this.BtnUcitajDokument.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnUcitajDokument.Name = "BtnUcitajDokument";
            this.BtnUcitajDokument.Size = new System.Drawing.Size(144, 29);
            this.BtnUcitajDokument.TabIndex = 8;
            this.BtnUcitajDokument.Text = "Učitaj &dokument";
            this.BtnUcitajDokument.UseVisualStyleBackColor = true;
            this.BtnUcitajDokument.Click += new System.EventHandler(this.BtnUcitajDokument_Click);
            // 
            // rtbIspisPodataka
            // 
            this.rtbIspisPodataka.Location = new System.Drawing.Point(12, 46);
            this.rtbIspisPodataka.Name = "rtbIspisPodataka";
            this.rtbIspisPodataka.Size = new System.Drawing.Size(444, 392);
            this.rtbIspisPodataka.TabIndex = 9;
            this.rtbIspisPodataka.Text = "";
            // 
            // btnOdustani
            // 
            this.btnOdustani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustani.Location = new System.Drawing.Point(312, 12);
            this.btnOdustani.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(144, 29);
            this.btnOdustani.TabIndex = 10;
            this.btnOdustani.Text = "&Odustani";
            this.btnOdustani.UseVisualStyleBackColor = true;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // btnFiltriraj
            // 
            this.btnFiltriraj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltriraj.Location = new System.Drawing.Point(162, 12);
            this.btnFiltriraj.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltriraj.Name = "btnFiltriraj";
            this.btnFiltriraj.Size = new System.Drawing.Size(144, 29);
            this.btnFiltriraj.TabIndex = 11;
            this.btnFiltriraj.Text = "&Filtriraj";
            this.btnFiltriraj.UseVisualStyleBackColor = true;
            this.btnFiltriraj.Click += new System.EventHandler(this.btnFiltriraj_Click);
            // 
            // FormPregled
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 450);
            this.Controls.Add(this.btnFiltriraj);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.rtbIspisPodataka);
            this.Controls.Add(this.BtnUcitajDokument);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormPregled";
            this.Text = "Pregled podataka";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnUcitajDokument;
        private System.Windows.Forms.RichTextBox rtbIspisPodataka;
        private System.Windows.Forms.Button btnOdustani;
        private System.Windows.Forms.Button btnFiltriraj;
    }
}