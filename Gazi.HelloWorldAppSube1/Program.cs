using System;

namespace Gazi.HelloWorldAppSube1
{
    internal class Program
    {
        static int sayi = 5;
        static void Main(string[] args)
        {

            //Değişkenler-Veri Yapıları

            //Console.WriteLine("Gazi");
            //Console.WriteLine("Üniversitesi");

            //byte a;//Veri tipi:byte, ismi a
            //byte b;
            //a = 10;//a değişkenine değer ataması.
            //b = 20;

            //byte c = 30;

            //byte a = 30, b;
            //b = 40;

            //a = 50;

            //const int number = 50;

            //byte yas;
            //Console.WriteLine(yas);//Değeri olmayan değişkenler
            //hiç bir işlemde kullanılamaz

            //byte a = 10, b = 30, c;
            //c = a * b;

            //Console.WriteLine(c);

            //float sayi = 3.15f;

            //var sayi = 5.25D;//Implicit (Veri tipinin açık belirtilmediği durum)
            //double number = 5.25;//Explicit (Veri tipinin açıkca belirtildiği durum)

            char c = 'B';


            string isim = "Ahmet";
            string soyad = "Mehmet";

            Console.ReadKey();
        }
    }
}

//Bu bir açıklama satırıdır.
//Namespace:İçinde classları bulunduran yapılardır.
//{} Scope(Blok) yapılarıdır
//Class:İçinde metodları bulunduran yapılardır.(Bu tanım şimdilik yaptığımız bir tanımdır, ilerleyen konularda bu konu detaylandıracağız)
//Metod: İş yapan kod bloklarına metod denir.
//Main metodu: Console uygulamalarının giriş noktasıdır. Her console uygulaması, main metodu ile başlar.
//Ctrl+F5: Hata ayıklama modu olmadan programı çalıştırır.
//Syntax: Programlama dilleri yazım kuralları

//C# Syntax: 
//1- Açılan parantezler mutlaka kapatılmalıdır.
//2- Scope tanımlamalarının sonunda ; bulunmaz.
//3- Satırların sonunda ; bulunur.
//4- Metodların sonunda mutlaka () bulunur.

//Syntax hatası olursa, program derlenmez. Dolayısıyla çalışmaz. VS hata olan yerin altını kırmızı çizgi ile işaretler. Bununla birlikte, scroolbarda'da kırmızı bir işaretle hatanın yerini bildirir.
//VS penceresinin altı kısmında da kırmızı bir çarpı işareti, yanında da kaç hata mesajı oldugu yazılır.

//IntelliSense: Kod yazarken yardımcı olan, açılan pencere.
//IntelliCode: Yapay Zeka destekli kod yazım yardımcısı.

//Solution Explorer: Solution'ınımız içindeki projelere ulaşabileceğimiz penceredir. View menusu aracılığı ile açılabilir.

//Solution: Bir yada birden fazla proje içerebilirler.

//Ctrl+K+C : Açıklama satırı
//Ctrl+K+U : Normal satıra geri dönüş
//Ctrl+K+D : Kod hiyerarşisini düzeltmek için kullanılır.

//C#->Derleme->MS-IL->Derleme(.NET Runtime)-> 0-1(Binary)

//MS-IL: Microsoft Intermediate Language
//1 bit = 0 veya 1
//8 bit = 1 byte
//1 Kilo Byte(KB) = 1024byte
//1 Mega Byte (MB) = 1024KB
//1 Giga Byte (GB) = 1024MB
//1 Tera Byte (TB) = 1024GB