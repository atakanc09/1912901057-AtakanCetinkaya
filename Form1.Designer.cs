
namespace _1912901057_AtakanCetinkaya
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
            this.btnOku = new System.Windows.Forms.Button();
            this.lstBxHaber = new System.Windows.Forms.ListBox();
            this.btnYaz = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnOku
            // 
            this.btnOku.Location = new System.Drawing.Point(1, 327);
            this.btnOku.Name = "btnOku";
            this.btnOku.Size = new System.Drawing.Size(119, 44);
            this.btnOku.TabIndex = 0;
            this.btnOku.Text = "Oku";
            this.btnOku.UseVisualStyleBackColor = true;
            this.btnOku.Click += new System.EventHandler(this.btnOku_Click);
            // 
            // lstBxHaber
            // 
            this.lstBxHaber.FormattingEnabled = true;
            this.lstBxHaber.ItemHeight = 15;
            this.lstBxHaber.Location = new System.Drawing.Point(1, 2);
            this.lstBxHaber.Name = "lstBxHaber";
            this.lstBxHaber.Size = new System.Drawing.Size(798, 319);
            this.lstBxHaber.TabIndex = 1;
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(174, 327);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(126, 44);
            this.btnYaz.TabIndex = 2;
            this.btnYaz.Text = "Yazdır";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYaz);
            this.Controls.Add(this.lstBxHaber);
            this.Controls.Add(this.btnOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.ListBox lstBxHaber;
        private System.Windows.Forms.Button btnYaz;
    }
}

