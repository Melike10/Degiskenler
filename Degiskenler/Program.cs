// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz!");
Console.Write("T.C. Kimlik Numarası:"  );
// int değerinin değer aralığını geçtiği için string kullandım
string TcNo = Console.ReadLine();
Console.Write("\n Adı :");
string ad = Console.ReadLine();
Console.Write("\n Soyadı :");
string soyAd = Console.ReadLine();
// baştakı sıfır girlmezse 10 haneli yani int değeri içinde oluyor o yüzden int kullandım ve böylece 10 hane ile sınırladım.
Console.Write("\n Telefon :");
int phone = Convert.ToInt32(Console.ReadLine());
// byte kullandım yaş için çünkü bir insan ömrü  256'dan küçüktür.
Console.Write("\n Yaş :");
byte yas = Convert.ToByte(Console.ReadLine());
// para da bir kısıt görmediğim için canlı derste öğrendiğim paaralar için en iyi tip olan decimali kullandım. 
Console.Write("\n İlk Aldığı Ürünün Fiyatı :");
decimal f1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("\n İkinci Aldığı Ürünün Fiyatı :");
decimal f2 = Convert.ToDecimal(Console.ReadLine());
decimal toplam = f1 + f2;
decimal puan = toplam / 10;

Console.WriteLine($"{TcNo} Tc Numaralı {ad} {soyAd} isimli kişi için kayıt oluşturulmuştur.");

Console.WriteLine($"{phone} telefon numarasına bildirim gönderilmiştir.");

Console.WriteLine($"{toplam} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {puan} .");


