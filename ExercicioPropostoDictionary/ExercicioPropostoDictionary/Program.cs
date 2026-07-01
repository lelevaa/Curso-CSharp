using ExercicioPropostoDictionary.Entities;
using System.Xml.Linq;


Dictionary<string, int> dicionario = new Dictionary<string,int>();
 
//não tem isso
//HashSet<Dictionary<string, int>> candidatosUnicos = new HashSet<Dictionary<string, int>>();

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

try
{
    using (StreamReader sr = new StreamReader(path))
    {
        while (!sr.EndOfStream)
        {
            string[] line = sr.ReadLine().Split(',');

            string name = line[0];

            int votos = int.Parse(line[1]);

            //não tinha necessidade do hash já que o dicionário já tem a key como chave, só precisava da lógica da soma para chaves repetidas
            if (dicionario.ContainsKey(name))
            {
                dicionario[name] += votos;
            }
            else
            {
                dicionario[name] = votos;
            }

            //Cadidato canditados = new Cadidato{
            //    Name = name,
            //    Votos = votos
            //};

            //dicionario.Add(
            //    canditados.Name,
            //    canditados.Votos
            //);

            //candidatosUnicos.Add(dicionario);
        }

        foreach (KeyValuePair<string, int> item in dicionario)
        {
            Console.WriteLine(item.Key + ": " + item.Value);
        }
    }
    
} catch(IOException e)
{
    Console.WriteLine(e.Message);
}
