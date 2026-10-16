using System;

class Program
{
    static void Main(string[] args)
    {
        Student[] students =
        {
            new Student("anna", 49),
            new Student("boris", 50),
            new Student("vera", 80),
            new Student("gleb", 100)
        };

        Student[] selected = StudentFilter.Apply(students);

        foreach (Student student in selected)
            Console.WriteLine(StudentFormatter.Format(student));

        string summary = StudentSummary.Build(selected);

        if (summary.Length > 0)
            Console.WriteLine(summary);
    }
}