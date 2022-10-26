using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    // sana calısacagın tipi calısacagın zman söylicem ozaman <T> generic, sen bir Resultsun aynı zamanda IDataResultsun o <T> için
    public class DataResult<T> : Result,IDataResult<T>
    {
        public DataResult(T data,bool success,string messages):base(success, messages)
        {
           Data = data;
                
        }
        public DataResult(T data,bool success): base(success)
        {
            Data = data;
        }
        public T Data { get; }

    }
}
