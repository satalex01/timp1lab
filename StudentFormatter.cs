static class StudentFormatter
{
    public static string Format(Student student)
    {
        return $"{student.Name}; score={student.Score}";
    }
}