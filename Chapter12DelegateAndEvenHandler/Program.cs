using Chapter12DelegateAndEvenHandler.Entity;

namespace Chapter12DelegateAndEvenHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
         Exam ex = new Exam();
         ex.AddQuesitonAndAnswer("Q1", new List<string> { "A1", "A2", "A3" });
         ex.AddQuesitonAndAnswer("Q2", new List<string> { "A1", "A2", "A3" });
         ex.AddQuesitonAndAnswer("Q3", new List<string> { "A1", "A2", "A3" });
       Student student = new Student();
            student.Name = "loai saber";
            student.Age = 27;
            ex.ExamEvent += student.ExamSubscribe;
         ex.StartExam();
        }
    }
}
