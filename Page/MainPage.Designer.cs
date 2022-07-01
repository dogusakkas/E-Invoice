
namespace E_InvoiceProject.Page
{
    partial class MainPage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Btn_Goruntule = new System.Windows.Forms.Button();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Btn_Yeni_FaturaKaydi = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_FaturaSayisi = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(468, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // Btn_Goruntule
            // 
            this.Btn_Goruntule.Location = new System.Drawing.Point(12, 185);
            this.Btn_Goruntule.Name = "Btn_Goruntule";
            this.Btn_Goruntule.Size = new System.Drawing.Size(92, 40);
            this.Btn_Goruntule.TabIndex = 1;
            this.Btn_Goruntule.Text = "Görüntüle";
            this.Btn_Goruntule.UseVisualStyleBackColor = true;
            this.Btn_Goruntule.Click += new System.EventHandler(this.Btn_Goruntule_Click);
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(110, 185);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(92, 40);
            this.Btn_Guncelle.TabIndex = 2;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Btn_Yeni_FaturaKaydi
            // 
            this.Btn_Yeni_FaturaKaydi.Location = new System.Drawing.Point(208, 185);
            this.Btn_Yeni_FaturaKaydi.Name = "Btn_Yeni_FaturaKaydi";
            this.Btn_Yeni_FaturaKaydi.Size = new System.Drawing.Size(105, 40);
            this.Btn_Yeni_FaturaKaydi.TabIndex = 3;
            this.Btn_Yeni_FaturaKaydi.Text = "Yeni Fatura Kaydı";
            this.Btn_Yeni_FaturaKaydi.UseVisualStyleBackColor = true;
            this.Btn_Yeni_FaturaKaydi.Click += new System.EventHandler(this.Btn_Yeni_FaturaKaydi_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(336, 194);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Fatura Sayısı";
            // 
            // Lbl_FaturaSayisi
            // 
            this.Lbl_FaturaSayisi.AutoSize = true;
            this.Lbl_FaturaSayisi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Lbl_FaturaSayisi.Location = new System.Drawing.Point(443, 194);
            this.Lbl_FaturaSayisi.Name = "Lbl_FaturaSayisi";
            this.Lbl_FaturaSayisi.Size = new System.Drawing.Size(18, 20);
            this.Lbl_FaturaSayisi.TabIndex = 7;
            this.Lbl_FaturaSayisi.Text = "0";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 287);
            this.Controls.Add(this.Lbl_FaturaSayisi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_Yeni_FaturaKaydi);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Btn_Goruntule);
            this.Controls.Add(this.dataGridView1);
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainPage";
            this.Load += new System.EventHandler(this.MainPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Btn_Goruntule;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.Button Btn_Yeni_FaturaKaydi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_FaturaSayisi;
    }
}