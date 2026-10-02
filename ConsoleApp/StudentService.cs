
class StudentService : IStudentService
{
    private List<Student> students = new List<Student>();

    public void AddStudent(Student student)
    {
        try
        {
            
            if (students.Any(s => s.Id == student.Id))
            {
                throw new Exception("Студент с таким Id уже существует.");
            }

           
            if (student.Age <= 0)
            {
                throw new Exception("Возраст должен быть больше 0.");
            }

            students.Add(student);

            Console.WriteLine("Студент успешно добавлен.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }


    public void DisplayStudents()
    {
        try
        {
            if (students.Count == 0)
            {
                throw new Exception("Список студентов пуст.");
            }

            Console.WriteLine("\n===== Все студенты =====");

            foreach (Student student in students)
            {
                Console.WriteLine(
                    $"Id: {student.Id}, " +
                    $"Имя: {student.FullName}, " +
                    $"Возраст: {student.Age}, " +
                    $"Группа: {student.Group}"
                );
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }

   
    public void UpdateStudent(
        int id,
        string fullName,
        int age,
        string group)
    {
        try
        {
            Student student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                throw new Exception("Студент не найден.");
            }

            if (age <= 0)
            {
                throw new Exception("Возраст должен быть больше 0.");
            }

            student.FullName = fullName;
            student.Age = age;
            student.Group = group;

            Console.WriteLine("Данные студента успешно обновлены.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }


    public void DeleteStudent(int id)
    {
        try
        {
            Student student = students.FirstOrDefault(s => s.Id == id);

            if (student == null)
            {
                throw new Exception("Студент не найден.");
            }

            students.Remove(student);

            Console.WriteLine("Студент успешно удалён.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }


    public Student SearchByName(string fullName)
    {
        try
        {
            Student student = students.FirstOrDefault(
                s => s.FullName.Equals(
                    fullName,
                    StringComparison.OrdinalIgnoreCase
                )
            );

            if (student == null)
            {
                throw new Exception("Студент с таким именем не найден.");
            }

            return student;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            return null;
        }
    }

   
    public List<Student> SearchByGroup(string group)
    {
        try
        {
            List<Student> result = students
                .Where(s => s.Group.Equals(
                    group,
                    StringComparison.OrdinalIgnoreCase
                ))
                .ToList();

            if (result.Count == 0)
            {
                throw new Exception("Студенты в этой группе не найдены.");
            }

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
            return new List<Student>();
        }
    }
}