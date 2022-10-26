using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    //Temel voidler icin baslangıc
    public interface IResult
    {
        // set işlemini kullanmak icin  Constructor kullanıcam 
        bool Success { get; } // sadece okunabilir
        string Message { get; } 
    }
}
