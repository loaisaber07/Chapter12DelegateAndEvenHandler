using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12DelegateAndEvenHandler.Entity;

    public class Student
    {
    public string Name { get; set; }
    public int Age { get; set;}
    public void ExamSubscribe(Exam ex) {
        Console.WriteLine(this.Name +"\t" + "Start Exam at"+DateTime.Now +"\n" +ex);
    }
}

