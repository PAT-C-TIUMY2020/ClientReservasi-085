using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientReservasi_085
{
    public partial class Register : Form
    {
        ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

        public Register()
        {
            InitializeComponent();
            TampilData();
            textBoxID.Visible = false;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void comboBoxKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxKategori.Items.Add("Admin");
            comboBoxKategori.Items.Add("Resepsionis");
        }

        private void Regsiter_Load(object sender, EventArgs e)
        {

        }

        private void btSimpan_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            string kategori = comboBoxKategori.Text;
            string a = service.Register(username, password, kategori);

            if (textBoxUser.Text == "" || textBoxPass.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
            }

            else
            {
                MessageBox.Show(a);
                Refresh();
                TampilData();
            }
        }

        private void btUpdate_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;
            string password = textBoxPass.Text;
            string kategori = comboBoxKategori.Text;
            int id = Convert.ToInt32(textBoxID.Text);
            string a = service.UpdateRegister(username, password, kategori, id);

            if (textBoxUser.Text == "" || textBoxPass.Text == "" || comboBoxKategori.Text == "")
            {
                MessageBox.Show("Semua data wajib diisi");
            }

            else
            {
                MessageBox.Show(a);
                Clear();
                TampilData();
            }
        }

        private void btHapus_Click(object sender, EventArgs e)
        {
            string username = textBoxUser.Text;

            DialogResult dialogResult = MessageBox.Show("Apakah Anda yakin ingin menghapus data ini?",
                "Hapus Data", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string a = service.DeleteRegister(username);
                MessageBox.Show(a);
                Clear();
                TampilData();
            }

            else if (dialogResult == DialogResult.No)
            {

            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            Clear();
        }

        public void TampilData()
        {
            var list = service.DataRegist();
            dataRegister.DataSource = list;
        }

        public void Clear()
        {
            textBoxUser.Clear();
            textBoxPass.Clear();
            comboBoxKategori.SelectedItem = null;

            btSimpan.Enabled = true;
            btUpdate.Enabled = false;
            btHapus.Enabled = false;
        }

        private void dataRegister_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBoxID.Text = Convert.ToString(dataRegister.Rows[e.RowIndex].Cells[0].Value);
            textBoxUser.Text = Convert.ToString(dataRegister.Rows[e.RowIndex].Cells[1].Value);
            textBoxPass.Text = Convert.ToString(dataRegister.Rows[e.RowIndex].Cells[2].Value);
            comboBoxKategori.Text = Convert.ToString(dataRegister.Rows[e.RowIndex].Cells[3].Value);

            btUpdate.Enabled = true;
            btHapus.Enabled = true;

            btSimpan.Enabled = false;
        }
    }
}
