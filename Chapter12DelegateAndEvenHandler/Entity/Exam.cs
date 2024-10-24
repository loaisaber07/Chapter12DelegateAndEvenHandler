using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12DelegateAndEvenHandler.Entity;
public class Exam
{ 
    public delegate void ExamHandler(Exam exam);    
    public event ExamHandler? ExamEvent;
    public IDictionary<string, IEnumerable<string>> ExamList { get; set; } = new Dictionary<string, IEnumerable<string>>();

    public void AddQuesitonAndAnswer(string key, IEnumerable<string> value)
    {
        ExamList.Add(key, value);
    }

    public void RemoveQuestionAndAnswer(string key)
    {
        ExamList.Remove(key);
    }
    public override string ToString()
    {
        StringBuilder questions = new StringBuilder();
        foreach(var item in ExamList)
        {
            questions.Append(item.Key + "\n");
            foreach(var item2 in item.Value)
            {
             questions.Append(item2 + "\n");
            }
        }
            return questions.ToString();
    }
    public void StartExam() { 
    ExamEvent?.Invoke(this);
    }
}

