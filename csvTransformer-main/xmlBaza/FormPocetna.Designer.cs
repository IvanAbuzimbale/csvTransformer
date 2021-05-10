
namespace csvTransformer
{
    partial class FormPocetna
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPocetna));
            this.btnUnos = new System.Windows.Forms.Button();
            this.btnPregled = new System.Windows.Forms.Button();
            this.pictLogo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnUnos
            // 
            this.btnUnos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnos.Location = new System.Drawing.Point(12, 210);
            this.btnUnos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUnos.Name = "btnUnos";
            this.btnUnos.Size = new System.Drawing.Size(248, 29);
            this.btnUnos.TabIndex = 5;
            this.btnUnos.Text = "&Unos";
            this.btnUnos.UseVisualStyleBackColor = true;
            this.btnUnos.Click += new System.EventHandler(this.btnUnos_Click);
            // 
            // btnPregled
            // 
            this.btnPregled.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPregled.Location = new System.Drawing.Point(12, 243);
            this.btnPregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPregled.Name = "btnPregled";
            this.btnPregled.Size = new System.Drawing.Size(248, 29);
            this.btnPregled.TabIndex = 6;
            this.btnPregled.Text = "&Pregled";
            this.btnPregled.UseVisualStyleBackColor = true;
            this.btnPregled.Click += new System.EventHandler(this.btnPregled_Click);
            // 
            // pictLogo
            // 
            this.pictLogo.Image = global::csvTransformer.Properties.Resources.CSV_Transformer_logo;
            this.pictLogo.Location = new System.Drawing.Point(12, 12);
            this.pictLogo.Name = "pictLogo";
            this.pictLogo.Size = new System.Drawing.Size(248, 193);
            this.pictLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictLogo.TabIndex = 8;
            this.pictLogo.TabStop = false;
            // 
            // FormPocetna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(272, 282);
            this.Controls.Add(this.pictLogo);
            this.Controls.Add(this.btnPregled);
            this.Controls.Add(this.btnUnos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "FormPocetna";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CSV Transformer";
            ((System.ComponentModel.ISupportInitialize)(this.pictLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnUnos;
        private System.Windows.Forms.Button btnPregled;
        private System.Windows.Forms.PictureBox pictLogo;
    }
}

