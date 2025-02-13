List<int> numbers = new List<int>();

Random rnd = new Random();

for (int i = 0; i < 10; i++)
{
    numbers.Add(rnd.Next(-10, 30));//Rastgele -10 ile 30 arasında 10 adet sayı üretildi.
}
Console.WriteLine("Rastgele Sayılardan Oluşan Liste:");
foreach(var num in numbers)
{
    Console.Write(num + ",");
}
Console.WriteLine("\n\nListedeki Çift Sayılar:");
foreach(var num in numbers.Where(x => x % 2 == 0))
{
    Console.Write(num+",");
}

Console.WriteLine("\n\nListedeki Tek Sayılar:");
foreach (var num in numbers.Where(x => x % 2 != 0))
{
    Console.Write(num + ",");
}

Console.WriteLine("\n\nListedeki Negatif Sayılar:");
foreach (var num in numbers.Where(x => x< 0))
{
    Console.Write(num + ",");
}

Console.WriteLine("\n\nListedeki Pozitif Sayılar:");
foreach (var num in numbers.Where(x => x > 0))
{
    Console.Write(num + ",");
}

Console.WriteLine("\n\nListedeki 15'ten büyük ve 22'den küçük sayılar:");
foreach (var num in numbers.Where(x => x > 15 & x<22))
{
    Console.Write(num + ",");
}

Console.WriteLine("\n\nListedeki her bir sayının karesi:");
foreach (var num in numbers.Select(x => x*x))
{
    Console.Write(num + ",");
}
