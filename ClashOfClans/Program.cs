using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ClashOfClans
{
    class ClashOfClans
    {
        int altin;
        int iksir;
        int karaIksir;
        int[] askerSayisi = new int[3];
        int[] binalar = new int[3];
        int[] yukseltmeFiyatlari = new int[5];
        int[] yukseltmeGucleri = new int[5];
        int guc;
        bool savasKazanma = false;
        bool kaynakToplama = false;

        public ClashOfClans()
        {
            // Başlangıçta Verilecek Miktarlar
            altin = 10000;
            iksir = 10000;
            karaIksir = 1000;

            askerSayisi[0] = 100; // Barbar Sayısı
            askerSayisi[1] = 100; // Okçu Sayısı
            askerSayisi[2] = 50; // Büyücü Sayısı

            binalar[0] = 1; // Belediye Binası
            binalar[1] = 1; // Klan Binası
            binalar[2] = 1; // Kışla Binası

            yukseltmeFiyatlari[0] = 1000; // 1.Seviye Yükseltme Fiyatı
            yukseltmeFiyatlari[1] = 2000; // 2.Seviye Yükseltme Fiyatı
            yukseltmeFiyatlari[2] = 5000; // 3.Seviye Yükseltme Fiyatı
            yukseltmeFiyatlari[3] = 10000; // 4.Seviye Yükseltme Fiyatı
            yukseltmeFiyatlari[4] = 15000; // 5.Seviye Yükseltme Fiyatı

            yukseltmeGucleri[0] = 200; // 1.Seviye Yükseltme İle Kazanılacak Güç
            yukseltmeGucleri[1] = 500; // 2.Seviye Yükseltme İle Kazanılacak Güç
            yukseltmeGucleri[2] = 1000; // 3.Seviye Yükseltme İle Kazanılacak Güç
            yukseltmeGucleri[3] = 2000; // 4.Seviye Yükseltme İle Kazanılacak Güç
            yukseltmeGucleri[4] = 4000; // 5.Seviye Yükseltme İle Kazanılacak Güç
        }

        public void kaynakGoster()
        {
            Console.WriteLine("\n---------- Kaynak Miktarları ----------");
            Console.WriteLine("Altın Miktarı : " + altin);
            Console.WriteLine("İksir Miktarı : " + iksir);
            Console.WriteLine("Kara İksir Miktarı : " + karaIksir);
        }


        public void savasYap()
        {
            Random rnd = new Random();
            int galibiyet = rnd.Next(0, 2);

            int olenBarbarSayisi = rnd.Next(0, askerSayisi[0]);
            int olenOkcuSayisi = rnd.Next(0, askerSayisi[1]);
            int olenBuyucuSayisi = rnd.Next(0, askerSayisi[2]);

            int kazanilanIksir = rnd.Next(500, 10000);
            int kazanilanAltin = rnd.Next(500, 10000);
            int kazanilanKaraIksir = rnd.Next(250, 5000);

            int kKazanilanIksir = rnd.Next(250, 2500);
            int kKazanilanAltin = rnd.Next(250, 2500);
            int kKazanilanKaraIksir = rnd.Next(100, 1500);

            askerSayisi[0] -= olenBarbarSayisi;
            askerSayisi[1] -= olenOkcuSayisi;
            askerSayisi[2] -= olenBuyucuSayisi;

            kaynakToplama = true;

            Console.WriteLine("\n----------- Savaş Yap -----------");
            Console.WriteLine("Savaş Yapılıyor...");
            if (galibiyet == 1)
            {
                iksir += kazanilanIksir;
                altin += kazanilanAltin;
                karaIksir += kazanilanKaraIksir;
                savasKazanma = true;
                Console.WriteLine("Savaşı Kazandınız !\nArtık Daha Çok Kaynak Toplayabilirsiniz");
                askerGoster();
                kaynakGoster();

            }
            else
            {
                iksir += kKazanilanIksir;
                altin += kKazanilanAltin;
                karaIksir += kKazanilanKaraIksir;
                Console.WriteLine("Savaşı Kaybettiniz !\nDaha Çok Kaynak Toplamanız İçin Savaşı Kazanmalısınız");
                askerGoster();
                kaynakGoster();
            }
        }

        public void kaynakTopla()
        {
            Console.WriteLine("\n----------- Kaynak Toplama -----------");
            if (kaynakToplama == true)
            {
                if (savasKazanma == true)
                {
                    altin += 5000;
                    iksir += 5000;
                    karaIksir += 1000;
                    Console.WriteLine("Kaynak Toplandı !");
                    Console.WriteLine("Altın Miktarı : " + altin);
                    Console.WriteLine("İksir Miktarı : " + iksir);
                    Console.WriteLine("Kara İksir Miktarı : " + karaIksir);
                }
                else
                {
                    altin += 2000;
                    iksir += 2000;
                    karaIksir += 500;
                    Console.WriteLine("Kaynak Toplandı !");
                    Console.WriteLine("Altın Miktarı : " + altin);
                    Console.WriteLine("İksir Miktarı : " + iksir);
                    Console.WriteLine("Kara İksir Miktarı : " + karaIksir);
                    Console.WriteLine("Daha Çok Kaynak Toplamanız İçin Savaş Kazanmalısınız");
                }
                kaynakToplama = false;
            }

            else 
            {
                Console.WriteLine("Kaynak Toplamak İçin Savaş Yapmalısınız !");
            }
        }

        public void easterEgg()
        {
            altin = 787787787;
            iksir = 787787787;
            karaIksir = 787787787;

            askerSayisi[0] = 787787787;
            askerSayisi[1] = 787787787;
            askerSayisi[2] = 787787787;

            binalar[0] = 787787787;
            binalar[1] = 787787787;
            binalar[2] = 787787787;

            guc = 787787787;
        }

        public void askerGoster()
        {
            Console.WriteLine("\n----------- Asker Miktarları -----------");
            Console.WriteLine("Barbar Miktarı : " + askerSayisi[0]);
            Console.WriteLine("Okçu Miktarı : " + askerSayisi[1]);
            Console.WriteLine("Büyücü Miktarı : " + askerSayisi[2]);
        }

        public void gucGoster()
        {
            Console.WriteLine("\n----------------- Güç -----------------");
            Console.WriteLine("Köyünüzün Gücü : " + guc);
        }
        public void askerUret(byte tur, int askerMiktar)
        {
            Console.WriteLine("\n------------- Asker Üretme -------------");
            int gerekenMiktar;

            switch(tur)
            {
                case 1: // Barbar Üretme
                    gerekenMiktar = askerMiktar * 10; // Barbar Üretmek İçin Gereken İksir
                    if(iksir >= gerekenMiktar)
                    {
                        iksir -= gerekenMiktar;
                        askerSayisi[0] += askerMiktar;
                        Console.WriteLine($"{askerMiktar} Tane Barbar Üretildi.");
                        askerGoster();
                        kaynakGoster();
                        guc += askerMiktar*5;
                    }
                    else
                    {
                        Console.WriteLine($"İksiriniz Yetmiyor ,{gerekenMiktar - iksir} İksir Daha Lazım.");
                    }
                    break;

                case 2: // Okçu Üretme
                    gerekenMiktar = askerMiktar * 10; // Okçu Üretmek İçin Gereken İksir
                    if (iksir >= gerekenMiktar)
                    {
                        iksir -= gerekenMiktar;
                        askerSayisi[1] += askerMiktar;
                        Console.WriteLine($"{askerMiktar} Tane Okçu Üretildi.");
                        askerGoster();
                        kaynakGoster();
                        guc += askerMiktar * 5;
                    }
                    else
                    {
                        Console.WriteLine($"İksiriniz Yetmiyor ,{gerekenMiktar - iksir} İksir Daha Lazım.");
                    }
                    break;

                case 3: // Büyücü Üretme
                    gerekenMiktar = askerMiktar * 25; // Büyücü Üretmek İçin Gereken İksir
                    if (iksir >= gerekenMiktar)
                    {
                        iksir -= gerekenMiktar;
                        askerSayisi[2] += askerMiktar;
                        Console.WriteLine($"{askerMiktar} Tane Büyücü Üretildi.");
                        askerGoster();
                        kaynakGoster();
                        guc += askerMiktar * 10;
                    }
                    else
                    {
                        Console.WriteLine($"İksiriniz Yetmiyor , {gerekenMiktar - iksir} İksir Daha Lazım.");
                    }
                    break;

                default:
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız !");
                    break;
            }

        }


        public void binaSeviyesiGoster()
        {
            Console.WriteLine("\n----------- Bina Seviyeleri -----------");
            Console.WriteLine("Belediye Binası : " + binalar[0]);
            Console.WriteLine("Klan Binası : " + binalar[1]);
            Console.WriteLine("Kışa Binası : " + binalar[2]);
        }
        public void binaGelistir(byte tur)
        {
            Console.WriteLine("\n------------ Bina Geliştirme ------------");
            int gerekenMiktar;
            switch(tur)
            {
                case 1: // Belediye Binası
                    if (binalar[0] < 5)
                    {
                        gerekenMiktar = yukseltmeFiyatlari[binalar[0] - 1]; // Yükseltme Fiyatlarının İndexi 0'dan Başladığı İçin Bina Seviyesinin Değerini 1 Azaltıp Fiyatı Buluyoruz
                        if (altin >= gerekenMiktar)
                        {
                            altin -= gerekenMiktar;
                            binalar[0] += 1;
                            Console.WriteLine($"Belediye Binası Seviye Atladı. Yeni Seviye : {binalar[0]}");
                            guc += yukseltmeGucleri[binalar[0] - 1]; // İndex 0'dan Başladığı İçin Bina Seviyesini 1 Azaltıp Seviyeyi Buluyoruz.
                        }
                        else
                        {
                            Console.WriteLine($"Geliştirmek İçin Altın Yetmiyor. {gerekenMiktar - altin} Altın Gerekli");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Belediye Binanız Maksimum Seviyede");
                    }
                    break;


                case 2: // Klan Binası
                    if (binalar[1] < 5) // Maksimum Seviyeden Az İse Binayı Geliştir
                    {
                        gerekenMiktar = yukseltmeFiyatlari[binalar[1]]; // İndex 0'dan Başladığı İçin Bina Seviyesini 1 Azaltıp Seviyeyi Buluyoruz.
                        if (altin >= gerekenMiktar)
                        {
                            altin -= gerekenMiktar;
                            binalar[1] += 1;
                            Console.WriteLine($"Klan Binası Seviye Atladı. Yeni Seviye : {binalar[1]}");
                            guc += yukseltmeGucleri[binalar[1] - 1]; // İndex 0'dan Başladığı İçin Bina Seviyesini 1 Azaltıp Seviyeyi Buluyoruz.
                        }
                        else
                        {
                            Console.WriteLine($"Geliştirmek İçin Altın Yetmiyor. {gerekenMiktar - altin} Altın Gerekli");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Belediye Binanız Maksimum Seviyede");
                    }
                    break;

                case 3: // Kışla Binası
                    if (binalar[2] < 5) // Maksimum Seviyeden Az İse Binayı Geliştir
                    {
                        gerekenMiktar = yukseltmeFiyatlari[binalar[2]]; // İndex 0'dan Başladığı İçin Bina Seviyesini 1 Azaltıp Seviyeyi Buluyoruz.
                        if (altin >= gerekenMiktar)
                        {
                            altin -= gerekenMiktar;
                            binalar[2] += 1;
                            Console.WriteLine($"Kışla Binası Seviye Atladı. Yeni Seviye : {binalar[2]}");
                            guc += yukseltmeGucleri[binalar[2] - 1]; // İndex 0'dan Başladığı İçin Bina Seviyesini 1 Azaltıp Seviyeyi Buluyoruz.
                        }
                        else
                        {
                            Console.WriteLine($"Geliştirmek İçin Altın Yetmiyor. {gerekenMiktar - altin} Altın Gerekli");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Belediye Binanız Maksimum Seviyede");
                    }
                    break;

                default:
                    Console.WriteLine("Lütfen Doğru Seçim Yapınız !");
                    break;
            }
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            byte askerTuru = 0;
            int askerMiktar = 0;
            byte binaTur = 0;
            int secim;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Yellow;



            Console.Write("Adınızı Giriniz : ");
            string ad = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("(Not : Geçmek İçin Enter'a Basınız)");
            Console.WriteLine("Yaklaşma !");
            Console.ReadKey();
            Console.WriteLine("Kılık değiştirmiş bir goblini anında tanırım...");
            Console.ReadKey();
            Console.WriteLine("Herkesin kaynaklarımızı çalmasından bıktık.");
            Console.ReadKey();
            Console.WriteLine("Benimle dövüşmeden hiçbir şey alamazsın !!");
            Console.ReadKey();
            Console.WriteLine("Vay canına ! Bir gobline göre oldukça güçlüsün");
            Console.ReadKey();
            Console.WriteLine("Ama sen ... Goblin değilsin !");
            Console.ReadKey();
            Console.WriteLine("Ş...ŞEF?! Gerçekten sen misin ?");
            Console.ReadKey();
            Console.WriteLine("ŞÜKÜRLER OLSUN GERİ DÖNDÜN !!!");
            Console.ReadKey();
            Console.WriteLine("Seni goblin sandığım için özür dilerim , Şef.");
            Console.ReadKey();
            Console.WriteLine($"Köyüne Hoş Geldin {ad}");

            Thread.Sleep(1500);

            ClashOfClans p1 = new ClashOfClans();

            while(true)
            {
            menu:
                Console.Clear();
                Console.WriteLine("------------ Clash Of Clans ------------");
                Console.WriteLine("1 - Kaynakları Göster \n2 - Askerleri Göster \n3 - Köy Gücü Göster \n4 - Kaynak Topla \n5 - Asker Üret \n6 - Bina Geliştir \n7 - Savaş Yap \n8 - Bina Seviyelerini Göster");
                Console.Write("Seçim Yapınız : ");
                try
                {
                    secim = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                    Thread.Sleep(500);
                    goto menu;
                }

                switch (secim)
                {
                    case 1:
                        p1.kaynakGoster();
                        break;

                    case 2:
                        p1.askerGoster();
                        break;

                    case 3:
                        p1.gucGoster();
                        break;

                    case 4:
                        p1.kaynakTopla();
                        break;

                    case 5:
                        try
                        {
                            Console.Write("Asker Türü Seçiniz (1 - Barbar / 2 - Okçu / 3 - Büyücü) : ");
                            askerTuru = Convert.ToByte(Console.ReadLine());
                            if(askerTuru > 3)
                            {
                                Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                                Thread.Sleep(500);
                                goto menu;
                            }
                            Console.Write("Kaç Tane Asker Üretmek İstiyorsunuz ? : ");
                            askerMiktar = Convert.ToInt32(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                            Thread.Sleep(500);
                            goto menu;
                        }
                        p1.askerUret(askerTuru, askerMiktar);
                        break;

                    case 6:
                        try
                        {
                            Console.Write("Bina Türü Seçiniz (1 - Belediye / 2 - Klan / 3 - Kışla) : ");
                            binaTur = Convert.ToByte(Console.ReadLine());
                        }
                        catch
                        {
                            Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                            Thread.Sleep(500);
                            goto menu;
                        }
                        p1.binaGelistir(binaTur);
                        break;

                    case 7:
                        p1.savasYap();
                        break;

                    case 8:
                        p1.binaSeviyesiGoster();
                        break;

                    case 787:
                        Console.Write("Özel Geçiş Şifrsini Giriniz : ");
                        string sifre = Console.ReadLine();
                        if(sifre.ToLower() == "ahmetbaba52")
                        {
                            Console.Clear();
                            Console.WriteLine("Easter Egg Aktifleştirildi");
                            p1.easterEgg();
                        }
                        break;

                    default:
                        Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                        Thread.Sleep(500);
                        goto menu;
                }

                cikis:
                Console.WriteLine("\nDevam Etmek İçin C Tuşuna , Çıkış Yapmak İçin E Tuşuna BASINIZ");
                ConsoleKeyInfo cki = Console.ReadKey();
                if (char.ToLower(cki.KeyChar) == 'e')
                {
                    break;
                }
                else if (char.ToLower(cki.KeyChar) == 'c')
                {
                    goto menu;
                }
                else
                {
                    Console.WriteLine("Lütfen Doğru Şekilde Seçim Yapınız !");
                    goto cikis;
                }
            }
            
        }
    }
}
