using System.Collections.Generic;
using ExercicioPropostoConjuntos.Entities;
using System.Globalization;

List<string> courses = new List<string>() { "A","B","C"};
HashSet<Student> set = new HashSet<Student>();

foreach(string corse in courses)
{
    Console.Write($"How many students for course {corse}?");
    int students = int.Parse(Console.ReadLine());
    for(int i = 0; i < students; i++)
    {
        int code = int.Parse(Console.ReadLine());
        set.Add(new Student { Code = code});
    }
}
Console.WriteLine("Total students: " + set.Count);
