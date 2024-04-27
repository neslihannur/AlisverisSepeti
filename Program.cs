namespace AlisverisSepeti
{
    internal class Program
    {
        static void Main(string[] args)

        {
            string[] urunler = [ "Limon", "Börek", "Karpuz ", "Kiraz", "Sabun", "Peynir", "Yumuşatıcı", "Şampuan", "Pirinç", "Mercimek" ];
            int[] fiyatlar = [10, 30, 110, 55, 50, 80, 90, 95, 130, 70 ];

            int toplamFiyat = 0;

            Console.WriteLine("Mevcut ürünlerimiz:");
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine($"{urunler[i]} - {fiyatlar[i]} TL");
            }

            Console.Write("Kaç adet ürün almak istiyorsunuz? ");
            int adet = int.Parse(Console.ReadLine());

            for (int i = 0; i < adet; i++)
            {
                Console.Write($"Almak istediğiniz ürün numarasını girin: ");
                int urunNum = int.Parse(Console.ReadLine());

                Console.Write($"Kaç adet {urunler[urunNum - 1]} almak istiyorsunuz? ");
                int alinanAdet = int.Parse(Console.ReadLine());

                toplamFiyat += fiyatlar[urunNum - 1] * alinanAdet;
            }

            Console.Write("Ödediğiniz tutarı girin: ");
            int odeme = int.Parse(Console.ReadLine());

            int paraUstu = odeme - toplamFiyat;

            Console.WriteLine("Aldığınız ürünler:");
            for (int i = 0; i < adet; i++)
            {
                Console.WriteLine($"{i + 1}. {urunler[i]} - {fiyatlar[i]} TL");
            }

            Console.WriteLine($"Toplam Tutar: {toplamFiyat} TL");
            Console.WriteLine($"Ödenen Tutar: {odeme} TL");
            Console.WriteLine($"Para Üstü: {paraUstu} TL");

            while (true)
            {
                Console.WriteLine("Sepete eklemek istediğiniz ürünün numarasını girin veya toplam fiyatı görmek için 't' tuşuna basın:");
                string girilenUrun = Console.ReadLine();

                if (girilenUrun == "t")
                {
                    Console.WriteLine($"Toplam Tutar: {toplamFiyat} TL");
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz numara. Lütfen geçerli ürün girin.");
                }
            }
        }
        }
    }

