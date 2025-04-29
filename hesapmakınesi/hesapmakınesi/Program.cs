
        double sayi1, sayi2, sonuc;
        string islem, devam;

        do
        {
            Console.WriteLine("Birinci sayıyı girin: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı girin: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Yapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1 - Toplama");
            Console.WriteLine("2 - Çıkarma");
            Console.WriteLine("3 - Çarpma");
            Console.WriteLine("4 - Bölme");
            Console.WriteLine("5 - Çıkış");
            Console.Write("Seçiminizi girin (1/2/3/4/5): ");
            islem = Console.ReadLine();

            if (islem == "1")
            {
                sonuc = sayi1 + sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "2")
            {
                sonuc = sayi1 - sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "3")
            {
                sonuc = sayi1 * sayi2;
                Console.WriteLine("Sonuç: " + sonuc);
            }
            else if (islem == "4")
            {
                if (sayi2 != 0)
                {
                    sonuc = sayi1 / sayi2;
                    Console.WriteLine("Sonuç: " + sonuc);
                }
                else
                {
                    Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
                }
            }
            else if (islem == "5")
            {
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim!");
            }

            Console.Write("Başka bir işlem yapmak ister misiniz? (E/H): ");
            devam = Console.ReadLine().ToUpper();

        } while (devam == "E");

        Console.WriteLine("Programdan çıkılıyor...");
        Console.ReadKey();
Console.WriteLine("salih alan");