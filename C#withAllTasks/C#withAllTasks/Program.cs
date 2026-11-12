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
//Console.WriteLine("Eded daxil edin:");
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
//    if (daxilEdilenSifre.ToLower() == duzgunSifre.ToLower())
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

//Dersde yazilan tasklarin baslangici
#region Massivdeki ededlerin cemi ( foreach istifade olunur )
//int[] arrays = [3, 7, 2, 8];
//int sum = 0;
//foreach (var item in arrays)
//{
//    sum += item;
//}
//Console.WriteLine("Massivdeki ededlerin cemi: " + sum);
#endregion

#region Foreach ile massdivdeki ededlerin en cox tekrar olunan ededini tapmaq ve sayini gostermek
//int[] numbers = [ 1, 2, 3, 2, 4, 2, 5 ];
//int maxCount = 1;
//int maxNumber = 0;
//foreach (var item in numbers)
//{
//    int count = 0;
//    foreach (var item1 in numbers)
//    {
//        if (item1 == item)
//        {
//            count++;
//        }
//    }
//    if (count > maxCount)
//    {
//        maxCount = count;
//        maxNumber = item;
//    }
//}
//if (maxCount > 1)
//{
//    Console.WriteLine( maxNumber + " -> " + maxCount);
//}
//else
//{
//    Console.WriteLine("Tekrarlanan eded yoxdur.");
//}
#endregion

#region Kitab etiketini cap eden metod void ile yazilmasi
//string kitabAdi = Console.ReadLine()!;
//string kitabMuellifi = Console.ReadLine()!;

//PrintBookLabel(kitabAdi, kitabMuellifi);
//void PrintBookLabel(string ad, string muellif)
//{
//    Console.WriteLine("Kitabin adi: " + ad);
//    Console.WriteLine("Kitabin muellifi: " + muellif);
//}
#endregion

#region Kitab etiketini cap eden metod return ile yazilmasi
//string kitabAdi = Console.ReadLine()!;
//string kitabMuellifi = Console.ReadLine()!;

//string etiket = CreateBookLabel(kitabAdi, kitabMuellifi);
//Console.WriteLine(etiket);
//string CreateBookLabel(string ad, string muellif)
//{
//    return "Kitabin adi: " + ad + "\nKitabin muellifi: " + muellif;
//}
#endregion

#region Metod mehsulun qiymetini ve sayini qebul edir ve umumi meblegi qaytarir void ile yazilmasi
//int mehsulQiymeti = int.Parse(Console.ReadLine()!);
//int mehsulSayi = int.Parse(Console.ReadLine()!);
//PrintOrderTotal(mehsulQiymeti, mehsulSayi);
//void PrintOrderTotal(int qiymet, int say)
//{
//    int umumiMebleg = qiymet * say;
//    Console.WriteLine("Umumi mebleg: " + umumiMebleg);
//}
#endregion

#region Metod mehsulun qiymetini ve sayini qebul edir ve umumi meblegi qaytarir return ile yazilmasi
//int mehsulQiymeti = int.Parse(Console.ReadLine()!);
//int mehsulSayi = int.Parse(Console.ReadLine()!);
//int umumiMebleg = CalculateTotal(mehsulQiymeti, mehsulSayi);
//Console.WriteLine("Umumi mebleg: " + umumiMebleg);
//int CalculateTotal(int qiymet, int say)
//{
//    return qiymet * say;
//}
#endregion

#region Metod gun sayini ve her gun yigilan meblegi qebul edir dovr vasitesi ile umumi meblegi qaytarir. void ile yazilmasi
//int gunSayi = int.Parse(Console.ReadLine()!);
//int herGunYigilanMebleg = int.Parse(Console.ReadLine()!);
//PrintSavingsPlan(gunSayi, herGunYigilanMebleg);

//void PrintSavingsPlan(int gun, int mebleg)
//{
//    int umumiMebleg = 0;
//    for (int i = 1; i <= gun; i++)
//    {
//        umumiMebleg += mebleg;
//    }
//    Console.WriteLine("Umumi mebleg: " + umumiMebleg);
//}
#endregion

#region Metod gun sayini ve her gun yigilan meblegi qebul edir dovr vasitesi ile umumi meblegi qaytarir. return ile yazilmasi
//int gunSayi = int.Parse(Console.ReadLine()!);
//int herGunYigilanMebleg = int.Parse(Console.ReadLine()!);
//int umumiMebleg = CreateSavingsPlan(gunSayi, herGunYigilanMebleg);
//Console.WriteLine("Umumi mebleg: " + umumiMebleg);
//int CreateSavingsPlan(int gun, int mebleg)
//{
//    int total = 0;
//    for (int i = 1; i <= gun; i++)
//    {
//        total += mebleg;
//    }
//    return total;
//}
#endregion

#region Metod bir sifre qebul edir ve sifre en azi 8 simvoldan ibaretdirse ve icinde en azi 1 reqem varsa teleblere uygundur void ile yazilisi
//string sifre = Console.ReadLine()!;
//PrintPasswordResult(sifre);
//void PrintPasswordResult(string sifre)
//{
//    if (sifre.Length >= 8 && sifre.Any(char.IsDigit))
//    {
//        Console.WriteLine("Sifre teleblere uygundur.");
//    }
//    else
//    {
//        Console.WriteLine("Sifre teleblere uygun deyil.");
//    }
//}
#endregion

#region Metod bir sifre qebul edir ve sifre en azi 8 simvoldan ibaretdirse ve icinde en azi 1 reqem varsa teleblere uygundur return ile yazilisi
//string returnSifre = Console.ReadLine()!;
//string sifreQiymeti = isValidPassword(returnSifre);
//Console.WriteLine("Sifre qiymeti: " + sifreQiymeti);
//string isValidPassword(string sifre)
//{
//    string sifreStr = sifre.ToString();
//    if (sifreStr.Length >= 8 && sifreStr.Any(char.IsDigit))
//    {
//        return "Sifre teleblere uygundur.";
//    }
//    else
//    {
//        return "Sifre teleblere uygun deyil.";
//    }
//}
#endregion

#region Tamaşacilarin yaslarina gore bilet qiymetinin void ile hesablanmasi
//int[] tamashaciYaslariVoid = { 8, 12, 25, 65, 70 };
//PrintReceipt(tamashaciYaslariVoid);

//void PrintReceipt(int[] yaslar)
//{
//    decimal umumiMebleg = 0;

//    foreach (int yas in yaslar)
//    {
//        umumiMebleg += yas < 12 ? 4m : yas <= 64 ? 8m : 6m;
//    }

//    Console.WriteLine("Bilet sayi: " + yaslar.Length);
//    Console.WriteLine("Umumi mebleg: " + umumiMebleg + " AZN");
//}
#endregion

#region Tamaşacilarin yaslarina gore bilet qiymetinin return ile hesablanmasi
//int[] tamashaciYaslariReturn = { 8, 12, 25, 65, 70 };
//decimal qaytarilanMebleg = CalculateGroupTotal(tamashaciYaslariReturn);
//Console.WriteLine("Bilet sayi: " + tamashaciYaslariReturn.Length);
//Console.WriteLine("Qaytarilan umumi mebleg: " + qaytarilanMebleg + " AZN");

//decimal GetTicketPrice(int yas)
//{
//    return yas < 12 ? 4m : yas <= 64 ? 8m : 6m;
//}

//decimal CalculateGroupTotal(int[] yaslar)
//{
//    decimal umumiMebleg = 0;

//    foreach (int yas in yaslar)
//    {
//        umumiMebleg += GetTicketPrice(yas);
//    }

//    return umumiMebleg;
//}
#endregion

#region Metod en az 1 elementi olan bir int[] massivi qebul edir ededi orta tapilir void ile yazilisi
//int[] arrays = [5, 10, 15, 20, 25];
//PrintAvarage(arrays);

//void PrintAvarage(int[] arr)
//{
//    int sum = 0;
//    foreach (int item in arr)
//    {
//        sum += item;
//    }
//    double average = (double)sum / arr.Length; //type casting (tip çevirmə) demekdir
//    Console.WriteLine("Ededi orta: " + average);
//}
#endregion

#region Metod en az 1 elementi olan bir int[] massivi qebul edir ededi orta tapilir neticeni double kimi qaytaracaq return ile yazilisi
//int[] arrays = [5, 10, 15, 23, 25];
//double result = CalculateAvarage(arrays);
//Console.WriteLine(result);

//double CalculateAvarage(int[] arr)
//{
//    int sum = 0;
//    foreach (int item in arr)
//    {
//        sum += item;
//    }
//    double average = (double)sum / arr.Length; //type casting (tip çevirmə) demekdir
//    return average;
//}
#endregion

#region Metod int[] massivi qebul edir , neticede her menfi ededin yerine 0 qoyur void ile yazilisi
//int[] arrays = [-3, 5, -2, 8, -1];
//PrintWithNegativesreplaced(arrays);

//void PrintWithNegativesreplaced(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 0)
//        {
//            arr[i] = 0;
//        }
//    }
//    foreach (var item in arr)
//    {
//        Console.Write(item + " ");
//    }
//}
#endregion 

#region Metod int[] massivi qebul edir , neticede her menfi ededin yerine 0 qoyur return ile yazilisi
//int[] arrays = [-3, 5, -2, 8, -1];
//int[] result = ReplaceNegativesWithZero(arrays);
//foreach (var item in result)
//{
//    Console.Write(item + " ");
//}
//int[] ReplaceNegativesWithZero(int[] arr)
//{
//    for (int i = 0; i < arr.Length; i++)
//    {
//        if (arr[i] < 0)
//        {
//            arr[i] = 0;
//        }
//    }
//    int[] newArrays = new int[arr.Length];
//    for (int i = 0; i < arr.Length; i++)
//    {
//        newArrays[i] = arr[i];
//    }
//    return newArrays;
//}
#endregion

#region Metod en azi iki gunun temperaturunu saxlayan int[] massivi qebul edir ikinci gunden baslayaraq her gunun temperaturundan evvelki gunun temperatoru cixir void ile yazilisi 
//int[] temperators = [20, 25, 30, 28, 32];
//PrinttemperatureChanges(temperators);

//void PrinttemperatureChanges(int[] arr)
//{
//    for (int i = 1; i < arr.Length; i++)
//    {
//        int change = arr[i] - arr[i - 1];
//        Console.Write(change + " ");
//    }
//}
#endregion

#region Metod en azi iki gunun temperaturunu saxlayan int[] massivi qebul edir ikinci gunden baslayaraq her gunun temperaturundan evvelki gunun temperatoru cixir void ile yazilisi
int[] temperators = [20, 25, 30, 28, 32];
int[] result = GetTemperatureChanges(temperators);
foreach (var change in result)
{
    Console.Write(change + " ");
}

int[] GetTemperatureChanges(int[] arr)
{
    int[] changes = new int[arr.Length - 1];
    for (int i = 1; i < arr.Length; i++)
    {
        changes[i - 1] = arr[i] - arr[i - 1];
    }
    return changes;
}
#endregion

#region Musbet eded daxil edilir tam bolme qaliq dan istifade ederek reqemleri tersine duzun ve neticeni gosterin void ile yazilisi
//int musbetEded = int.Parse(Console.ReadLine()!);

//if (musbetEded <= 0)
//{
//    Console.WriteLine("Daxil edilen eded musbet olmalidir.");
//    return;
//}

//PrintReversedDigits(musbetEded);

//void PrintReversedDigits(int eded)
//{
//    int tersEded = 0;
//    while (eded > 0)
//    {
//        int sonReqem = eded % 10;
//        tersEded = tersEded * 10 + sonReqem;
//        eded /= 10;
//    }
//    Console.WriteLine("Tersine cevrilmis eded: " + tersEded);
//}
#endregion

#region Musbet eded daxil edilir tam bolme qaliq dan istifade ederek reqemleri tersine duzun ve neticeni gosterin return ile yazilisi
//int musbetEded = int.Parse(Console.ReadLine()!);
//if (musbetEded <= 0)
//{
//    Console.WriteLine("Daxil edilen eded musbet olmalidir.");
//    return;
//}

//int tersEded = PrintReversedDigits(musbetEded);
//Console.WriteLine("Tersine cevrilmis eded: " + tersEded);

//int PrintReversedDigits(int eded)
//{
//    int tersEded = 0;
//    while (eded > 0)
//    {
//        int sonReqem = eded % 10;
//        tersEded = tersEded * 10 + sonReqem;
//        eded /= 10;
//    }
//    return tersEded;
//}
#endregion

#region Fibonacci ardicilliginin ilk n ededinin return ile yazilisi void ile yazilisi: n=7 -> 0,1,1,2,3,5,8
//int n = int.Parse(Console.ReadLine()!);
//if (n <= 0)
//{
//    Console.WriteLine("Daxil edilen eded musbet olmalidir.");
//    return;
//}

//FibonacciEdedFind(n);

//void FibonacciEdedFind(int n)
//{
//    int evvelkiEded = 0;
//    int novbetiEded = 1;
//    int fibEded = 0;
//    for (int i = 1; i <= n; i++)
//    {
//        fibEded = evvelkiEded;
//        int novbetiFibonacciEdedi = evvelkiEded + novbetiEded;
//        evvelkiEded = novbetiEded;
//        novbetiEded = novbetiFibonacciEdedi;
//        Console.WriteLine("--------------------");
//        Console.WriteLine(fibEded);
//    }
//}
#endregion

#region Fibonacci ardicilliginin ilk n ededinin return ile yazilisi return ile yazilisi: n=7 -> 0,1,1,2,3,5,8
//int n = int.Parse(Console.ReadLine()!);
//if (n <= 0)
//{
//    Console.WriteLine("Daxil edilen eded musbet olmalidir.");
//    return;
//}

//int result = FibonacciEdedFind(n);
//Console.WriteLine(result);

//int FibonacciEdedFind(int n)
//{
//    int evvelkiEded = 0;
//    int novbetiEded = 1;
//    for (int i = 1; i <= n; i++)
//    {
//        Console.WriteLine(evvelkiEded);
//        Console.WriteLine("-------------");
//        int novbetiFibonacciEdedi = evvelkiEded + novbetiEded;
//        evvelkiEded = novbetiEded;
//        novbetiEded = novbetiFibonacciEdedi;
//    }
//    return 0;
//}
#endregion

