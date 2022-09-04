//www.patika.dev
//C# 101 Algoritma Ödevi
//1)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın
namespace AlgoritmaOdevi
{
   class Program
    {
      static void Main(string[] args)
      { 
         sorular soru=new sorular();
         //soru.ciftYazdir();
         //soru.tamBolen();
         //soru.kelimeYaz();
         soru.kelimeSay();
      }  
    }

    class sorular
    {       
      public void ciftYazdir()
      {
        Console.WriteLine ("Girilen Sayılardan Çif Olanları veren Program");
        Console.WriteLine ("Pozitif Bir Sayı Giriniz: ");
        int n=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine (n+" adet pozitif tam sayı giriniz: ");
        int[] dizi = new int[n];
        for (int i = 0; i < dizi.Length; i++)
        {
         dizi[i]=Convert.ToInt32(Console.ReadLine());
        }
        for (int j = 0; j < dizi.Length; j++)
        {
        if (dizi[j]%2==0)
        Console.WriteLine(dizi[j]);
        }
      }

//2)Bir konsol uygulamasında kullanıcıdan pozitif iki sayı girmesini isteyin (n, m). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan m'e eşit yada tam bölünenleri console'a yazdırın.
      public void tamBolen()
      {
        Console.WriteLine ("Tam Bölenleri Veren Program");
        Console.WriteLine ("Pozitif İki Sayı Giriniz: ");
        int n=Convert.ToInt32(Console.ReadLine());
        int m=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine (n+" Adet Pozitif Sayı Giriniz: ");
        int[] dizi2 = new int[n];
        for (int i=0; i<n; i++)
        {
          dizi2[i]=Convert.ToInt32(Console.ReadLine());
        }
        foreach (var item in dizi2)
        {
        if (item==m||item%m==0)
        Console.WriteLine(item);
        }
      }
//3) Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin (n). Sonrasında kullanıcıdan n adet kelime girmesi isteyin. Kullanıcının girişini yaptığı kelimeleri sondan başa doğru console'a yazdırın.
          public void kelimeYaz()
          {
            Console.WriteLine("Pozitif Bir Sayı Giriniz: ");
            int n= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(n+"Adet Kelime Giriniz: ");
            string[] dizi= new string[n];
            for (int i = 0; i < dizi.Length; i++)
            {
              dizi[i]=Console.ReadLine(); 
            }
            Array.Reverse(dizi);
            foreach (var item2 in dizi)
            {
              Console.WriteLine(item2);
            }
            
          }
//4) Bir konsol uygulamasında kullanıcıdan bir cümle yazması isteyin. Cümledeki toplam kelime ve harf sayısını console'a yazdırın
          public void kelimeSay()
          {
            Console.WriteLine("Bir Cümle Yazınız");
            string cumle= Console.ReadLine();
            string[] kelimeler= cumle.Split(' ');
            foreach (var item in kelimeler)
            {
              Console.WriteLine(item);
            }
          }
    }
 }


