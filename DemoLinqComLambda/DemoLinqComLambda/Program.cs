using DemoLinqComLambda.Entities;
using System.Collections.Generic;
using System.Linq;

Category c1 = new Category() { Id =  1 , Name = "Tools", Tier = 2};
Category c2 = new Category() { Id =  2 , Name = "Computers", Tier = 1};
Category c3 = new Category() { Id =  3 , Name = "Eletronics", Tier = 1};

List<Product> products = new List<Product>()
{
    new Product() {Id = 1 , Name = "Computer", Price = 1100.0, Category = c2},
    new Product() {Id = 2 , Name = "Hammer", Price = 90.0, Category = c1},
    new Product() {Id = 3 , Name = "TV", Price = 1700.0, Category = c3},
    new Product() {Id = 4 , Name = "Notebook", Price = 800, Category = c2},
};

//LINQ
var r1 = products.Where(p => p.Category.Tier == 1 && p.Price < 900.0);

//Execute:
static void Print<T>(string message,IEnumerable<T> collection)
{
    Console.WriteLine(message);
    foreach(T obj in collection)
    {
        Console.WriteLine(obj);
    }
    Console.WriteLine();
}

//Print("TIER 1 AND PRICE < 900: ", r1);

var r2 = products.Where(p => p.Category.Name == "Tools").Select(p => p.Name);
//Print("NAME OF PRODUCTS FROM TOOLS ", r2);

//trazer só alguns atributos
var r3 = products.Where(p => p.Name[0] == 'C').Select(p=>new {p.Name,p.Price,CategoryName = p.Category.Name});
//Print("NAMES STARTED WITH 'C' AND ANONYMPUS OBJECT", r3);

//
var r4 = products.Where(p => p.Category.Tier == 1).OrderBy(p => p.Price).ThenBy(p => p.Name);
//Print("TIER 1 ORDER BY PRICE THEN BY NAME: ", r4);

//skip/take, paginação
var r5 = r4.Skip(2).Take(4);
//Print("TIER 1 ORDER BY PRICE THEN BY NAME SKIP 2 TAKE 4", r5);

var r6 = products.FirstOrDefault();
Console.WriteLine("FIRST PRODUCT: "+ r6);

var r7 = products.Where(p => p.Price > 3000.0).FirstOrDefault();
Console.WriteLine("FIRST PRODUCT TEST: "+ r7);
Console.WriteLine();


//só pode usar se retornar 1 ou nenhum elemento
var r8 = products.Where(p => p.Id == 6).SingleOrDefault();
Console.WriteLine("Single or default: " + r8);

//max/min
var r10 = products.Max(p => p.Price);
Console.WriteLine("Max price: " + r10);

var r12 = products.Where(p => p.Category.Id == 1).Sum(p => p.Price);
Console.WriteLine("Category 1 sum prices: " + r12);

var r13 = products.Where(p => p.Category.Id == 2).Average(p => p.Price);
Console.WriteLine("Category 1 average prices: " + r13);

//sequencia de produtos -> decimal -> default
var r14 = products.Where(p => p.Category.Id == 5).Select(p => p.Price).DefaultIfEmpty(0.0).Average();
Console.WriteLine("Category 5 average prices: " +r14);

//agregate ou reduce(map/reduce) => montar uma operação agregada personalizada
var r15 = products.Where(p => p.Category.Id == 1).Select(p => p.Price).Aggregate(0.0,(x, y) => x + y);
Console.WriteLine("Category 1 aggregate sum: " + r15);

//agrupamento
var r16 = products.GroupBy(p => p.Category);
foreach(IGrouping<Category, Product> group in r16)
{
    Console.WriteLine("Category: " + group.Key.Name + ": ");
    foreach(Product p in group)
    {
        Console.WriteLine(p);
    }
    Console.WriteLine();
}
