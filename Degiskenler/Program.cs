// See https://aka.ms/new-console-template for more information
Console.WriteLine("Lütfen aşağıdaki bilgileri giriniz!");
Console.Write("T.C. Kimlik Numarası:"  );
// int değerinin değer aralığını geçtiği için double kullandım
double TcNo = Convert.ToDouble(Console.ReadLine());
Console.Write("\n Adı :");
string ad = Console.ReadLine();
Console.Write("\n Soyadı :");
string soyAd = Console.ReadLine();
// baştaki sıfır girilmese de 10 hane olduğu ve int sınırını geçtiği için double kullandım  .
Console.Write("\n Telefon :");
double phone = Convert.ToDouble(Console.ReadLine());
// byte kullandım yaş için çünkü bir insan ömrü  256'dan küçüktür.
Console.Write("\n Yaş :");
byte yas = Convert.ToByte(Console.ReadLine());
// para da bir kısıt görmediğim için (2 milyarı da geçebileceğini düşünerek) canlı derste öğrendiğim paralar için en iyi tip olan decimali kullandım. 
Console.Write("\n İlk Aldığı Ürünün Fiyatı :");
decimal f1 = Convert.ToDecimal(Console.ReadLine());
Console.Write("\n İkinci Aldığı Ürünün Fiyatı :");
decimal f2 = Convert.ToDecimal(Console.ReadLine());
decimal toplam = f1 + f2;
decimal puan = toplam / 10;

Console.WriteLine($"{TcNo} Tc Numaralı {ad} {soyAd} isimli kişi için kayıt oluşturulmuştur.");

Console.WriteLine($"{phone} telefon numarasına bildirim gönderilmiştir.");

Console.WriteLine($"{toplam} toplam harcama karşılığı kazanılan 10% patika puan miktarı -> {puan} .");


