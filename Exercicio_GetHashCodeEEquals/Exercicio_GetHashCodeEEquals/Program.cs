using System;
using Exercicio_GetHashCodeEEquals.Entities;

//string a = "Maria";
//string b = "Alex";

//Console.WriteLine(a.Equals(b));

//GERA O MESMO HASHCODE
//Se o código de dois objetos for diferente, então os dois objetos são diferentes
//mais rápido. Pra ter certeza de objetos diferentes use o equals depois

//string a = "Maria";
//string b = "Maria";

//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());

Client a = new Client { Name = "Maria", Email = "maria@gmail.com" };
//false
Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

//true
//Client b = new Client { Name = "Alex", Email = "maria@gmail.com" };

//compara conteúdo
Console.WriteLine(a.Equals(b));

//Console.WriteLine(a.GetHashCode());
//Console.WriteLine(b.GetHashCode());

//vai dar falso porque pega o ponteiro de memória do objeto(compara referência de memória)
Console.WriteLine(a == b);