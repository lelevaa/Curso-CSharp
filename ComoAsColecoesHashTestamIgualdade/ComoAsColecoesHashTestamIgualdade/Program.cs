using ComoAsColecoesHashTestamIgualdade.Entities;
//Coleções hash: são aquelas coleções que indexão os elementos com base em um hash
//exemplo: dictionary/map
//cada elemento é usado pelo hash

//Como as coleções Hash testam igualdade?
//1 - gethashcode code e equals estiverem implementados: 1º gethash code, se ger igual usa o equals
HashSet<string> set = new HashSet<string>();

set.Add("Maria");
set.Add("Alex");

Console.WriteLine(set.Contains("Maria"));

Console.WriteLine();
//2 - gethash code e equals estiverem implementados:
//opção 1 se for tipo referência: compara as referÊncias de memória dos obejtos(exemplo a classe)
//opção 2 se for tipo valor(struct): compara os valores dos atribuidos
HashSet<Product> a = new HashSet<Product>();

a.Add(new Product("TV", 900.0));
a.Add(new Product("Notebook", 1200.0));

Product prod = new Product("Notebook", 1200.0);
Console.WriteLine(a.Contains(prod));//dá falso (referêncida de memória), sem a implementação do equals e hashcode

HashSet<Point> b = new HashSet<Point>();
b.Add(new Point(3,4));
b.Add(new Point(5,10));

Point p = new Point(3,4);

Console.WriteLine(b.Contains(p));