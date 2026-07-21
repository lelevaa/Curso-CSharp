using System.Collections.Generic;
using ExercicioResolvidoLamdaLinq.Entities;
using System.IO;
using System.Globalization;
using System.Runtime.Intrinsics.X86;

Console.Write("Enter full file path: ");
string path = Console.ReadLine();

List<Products> list = new List<Products>();

//ler o arquivo
using(StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] fields = sr.ReadLine().Split(',');

        string name = fields[0];
        double price = double.Parse(fields[1], CultureInfo.InvariantCulture);

        list.Add(new Products(name, price));
    }
}
//lista de produtos => lista de double
var avg = list.Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Average price: " + avg.ToString("F2", CultureInfo.InvariantCulture));

//ordenar resposta com nome dos produtos
var names = list.Where(p => p.Price < avg).OrderByDescending(p => p.Name).Select(p => p.Name);
foreach(string name in names)
{
    Console.WriteLine(name);
}

