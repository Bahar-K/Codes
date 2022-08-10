using System;
using System.Collections;


namespace BtkAkademi
{
    public class Personel
    {
        public Personel(string name, int salary)
        {
            Name = name;
            
            Salary = salary;
        }

        public int No { get; set; }
        public string Name { get; set; }
        public int Salary { get; set; }
        public override string ToString()
        {
            return $"{Name,-10}{Salary,-10}";
        }
    }
    public class Program
    {

        static void Main(string[] args)
        {
            //BTK akademi algoritma-programlama-ve-veri-yapilarina-giris videolarından
            //ArrayOrnekleri();
            //Hashtable();
            //HashtableUygulama();
            //SortedList();
            //SortedListUygulama();
            //Stack();
            //QueueUygulama();
            //LinkedList();
            //Dictionary();
            //DictionaryUygulama();
            //SortedDictUygulama();
            //SortedSet();

            SortedSetUygulama();

            Console.ReadKey();
        }

        private static void SortedSetUygulama()
        {
            //SortedSet Uygulama
            // A kümesinde 4 tane random sayi var 
            var A = new SortedSet<int>(RastgeleSayiUret(4));
            // B kümesinde 6 tane random sayi var 
            var B = new SortedSet<int>(RastgeleSayiUret(6));

            #region yazdirma
            Console.WriteLine();
            Console.WriteLine("A kümesi");
            foreach (int item in A)
            {
                Console.WriteLine($"{item,5}");
            }
            Console.WriteLine();

            Console.WriteLine();
            Console.WriteLine("B kümesi");
            foreach (int item in B)
            {
                Console.WriteLine($"{item,5}");
            }
            #endregion

            //A.UnionWith(B); Union UnionWith (Birleşim)
            //A.IntersectWith(B); IntersectWith (Kesişim)
            //A.ExceptWith(B); Sadece A da olanlar A-B
            //A.SymmetricExceptWith(B); Kesişim dışındaki elemanlar

            A.UnionWith(B);
            //A.IntersectWith(B);
            //A.ExceptWith(B);
            //A.SymmetricExceptWith(B);

            Console.WriteLine();
            Console.WriteLine("\nA ve B Kümesinin Birleşimi");
            foreach (var item in A)
            {
                Console.WriteLine($"{item,5}");
            }
            Console.WriteLine();
            Console.WriteLine("A birleşim B toplam sayisi : {0}", A.Count);
            Console.WriteLine();
        }

        static List<int> RastgeleSayiUret(int n)
        {
            var list = new List<int>();
            var r = new Random();
            for (int i = 0; i < n; i++)
            {
                list.Add(r.Next(0,1023));
            }
            return list;
        }


        private static void SortedSet()
        {
            //SortedSet
            //Tanımlama
            //SortedSet yapısındaki elemanlar benzersiz olması gerekiyor.
            var liste = new SortedSet<string>();

            //Ekleme
            //liste.Add() yapısı bool değer donduruyor.
            liste.Add("Bahar");
            liste.Add("Mosh");
            liste.Add("Bosh");
            liste.Add("Hosh");

            if (liste.Add("Mosh"))
            {
                Console.WriteLine("Mosh eklendi");
            }
            else
            {
                Console.WriteLine("Mosh Listeye eklenmedi");
            }
            //Yukardaki if else yapısının farklı hali
            Console.WriteLine("{0}", liste.Add("Funda") == true ? "Funda eklendi" : "Ekleme basarısız");

            liste.Remove("Mosh");
            liste.RemoveWhere(deger => deger.StartsWith("H"));

            foreach (string item in liste)
            {
                Console.WriteLine($"Listedekiler {item}");
            }
        }

        private static void SortedDictUygulama()
        {
            //SortedDictionary

            var kitapIndeks = new Dictionary<string, List<int>>()
            {
                {"HTML",new List<int>() {2,3,6}},
                {"CSS", new List<int>() {4,5}},
                {"SQL", new List<int>() { 23,32,46} }
            };

            foreach (var item in kitapIndeks)
            {
                Console.WriteLine(item.Key);
                //Value lar list oldugu için boyle cağırıyoruz
                item.Value.ForEach(s => Console.WriteLine("\t >" + s));
            }
        }

        private static void DictionaryUygulama()
        {
            //DictionaryUygulama
            var personelListesi = new Dictionary<int, Personel>()
            {
                {100,new Personel("bhr",2300) },
                {101,new Personel("bosh",2320) },
                {102,new Personel("hosh",3200) },

            };
            foreach (var personel in personelListesi)
            {
                Console.WriteLine(personel);
            }
        }

        private static void Dictionary()
        {
            //Dictionary
            //Tanımlama
            var telefonKodlari = new Dictionary<int, string>()
            {
                {23,"bahar"},
                {32,"bosh" },
                {46,"hosh" }
            };

            //Erişme
            telefonKodlari[23] = "hosht";

            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }

            //ContainsKey
            if (!telefonKodlari.ContainsKey(12))
            {
                Console.WriteLine("\a12 nin kodu tanımlı değil.Tanımlanıyor");
                telefonKodlari.Add(12, "bruno");
            }

            //ContainValue
            if (!telefonKodlari.ContainsValue("image"))
            {
                Console.WriteLine("\aimage telefon kodu tanımlı değil. Tanımlanıyor.");
                telefonKodlari.Add(10, "image");
            }
            foreach (var item in telefonKodlari)
            {
                Console.WriteLine(item);
            }
        }

        private static void LinkedList()
        {
            //LinkedList<T> Temelleri
            //Tanımlama
            var sehirler = new LinkedList<string>();
            sehirler.AddFirst("Istanbul");
            sehirler.AddFirst("Ankara");
            sehirler.AddLast("Ardahan");

            sehirler.AddAfter(sehirler.Find("Istanbul"), "Adana");
            sehirler.AddBefore(sehirler.First.Next, "Hatay");
            sehirler.AddAfter(sehirler.Last.Previous, "Bursa");

            Console.WriteLine();
            Console.WriteLine("Gidiş Güzergahı");
            var eleman = sehirler.First;
            while (eleman != null)
            {
                Console.WriteLine(eleman.Value);
                eleman = eleman.Next;
            }

            Console.WriteLine();
            Console.WriteLine("Geliş Güzergahı");
            var gecici = sehirler.Last;
            while (gecici != null)
            {
                Console.WriteLine(gecici.Value);
                gecici = gecici.Previous;
            }
        }

        private static void QueueUygulama()
        {
            var sesliHarfler = new List<char>()
            {
                'a','e','ı','i','u','ü','o','ö'
            };

            // Klavyeyi dinliyoruz. seçim değişkenine atadık.
            ConsoleKeyInfo secim;
            var kuyruk = new Queue<char>();

            foreach (char karakter in sesliHarfler)
            {
                Console.WriteLine();
                Console.Write($"{karakter,-4} kuyruğa eklensin mi? [e/h]");
                Console.WriteLine();
                secim = Console.ReadKey();
                if (secim.Key == ConsoleKey.E)
                {
                    kuyruk.Enqueue(karakter);
                    Console.WriteLine($"\n{karakter,-4} kuyruğa eklendi.");
                    Console.WriteLine($"Kuyruktaki eleman sayisi {kuyruk.Count}");
                    Console.WriteLine();
                }
            }

            Console.WriteLine();
            Console.WriteLine("Kuyruktan eleman çıkarma işlemi için esc basınız.");
            secim = Console.ReadKey();
            Console.WriteLine();

            if (secim.Key == ConsoleKey.Escape)
            {
                Console.WriteLine();
                while (kuyruk.Count > 0)
                {
                    Console.WriteLine($"{kuyruk.Peek(),-3} kuyruktan çıkarılıyor");
                    Console.WriteLine($"{kuyruk.Dequeue(),-3} kuyruktan çıkarıldı.,");
                    Console.WriteLine($"kuyruktaki eleman sayısı {kuyruk.Count,-3}");
                }
                Console.WriteLine("Kuyruktan çıkarma işlemi tamamlandı.");
            }
            Console.WriteLine("Program bitti.");
        }

        private static void Stack()
        {
            var karakterYigini = new Stack<char>();
            for (int i = 65; i <= 90; i++)
            {
                karakterYigini.Push((char)i);
                Console.WriteLine($"{karakterYigini.Peek()} yıgına eklenen sayı.");
                Console.WriteLine($"Yigindaki eleman sayisi: {karakterYigini.Count}");
            }
            //Ek bilgi
            var dizi = karakterYigini.ToArray();
            Console.WriteLine("Yıgından çıkartma işlemi için bir tuşa basınız");
            Console.ReadKey();

            while (karakterYigini.Count > 0)
            {
                Console.WriteLine($"{karakterYigini.Pop()} yığından cıkarıldı");
                Console.WriteLine($"Yıgındaki eleman sayisi {karakterYigini.Count}");
            }
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
            //SortedList Hashtable dan farkı biz indexleri sıralamasak bile Sorted da sıralıyor
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
                //Replace bizde char türünden istiyor ama item.Key ise object. O yuzden (char) ekledik
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

            //sayılar dizisindeki 5 nin kaçıncı indexte old. yazacak
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