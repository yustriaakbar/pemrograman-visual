namespace CRUD_Mahasiswa
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
            this.id_mahasiswa = new System.Windows.Forms.Label();
            this.nama = new System.Windows.Forms.Label();
            this.alamat = new System.Windows.Forms.Label();
            this.jurusan = new System.Windows.Forms.Label();
            this.jenis_kelamin = new System.Windows.Forms.Label();
            this.textBox_id = new System.Windows.Forms.TextBox();
            this.textBox_nama = new System.Windows.Forms.TextBox();
            this.textBox_alamat = new System.Windows.Forms.TextBox();
            this.textBox_jurusan = new System.Windows.Forms.TextBox();
            this.textBox_jeniskelamin = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_simpan = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_hapus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // id_mahasiswa
            // 
            this.id_mahasiswa.AutoSize = true;
            this.id_mahasiswa.Location = new System.Drawing.Point(33, 32);
            this.id_mahasiswa.Name = "id_mahasiswa";
            this.id_mahasiswa.Size = new System.Drawing.Size(74, 13);
            this.id_mahasiswa.TabIndex = 0;
            this.id_mahasiswa.Text = "ID Mahasiswa";
            this.id_mahasiswa.Click += new System.EventHandler(this.label1_Click);
            // 
            // nama
            // 
            this.nama.AutoSize = true;
            this.nama.Location = new System.Drawing.Point(33, 61);
            this.nama.Name = "nama";
            this.nama.Size = new System.Drawing.Size(35, 13);
            this.nama.TabIndex = 1;
            this.nama.Text = "Nama";
            // 
            // alamat
            // 
            this.alamat.AutoSize = true;
            this.alamat.Location = new System.Drawing.Point(33, 93);
            this.alamat.Name = "alamat";
            this.alamat.Size = new System.Drawing.Size(39, 13);
            this.alamat.TabIndex = 2;
            this.alamat.Text = "Alamat";
            // 
            // jurusan
            // 
            this.jurusan.AutoSize = true;
            this.jurusan.Location = new System.Drawing.Point(33, 128);
            this.jurusan.Name = "jurusan";
            this.jurusan.Size = new System.Drawing.Size(44, 13);
            this.jurusan.TabIndex = 3;
            this.jurusan.Text = "Jurusan";
            // 
            // jenis_kelamin
            // 
            this.jenis_kelamin.AutoSize = true;
            this.jenis_kelamin.Location = new System.Drawing.Point(33, 158);
            this.jenis_kelamin.Name = "jenis_kelamin";
            this.jenis_kelamin.Size = new System.Drawing.Size(71, 13);
            this.jenis_kelamin.TabIndex = 4;
            this.jenis_kelamin.Text = "Jenis Kelamin";
            // 
            // textBox_id
            // 
            this.textBox_id.Location = new System.Drawing.Point(160, 29);
            this.textBox_id.Name = "textBox_id";
            this.textBox_id.Size = new System.Drawing.Size(137, 20);
            this.textBox_id.TabIndex = 5;
            // 
            // textBox_nama
            // 
            this.textBox_nama.Location = new System.Drawing.Point(160, 58);
            this.textBox_nama.Name = "textBox_nama";
            this.textBox_nama.Size = new System.Drawing.Size(137, 20);
            this.textBox_nama.TabIndex = 6;
            // 
            // textBox_alamat
            // 
            this.textBox_alamat.Location = new System.Drawing.Point(160, 90);
            this.textBox_alamat.Name = "textBox_alamat";
            this.textBox_alamat.Size = new System.Drawing.Size(137, 20);
            this.textBox_alamat.TabIndex = 7;
            // 
            // textBox_jurusan
            // 
            this.textBox_jurusan.Location = new System.Drawing.Point(160, 121);
            this.textBox_jurusan.Name = "textBox_jurusan";
            this.textBox_jurusan.Size = new System.Drawing.Size(137, 20);
            this.textBox_jurusan.TabIndex = 8;
            // 
            // textBox_jeniskelamin
            // 
            this.textBox_jeniskelamin.Location = new System.Drawing.Point(160, 155);
            this.textBox_jeniskelamin.Name = "textBox_jeniskelamin";
            this.textBox_jeniskelamin.Size = new System.Drawing.Size(137, 20);
            this.textBox_jeniskelamin.TabIndex = 9;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(739, 172);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button_simpan
            // 
            this.button_simpan.Location = new System.Drawing.Point(36, 380);
            this.button_simpan.Name = "button_simpan";
            this.button_simpan.Size = new System.Drawing.Size(75, 23);
            this.button_simpan.TabIndex = 11;
            this.button_simpan.Text = "Simpan";
            this.button_simpan.UseVisualStyleBackColor = true;
            this.button_simpan.Click += new System.EventHandler(this.button_simpan_Click);
            // 
            // button_update
            // 
            this.button_update.Location = new System.Drawing.Point(128, 380);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 12;
            this.button_update.Text = "Update";
            this.button_update.UseVisualStyleBackColor = true;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_hapus
            // 
            this.button_hapus.Location = new System.Drawing.Point(222, 380);
            this.button_hapus.Name = "button_hapus";
            this.button_hapus.Size = new System.Drawing.Size(75, 23);
            this.button_hapus.TabIndex = 13;
            this.button_hapus.Text = "Hapus";
            this.button_hapus.UseVisualStyleBackColor = true;
            this.button_hapus.Click += new System.EventHandler(this.button_hapus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_hapus);
            this.Controls.Add(this.button_update);
            this.Controls.Add(this.button_simpan);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox_jeniskelamin);
            this.Controls.Add(this.textBox_jurusan);
            this.Controls.Add(this.textBox_alamat);
            this.Controls.Add(this.textBox_nama);
            this.Controls.Add(this.textBox_id);
            this.Controls.Add(this.jenis_kelamin);
            this.Controls.Add(this.jurusan);
            this.Controls.Add(this.alamat);
            this.Controls.Add(this.nama);
            this.Controls.Add(this.id_mahasiswa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label id_mahasiswa;
        private System.Windows.Forms.Label nama;
        private System.Windows.Forms.Label alamat;
        private System.Windows.Forms.Label jurusan;
        private System.Windows.Forms.Label jenis_kelamin;
        private System.Windows.Forms.TextBox textBox_id;
        private System.Windows.Forms.TextBox textBox_nama;
        private System.Windows.Forms.TextBox textBox_alamat;
        private System.Windows.Forms.TextBox textBox_jurusan;
        private System.Windows.Forms.TextBox textBox_jeniskelamin;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_simpan;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_hapus;
    }
}

