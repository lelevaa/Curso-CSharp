using ExercicioFixacao_ManipulacaoDeArquivosEDiretorios.Entities;
using System;
using System.IO;
using System.Numerics;
using System.Globalization;
namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathOrigem = @"C:\Users\letic\OneDrive\Área de Trabalho\origem\produtos.csv";
            //pega o diretório
            string pathRaiz = Path.GetDirectoryName(pathOrigem);//origem

            //Console.Write(pathRaiz);

            //lista as pastas
            //caso exista
            //var folders = Directory.EnumerateDirectories(pathRaiz, "*.*", SearchOption.AllDirectories);

            //string do caminho da nova pasta
            string pathDestino = Path.Combine(pathRaiz, "out");

            //cria a pasta
            Directory.CreateDirectory(pathDestino);

            //cria o arquivo
            string arquivo = Path.Combine(pathDestino, "summary.csv");

            try
            {
                //lista onde serão armazenados
                List<Product> products = new List<Product>();

                //linhas
                string[] lines = File.ReadAllLines(pathOrigem);

                foreach (string line in lines)
                {
                    string[] fields = line.Split(',');

                    string name = fields[0];
                    //se é uma lista de string...
                    double price = double.Parse(fields[1],CultureInfo.InvariantCulture);
                    int quantity = int.Parse(fields[2]);

                    //adiciona na lista os campos
                    products.Add(new Product(name, price, quantity));
                }

                using (StreamWriter sw = File.AppendText(arquivo))
                {
                    foreach (Product product in products)
                    {
                        sw.WriteLine($"{product.Name}, R${product.Total().ToString("F2", CultureInfo.InvariantCulture)}");
                    }
                    Console.WriteLine("Arquivo summary.csv criado com sucesso!");
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}