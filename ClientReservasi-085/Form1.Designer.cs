namespace ClientReservasi_085
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.dtPemesanan = new System.Windows.Forms.DataGridView();
            this.pemesananBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.wCFReservasiDataSet = new ClientReservasi_085.WCFReservasiDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.textBoxNama = new System.Windows.Forms.TextBox();
            this.textBoxNoTlp = new System.Windows.Forms.TextBox();
            this.textBoxJumlah = new System.Windows.Forms.TextBox();
            this.textBoxIDLokasi = new System.Windows.Forms.TextBox();
            this.btSimpan = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.pemesananTableAdapter = new ClientReservasi_085.WCFReservasiDataSetTableAdapters.PemesananTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dtPemesanan
            // 
            this.dtPemesanan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtPemesanan.Location = new System.Drawing.Point(12, 405);
            this.dtPemesanan.Name = "dtPemesanan";
            this.dtPemesanan.RowTemplate.Height = 24;
            this.dtPemesanan.Size = new System.Drawing.Size(1235, 303);
            this.dtPemesanan.TabIndex = 0;
            this.dtPemesanan.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtPemesanan_CellContentClick);
            // 
            // pemesananBindingSource
            // 
            this.pemesananBindingSource.DataMember = "Pemesanan";
            this.pemesananBindingSource.DataSource = this.wCFReservasiDataSet;
            // 
            // wCFReservasiDataSet
            // 
            this.wCFReservasiDataSet.DataSetName = "WCFReservasiDataSet";
            this.wCFReservasiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(105, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "ID Reservasi                 :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(105, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(161, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nama                            :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(105, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(162, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "No Telpon                     :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(105, 250);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Jumlah Pemesanan       :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(105, 314);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "ID Lokasi                        :";
            // 
            // textBoxID
            // 
            this.textBoxID.Location = new System.Drawing.Point(344, 47);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(527, 22);
            this.textBoxID.TabIndex = 6;
            // 
            // textBoxNama
            // 
            this.textBoxNama.Location = new System.Drawing.Point(344, 113);
            this.textBoxNama.Name = "textBoxNama";
            this.textBoxNama.Size = new System.Drawing.Size(527, 22);
            this.textBoxNama.TabIndex = 7;
            // 
            // textBoxNoTlp
            // 
            this.textBoxNoTlp.Location = new System.Drawing.Point(344, 179);
            this.textBoxNoTlp.Name = "textBoxNoTlp";
            this.textBoxNoTlp.Size = new System.Drawing.Size(527, 22);
            this.textBoxNoTlp.TabIndex = 8;
            // 
            // textBoxJumlah
            // 
            this.textBoxJumlah.Location = new System.Drawing.Point(344, 247);
            this.textBoxJumlah.Name = "textBoxJumlah";
            this.textBoxJumlah.Size = new System.Drawing.Size(527, 22);
            this.textBoxJumlah.TabIndex = 9;
            // 
            // textBoxIDLokasi
            // 
            this.textBoxIDLokasi.Location = new System.Drawing.Point(344, 314);
            this.textBoxIDLokasi.Name = "textBoxIDLokasi";
            this.textBoxIDLokasi.Size = new System.Drawing.Size(527, 22);
            this.textBoxIDLokasi.TabIndex = 10;
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(1008, 53);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(126, 50);
            this.btSimpan.TabIndex = 11;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(1008, 126);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(126, 50);
            this.btUpdate.TabIndex = 12;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(1008, 204);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(126, 50);
            this.btHapus.TabIndex = 13;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(1008, 273);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(126, 50);
            this.btClear.TabIndex = 14;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // pemesananTableAdapter
            // 
            this.pemesananTableAdapter.ClearBeforeFill = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 738);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.textBoxIDLokasi);
            this.Controls.Add(this.textBoxJumlah);
            this.Controls.Add(this.textBoxNoTlp);
            this.Controls.Add(this.textBoxNama);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtPemesanan);
            this.Name = "Form1";
            this.Text = "Reservasi";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtPemesanan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pemesananBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.wCFReservasiDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtPemesanan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.TextBox textBoxNama;
        private System.Windows.Forms.TextBox textBoxNoTlp;
        private System.Windows.Forms.TextBox textBoxJumlah;
        private System.Windows.Forms.TextBox textBoxIDLokasi;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btClear;
        private WCFReservasiDataSet wCFReservasiDataSet;
        private System.Windows.Forms.BindingSource pemesananBindingSource;
        private WCFReservasiDataSetTableAdapters.PemesananTableAdapter pemesananTableAdapter;
    }
}

