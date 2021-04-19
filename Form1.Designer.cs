
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
            this.btnYazdir = new System.Windows.Forms.Button();
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
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(180, 327);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(118, 44);
            this.btnYazdir.TabIndex = 2;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lstBxHaber);
            this.Controls.Add(this.btnOku);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOku;
        private System.Windows.Forms.ListBox lstBxHaber;
        private System.Windows.Forms.Button btnYazdir;
    }
}

