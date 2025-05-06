// single responsibility principle
// soru: json, xml dosyalarından veri okuyan yapıları yazınız.

// kötü örnek
string DosyadanOku(string dosyaAdi)
{
    if (dosyaAdi.Contains("json"))
    {
        // json dosyasını oku
    }
    else if (dosyaAdi.Contains("xml"))
    {
        // xml dosyasını oku
    }
    else
    {
        throw new Exception("Dosya tipi desteklenmiyor");
    }

    return "";
}

// csv yi de ekle denildiğinde else if de eklenirse open closed a aykırı olmuş olacak. yani biz srp uygulamadığımız için başka bir prensibi de ezmiş oluyoruz.