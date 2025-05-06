// LISKOV SUBSTITUTION PRINCIPLE
// barbara liskov

using LSP;

Daire daire = new Daire() { Yaricap = 4 };
Silindir silindir = new Silindir() { Yaricap = 4, Yukseklik = 10 };

Console.WriteLine(Hesaplayici.Hesapla(daire));
Console.WriteLine(Hesaplayici.Hesapla(silindir));

// koniyi de eklemek istediğimizde silindirden kalıtım alarak hesapla metodunda 3e böldüğümüzde diğer class ları etkilememiş değiştirmek mecburiyetinde kalmamış oluyoruz.
