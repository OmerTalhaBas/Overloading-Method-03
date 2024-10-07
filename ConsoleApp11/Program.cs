class Program
{
    static void Main(string[] args)
    {        
        Console.Write("Lütfen Ürün İsmini Giriniz : ");
        string urunIsmi = Console.ReadLine();

        Console.Write("Eklenecek Adet Miktarını Yazınız : ");
        string adetGirisi = Console.ReadLine();

        Console.Write("Fiyatı Yazınız : ");
        string fiyatGirisi = Console.ReadLine();

        Ekle(urunIsmi, adetGirisi, fiyatGirisi);
    }

    static void Ekle(string UrunIsmi, string AdetGirisi, string FiyatGirisi)
    {
        Console.WriteLine($" {UrunIsmi} Sepete Başarıyla Eklendi!");

        if (AdetGirisi.Length > 0)
        {
            int adet = Convert.ToInt32(AdetGirisi);
            Console.WriteLine($"{adet} Adet {UrunIsmi} Ürünü Sepete Eklendi.");

            if (FiyatGirisi.Length > 0)
            {
                double fiyat = Convert.ToDouble(FiyatGirisi);
                double toplam = adet * fiyat;
                Console.WriteLine($"Toplam Tutar : {toplam} Türk Lirası. {UrunIsmi} Siparişiniz Tamamlanmıştır. İyi Günler Dileriz!");
            }
        }
    }
}
