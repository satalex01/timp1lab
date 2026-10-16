static class StudentSummary
{
    public static string Build(Student[] students)
    {
        int sum = 0;

        foreach (Student student in students)
        {
            sum += student.Score;
        }

        return $"SumScore: {sum}";
    }
}