// open extension closed modification
// srp deki soruyu da burada çözebiliriz.

using OCP;

JsonDosya jsonDosya = new JsonDosya();

XmlDosya xmlDosya = new XmlDosya();

Console.WriteLine(jsonDosya.Oku());
Console.WriteLine(xmlDosya.Oku());
