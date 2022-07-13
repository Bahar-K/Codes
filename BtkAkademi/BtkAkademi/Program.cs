using System;
using System.Collections;

namespace BtkAkademi
{
    public class Program
    {
        static void Main(string[] args)
        {
            //BTK akademi algoritma-programlama-ve-veri-yapilarina-giris videolarından
            //ArrayOrnekleri();
            //Hashtable();
            //HashtableUygulama();
            //SortedList();
            SortedListUygulama();

            Console.ReadKey();
        }

        private static void SortedListUygulama()
        {
            //SortedList uygulaması
            var kitapIcerigi = new SortedList();
            kitapIcerigi.Add(1, "Önsöz");
            kitapIcerigi.Add(23, "Operatörler");
            kitapIcerigi.Add(90, "Dönguler");
            kitapIcerigi.Add(44, "Degiskenler");
            kitapIcerigi.Add(40, "Iliskisel Operatörler");

            Console.WriteLine($"{"Konular",-32} {"Sayfalar",-5} ");
            foreach (DictionaryEntry kitap in kitapIcerigi)
            {
                Console.WriteLine($"{kitap.Value,-32} {kitap.Key,-5}");
            }
        }

        private static void SortedList()
        {
            //SortedList 
            //SortedList Hashtable dan farkı biz indexleri sıralamasak biler Sorted da sıralıyor
            //Tanımlama
            var list = new SortedList()
            {
                {1,"bir"},
                {5,"beş"},
                {32,"otuz iki"},
                {23,"yirmi üç"},
            };

            //Dolaşma
            // DictionaryEntry yerine var yazarsak Key değerine ulasamayacagız o yuzden oyle
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }

            //Erişme
            //Key ile
            Console.WriteLine(list[23]);
            //index ile
            Console.WriteLine(list.GetByIndex(3));
            // Get -> Key
            Console.WriteLine(list.GetKey(1));
            // Liste sonu elemanı alma
            Console.WriteLine(list.GetByIndex(list.Count - 1));

            var anahtarlar = list.Keys;
            Console.WriteLine("\nAnahtarlar");
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            var degerler = list.Values;
            Console.WriteLine("\nDegerler");
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\nGüncelleme");
            if (list.ContainsKey(23))
            {
                list[23] = "Twenty Three";
            }
            foreach (DictionaryEntry item in list)
            {
                Console.WriteLine($"{item.Key} - {item.Value}");
            }
        }

        private static void HashtableUygulama()
        {
            //Hashtable Uygulaması 
            // Türkçe karakterleri çevirme mantığı için kullanabileceğin kod with Hashtable
            //Başlıgı okuma
            Console.WriteLine("Başlığı Yazınız: ");
            string baslik = Console.ReadLine();

            //Kucultme yapıyoruz 
            baslik = baslik.ToLower();

            //Hashtable
            //Manipüle etmek istediğimiz karakterleri tanımlayacagz
            var karakterSeti = new Hashtable()
            {
                {'ç','c' },
                {'ı','i' },
                {'ğ','g' },
                {'ü','u' },
                {' ','-' },
                {'ö','o' },
            };

            foreach (DictionaryEntry item in karakterSeti)
            {
                //Replace bizde char türünde istiyor ama item.Key object o yuzden (char) ekledik
                baslik = baslik.Replace((char)item.Key, (char)item.Value);
            }
            Console.WriteLine(baslik);
        }

        private static void Hashtable()
        {
            // HASHTABLE
            //Tanımlama
            var sehirler = new Hashtable();

            //Ekleme
            sehirler.Add(6, "Ankara");
            sehirler.Add(34, "İstanbul");
            sehirler.Add(55, "Samsun");
            sehirler.Add(23, "Elazığ");

            //Dolaşma
            // DictionaryEntry yerine var yazarsak Key değerine ulasamayacagız o yuzden oyle
            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"{item.Value,-23}");
            }

            // Anahtarları alma
            Console.WriteLine("\nAnahtarlar (Keys)");
            var anahtarlar = sehirler.Keys;
            foreach (var item in anahtarlar)
            {
                Console.WriteLine(item);
            }

            // Değerleri alma
            Console.WriteLine("\nDeğerler (Values)");
            var degerler = sehirler.Values;
            // var degerler yerine Icollection degerler yazablrz
            // cunku tanımladıgımız degerler türü Icollection
            foreach (var item in degerler)
            {
                Console.WriteLine(item);
            }

            // Eleman Erişme
            Console.WriteLine("\nEleman Erişme");
            Console.WriteLine(sehirler[23]);

            //Eleman Silme
            Console.WriteLine("\nEleman silme");
            sehirler.Remove(55);

            foreach (DictionaryEntry item in sehirler)
            {
                Console.WriteLine($"{item.Key,-5}" +
                    $"{item.Value,-23}");
            }
        }

        private static void ArrayOrnekleri()
        {

            //Üç farklı şekilde array dizi oluşturma
            //Array | Dizi | Tanimlama
            int[] sayilar = new int[] { 1, 2, 3, 5 };
            var numbers = Array.CreateInstance(typeof(int), 4);
            var sayilar2 = new ArrayList(sayilar);

            sayilar.CopyTo(numbers, 0);
            Array.Clear(sayilar, 1, 2);
            numbers.SetValue(-1, 0);
            numbers.SetValue(-2, 1);
            numbers.SetValue(-3, 2);
            numbers.SetValue(-4, 3);

            //Array (Dizileri) sıralama
            Array.Sort(sayilar);
            Array.Sort(numbers);
            sayilar2.Sort();

            //sayılar dizisindeki 2 nin kaçıncı indexte old. yazacak
            //eger boyle bir deger yoksa -1 dondurur.
            int x = Array.IndexOf(sayilar, 5);
            Console.WriteLine(x);

            //Dolashma
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(
                    $"sayilar[{i}] = " +
                    $"{sayilar[i],3} " +
                    $"numbers[{i}] = " +
                    $"{numbers.GetValue(i),3} " +
                    $"sayilar2[{i}] = " +
                    $"{sayilar2[i]} ");
            }
        }
    }
}