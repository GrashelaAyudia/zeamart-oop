using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZeaMart_System
{
    public partial class Form1 : Form
    {
        MySqlConnection konektion = Connection.GetConnection();
        DataTable dataTable = new DataTable();
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            filldataTable();
        }

        public DataTable Getdatanovel()
        {
            //membaca data di localhost
            dataTable.Reset();
            dataTable = new DataTable();
            using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM data_novel", konektion))
            {
                konektion.Open();
                MySqlDataReader reader = cmd.ExecuteReader();
                dataTable.Load(reader);
            }
            return dataTable;
        }

        public void filldataTable()
        {
            //menampilkan datatable ke datagridview
            datagrid_novel.RowTemplate.Height = 120;
            datagrid_novel.DataSource = Getdatanovel();

            DataGridViewButtonColumn colEdit = new DataGridViewButtonColumn();
            colEdit.UseColumnTextForButtonValue = true;
            colEdit.Text = "Edit";
            colEdit.Name = "";
            datagrid_novel.Columns.Add(colEdit);

            DataGridViewButtonColumn colDelete = new DataGridViewButtonColumn();
            colDelete.UseColumnTextForButtonValue = true;
            colDelete.Text = "Delete";
            colDelete.Name = "";
            datagrid_novel.Columns.Add(colDelete);

            DataGridViewImageColumn imgCol = new DataGridViewImageColumn();
            imgCol = (DataGridViewImageColumn)datagrid_novel.Columns[4];
            imgCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            imgCol.DefaultCellStyle.NullValue = null;

            datagrid_novel.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void datagrid_novel_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 4 && (e.Value == null || e.Value == DBNull.Value)) // Kolom index 4 adalah kolom DataGridViewImageColumn
            {
                e.Value = "Tidak ada gambar"; // Tampilkan pesan "Tidak ada gambar" pada cell
                e.FormattingApplied = true; // Beri tanda bahwa formatting sudah diterapkan pada cell
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5)
            {
                int id = Convert.ToInt32(datagrid_novel.CurrentCell.RowIndex.ToString());
                textBoxedkode.Text = datagrid_novel.Rows[id].Cells[0].Value.ToString();
                textBoxednama.Text = datagrid_novel.Rows[id].Cells[1].Value.ToString();
                textBoxedharga.Text = datagrid_novel.Rows[id].Cells[2].Value.ToString();
                textBoxedjumlah.Text = datagrid_novel.Rows[id].Cells[3].Value.ToString();

                Byte[] img = (Byte[])datagrid_novel.Rows[id].Cells[4].Value;

                MemoryStream ms = new MemoryStream(img);

                picturebx.Image = Image.FromStream(ms);

                textBoxednama.Enabled = true;
                textBoxedharga.Enabled = true;
                textBoxedjumlah.Enabled = true;
                picturebx.Enabled = true;
                /*                btn_savedit.Enabled = true;*/
            }

            if (e.ColumnIndex == 6)
            {
                int id = Convert.ToInt32(datagrid_novel.CurrentCell.RowIndex.ToString());

                MySqlCommand cmd;
                try
                {
                    cmd = konektion.CreateCommand();
                    cmd.CommandText = "DELETE FROM data_novel WHERE id = @id";
                    cmd.Parameters.AddWithValue("@id", datagrid_novel.Rows[id].Cells[0].Value.ToString());

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Data berhasil terhapus");
                    resetIncrement();
                    konektion.Close();

                    datagrid_novel.Columns.Clear();
                    dataTable.Clear();
                    filldataTable();
                }
                catch (Exception)
                {
                    MessageBox.Show("Gagal delete buku");
                }
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
     /*       MySqlCommand cmd;*/
            try
            {
                byte[] imageBytes = null;
                if (picturebx.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picturebx.Image.Save(ms, picturebx.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                // Masukkan data ke dalam tabel
                MySqlCommand cmd = new MySqlCommand();
                resetIncrement();
                cmd = konektion.CreateCommand();
                cmd.CommandText = "INSERT INTO data_novel(nama, harga, jumlah, gambar) VALUE (@nama, @harga, @jenis, @gambar)";
                cmd.Parameters.AddWithValue("@nama", textBoxnama.Text);
                cmd.Parameters.AddWithValue("@harga", textBoxharga.Text);
                cmd.Parameters.AddWithValue("@jenis", textBoxjumlah.Text);
                cmd.Parameters.AddWithValue("@gambar", imageBytes);
                cmd.ExecuteNonQuery();

                konektion.Close();
                datagrid_novel.Columns.Clear();
                dataTable.Clear();
                filldataTable();


            }
            catch (Exception)
            {
                MessageBox.Show("Gagal menginput data");
            }
        }

        private void btn_del_Click(object sender, EventArgs e)
        {

        }

        private void resetIncrement()
        {
            MySqlScript script = new MySqlScript(konektion, "SET @id := 0; UPDATE data_novel SET id = @id := (@id+1); " + "ALTER TABLE data_novel AUTO_INCREMENT = 1;");
            script.Execute();
        }

        private void btnedit_Click(object sender, EventArgs e)
        {
            MySqlCommand cmd;

            try
            {
                resetIncrement();
                byte[] imageBytes = null;
                if (picturebx.Image != null)
                {
                    MemoryStream ms = new MemoryStream();
                    picturebx.Image.Save(ms, picturebx.Image.RawFormat);
                    imageBytes = ms.ToArray();
                }

                cmd = konektion.CreateCommand();
                cmd.CommandText = "UPDATE data_novel SET nama = @nama, harga = @harga, jumlah = @jumlah, gambar = @gambar WHERE id = @id";
                cmd.Parameters.AddWithValue("@id", textBoxedkode.Text);
                cmd.Parameters.AddWithValue("@nama", textBoxednama.Text);
                cmd.Parameters.AddWithValue("@harga", textBoxedharga.Text);
                cmd.Parameters.AddWithValue("@jumlah", textBoxedjumlah.Text);
                cmd.Parameters.AddWithValue("@gambar", imageBytes);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Data berhasil diubah");
                konektion.Close();  

                datagrid_novel.Columns.Clear();
                dataTable.Clear();
                filldataTable();
            }
            catch (Exception)
            {
                MessageBox.Show("Data gagal diubah");
            }
        }

        private void buttonpicture_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image files (*.png;*.jpg;*.jpeg)|*.png;*.jpg;*.jpeg|All files (*.*)|*.*";
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);
            openFileDialog.Title = "Select an image file";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Mengambil nama file gambar yang dipilih
                string fileName = openFileDialog.FileName;

                try
                {
                    // Mengubah file gambar menjadi Image
                    Image img = Image.FromFile(fileName);

                    // Menampilkan gambar pada PictureBox
                    picturebx.Image = img;

                    // Mengatur ukuran gambar agar sesuai dengan ukuran PictureBox
                    picturebx.SizeMode = PictureBoxSizeMode.Zoom;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            searchDataNovel(searchlabel.Text);
        }

        public void searchDataNovel (string ValueToFind)
        {
            string searchQuery = "SELECT * FROM data_novel WHERE CONCAT(nama, harga, jumlah) LIKE '%" + ValueToFind + "%'";
            MySqlDataAdapter adapter = new MySqlDataAdapter(searchQuery, konektion);
            DataTable table = new DataTable();
            adapter.Fill(table);
            datagrid_novel.DataSource = table;
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void textBoxjumlah_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxharga_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxnama_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
