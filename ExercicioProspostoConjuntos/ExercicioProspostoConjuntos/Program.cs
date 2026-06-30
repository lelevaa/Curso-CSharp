using System.Globalization;
using ExercicioProspostoConjuntos.Entities;

Console.Write("Enter file full path: ");
string path = Console.ReadLine();

//como a ordem não importa, é mais apropriado que sortedhash
HashSet<LogRecord> set = new HashSet<LogRecord>();

try
{
    using (StreamReader sr = File.OpenText(path))
    {
        while (!sr.EndOfStream)
        {

            string[] line = sr.ReadLine().Split(' ');//recortou e colocou no vetor

            string name = line[0];

            DateTime instant = DateTime.Parse(line[1]);
            set.Add(new LogRecord { Username = name, Instante = instant });
        }
        Console.WriteLine("Total users: " + set.Count);
    }
}
catch (IOException e)
{
    Console.WriteLine(e.Message);
}