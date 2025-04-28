namespace butceTakipSistemi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int aySonuBakiyesi = 0;

        aySecimi:
            Console.Write("Hangi ay için işlem yapmak istiyorsunuz? (1-12): ");
             int ay = Convert.ToInt32(Console.ReadLine());

             if (ay < 1 || ay > 12)
            {
                Console.WriteLine("Geçersiz ay girdiniz. Tekrar deneyin.");
                goto aySecimi;
            }

             string ayAdi = "";

             if (ay == 1) ayAdi = "Ocak";
             else if (ay == 2) ayAdi = "Şubat";
             else if (ay == 3) ayAdi = "Mart";
             else if (ay == 4) ayAdi = "Nisan";
             else if (ay == 5) ayAdi = "Mayıs";
             else if (ay == 6) ayAdi = "Haziran";
             else if (ay == 7) ayAdi = "Temmuz";
             else if (ay == 8) ayAdi = "Ağustos";
             else if (ay == 9) ayAdi = "Eylül";
             else if (ay == 10) ayAdi = "Ekim";
             else if (ay == 11) ayAdi = "Kasım";
             else if (ay == 12) ayAdi = "Aralık";

            Console.WriteLine($"Seçilen ay: {ayAdi}");

        islemSecimi:
            Console.WriteLine("\nİşlem seçiniz:");
            Console.WriteLine("1 - Gelir ekle");
            Console.WriteLine("2 - Gider ekle");
            Console.WriteLine("3 - Bakiyeyi görüntüle");
            Console.Write("Seçiminiz: ");
            int secim = Convert.ToInt32(Console.ReadLine());

          
             if (secim == 1)
                  {
                Console.Write("Gelir tutarını giriniz: ");
                 int tutar = Convert.ToInt32(Console.ReadLine());
                 aySonuBakiyesi = aySonuBakiyesi + tutar;
                 goto islemSecimi;
                 }
                else if (secim == 2)
                      {
                Console.Write("Gider tutarını giriniz: ");
                 int tutar = Convert.ToInt32(Console.ReadLine());
                 aySonuBakiyesi = aySonuBakiyesi - tutar;
                 goto islemSecimi;
                        }
                  else if (secim == 3)
                           {
                Console.WriteLine($"{ayAdi} ayı sonu bakiyeniz: {aySonuBakiyesi} TL");
                  if (aySonuBakiyesi < 0)
                {
                     Console.WriteLine("Bu ay ödemeniz gereken borçlarınız var!");
                }
             }
             else
            {
                 Console.WriteLine("Hatalı seçim yaptınız, tekrar deneyin.");
                 goto islemSecimi;
             }
        }
    }
}
    

