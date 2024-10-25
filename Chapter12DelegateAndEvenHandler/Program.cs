using Chapter12DelegateAndEvenHandler.Entity;
using Chapter12DelegateAndEvenHandler.ExtensionMethid;

namespace Chapter12DelegateAndEvenHandler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region deligate 
            //     Exam ex = new Exam();
            //  ex.AddQuesitonAndAnswer("Q1", new List<string> { "A1", "A2", "A3" });
            //  ex.AddQuesitonAndAnswer("Q2", new List<string> { "A1", "A2", "A3" });
            //  ex.AddQuesitonAndAnswer("Q3", new List<string> { "A1", "A2", "A3" });
            //Student student = new Student();
            //     student.Name = "loai saber";
            //     student.Age = 27;
            //     ex.ExamEvent += student.ExamSubscribe;
            //  ex.StartExam();
            #endregion
            #region Extenstion Method
            List<int> intArray = new List<int>{ 2, 4, 5, 7, 8, 5, 3, };
            foreach (var even in intArray.GetEvenNumbers(x => x % 2 == 0))
            {
                Console.WriteLine(even);
            }
            #endregion
        }
    }
}
