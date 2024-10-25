using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter12DelegateAndEvenHandler.ExtensionMethid; 

    public static class Numbers
    {
    public static IEnumerable<int> GetEvenNumbers(this IEnumerable<int> numbers, Predicate<int> isEven)
    {
        foreach (var item in numbers.Where(s=>isEven(s)))
        {
            yield return item;
        }
 
    }
    }

