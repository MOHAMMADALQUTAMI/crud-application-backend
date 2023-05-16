namespace ReviewClasses;

class Program
{
    public static List<Student> StudentDatabase = new List<Student>();
    static void Main(string[] args)
    {
     while(true){
        Console.WriteLine("Enter 1 to Create an Student");
        Console.WriteLine("Enter 2. to Get All Student");
        Console.WriteLine("Enter 3. To Get Student By Id");
        Console.WriteLine("Enter 4. to Update an Student");
        Console.WriteLine("Enter 5 to Delete an Student");
        Console.WriteLine("Enter 6 to Exit");
        string option = Console.ReadLine();

        switch(option) {
            
        case "1" :
        Console.WriteLine("Enter Name: ");                                             
        string createName = (Console.ReadLine());
        Console.WriteLine("Enter Title: ");
        string createTitle = Console.ReadLine();
        Console.WriteLine("Enter Age must be a number: ");
         int createAge = Convert.ToInt32(Console.ReadLine());

         Student e =  new Student();
              e.Create(createName ,createTitle ,createAge );
        break;
        case "2" :
         foreach(Student s in StudentDatabase){
             Console.WriteLine($"ID: {s.Id}, Name: {s.Name}, Age: {s.Age}");
                                                                                                 //  foreach(Student student in StudentDatabase){
                                                                                               //    string message = "id: " + StudentDatabase.Id.ToString() + " name: " + StudentDatabase.Name" ;
                                                                                                         //     Console.WriteLine(message);
         }
        break;
        case "3" :
        break;
        case "4":
        Student newstudentdata = new Student();
        Console.WriteLine("Enter new Name: ");
                newstudentdata.Name = Console.ReadLine();
                Console.WriteLine("Enter new Title: ");
                newstudentdata.Title = Console.ReadLine();
                Console.WriteLine("Enter new Age must be a number: ");
                newstudentdata.Age = Convert.ToInt32(Console.ReadLine());
                //  newstudentdata.Update(newstudentdata);
        Console .WriteLine("Enter Student name for update");
        string name = Console.ReadLine();
        Student student = new Student();
        foreach( Student UpdateStudent in StudentDatabase) {
            if( UpdateStudent.Name==name){
                student =UpdateStudent;
                     student.Update(newstudentdata);

            } 
        }
               

        break;
        
        case "5":  Console.WriteLine("Delete Student");
      Console.Write("Enter student ID to delete: ");
        int id = Convert.ToInt32(Console.ReadLine());
        Student newstudent =  Program.StudentDatabase.Find(s => s.Id == id);
        if (newstudent != null)
        {
             Program.StudentDatabase.Remove(newstudent);
            Console.WriteLine("Student deleted successfully!");
        }
        else
        {
            Console.WriteLine("Student not found.");
        }
        break;
        case "6" :
        Environment.Exit(0);
        break;
         default:
                Console.WriteLine("Invalid Option");
                break;
        }
     }









        // Student e =  new Student();
        // e.Create(1731438,"mohammad",24);
        // Student newStudent = StudentDatabase[0];
        // Console.WriteLine(newStudent.Id);
        // Console.WriteLine(newStudent.Name);
        // Console.WriteLine(newStudent.Age);
        // Console.WriteLine("Hello, World!");
    }
}
