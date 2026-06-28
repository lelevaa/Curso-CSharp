//hashset: armazenamento em tabela hash; EXTREMAMENTE rápido; a ordem não é garantida
//sortedset: armazenamento em árvore; rápido(busca por log(n) => faz ficar rápido); são armazenados ordenadamente conforme implementação IComparer<T>

//Principais métodos: add, clear, contains, unionwith(other), intersectwith(other), exceptwith(other), remove(t), removewhere(predicate)
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading.Tasks.Dataflow;

//HashSet<string> set = new HashSet<string>();

//set.Add("TV");
//set.Add("Notebook");
//set.Add("Tablet");

//Console.WriteLine(set.Contains("Notebook"));

//foreach(string s in set)
//{
//    Console.WriteLine(s);
//}

SortedSet<int> a = new SortedSet<int>() { 0,2,4,5,6,8,10};
SortedSet<int> b = new SortedSet<int>() { 5,6,7,8,9,10};

//Union
//insere em "c" "a"
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);//insere todos os elementos de b que não estejam em c (CONJUNTO NÃO ACEITA REPETIÇÃO)

//intersection. Com lista isso dá mais trabalho
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);

//difference, elementos de a excluindo os elementos de b
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);

PrintCollection(e);


//IEnumerable: interface implementada de por todas as coleções bases da system.collections
//percorrer coleções padronizadas!!
static void PrintCollection<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection )
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}
;

