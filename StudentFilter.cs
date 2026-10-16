static class StudentFilter
{
    public static Student[] Apply(Student[] students)
    {
        int count = 0;

        foreach (Student student in students)
        {
            if (student.Score >= 50)
                count++;
        }

        Student[] result = new Student[count];
        int index = 0;

        foreach (Student student in students)
        {
            if (student.Score >= 50)
            {
                result[index] = student;
                index++;
            }
        }

        return result;
    }
}