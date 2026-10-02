// // task1
// // virtual — метод имеет реализацию, переопределение в наследнике необязательно.
// // abstract — метод не имеет реализации, наследник обязан его переопределить.


// // task2
// // Static-класс — это класс, у которого нельзя создать объект (экземпляр), а его методы и свойства вызываются напрямую через имя класса.


// // task3
// // обобщённый тип, позволяющий писать код, который работает с разными типами данных

// // task4
// // Если речь о программировании, struct (структура) — это тип данных, который объединяет несколько связанных значений в один объект.
// // различие — способ хранения и копирования данных




// class5
// class Program
// {
//     static void Main()
//     {
    
//         MyQueue<int> numbers = new MyQueue<int>();

//         numbers.Enqueue(10);
//         numbers.Enqueue(20);
//         numbers.Enqueue(30);

//         Console.WriteLine("Очередь чисел:");
//         Console.WriteLine("Первый элемент: " + numbers.Peek());
//         Console.WriteLine("Удалён: " + numbers.Dequeue());
//         Console.WriteLine("Количество: " + numbers.Count);

      
//         MyQueue<string> words = new MyQueue<string>();

//         words.Enqueue("Hello");
//         words.Enqueue("World");
//         words.Enqueue("C#");

//         Console.WriteLine("\nОчередь строк:");
//         Console.WriteLine("Первый элемент: " + words.Peek());
//         Console.WriteLine("Удалён: " + words.Dequeue());
//         Console.WriteLine("Количество: " + words.Count);

//         try
//         {
//             MyQueue<int> emptyQueue = new MyQueue<int>();

//             Console.WriteLine(emptyQueue.Dequeue());
//         }
//         catch (InvalidOperationException ex)
//         {
//             Console.WriteLine("\nОшибка: " + ex.Message);
//         }
//     }
// }


// class Program
// {
//     static void Main()
//     {
//         IStudentService service = new StudentService();

//         while (true)
//         {

//             Console.WriteLine("1. Добавить студента");
//             Console.WriteLine("2. Показать всех студентов");
//             Console.WriteLine("3. Обновить студента");
//             Console.WriteLine("4. Удалить студента");
//             Console.WriteLine("5. Поиск по имени");
//             Console.WriteLine("6. Поиск по группе");
//             Console.WriteLine("0. Выход");

//             Console.Write("\nВыберите действие: ");
//             string choice = Console.ReadLine();

//             try
//             {
//                 switch (choice)
//                 {
                  
//                     case "1":
//                         Console.Write("Введите Id: ");

//                         if (!int.TryParse(Console.ReadLine(), out int id))
//                         {
//                             throw new Exception("Id должен быть целым числом.");
//                         }

//                         Console.Write("Введите полное имя: ");
//                         string fullName = Console.ReadLine();

//                         Console.Write("Введите возраст: ");

//                         if (!int.TryParse(Console.ReadLine(), out int age))
//                         {
//                             throw new Exception(
//                                 "Возраст должен быть целым числом."
//                             );
//                         }

//                         Console.Write("Введите группу: ");
//                         string group = Console.ReadLine();

//                         Student student = new Student(
//                             id,
//                             fullName,
//                             age,
//                             group
//                         );

//                         service.AddStudent(student);
//                         break;

                
//                     case "2":
//                         service.DisplayStudents();
//                         break;

                   
//                     case "3":
//                         Console.Write("Введите Id студента: ");

//                         if (!int.TryParse(
//                                 Console.ReadLine(),
//                                 out int updateId))
//                         {
//                             throw new Exception(
//                                 "Id должен быть целым числом."
//                             );
//                         }

//                         Console.Write("Введите новое имя: ");
//                         string newName = Console.ReadLine();

//                         Console.Write("Введите новый возраст: ");

//                         if (!int.TryParse(
//                                 Console.ReadLine(),
//                                 out int newAge))
//                         {
//                             throw new Exception(
//                                 "Возраст должен быть целым числом."
//                             );
//                         }

//                         Console.Write("Введите новую группу: ");
//                         string newGroup = Console.ReadLine();

//                         service.UpdateStudent(
//                             updateId,
//                             newName,
//                             newAge,
//                             newGroup
//                         );

//                         break;

                  
//                     case "4":
//                         Console.Write("Введите Id студента: ");

//                         if (!int.TryParse(
//                                 Console.ReadLine(),
//                                 out int deleteId))
//                         {
//                             throw new Exception(
//                                 "Id должен быть целым числом."
//                             );
//                         }

//                         service.DeleteStudent(deleteId);
//                         break;

                
//                     case "5":
//                         Console.Write("Введите полное имя: ");
//                         string searchName = Console.ReadLine();

//                         Student foundStudent =
//                             service.SearchByName(searchName);

//                         if (foundStudent != null)
//                         {
//                             Console.WriteLine("\nСтудент найден:");
//                             Console.WriteLine(
//                                 $"Id: {foundStudent.Id}"
//                             );
//                             Console.WriteLine(
//                                 $"Имя: {foundStudent.FullName}"
//                             );
//                             Console.WriteLine(
//                                 $"Возраст: {foundStudent.Age}"
//                             );
//                             Console.WriteLine(
//                                 $"Группа: {foundStudent.Group}"
//                             );
//                         }

//                         break;

                
//                     case "6":
//                         Console.Write("Введите группу: ");
//                         string searchGroup = Console.ReadLine();

//                         List<Student> foundStudents =
//                             service.SearchByGroup(searchGroup);

//                         if (foundStudents.Count > 0)
//                         {
//                             Console.WriteLine("\nСтуденты группы:");

//                             foreach (Student s in foundStudents)
//                             {
//                                 Console.WriteLine(
//                                     $"Id: {s.Id}, " +
//                                     $"Имя: {s.FullName}, " +
//                                     $"Возраст: {s.Age}, " +
//                                     $"Группа: {s.Group}"
//                                 );
//                             }
//                         }

//                         break;

             
//                     case "0":
//                         Console.WriteLine("Программа завершена.");
//                         return;

//                     default:
//                         Console.WriteLine(
//                             "Неверный пункт меню."
//                         );
//                         break;
//                 }
//             }
//             catch (Exception ex)
//             {
//                 Console.WriteLine(
//                     "Ошибка: " + ex.Message
//                 );
//             }
//         }
//     }
// }

