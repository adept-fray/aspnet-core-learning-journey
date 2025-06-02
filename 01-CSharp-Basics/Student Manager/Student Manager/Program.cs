using Student_Manager;
var manager = new StudentManager();
void Menu()
{
    Console.WriteLine();
    Console.WriteLine("Options.");
    Console.WriteLine("1. Add student");
    Console.WriteLine("2. Remove student");
    Console.WriteLine("3. List students");
    Console.WriteLine("4. Find student by name");
    Console.WriteLine("5. Exit");
    Console.WriteLine();
}
void AddStudent(StudentManager studentManager)
{
    Console.WriteLine("Enter student info.");
    Console.Write("Name: ");
    string name = Console.ReadLine();
    Console.Write("Age: ");
    int age = int.Parse(Console.ReadLine());
    Console.Write("Gender: ");
    string gender = Console.ReadLine();

    Student student = new Student(name, age, gender);
    studentManager.Add(student);
}
void RemoveStudent(StudentManager studentManager)
{
    Console.WriteLine("Remove student by name.");
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Student student = studentManager.FindOneByName(name);
    studentManager.Remove(student);
}

void ListStudents(StudentManager studentManager)
{
    studentManager.List();
}

void FindStudent(StudentManager studentManager)
{
    Console.WriteLine("Find student by name.");
    Console.Write("Name: ");
    string name = Console.ReadLine();

    Student student = studentManager.FindOneByName(name);
    student.PrintInfo();
}
bool Options()
{
    Console.Write("Choose option: ");
    string option = Console.ReadLine();

    if (option == "1")
    {
        AddStudent(manager);
    }
    else if (option == "2")
    {
        RemoveStudent(manager);
    }
    else if (option == "3")
    {
        ListStudents(manager);
    }
    else if (option == "4")
    {
        FindStudent(manager);
    }
    else if (option == "5")
    {
        return true;
    }
    else
    {
        Console.WriteLine("Invalid option.");
    }
    return false;
}

while (true)
{
    Menu();

    if (Options())
        break;
}