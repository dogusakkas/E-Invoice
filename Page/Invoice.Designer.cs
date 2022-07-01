
namespace E_InvoiceProject.Page
{
    partial class Invoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Id = new System.Windows.Forms.TextBox();
            this.Btn_Guncelle = new System.Windows.Forms.Button();
            this.Txt_Fiyat = new System.Windows.Forms.TextBox();
            this.Dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.Txt_FaturaNo = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fatura No";
            // 
            // Txt_Id
            // 
            this.Txt_Id.Enabled = false;
            this.Txt_Id.Location = new System.Drawing.Point(189, 67);
            this.Txt_Id.Name = "Txt_Id";
            this.Txt_Id.Size = new System.Drawing.Size(117, 20);
            this.Txt_Id.TabIndex = 2;
            // 
            // Btn_Guncelle
            // 
            this.Btn_Guncelle.Location = new System.Drawing.Point(314, 312);
            this.Btn_Guncelle.Name = "Btn_Guncelle";
            this.Btn_Guncelle.Size = new System.Drawing.Size(88, 39);
            this.Btn_Guncelle.TabIndex = 4;
            this.Btn_Guncelle.Text = "Güncelle";
            this.Btn_Guncelle.UseVisualStyleBackColor = true;
            this.Btn_Guncelle.Click += new System.EventHandler(this.Btn_Guncelle_Click);
            // 
            // Txt_Fiyat
            // 
            this.Txt_Fiyat.Location = new System.Drawing.Point(189, 169);
            this.Txt_Fiyat.Name = "Txt_Fiyat";
            this.Txt_Fiyat.Size = new System.Drawing.Size(117, 20);
            this.Txt_Fiyat.TabIndex = 7;
            // 
            // Dtp_Tarih
            // 
            this.Dtp_Tarih.CustomFormat = "dd.MM.yyyy";
            this.Dtp_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Tarih.Location = new System.Drawing.Point(189, 132);
            this.Dtp_Tarih.Name = "Dtp_Tarih";
            this.Dtp_Tarih.Size = new System.Drawing.Size(117, 20);
            this.Dtp_Tarih.TabIndex = 8;
            // 
            // Txt_FaturaNo
            // 
            this.Txt_FaturaNo.Location = new System.Drawing.Point(189, 98);
            this.Txt_FaturaNo.Name = "Txt_FaturaNo";
            this.Txt_FaturaNo.Size = new System.Drawing.Size(117, 20);
            this.Txt_FaturaNo.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(120, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Tarih";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(122, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Fiyat";
            // 
            // Invoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(529, 408);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Txt_FaturaNo);
            this.Controls.Add(this.Dtp_Tarih);
            this.Controls.Add(this.Txt_Fiyat);
            this.Controls.Add(this.Btn_Guncelle);
            this.Controls.Add(this.Txt_Id);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Invoice";
            this.Text = "Invoice";
            this.Load += new System.EventHandler(this.Invoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Id;
        private System.Windows.Forms.Button Btn_Guncelle;
        private System.Windows.Forms.TextBox Txt_Fiyat;
        private System.Windows.Forms.DateTimePicker Dtp_Tarih;
        private System.Windows.Forms.MaskedTextBox Txt_FaturaNo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}