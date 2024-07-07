using System;
using System.Collections.Generic;

namespace Araba3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            String Secim = "";
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            List<Arac> KiralananAraclar = new List<Arac>();

            while (Secim != "0")
            {
                Console.WriteLine("<<<<<<<<<<<<<<<<<<<<<<<  ARAÇ KİRALAMA YAZILIMI  >>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>>");
                Console.ResetColor();

                Console.WriteLine("Hangi tür araç kiralanacağını seçiniz:\n\n");
                Console.WriteLine("1- Bisiklet\n");
                Console.WriteLine("2- Motorsiklet\n");
                Console.WriteLine("3- Araba\n");
                Console.WriteLine("4- Tekne\n");
                Console.WriteLine("5- Kiralanan Araçları Listele\n");
                Console.WriteLine("6- Gelirimi Listele\n");
                Console.WriteLine("\nSeçiminizi yapınız ...");
                Console.WriteLine("Programdan çıkma için 0'a basınız...");
                Secim = Console.ReadLine();
                string Marka = "";
                int UretimYil = 0;
                string Renk = "";
                string Vites = "";
                int KisiSayisi = 0;
                int MotorHacmi = 0;
                int BagajHacmi = 0;
                int Uzunluk = 0;

                int KiraUcreti = 0;
                int KiraSuresi = 0;
                switch (Secim)
                {
                    case "1":
                        Console.WriteLine("Marka Giriniz:");
                        Marka = Console.ReadLine();
                        Console.WriteLine("Üretim Yılı Giriniz:");
                        UretimYil = int.Parse(Console.ReadLine());
                        Console.WriteLine("Renk Giriniz:");
                        Renk = Console.ReadLine();
                        Console.WriteLine("Vites Giriniz(Otomatik için 0 Manuel için 1):");
                        Vites = Console.ReadLine();
                        if (Vites == "0")
                            Vites = "Otomatik";
                        else
                            Vites = "Manuel";
                        Console.WriteLine("Max Kişi Sayısını Giriniz:");
                        KisiSayisi = int.Parse(Console.ReadLine());

                        Console.WriteLine("Saatlik UcretGiriniz:");
                        KiraUcreti = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kaç Saat Kiralanacak:");
                        KiraSuresi = int.Parse(Console.ReadLine());

                        Bisiklet B = new Bisiklet(Marka, UretimYil, Renk, Vites, KisiSayisi);
                        B.Kirala(KiraUcreti, KiraSuresi);
                        KiralananAraclar.Add(B);
                        Console.WriteLine("Bisiklet başarılı bir şekilde kiralanmıştır");
                        break;
                    case "2":
                        Console.WriteLine("Marka Giriniz:");
                        Marka = Console.ReadLine();
                        Console.WriteLine("MotorHacmi Giriniz:");
                        MotorHacmi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Üretim Yılı Giriniz:");
                        UretimYil = int.Parse(Console.ReadLine());
                        Console.WriteLine("Renk Giriniz:");
                        Renk = Console.ReadLine();
                        Console.WriteLine("Vites Giriniz(Otomatik için 0 Manuel için 1):");
                        Vites = Console.ReadLine();
                        if (Vites == "0")
                            Vites = "Otomatik";
                        else
                            Vites = "Manuel";
                        Console.WriteLine("Max Kişi Sayısını Giriniz:");
                        KisiSayisi = int.Parse(Console.ReadLine());

                        Console.WriteLine("Saatlik UcretGiriniz:");
                        KiraUcreti = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kaç Saat Kiralanacak:");
                        KiraSuresi = int.Parse(Console.ReadLine());


                        Motorsiklet M = new Motorsiklet(Marka, MotorHacmi, UretimYil, Renk, Vites, KisiSayisi);
                        M.Kirala(KiraUcreti, KiraSuresi);
                        KiralananAraclar.Add(M);
                        Console.WriteLine("Motorsiklet başarılı bir şekilde kiralanmıştır");
                        break;
                    case "3":
                        Console.WriteLine("Marka Giriniz:");
                        Marka = Console.ReadLine();
                        Console.WriteLine("MotorHacmi Giriniz:");
                        MotorHacmi = int.Parse(Console.ReadLine());
                        Console.WriteLine("BagajHacmi Giriniz:");
                        BagajHacmi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Üretim Yılı Giriniz:");
                        UretimYil = int.Parse(Console.ReadLine());
                        Console.WriteLine("Renk Giriniz:");
                        Renk = Console.ReadLine();
                        Console.WriteLine("Vites Giriniz(Otomatik için 0 Manuel için 1):");
                        Vites = Console.ReadLine();
                        if (Vites == "0")
                            Vites = "Otomatik";
                        else
                            Vites = "Manuel";
                        Console.WriteLine("Max Kişi Sayısını Giriniz:");
                        KisiSayisi = int.Parse(Console.ReadLine());

                        Console.WriteLine("Günlük UcretGiriniz:");
                        KiraUcreti = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kaç Gün Kiralanacak:");
                        KiraSuresi = int.Parse(Console.ReadLine());

                        Araba A = new Araba(Marka, MotorHacmi, BagajHacmi, UretimYil, Renk, Vites, KisiSayisi);
                        A.Kirala(KiraUcreti, KiraSuresi);
                        KiralananAraclar.Add(A);
                        Console.WriteLine("Araba başarılı bir şekilde kiralanmıştır");
                        break;

                    case "4":
                        Console.WriteLine("Marka Giriniz:");
                        Marka = Console.ReadLine();
                        Console.WriteLine("MotorHacmi Giriniz:");
                        MotorHacmi = int.Parse(Console.ReadLine());
                        Console.WriteLine("Uzunluk Giriniz:");
                        Uzunluk = int.Parse(Console.ReadLine());
                        Console.WriteLine("Üretim Yılı Giriniz:");
                        UretimYil = int.Parse(Console.ReadLine());
                        Console.WriteLine("Renk Giriniz:");
                        Renk = Console.ReadLine();
                        Console.WriteLine("Vites Giriniz(Otomatik için 0 Manuel için 1):");
                        Vites = Console.ReadLine();
                        if (Vites == "0")
                            Vites = "Otomatik";
                        else
                            Vites = "Manuel";
                        Console.WriteLine("Max Kişi Sayısını Giriniz:");
                        KisiSayisi = int.Parse(Console.ReadLine());

                        Console.WriteLine("Haftalık Ucret Giriniz:");
                        KiraUcreti = int.Parse(Console.ReadLine());

                        Console.WriteLine("Kaç Hafta Kiralanacak:");
                        KiraSuresi = int.Parse(Console.ReadLine());

                        Tekne T = new Tekne(Marka, MotorHacmi, Uzunluk, UretimYil, Renk, Vites, KisiSayisi);
                        T.Kirala(KiraUcreti, KiraSuresi);
                        KiralananAraclar.Add(T);
                        Console.WriteLine("Tekne başarılı bir şekilde kiralanmıştır");
                        break;

                    case "5":
                        for (int i = 0; i < KiralananAraclar.Count; i++)
                        {
                            KiralananAraclar[i].AracBilgisiniGoster();
                        }
                        break;

                    case "6":
                        int Gelir = 0;
                        for (int i = 0; i < KiralananAraclar.Count; i++)
                        {
                            Gelir = Gelir + KiralananAraclar[i].GelirHesapla();
                        }
                        Console.WriteLine($"Toplam Şirke Kazancı : {Gelir}");
                        break;

                }

            }




        }
    }

    abstract class Arac
    {
        protected string Marka = "Tanımsız";
        protected int UretimYil = 0;
        protected string Renk = "Tanımsız";
        protected string Vites = "Tanımsız";//{Otomatik,Manuel}
        protected int KisiSayisi = 0;

        public Arac(string Marka, int UretimYil, string Renk, string Vites, int KisiSayisi)
        {
            this.Marka = Marka;
            this.UretimYil = UretimYil;
            this.Renk = Renk;
            this.Vites = Vites;
            this.KisiSayisi = KisiSayisi;

        }
        public virtual void AracBilgisiniGoster()
        {
            Console.WriteLine("----------------  Araç Bilgisi ------------------");
            Console.WriteLine($"Marka : {Marka} - Üretim Yılı : {UretimYil} - Renk : {Renk} - Vites : {Vites} - Kişi Sayısı : {KisiSayisi}");
            Console.WriteLine("----------------  Araç Bilgisi ------------------");
        }

        public abstract int GelirHesapla();


    }

    interface IKirala
    {
        void Kirala(int KiraUcreti, int KiraPeriyodu);
        void TeslimAl();

        int GelirHesapla();

    }

    class Bisiklet : Arac, IKirala
    {
        private int KiraUcreti = 0;
        private int KiraPeriyodu = 0;
        private string Durum = "Tanımsiz";
        public Bisiklet(string Marka, int UretimYil, string Renk, string Vites, int KisiSayisi) : base(Marka, UretimYil, Renk, Vites, KisiSayisi)
        {

        }

        public void Kirala(int KiraUcreti, int KiraPeriyodu)
        {
            this.KiraUcreti = KiraUcreti;
            this.KiraPeriyodu = KiraPeriyodu;

            if (Durum != "Kiralandı")
                Durum = "Kiralandı";
            else
                Console.WriteLine("Araç zaten kiralanmış durumda");
        }

        public void TeslimAl()
        {
            Durum = "Müsait";
        }

        public override int GelirHesapla()
        {
            return KiraUcreti * KiraPeriyodu;
        }
    }

    class Motorsiklet : Arac, IKirala
    {
        private int KiraUcreti = 0;
        private int KiraPeriyodu = 0;
        private string Durum = "Tanımsiz";
        private int MotorHacmi = 0;
        public Motorsiklet(string Marka, int MotorHacmi, int UretimYil, string Renk, string Vites, int KisiSayisi) : base(Marka, UretimYil, Renk, Vites, KisiSayisi)
        {
            this.MotorHacmi = MotorHacmi;
        }

        public void Kirala(int KiraUcreti, int KiraPeriyodu)
        {
            this.KiraUcreti = KiraUcreti;
            this.KiraPeriyodu = KiraPeriyodu;

            if (Durum != "Kiralandı")
                Durum = "Kiralandı";
            else
                Console.WriteLine("Araç zaten kiralanmış durumda");
        }

        public void TeslimAl()
        {
            Durum = "Müsait";
        }

        public override int GelirHesapla()
        {
            return KiraUcreti * KiraPeriyodu;
        }
    }

    class Araba : Arac, IKirala
    {
        private int KiraUcreti = 0;
        private int KiraPeriyodu = 0;
        private string Durum = "Tanımsiz";
        private int MotorHacmi = 0;
        private int BagajHacmi = 0;
        public Araba(string Marka, int MotorHacmi, int BagajHacmi, int UretimYil, string Renk, string Vites, int KisiSayisi) : base(Marka, UretimYil, Renk, Vites, KisiSayisi)
        {
            this.MotorHacmi = MotorHacmi;
            this.BagajHacmi = BagajHacmi;
        }

        public void Kirala(int KiraUcreti, int KiraPeriyodu)
        {
            this.KiraUcreti = KiraUcreti;
            this.KiraPeriyodu = KiraPeriyodu;

            if (Durum != "Kiralandı")
                Durum = "Kiralandı";
            else
                Console.WriteLine("Araç zaten kiralanmış durumda");
        }

        public void TeslimAl()
        {
            Durum = "Müsait";
        }

        public override int GelirHesapla()
        {
            return KiraUcreti * KiraPeriyodu;
        }
    }

    class Tekne : Arac, IKirala
    {
        private int KiraUcreti = 0;
        private int KiraPeriyodu = 0;
        private string Durum = "Tanımsiz";
        private int MotorHacmi = 0;
        private int Uzunluk = 0;
        public Tekne(string Marka, int MotorHacmi, int Uzunluk, int UretimYil, string Renk, string Vites, int KisiSayisi) : base(Marka, UretimYil, Renk, Vites, KisiSayisi)
        {
            this.MotorHacmi = MotorHacmi;
            this.Uzunluk = Uzunluk;
        }

        public void Kirala(int KiraUcreti, int KiraPeriyodu)
        {
            this.KiraUcreti = KiraUcreti;
            this.KiraPeriyodu = KiraPeriyodu;

            if (Durum != "Kiralandı")
                Durum = "Kiralandı";
            else
                Console.WriteLine("Araç zaten kiralanmış durumda");
        }

        public void TeslimAl()
        {
            Durum = "Müsait";
        }

        public override int GelirHesapla()
        {
            return KiraUcreti * KiraPeriyodu;
        }
    }
}   