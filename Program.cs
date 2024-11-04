using C_20241104;
using System.Text;

List<Versenyzo> versenyzok = [];

using StreamReader sr = new("..\\..\\..\\src\\forras.txt", Encoding.UTF8);
while (!sr.EndOfStream)
{
    versenyzok.Add(new(sr.ReadLine()));
}

Console.WriteLine($"Versenyzők száma: {versenyzok.Count()}");

//csopi 3

//var f1 = versenyzok.Count(v => v.Kategoria == "25-29");
//Console.WriteLine($"Versenyzők száma: {f1}");

//var f2 = versenyzok.Average(v => 2024 - v.Szulev);
//Console.WriteLine($"átlag: {f2}");

//var f3 = versenyzok.Sum(v => v.Idok["uszas"].TotalHours);
//Console.WriteLine($"teljes úszás idő: {Math.Round(f3,2)}");

//var f4 = versenyzok.Where(v => v.Kategoria == "elit").Average(v => v.Idok["uszas"].TotalMinutes);
//Console.WriteLine($"f4: {f4:0.00}");

//var f5 = versenyzok.Where(v => v.Nem).MinBy(v => v.Osszido);
//Console.WriteLine($"f5: {f5}");

//var f6 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(g => g.Key);
//foreach (var grp in f6)
//{
//    Console.WriteLine($"{grp.Key}: {grp.Count(),2}");
//}

//var f7 = versenyzok.GroupBy(v => v.Kategoria).ToDictionary(g => g.Key, g => g.Average(v => v.Idok["I depo"].TotalMinutes + v.Idok["II depo"].TotalMinutes)).OrderBy(kvp => kvp.Key);
//Console.WriteLine("Átlag depó idő kategoriánként");
//foreach (var kvp in f7)
//{
//    Console.WriteLine($"\t{kvp.Key}: {kvp.Value:0.00} perc");
//}

//csopi 1

//var f1 = versenyzok.Count(v => v.Kategoria == "elit");
//Console.WriteLine($"Versenyzők száma: {f1}");

//var f2 = versenyzok.Where(v => v.Nem == false).Average(v => 2024 - v.Szulev);
//Console.WriteLine($"átlag: {f2}");

//var f3 = versenyzok.Sum(v => v.Idok["kerekparozas"].TotalHours);
//Console.WriteLine($"teljes úszás idő: {Math.Round(f3,2)}");

//var f4 = versenyzok.Where(v => v.Kategoria == "elit junior").Average(v => v.Idok["uszas"].TotalMinutes);
//Console.WriteLine($"f4: {f4:0.00}");

//var f5 = versenyzok.Where(v => v.Nem == true).MinBy(v => v.Osszido);
//Console.WriteLine($"f5: {f5}");

//var f6 = versenyzok.GroupBy(v => v.Kategoria).OrderBy(g => g.Key);
//foreach (var grp in f6)
//{
//    Console.WriteLine($"{grp.Key}: {grp.Count(),2}");
//}

//csopi 2

//var f1 = versenyzok.Count(v => v.Kategoria == "elit junior");
//Console.WriteLine($"Versenyzők száma: {f1}");

//var f2 = versenyzok.Where(v => v.Nem == true).Average(v => 2024 - v.Szulev);
//Console.WriteLine($"átlag: {f2}");

//var f3 = versenyzok.Sum(v => v.Osszido/60/60);
//Console.WriteLine($"teljes úszás idő: {f3:0.00}");

//var f4 = versenyzok.Where(v => v.Kategoria == "20-24").Average(v => v.Idok["uszas"].TotalMinutes);
//Console.WriteLine($"f4: {f4:0.00}");

//var f5 = versenyzok.Where(v => v.Nem == false).MinBy(v => v.Osszido);
//Console.WriteLine($"f5: {f5}");

//var f6 = versenyzok.GroupBy(v => v.Nem).OrderBy(g => g.Key);
//foreach (var grp in f6)
//{
//    if (grp.Key == true)
//    {
//        Console.WriteLine($"Férfi: {grp.Count(),2}");
//    }
//    else if (grp.Key == false)
//    {
//        Console.WriteLine($"Nő: {grp.Count(),2}");
//    }
//}