//www.patika.dev
//C# 101 Algoritma Ödevi
//1)Bir konsol uygulamasında kullanıcıdan pozitif bir sayı girmesini isteyin(n). Sonrasında kullanıcıdan n adet pozitif sayı girmesini isteyin. Kullanıcının girmiş olduğu sayılardan çift olanlar console'a yazdırın

class Program
{
    static void Main(string[] args)
    { 
    Console.WriteLine ("Pozitif Bir Sayı Giriniz: ");
    int n=Convert.ToInt32(Console.ReadLine());
    Console.WriteLine (n+" adet pozitif tam sayı giriniz: ");
    int[] dizi = new int[n];
    int[] ciftSayi = new int[n];
      for (int i = 0; i < dizi.Length; i++)
        {
            dizi[i]=Convert.ToInt16(Console.ReadLine());
            if (dizi[i]%2==0)
            {
           Console.WriteLine ("Girilen Çift Sayılar: ");
           for (int j = 0; j < dizi.Length; j++) 
           ciftSayi[j]=dizi[i];            
            }
            else{
                continue;
            }
            for (int k = 0; k < dizi.Length; k++) 
             Console.Write (ciftSayi[k]);
        }
    
    }

}