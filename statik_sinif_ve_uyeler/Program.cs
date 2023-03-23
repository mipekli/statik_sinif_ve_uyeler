class program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Çalışan Sayısı:   {0},",Calisan.CalisanSayisi);
        Calisan calisan = new Calisan("Ayşe","Yılmaz","İk");
        Console.WriteLine("Çalışan Sayısı:   {0},", Calisan.CalisanSayisi);
        Calisan calisan1 = new Calisan("Mert", "Demir", "Pazarlama");
        Calisan calisan2 = new Calisan("İsmet", "Gözdağı", "Satış");
        Console.WriteLine("Çalışan Sayısı:   {0},", Calisan.CalisanSayisi);

        Console.WriteLine("Toplama işlemi sonucu    :{0}", Islemler.Topla(100,200));
        Console.WriteLine("Çıkarma işlemi sonucu    :{0}", Islemler.Cıkar(400,50));

    }

}

class Calisan
{
    private static int calisanSayisi;

    public static int CalisanSayisi
    {
        get => calisanSayisi;
        set => calisanSayisi = value;
    }

    private string Isim;
    private string Soyisim;
    private string Depertman;

    static Calisan()
    {
        CalisanSayisi = 0;
    }
    public Calisan(string isim, string soyisim, string depetrman)
    {
        this.Isim = isim;
        this.Soyisim = soyisim;
        this.Depertman = depetrman; 
        calisanSayisi ++;
    }
   
}
static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cıkar(int sayi1, int sayi2)
    {
    return sayi1 - sayi2;
    }
}