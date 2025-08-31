namespace sayı_tahmin_oyunu_projesi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int sanslıSayı = random.Next(1, 101);
            int girilenTahmin = 0;
            int deneme = 1;
            do
            {
                Console.WriteLine($"{deneme}.hakkınız,Lütfen 1 ile 100 arasında sayı giriniz.");
                girilenTahmin = Convert.ToInt32(Console.ReadLine());
                if (girilenTahmin>sanslıSayı)
                {
                    Console.WriteLine("Daha küçük bir sayı giriniz.");
                }
                else if (girilenTahmin<sanslıSayı)
                {
                    Console.WriteLine("Daha büyük bir sayı giriniz.");
                }
                else
                {
                    Console.WriteLine($"Tebrikler {deneme}. denemede sayıyı buldunuz.");
                }
                if(deneme==6)
                {
                    Console.WriteLine($"Hakkınız doldu,aradığınız sayı:{sanslıSayı}");
                    Thread.Sleep(10000);
                    Console.WriteLine("Tekrar oynamak ister misiniz (E/H)?");
                    string cevap = Console.ReadLine().ToLower();
                    if (cevap == "e")
                    {
                        deneme = 0;
                        sanslıSayı = random.Next(1, 101);
                    }
                    else
                    {
                        Console.WriteLine("oyun için teşekkürler.");
                        break;
                    }
                }
                
            }
            while (girilenTahmin != sanslıSayı && deneme++<6);
        }
    }
}
