namespace ClientReservasi_085
{
    partial class Register
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
            this.labelUser = new System.Windows.Forms.Label();
            this.labelPass = new System.Windows.Forms.Label();
            this.labelKategori = new System.Windows.Forms.Label();
            this.textBoxUser = new System.Windows.Forms.TextBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.comboBoxKategori = new System.Windows.Forms.ComboBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btHapus = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btSimpan = new System.Windows.Forms.Button();
            this.dataRegister = new System.Windows.Forms.DataGridView();
            this.textBoxID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // labelUser
            // 
            this.labelUser.AutoSize = true;
            this.labelUser.Location = new System.Drawing.Point(137, 111);
            this.labelUser.Name = "labelUser";
            this.labelUser.Size = new System.Drawing.Size(73, 17);
            this.labelUser.TabIndex = 0;
            this.labelUser.Text = "Username";
            // 
            // labelPass
            // 
            this.labelPass.AutoSize = true;
            this.labelPass.Location = new System.Drawing.Point(137, 189);
            this.labelPass.Name = "labelPass";
            this.labelPass.Size = new System.Drawing.Size(69, 17);
            this.labelPass.TabIndex = 1;
            this.labelPass.Text = "Password";
            // 
            // labelKategori
            // 
            this.labelKategori.AutoSize = true;
            this.labelKategori.Location = new System.Drawing.Point(137, 270);
            this.labelKategori.Name = "labelKategori";
            this.labelKategori.Size = new System.Drawing.Size(61, 17);
            this.labelKategori.TabIndex = 2;
            this.labelKategori.Text = "Kategori";
            // 
            // textBoxUser
            // 
            this.textBoxUser.Location = new System.Drawing.Point(299, 106);
            this.textBoxUser.Name = "textBoxUser";
            this.textBoxUser.Size = new System.Drawing.Size(523, 22);
            this.textBoxUser.TabIndex = 3;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Location = new System.Drawing.Point(299, 184);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(523, 22);
            this.textBoxPass.TabIndex = 4;
            // 
            // comboBoxKategori
            // 
            this.comboBoxKategori.FormattingEnabled = true;
            this.comboBoxKategori.Location = new System.Drawing.Point(299, 263);
            this.comboBoxKategori.Name = "comboBoxKategori";
            this.comboBoxKategori.Size = new System.Drawing.Size(523, 24);
            this.comboBoxKategori.TabIndex = 5;
            this.comboBoxKategori.SelectedIndexChanged += new System.EventHandler(this.comboBoxKategori_SelectedIndexChanged);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(946, 286);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(126, 50);
            this.btClear.TabIndex = 18;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btHapus
            // 
            this.btHapus.Location = new System.Drawing.Point(946, 217);
            this.btHapus.Name = "btHapus";
            this.btHapus.Size = new System.Drawing.Size(126, 50);
            this.btHapus.TabIndex = 17;
            this.btHapus.Text = "Hapus";
            this.btHapus.UseVisualStyleBackColor = true;
            this.btHapus.Click += new System.EventHandler(this.btHapus_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(946, 139);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(126, 50);
            this.btUpdate.TabIndex = 16;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btSimpan
            // 
            this.btSimpan.Location = new System.Drawing.Point(946, 66);
            this.btSimpan.Name = "btSimpan";
            this.btSimpan.Size = new System.Drawing.Size(126, 50);
            this.btSimpan.TabIndex = 15;
            this.btSimpan.Text = "Simpan";
            this.btSimpan.UseVisualStyleBackColor = true;
            this.btSimpan.Click += new System.EventHandler(this.btSimpan_Click);
            // 
            // dataRegister
            // 
            this.dataRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRegister.Location = new System.Drawing.Point(140, 358);
            this.dataRegister.Name = "dataRegister";
            this.dataRegister.RowTemplate.Height = 24;
            this.dataRegister.Size = new System.Drawing.Size(682, 244);
            this.dataRegister.TabIndex = 19;
            this.dataRegister.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataRegister_CellContentClick);
            // 
            // textBoxID
            // 
            this.textBoxID.BackColor = System.Drawing.SystemColors.Menu;
            this.textBoxID.Location = new System.Drawing.Point(959, 23);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(100, 22);
            this.textBoxID.TabIndex = 20;
            // 
            // Regsiter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1269, 673);
            this.Controls.Add(this.textBoxID);
            this.Controls.Add(this.dataRegister);
            this.Controls.Add(this.btClear);
            this.Controls.Add(this.btHapus);
            this.Controls.Add(this.btUpdate);
            this.Controls.Add(this.btSimpan);
            this.Controls.Add(this.comboBoxKategori);
            this.Controls.Add(this.textBoxPass);
            this.Controls.Add(this.textBoxUser);
            this.Controls.Add(this.labelKategori);
            this.Controls.Add(this.labelPass);
            this.Controls.Add(this.labelUser);
            this.Name = "Regsiter";
            this.Text = "Regsiter";
            this.Load += new System.EventHandler(this.Regsiter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelUser;
        private System.Windows.Forms.Label labelPass;
        private System.Windows.Forms.Label labelKategori;
        private System.Windows.Forms.TextBox textBoxUser;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.ComboBox comboBoxKategori;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btHapus;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btSimpan;
        private System.Windows.Forms.DataGridView dataRegister;
        private System.Windows.Forms.TextBox textBoxID;
    }
}