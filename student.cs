
namespace ReviewClasses;

public class Student {
    public int Id {get;set;}
    public string Name {get;set;}
    public string Title{get;set;}
    public int Age {get;set;}
    public void Create(  string name,string Title ,int age) {
        // Student.Add(new Student());
        Student newStudentdata= new Student();
    //    newStudent. Id =id;
       newStudentdata. Name =name;
       newStudentdata.Title=Title;
       newStudentdata. Age=age;
         
       List<Student> AllStudents = GetAllStudents();
        Program.StudentDatabase.Add(newStudentdata);
       Console.ForegroundColor =ConsoleColor.Blue;
       Console.WriteLine("Student Created succsefully");
    }
     public List<Student> GetAllStudents() {
                return Program.StudentDatabase;                                                                    //     Console.WriteLine(message);
         }
          
    //   }
    //  public Student GetById(int ID){
    //      return GetStudentId;
    //  }
    public  void Update(Student student ){
     Name =student.Name ;
     Title = student.Title;
     Age = student.Age;

    }
    public void Delete(int Id){
     Console.WriteLine("Delete an student");
    }
    private int GetStudentId() {
         if(Program.StudentDatabase.Count == 1){
             return 1;
         } else {
            return Program.StudentDatabase.First().Id++;
         }
    }
}
