
namespace E_InvoiceProject.Page
{
    partial class NewInvoice
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Cm_Satislar = new System.Windows.Forms.ComboBox();
            this.Txt_Fiyat = new System.Windows.Forms.TextBox();
            this.Txt_FaturaNo = new System.Windows.Forms.MaskedTextBox();
            this.Dtp_Tarih = new System.Windows.Forms.DateTimePicker();
            this.Btn_Kaydet = new System.Windows.Forms.Button();
            this.Btn_YeniKayit = new System.Windows.Forms.Button();
            this.Txt_Urun = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_InvoiceId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(731, 138);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(56, 187);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "E-Fatura";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 239);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Fatura No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tarih";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(297, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Satışlar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(303, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fiyat";
            // 
            // Cm_Satislar
            // 
            this.Cm_Satislar.FormattingEnabled = true;
            this.Cm_Satislar.Location = new System.Drawing.Point(362, 239);
            this.Cm_Satislar.Name = "Cm_Satislar";
            this.Cm_Satislar.Size = new System.Drawing.Size(131, 21);
            this.Cm_Satislar.TabIndex = 6;
            // 
            // Txt_Fiyat
            // 
            this.Txt_Fiyat.Location = new System.Drawing.Point(362, 289);
            this.Txt_Fiyat.Name = "Txt_Fiyat";
            this.Txt_Fiyat.Size = new System.Drawing.Size(131, 20);
            this.Txt_Fiyat.TabIndex = 7;
            // 
            // Txt_FaturaNo
            // 
            this.Txt_FaturaNo.Location = new System.Drawing.Point(128, 236);
            this.Txt_FaturaNo.Mask = "000000";
            this.Txt_FaturaNo.Name = "Txt_FaturaNo";
            this.Txt_FaturaNo.Size = new System.Drawing.Size(138, 20);
            this.Txt_FaturaNo.TabIndex = 8;
            this.Txt_FaturaNo.ValidatingType = typeof(int);
            // 
            // Dtp_Tarih
            // 
            this.Dtp_Tarih.CustomFormat = "dd.MM.yyyy";
            this.Dtp_Tarih.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Dtp_Tarih.Location = new System.Drawing.Point(128, 292);
            this.Dtp_Tarih.Name = "Dtp_Tarih";
            this.Dtp_Tarih.Size = new System.Drawing.Size(138, 20);
            this.Dtp_Tarih.TabIndex = 9;
            // 
            // Btn_Kaydet
            // 
            this.Btn_Kaydet.Location = new System.Drawing.Point(61, 366);
            this.Btn_Kaydet.Name = "Btn_Kaydet";
            this.Btn_Kaydet.Size = new System.Drawing.Size(89, 35);
            this.Btn_Kaydet.TabIndex = 10;
            this.Btn_Kaydet.Text = "Kaydet";
            this.Btn_Kaydet.UseVisualStyleBackColor = true;
            this.Btn_Kaydet.Click += new System.EventHandler(this.Btn_Kaydet_Click);
            // 
            // Btn_YeniKayit
            // 
            this.Btn_YeniKayit.Location = new System.Drawing.Point(470, 366);
            this.Btn_YeniKayit.Name = "Btn_YeniKayit";
            this.Btn_YeniKayit.Size = new System.Drawing.Size(87, 35);
            this.Btn_YeniKayit.TabIndex = 11;
            this.Btn_YeniKayit.Text = "Yeni Kayıt";
            this.Btn_YeniKayit.UseVisualStyleBackColor = true;
            this.Btn_YeniKayit.Click += new System.EventHandler(this.Btn_YeniKayit_Click);
            // 
            // Txt_Urun
            // 
            this.Txt_Urun.Location = new System.Drawing.Point(609, 236);
            this.Txt_Urun.Name = "Txt_Urun";
            this.Txt_Urun.Size = new System.Drawing.Size(134, 20);
            this.Txt_Urun.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(573, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Ürün";
            // 
            // Txt_InvoiceId
            // 
            this.Txt_InvoiceId.Location = new System.Drawing.Point(609, 286);
            this.Txt_InvoiceId.Name = "Txt_InvoiceId";
            this.Txt_InvoiceId.Size = new System.Drawing.Size(134, 20);
            this.Txt_InvoiceId.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(519, 289);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Fatura Numarası";
            // 
            // NewInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Txt_InvoiceId);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Urun);
            this.Controls.Add(this.Btn_YeniKayit);
            this.Controls.Add(this.Btn_Kaydet);
            this.Controls.Add(this.Dtp_Tarih);
            this.Controls.Add(this.Txt_FaturaNo);
            this.Controls.Add(this.Txt_Fiyat);
            this.Controls.Add(this.Cm_Satislar);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "NewInvoice";
            this.Text = "NewInvoice";
            this.Load += new System.EventHandler(this.NewInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Cm_Satislar;
        private System.Windows.Forms.TextBox Txt_Fiyat;
        private System.Windows.Forms.MaskedTextBox Txt_FaturaNo;
        private System.Windows.Forms.DateTimePicker Dtp_Tarih;
        private System.Windows.Forms.Button Btn_Kaydet;
        private System.Windows.Forms.Button Btn_YeniKayit;
        private System.Windows.Forms.TextBox Txt_Urun;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_InvoiceId;
        private System.Windows.Forms.Label label7;
    }
}