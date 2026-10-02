interface IStudentService
{
    void AddStudent(Student student);
    void DisplayStudents();
    void UpdateStudent(int id, string fullName, int age, string group);
    void DeleteStudent(int id);
    Student SearchByName(string fullName);
    List<Student> SearchByGroup(string group);
}