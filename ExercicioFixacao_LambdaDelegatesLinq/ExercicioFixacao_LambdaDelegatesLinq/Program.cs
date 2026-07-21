//IMPORTAÇÕES
using System.Globalization;
using System.Collections.Generic;
using ExercicioFixacao_LambdaDelegatesLinq.Entities;

//CONSOLE
Console.Write("Enter full file path: ");
string path = Console.ReadLine();

Console.Write("Enter salary: ");
double salary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

//LISTA DE EMPREGADOS
List<Employee> employees = new List<Employee>();

//LEITURA DO CAMINHO
using (StreamReader sr = File.OpenText(path))
{
    while (!sr.EndOfStream)
    {
        string[] vect = sr.ReadLine().Split(",");

        string name = vect[0];
        string email = vect[1];
        double value = double.Parse(vect[2], CultureInfo.InvariantCulture);

        employees.Add(new Employee(name, email, value));
    }
}

//APRESETAR OS EMAIL DO CSV
var emails = employees.Where(p => p.Salary > salary).OrderBy(p => p.Email).Select(p => p.Email);

Console.WriteLine($"Email of people whose salary is more than {salary}:");
foreach (string email in emails)
{
    Console.WriteLine(email);
}

//SOMA DO SALÁRIO DE QUEM COMEÇA COM A LETRA "M"
var startedWithM = employees.Where(p => p.Name[0] == 'M').Sum(p => p.Salary);
Console.WriteLine($"Sum of salary of people whose name starts with 'M': {startedWithM}");
