class Program
{
    static void Main(string[] args)
    {
        Console.Write("Lütfen Ürün İsmini Giriniz : ");
        string urunIsmi = Console.ReadLine();

        Console.Write("Eklenecek Adet Miktarını Yazınız : ");
        string adetGirisi = Console.ReadLine();
        int adet = Convert.ToInt32(adetGirisi);

        Console.Write("Fiyatı Yazınız : ");
        string fiyatGirisi = Console.ReadLine();

        if (fiyatGirisi.Length == 0)
        {
            Ekle(urunIsmi, adet);
        }
        else
        {
            double fiyat = Convert.ToDouble(fiyatGirisi);
            Ekle(urunIsmi, adet, fiyat);
        }
    }

    static void Ekle(string urunIsmi, int adet)
    {
        Console.WriteLine($" {urunIsmi} Sepete Başarıyla Eklendi!");
        Console.WriteLine($"{adet} Adet {urunIsmi} Ürünü Sepete Eklendi!");
        Console.WriteLine("Fiyat belirtilmedi.");
    }

    static void Ekle(string urunIsmi, int adet, double fiyat)
    {
        Console.WriteLine($" {urunIsmi} Sepete Başarıyla Eklendi!");
        Console.WriteLine($"{adet} Adet {urunIsmi} Ürünü Sepete Eklendi!");
        double toplam = adet * fiyat;
        Console.WriteLine($"Toplam Tutar: {toplam} Türk Lirası. {urunIsmi} Siparişiniz Tamamlanmıştır. İyi Günler Dileriz!");
    }
}
