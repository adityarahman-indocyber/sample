using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University
{

    class Program
    {
        static void Main(string[] args)
        {
            MenuUtama();
        }

       public static void MenuUtama()
        {
            string pilih;
            Console.WriteLine("\nSelamat Datang Di Aplikasi Kampus");
            Console.WriteLine("1.All Student Data");
            Console.WriteLine("2.All Tutor Data");
            Console.WriteLine("3.About this University");
            Console.WriteLine("4.Exit Application");
            Console.Write("Pilih nomor menu untuk masuk ke menu : ");

            pilih = Console.ReadLine();
            switch (pilih)
            {
                case "1":
                    PendataanMahasiswa();
                    break;
                case "2":
                    PendataanDosen();
                    break;
                case "3":
                    universitas();
                    break;
                case "4":
                    Console.WriteLine("Anda Keluar dari aplikasi");
                    break;
                default:
                    Console.WriteLine("Harus Memilih Antara 1 - 3 !\n");
                    MenuUtama();
                    break;
            }
           
            
        }
       public static void PendataanMahasiswa()
        {
            string pilih,pilih2, NIKM;
            //DATA MAHASISWA
            Mahasiswa Alex = new Mahasiswa("A021", "Alex", "Wirianata", new DateTime(1990, 11, 23), "Jakarta", "Pria", 312008923111990002, new DateTime(2018, 4, 12))
            {
                Religion = Agama.Kristen,
                goldar = GolonganDarah.A
            };
            List<MataKuliah> mataKuliahAlex = new List<MataKuliah>()
            {
                new MataKuliah("Object Oriented Programming", "Programming", 20,new DateTime(2018,4,12),new DateTime(2018,9,12)),
                new MataKuliah("Data Structure ", "Programming", 30, new DateTime(2018, 7, 18), DateTime.Today)
            };

            Mahasiswa Desy = new Mahasiswa("A022", "Desy", "Oktaviani", new DateTime(1995, 5, 11), "Bandung", "Wanita", 312008911051995002, new DateTime(2018, 4, 1))
            {
                Religion = Agama.Islam,
                goldar = GolonganDarah.O

            };
            List<MataKuliah> mataKuliahDesy = new List<MataKuliah>()
            {
                new MataKuliah("Networking Fundamental", "Networking", 20,new DateTime(2018,4,1),DateTime.Today),
                new MataKuliah("Data Structure ", "Programming", 30, new DateTime(2018, 7, 18), DateTime.Today)
            };

            Mahasiswa Joko = new Mahasiswa("A023", "Joko", "Davidson", new DateTime(1990, 7, 7), "Jakarta", "Pria", 312008923111990002, new DateTime(2018, 4, 14))
            {
                Religion = Agama.Islam,
                goldar = GolonganDarah.A

            };
            List<MataKuliah> mataKuliahJoko = new List<MataKuliah>()
            {
                new MataKuliah("Unified Modelling Language","Management and Analysis", 40,new DateTime(2018,5,3),new DateTime(2018,11,1)),

            };
            

            Alex.setMataKuliah(mataKuliahAlex);
            Desy.setMataKuliah(mataKuliahDesy);
            Joko.setMataKuliah(mataKuliahJoko);

            List<Mahasiswa> groupMHS = new List<Mahasiswa>();
            groupMHS.Add(Alex);
            groupMHS.Add(Desy);
            groupMHS.Add(Joko);

            //MENU PELAJAR
            Console.WriteLine("\nData Mahasiswa");
            Console.WriteLine("================");
            
            foreach (Mahasiswa item in groupMHS)
            {
                item.PrintInfoMhs();
            }
            Console.WriteLine("\n1.Student Informatian");
            Console.WriteLine("2.Back to Main Menu");
            Console.WriteLine("3.Exit Application");
            Console.Write("Pilih nomor menu untuk masuk ke menu : ");        
            pilih = Console.ReadLine();
            switch (pilih)
            {
                case "1":
                    nikmhs:
                    Console.Write("Masukan nomor NIK yang anda ingin lihat informasinya : ");
                    NIKM = Console.ReadLine();
                    NIKM = NIKM.ToUpper();
                    bool validasi = false;
                    while (validasi == false)
                    {
                        foreach (Mahasiswa item in groupMHS)
                        {
                            if (NIKM == item.NIK)
                            {
                                validasi = true;
                            }
                        }
                        if (validasi == false)
                        {
                            Console.WriteLine("Nik yang anda masukan tidak sesuai !");
                            goto nikmhs;
                        }
                    }
                    foreach (Mahasiswa item in groupMHS)
                    {
                        if (NIKM == item.NIK)
                        {
                            int tahun = DateTime.Now.Year - item.tglMasukUniv.Year;
                            int bulan = DateTime.Now.Month - item.tglMasukUniv.Month;
                            int hari = DateTime.Now.Day - item.tglMasukUniv.Day;
                            if (bulan < 0)
                            {
                                bulan = bulan + 12;
                            }
                            if (hari < 0)
                            {
                                hari = hari + 30;
                            }
                            string durasi = string.Format("{0} Tahun, {1} Bulan, {2} Hari", tahun, bulan, hari);

                            int umur = DateTime.Now.Year - item.TglLahir.Year;
                            if (DateTime.Now.Month < item.TglLahir.Month)
                            {
                                if (DateTime.Now.Day < item.TglLahir.Day)
                                {
                                    umur = umur - 1;
                                }
                            }

                            Console.WriteLine("\nBiodata Mahasiswa !");
                            Console.WriteLine("---------------------");
                            Console.WriteLine("First Name : {0} \nLast Name : {1} \nGender : {2} \nBirth Information : {3} ({4} tahun) \nReligion : {5} \nBlood Type : {6} " +
                                "\nIDCard : {7} \nEntry Date : {8} Durasi({9})", item.NamaDepan, item.NamaBelakang, item.gender, item.TglLahir.ToString("dd MMMM yyyy"), umur, item.Religion, item.goldar, item.NoKTP, item.tglMasukUniv.ToString("dd MMMM yyyy"), durasi);
                            Console.WriteLine();

                            foreach (Mahasiswa item2 in groupMHS)
                            {
                                if (NIKM == item2.NIK)
                                {
                                    Console.WriteLine("Enrollment Information :");
                                    Console.WriteLine("------------------------");
                                    item2.PrintInfoMatkulMhs();
                                }
                            }


                        }


                    }
                  
                    Console.WriteLine("\n1.Back to All Student Data");
                    Console.WriteLine("2.Back to Main Menu");
                    Console.WriteLine("3.Exit Application");
                    Console.Write("Pilih nomor menu untuk masuk ke menunya : ");
                    pilih2 = Console.ReadLine();
                    switch (pilih2)
                    {
                        case "1":
                            PendataanMahasiswa();
                            break;
                        case "2":
                            MenuUtama();
                            break;
                        case "3":
                            Console.WriteLine("Anda keluar dari aplikasi !");
                            break;
                        default:
                            Console.WriteLine("Harus Memilih Antara 1 - 3 !");
                            break;
                    }
                    break;
                case "2":
                    MenuUtama();
                    break;
                case "3":
                    Console.WriteLine("Anda Keluar dari aplikasi");
                    break;
                default:
                    Console.WriteLine("Harus Memilih Antara 1 - 3 !");
                    PendataanMahasiswa();
                    break;
            }
        }

       public static void PendataanDosen()
        {
           
            string pilih,pilih2,nikd;

            //DATA DOSEN 
            Dosen Antik = new Dosen("T701", "Antik", "Haya", new DateTime(1988, 11, 12), "Jakarta", "Wanita", 312008912111988002, new DateTime(2016, 3, 18), 6500000)
            {
                Religion = Agama.Islam,
                goldar = GolonganDarah.A

            };
            List<MataKuliah> skillAntik = new List<MataKuliah>()
            {
                new MataKuliah("Infrastructure Design", "Networking"),
                new MataKuliah("Network Security", "Networking")
            };
       
            Dosen Cahya = new Dosen("T808", "Cahya", "Subroto", new DateTime(1989, 1, 7), "Surabaya", "Pria", 312008907011989002, new DateTime(2016, 4, 4), 8800000)
            {
                Religion = Agama.Islam,
                goldar = GolonganDarah.B

            };
            List<MataKuliah> skillCahya = new List<MataKuliah>()
            {
                new MataKuliah("Object Oriented Programming", "Programing"),
                new MataKuliah("Java Fundamental", "Programming"),
                new MataKuliah("Database Fundamental", "Programing")

            };

            List<Dosen> groupDosen = new List<Dosen>();
            groupDosen.Add(Antik);
            groupDosen.Add(Cahya);


            //Set Data
            Antik.setMataKuliah(skillAntik);
            Cahya.setMataKuliah(skillCahya);

            Console.WriteLine("\nData Dosen");
            Console.WriteLine("-----------");

            foreach (Dosen item in groupDosen)
            {
                item.PrintInfoDosen();
            }
            Console.WriteLine();
            Console.WriteLine("1.Tutor Information");
            Console.WriteLine("2.Back to Main Menu");
            Console.WriteLine("3.Exit Application");
            Console.Write("Pilih nomor menu untuk masuk ke menunya : ");
            pilih = Console.ReadLine();
            switch (pilih)
            {
                case "1":
                    nikdosen:
                    Console.Write("Masukan nomor NIK yang anda ingin lihat informasinya : ");
                    nikd = Console.ReadLine();
                    nikd = nikd.ToUpper();
                    bool validasi = false;
                    while (validasi == false)
                    {
                        foreach (Dosen item in groupDosen)
                        {
                            if (nikd == item.NIK)
                            {
                                validasi = true;
                            }
                        }
                        if (validasi == false)
                        {
                            Console.WriteLine("NIK Dosen yang anda masukan tidak sesuai !");
                            goto nikdosen;
                        }
                    }
                    foreach (Dosen item in groupDosen)
                    {
                        if (nikd == item.NIK)
                        {
                            //HITUNG DURASI KERJA
                            int tahun = DateTime.Now.Year - item.tglMasukKerja.Year;
                            int bulan = DateTime.Now.Month - item.tglMasukKerja.Month;
                            int hari = DateTime.Now.Day - item.tglMasukKerja.Day;
                            if (bulan < 0)
                                {
                                    bulan = bulan + 12;
                                }
                            if (hari < 0)
                                {
                                    hari = hari + 30;
                                }
                            string durasi = string.Format("{0} Tahun, {1} Bulan, {2} Hari", tahun, bulan, hari);

                            //HITUNG DURASI KERJA
                            int umur = DateTime.Now.Year - item.TglLahir.Year;
                            if (DateTime.Now.Month < item.TglLahir.Month)
                            {
                                if (DateTime.Now.Day < item.TglLahir.Day)
                                {
                                    umur = umur - 1;
                                }
                            }
                            //Menampilakan Biodata Dosen
                            Console.WriteLine("\nBiodata Dosen !");
                            Console.WriteLine("First Name : {0} \nLast Name : {1} \nGender : {2} \nBirth Information : {3} ({4} tahun) \nReligion : {5} \nBlood Type : {6} " +
                                "\nIDCard : {7} \nEntry Date : {8} Durasi({9}) \nGaji : {10}", item.NamaDepan, item.NamaBelakang, item.gender, item.TglLahir.ToString("dd MMMM yyyy"), umur, 
                                item.Religion, item.goldar, item.NoKTP, item.tglMasukKerja.ToString("dd MMMM yyyy"), durasi,item.gaji.ToString("C3"));
                            Console.WriteLine();
                           
                            foreach (Dosen item2 in groupDosen)
                            {
                                if (nikd == item2.NIK)
                                {
                                    Console.WriteLine("Competency Information :");
                                    Console.WriteLine("------------------------");
                                    item2.PrintInfoMatkulDosen();
                                }
                            }
                          
                        }
                    }
                    Console.WriteLine("\n1.Back to All Tutor Data");
                    Console.WriteLine("2.Back to Main Menu");
                    Console.WriteLine("3.Exit Application");
                    Console.Write("Pilih nomor menu untuk masuk ke menunya : ");
                    pilih2 = Console.ReadLine();
                    switch (pilih2)
                    {
                        case "1":
                            PendataanDosen();
                            break;
                        case "2":
                            MenuUtama();
                            break;
                        case "3":
                            Console.WriteLine("Anda keluar dari aplikasi !");
                            break;
                        default:
                            Console.WriteLine("Harus Memilih Antara 1 - 3 !\n");
                            break;
                    }
                    break;
                case "2":
                    MenuUtama();
                    break;
                case "3":
                    Console.WriteLine("Anda Telah Keluar Aplikasi");
                    break;
                default:
                    Console.WriteLine("Anda hanya bisa input 1-3 ");
                    PendataanDosen();
                    break;
            }


        }
       public static void universitas()
        {
            string pilih;
            Universitas unicorn = new Universitas("Unicorn (University of Cornfield)",new DateTime(1978,12,12),"Amerika Serikat, Southern State, di kota Texas.");

            Console.WriteLine("\nAbout Universitas !");
            Console.WriteLine("-------------------");
            unicorn.PrintInfoUniv();
            Console.Write("\nSilahkan pilih nomor antara 1 - 3 ");
            Console.WriteLine("\n1.Back to Main Menu");
            Console.WriteLine("2.Exit Application");
            univpilih:
            Console.Write("Pilih nomor menu untuk masuk ke menunya : ");
            pilih = Console.ReadLine();
            switch (pilih)
            {
                case "1":
                    MenuUtama();
                    break;
                case "2":
                    Console.WriteLine("Anda keluar dari aplikasi !");
                    break;
                default:
                    Console.WriteLine("Inputan tidak tepat silahkan pilih Antara 1 atau 2 !");
                    goto univpilih;
                    break;
            }
        }

    }
}


