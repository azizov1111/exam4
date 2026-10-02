class Student
{
    public int Id { get; set; }
    public string FullName { get; set; }
    public int Age { get; set; }
    public string Group { get; set; }

    public Student(int id, string fullName, int age, string group)
    {
        Id = id;
        FullName = fullName;
        Age = age;
        Group = group;
    }
}