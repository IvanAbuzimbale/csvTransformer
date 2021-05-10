
namespace csvTransformer
{
    partial class FormFiltriranje
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormFiltriranje));
            this.btnFiltrirajPodatke = new System.Windows.Forms.Button();
            this.cmbRazredFilter = new System.Windows.Forms.ComboBox();
            this.txtEmailFilter = new System.Windows.Forms.TextBox();
            this.txtPrezimeFilter = new System.Windows.Forms.TextBox();
            this.txtImeFilter = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOdustaniFilter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnFiltrirajPodatke
            // 
            this.btnFiltrirajPodatke.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrirajPodatke.Location = new System.Drawing.Point(12, 209);
            this.btnFiltrirajPodatke.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFiltrirajPodatke.Name = "btnFiltrirajPodatke";
            this.btnFiltrirajPodatke.Size = new System.Drawing.Size(268, 29);
            this.btnFiltrirajPodatke.TabIndex = 22;
            this.btnFiltrirajPodatke.Text = "&Filtriraj";
            this.btnFiltrirajPodatke.UseVisualStyleBackColor = true;
            this.btnFiltrirajPodatke.Click += new System.EventHandler(this.btnFiltrirajPodatke_Click);
            // 
            // cmbRazredFilter
            // 
            this.cmbRazredFilter.FormattingEnabled = true;
            this.cmbRazredFilter.Items.AddRange(new object[] {
            "1.a",
            "1.b",
            "1.c",
            "1.d",
            "2.a",
            "2.b",
            "2.c",
            "2.d",
            "3.a",
            "3.b",
            "3.c",
            "3.d",
            "4.a",
            "4.b",
            "4.c",
            "4.d"});
            this.cmbRazredFilter.Location = new System.Drawing.Point(12, 170);
            this.cmbRazredFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbRazredFilter.Name = "cmbRazredFilter";
            this.cmbRazredFilter.Size = new System.Drawing.Size(268, 23);
            this.cmbRazredFilter.TabIndex = 21;
            // 
            // txtEmailFilter
            // 
            this.txtEmailFilter.Location = new System.Drawing.Point(12, 121);
            this.txtEmailFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtEmailFilter.Name = "txtEmailFilter";
            this.txtEmailFilter.Size = new System.Drawing.Size(268, 23);
            this.txtEmailFilter.TabIndex = 20;
            // 
            // txtPrezimeFilter
            // 
            this.txtPrezimeFilter.Location = new System.Drawing.Point(12, 72);
            this.txtPrezimeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPrezimeFilter.Name = "txtPrezimeFilter";
            this.txtPrezimeFilter.Size = new System.Drawing.Size(268, 23);
            this.txtPrezimeFilter.TabIndex = 19;
            // 
            // txtImeFilter
            // 
            this.txtImeFilter.Location = new System.Drawing.Point(12, 24);
            this.txtImeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtImeFilter.Name = "txtImeFilter";
            this.txtImeFilter.Size = new System.Drawing.Size(268, 23);
            this.txtImeFilter.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 14;
            this.label4.Text = "Razred";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "E-mail";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "Prezime";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 17;
            this.label1.Text = "Ime";
            // 
            // btnOdustaniFilter
            // 
            this.btnOdustaniFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOdustaniFilter.Location = new System.Drawing.Point(12, 242);
            this.btnOdustaniFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOdustaniFilter.Name = "btnOdustaniFilter";
            this.btnOdustaniFilter.Size = new System.Drawing.Size(268, 29);
            this.btnOdustaniFilter.TabIndex = 23;
            this.btnOdustaniFilter.Text = "&Odustani";
            this.btnOdustaniFilter.UseVisualStyleBackColor = true;
            this.btnOdustaniFilter.Click += new System.EventHandler(this.btnOdustaniFilter_Click);
            // 
            // FormFiltriranje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 282);
            this.Controls.Add(this.btnOdustaniFilter);
            this.Controls.Add(this.btnFiltrirajPodatke);
            this.Controls.Add(this.cmbRazredFilter);
            this.Controls.Add(this.txtEmailFilter);
            this.Controls.Add(this.txtPrezimeFilter);
            this.Controls.Add(this.txtImeFilter);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormFiltriranje";
            this.Text = "Filtriranje podataka";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnFiltrirajPodatke;
        private System.Windows.Forms.ComboBox cmbRazredFilter;
        private System.Windows.Forms.TextBox txtEmailFilter;
        private System.Windows.Forms.TextBox txtPrezimeFilter;
        private System.Windows.Forms.TextBox txtImeFilter;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOdustaniFilter;
    }
}