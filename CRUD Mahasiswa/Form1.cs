using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD_Mahasiswa
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        static SqlConnection koneksi()
        {
            string connection_string = @"Data Source=DELL-PERTAMINA\SQLEXPRESS;Initial Catalog=db_testing;Integrated Security=True";
            SqlConnection conn = new SqlConnection(connection_string);
            return conn;
        }
        private void button_simpan_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO Mahasiswa VALUES("+Convert.ToInt32(textBox_id.Text)+",'" + textBox_nama.Text + "','" + textBox_alamat.Text + "','" + textBox_jurusan.Text + "','" + textBox_jeniskelamin.Text + "')";
            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();
            MessageBox.Show("Simpan data berhasil!!");
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "UPDATE Mahasiswa SET mahasiswa_nama = '"+textBox_nama.Text+"', mahasiswa_alamat='" + textBox_alamat.Text + "',mahasiswa_jurusan = '"+textBox_jurusan.Text+"', mahasiswa_jeniskelamin='" + textBox_jeniskelamin.Text + "'WHERE mahasiswa_id = "+Convert.ToInt32(textBox_id.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();
            MessageBox.Show("Update data berhasil!!");
        }

        private void button_hapus_Click(object sender, EventArgs e)
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE FROM Mahasiswa WHERE mahasiswa_id = "+Convert.ToInt32(textBox_id.Text);
            cmd.ExecuteNonQuery();
            conn.Close();
            display_data();
            MessageBox.Show("Hapus data berhasil!!");
        }

        public void display_data()
        {
            SqlConnection conn = koneksi();
            conn.Open();
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT mahasiswa_id AS ID, mahasiswa_nama AS Nama, mahasiswa_alamat AS Alamat, mahasiswa_jurusan AS Jurusan, mahasiswa_jeniskelamin AS Jenis_Kelamin FROM Mahasiswa";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
