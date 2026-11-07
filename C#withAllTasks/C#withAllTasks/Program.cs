using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Hello, Nesir");

#region Ededlerin cemi
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int c = a + b;
//Console.WriteLine("Ededlerin cemi: " + c);
// Zaman murekkebliyi: O(1)
#endregion

#region Sahe ve Perimetrin tapilmasi
//int en = int.Parse(Console.ReadLine());
//int uzunluq = int.Parse(Console.ReadLine());
//int sahe = en * uzunluq;
//int perimetr = 2 * (en + uzunluq);
//Console.WriteLine("Sahe: " + sahe);
//Console.WriteLine("Perimetr: " + perimetr);
// Zaman murekkebliyi: O(1)
#endregion

#region Daxil edilen ededin reqemlerinin cemi
//int eded = int.Parse(Console.ReadLine());
//int cemi = 0;
//while (eded > 0)
//{
//    cemi += eded % 10;
//    eded /= 10;
//}
//Console.WriteLine("Reqemlerinin cemi: " + cemi);
// Zaman murekkebliyi: O(log n)
#endregion

#region Daxil edilen ededin hem 3 e hemde 7 e bolunub bolunmediyini tapmaq
//int eded = int.Parse(Console.ReadLine());
//if (eded % 3 == 0 && eded % 7 == 0)
//{
//    Console.WriteLine("Eded hem 3 e hemde 7 e bolunur.");
//}
//else
//{
//    Console.WriteLine("Eded hem 3 e hemde 7 e bolunmir.");
//}
// Zaman murekkebliyi: O(1)
#endregion

#region Iki eded daxil edilir bunlardan ikiside cut ededdirse cemini tapmaq
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int sum = 0;
//if (a % 2 == 0 && b % 2 == 0)
//{
//    sum = a + b;
//    Console.WriteLine("Iki eded de deqiqene bolunur. Cemi: " + sum);
//}
//else
//{
//    Console.WriteLine("Iki eded de cut eded olmalidi");
//}
// Zaman murekkebliyi: O(1)
#endregion

#region Daxil edilen ededlerin arasindaki tek ededlerin sayin tapmaq ( serhed ededleri daxildir )
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int count = 0;
//for (int i = a; i <= b; i++)
//{
//    if (i % 2 == 1)
//    {
//        count++;
//    }
//}
//Console.WriteLine("Tek ededlerin sayi: " + count);
// Zaman murekkebliyi: O(n)
#endregion

#region Daxil edilen ededin hem 2 ye hem 5 e bolunub bolunmediyini tapmaq
//int eded = int.Parse(Console.ReadLine());
//if (eded % 2 == 0 && eded % 5 == 0)
//{
//    Console.WriteLine("Eded hem 2 ye hem 5 e bolunur.");
//}
//else
//{
//    Console.WriteLine("Eded hem 2 ye hem 5 e bolunmur.");
//}
// Zaman murekkebliyi: O(1)
#endregion

#region Iki eded daxil edilir bunlarin ikiside tek ededdirse hasili tapilir. Eks halda ise "her iki eded tek deyil" yazilir.
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//if (a % 2 == 1 && b % 2 == 1)
//{
//    Console.WriteLine("Iki eded de tekdir. Hasili: " + (a * b));
//}
//else
//{
//    Console.WriteLine("Her iki eded tek deyil.");
//}
// Zaman murekkebliyi: O(1)
#endregion

#region Daxil edilen ededlerin arasindaki cut ededlerin cemini tapmaq ( serhed ededleri daxildir )
//int a = int.Parse(Console.ReadLine());
//int b = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = a; i <= b; i++)
//{
//    if (i % 2 == 0)
//    {
//        sum += i;
//    }
//}
//Console.WriteLine("Cut ededlerin cemi: " + sum);
// Zaman murekkebliyi: O(n)
#endregion

#region 1 - Alis-verisde pulun catmasi
//decimal mehsulQiymeti = decimal.Parse(Console.ReadLine()!);
//decimal verilenPul = decimal.Parse(Console.ReadLine()!);
//if (verilenPul >= mehsulQiymeti)
//{
//    Console.WriteLine("Qaytarilacaq mebleg: " + (verilenPul - mehsulQiymeti));
//}
//else
//{
//    Console.WriteLine("Eksik mebleg: " + (mehsulQiymeti - verilenPul));
//}
// Zaman murekkebliyi: O(1)
#endregion

#region 2 - Kinoya bilet qiymetinin yasdan asili hesablanmasi
//int yas = int.Parse(Console.ReadLine()!);
//int biletQiymeti = yas < 12 ? 5 : 8;
//Console.WriteLine("Biletin qiymeti: " + biletQiymeti + " manat");
// Zaman murekkebliyi: O(1)
#endregion

#region 3 - Imtahan neticesinin kecid balina gore yoxlanilmasi
//int bal = int.Parse(Console.ReadLine()!);
//if (bal >= 51)
//{
//    Console.WriteLine("Kecdi");
//}
//else
//{
//    Console.WriteLine("Kesildi");
//}
// Zaman murekkebliyi: O(1)
#endregion

#region 4 - Sifaris meblegine gore pulsuz catdirilmanin hesablanmasi
//decimal sifarisMeblegi = decimal.Parse(Console.ReadLine()!);
//decimal catdirilmaMeblegi = sifarisMeblegi >= 50 ? 0 : 5;
//decimal yekunMebleg = sifarisMeblegi + catdirilmaMeblegi;
//Console.WriteLine("Yekun mebleg: " + yekunMebleg + " manat");
// Zaman murekkebliyi: O(1)
#endregion

#region 5 - Ededin musbet, menfi ve ya sifir olmasinin yoxlanilmasi
//int eded = int.Parse(Console.ReadLine()!);
//if (eded > 0)
//{
//    Console.WriteLine("Musbet ededdir.");
//}
//else if (eded < 0)
//{
//    Console.WriteLine("Menfi ededdir.");
//}
//else
//{
//    Console.WriteLine("Sifirdir.");
//}
// Zaman murekkebliyi: O(1)
#endregion

#region 6 - 1-den n-e qeder ardicil ededlerin ekrana yazdirilmasi
//int n = int.Parse(Console.ReadLine()!);
//for (int i = 1; i <= n; i++)
//{
//    Console.Write(i + " ");
//}
// Zaman murekkebliyi: O(n)
#endregion

#region 7 - 1-den n-e qeder ededlerin ceminin hesablanmasi
//int n = int.Parse(Console.ReadLine()!);
//int cemi = 0;
//for (int i = 1; i <= n; i++)
//{
//    cemi += i;
//}
//Console.WriteLine("Ededlerin cemi: " + cemi);
// Zaman murekkebliyi: O(n)
#endregion

#region 8 - Verilmis ededin 1-den 10-a qeder vurma cedveli
//int eded = int.Parse(Console.ReadLine()!);
//for (int i = 1; i <= 10; i++)
//{
//    Console.WriteLine(eded + " x " + i + " = " + (eded * i));
//}
// Zaman murekkebliyi: O(1)
#endregion

#region 9 - Heftelik kitab oxusunun umumi sehife sayinin hesablanmasi
//int heftelikSehifeCemi = 0;
//for (int gun = 1; gun <= 7; gun++)
//{
//    int sehifeSayi = int.Parse(Console.ReadLine()!);
//    heftelikSehifeCemi += sehifeSayi;
//}
//Console.WriteLine("Heftelik oxunan sehifelerin cemi: " + heftelikSehifeCemi);
// Zaman murekkebliyi: O(1)
#endregion

#region 10 - n-den 1-e qeder geri sayimin ekrana yazdirilmasi
//int n = int.Parse(Console.ReadLine()!);
//for (int i = n; i >= 1; i--)
//{
//    Console.Write(i + " ");
//}
// Zaman murekkebliyi: O(n)
#endregion

#region 11 - Sinifdaki kecen ve kesilen telebelerin sayinin hesablanmasi
//int telebeSayi = int.Parse(Console.ReadLine()!);
//int kecenTelebeSayi = 0;
//int kesilenTelebeSayi = 0;
//for (int i = 1; i <= telebeSayi; i++)
//{
//    int bal = int.Parse(Console.ReadLine()!);
//    if (bal >= 51)
//    {
//        kecenTelebeSayi++;
//    }
//    else
//    {
//        kesilenTelebeSayi++;
//    }
//}
//Console.WriteLine("Kecen telebelerin sayi: " + kecenTelebeSayi);
//Console.WriteLine("Kesilen telebelerin sayi: " + kesilenTelebeSayi);
// Zaman murekkebliyi: O(n)
#endregion

#region 12 - Daxil edilen musbet ededlerin ceminin hesablanmasi
//int ededSayi = int.Parse(Console.ReadLine()!);
//int musbetEdedlerinCemi = 0;
//for (int i = 1; i <= ededSayi; i++)
//{
//    int eded = int.Parse(Console.ReadLine()!);
//    if (eded > 0)
//    {
//        musbetEdedlerinCemi += eded;
//    }
//}
//Console.WriteLine("Musbet ededlerin cemi: " + musbetEdedlerinCemi);
// Zaman murekkebliyi: O(n)
#endregion

#region 13 - Musbet tam ededin reqemlerini tersine cevirme
//int eded = int.Parse(Console.ReadLine()!);
//int tersEded = 0;
//while (eded > 0)
//{
//    int sonReqem = eded % 10;
//    tersEded = tersEded * 10 + sonReqem;
//    eded /= 10;
//}
//Console.WriteLine("Tersine cevrilmis eded: " + tersEded);
// Zaman murekkebliyi: O(log n)
#endregion

#region 14 - Fibonacci ardicilliginin ilk n ededinin yazdirilmasi
//int n = int.Parse(Console.ReadLine()!);
//int evvelkiEded = 0;
//int novbetiEded = 1;
//for (int i = 1; i <= n; i++)
//{
//    Console.Write(evvelkiEded + " ");
//    int novbetiFibonacciEdedi = evvelkiEded + novbetiEded;
//    evvelkiEded = novbetiEded;
//    novbetiEded = novbetiFibonacciEdedi;
//}
// Zaman murekkebliyi: O(n)
#endregion

#region 15 - Daxil edilen ededler arasinda en boyuk qiymetin tapilmasi
//int n = int.Parse(Console.ReadLine()!);
//int enBoyukEded = int.Parse(Console.ReadLine()!);
//for (int i = 2; i <= n; i++)
//{
//    int eded = int.Parse(Console.ReadLine()!);
//    if (eded > enBoyukEded)
//    {
//        enBoyukEded = eded;
//    }
//}
//Console.WriteLine("En boyuk eded: " + enBoyukEded);
// Zaman murekkebliyi: O(n)
#endregion

#region 16 - Cem 100-e catana qeder musbet ededlerin qebulu
//int cem = 0;
//int qebulEdilenEdedlerinSayi = 0;
//while (cem < 100)
//{
//    int eded = int.Parse(Console.ReadLine()!);
//    if (eded > 0)
//    {
//        cem += eded;
//        qebulEdilenEdedlerinSayi++;
//    }
//}
//Console.WriteLine("Yekun cem: " + cem);
//Console.WriteLine("Qebul edilen ededlerin sayi: " + qebulEdilenEdedlerinSayi);
// Zaman murekkebliyi: O(n)
#endregion

#region 17 - Sifre ucun maksimum uc giris cehdinin yoxlanilmasi
//const string duzgunSifre = "Code123";
//bool sifreDuzgundur = false;
//for (int cehd = 1; cehd <= 3; cehd++)
//{
//    string daxilEdilenSifre = Console.ReadLine()!;
//    if (daxilEdilenSifre == duzgunSifre)
//    {
//        Console.WriteLine("Giris ugurludur");
//        sifreDuzgundur = true;
//        break;
//    }
//}
//if (!sifreDuzgundur)
//{
//    Console.WriteLine("Giris bloklandi");
//}
// Zaman murekkebliyi: O(1)
#endregion