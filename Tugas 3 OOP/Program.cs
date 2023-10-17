using System;

class Tabungan
{
    private int saldo;

    public Tabungan()
    {
        saldo = 0;
    }

    public int CekSaldo()
    {
        return saldo;
    }

    public void SimpanUang(int jumlah)
    {
        saldo += jumlah;
        saldo -= 5000; // Biaya administrasi
    }

    public bool AmbilRupiah(int jumlah)
    {
        int biayaPotongan = jumlah / 15000 * 50;

        if (saldo >= jumlah + biayaPotongan)
        {
            saldo -= jumlah + biayaPotongan;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo tidak mencukupi untuk pengambilan uang dalam rupiah.");
            return false;
        }
    }

    public bool AmbilDollar(int jumlahDollar)
    {
        int jumlahRupiah = jumlahDollar * 15000;
        int biayaPotongan = jumlahRupiah / 15000 * 50;

        if (saldo >= jumlahRupiah + biayaPotongan)
        {
            saldo -= jumlahRupiah + biayaPotongan;
            return true;
        }
        else
        {
            Console.WriteLine("Saldo tidak mencukupi untuk pengambilan uang dalam dollar.");
            return false;
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Tabungan tabungan = new Tabungan();

        Console.WriteLine("Selamat datang di program tabungan!");

        while (true)
        {
            Console.WriteLine("\nMenu:");
            Console.WriteLine("1. Menabung");
            Console.WriteLine("2. Mengambil uang dalam rupiah");
            Console.WriteLine("3. Mengambil uang dalam dollar");
            Console.WriteLine("4. Cek saldo");
            Console.WriteLine("5. Keluar");
            Console.Write("Pilih menu (1/2/3/4/5): ");

            string pilihan = Console.ReadLine();

            switch (pilihan)
            {
                case "1":
                    Console.Write("Masukkan jumlah uang yang ingin ditabung dalam rupiah: ");
                    int jumlahTabungan = int.Parse(Console.ReadLine());
                    tabungan.SimpanUang(jumlahTabungan);
                    Console.WriteLine("Penyimpanan uang berhasil.");
                    break;

                case "2":
                    Console.Write("Masukkan jumlah uang yang ingin diambil dalam rupiah: ");
                    int jumlahAmbilRupiah = int.Parse(Console.ReadLine());
                    bool berhasilAmbilRupiah = tabungan.AmbilRupiah(jumlahAmbilRupiah);
                    if (berhasilAmbilRupiah)
                    {
                        Console.WriteLine("Pengambilan uang dalam rupiah berhasil.");
                    }
                    break;

                case "3":
                    Console.Write("Masukkan jumlah uang yang ingin diambil dalam dollar: ");
                    int jumlahAmbilDollar = int.Parse(Console.ReadLine());
                    bool berhasilAmbilDollar = tabungan.AmbilDollar(jumlahAmbilDollar);
                    if (berhasilAmbilDollar)
                    {
                        Console.WriteLine("Pengambilan uang dalam dollar berhasil.");
                    }
                    break;

                case "4":
                    Console.WriteLine("Saldo saat ini: " + tabungan.CekSaldo());
                    break;

                case "5":
                    Console.WriteLine("Terima kasih! Program selesai.");
                    return;

                default:
                    Console.WriteLine("Pilihan tidak valid. Silakan pilih menu yang benar.");
                    break;
            }
        }
    }
}
