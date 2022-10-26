using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Results
{
    public class Result : IResult
    {
     

        public Result(bool success, string message):this(success) // iki parametreli bir constructor gönderdiğimde iki parametreli constructor calışacak ama this diyerek bu clasın tek parametreli contructorınıda calıstır.
        {
            // sen Resulta constructor vasıtasıyla bir tane true bir tanede string bir sey göndermek istiyorsun
            Message = message; // aşagıdaki Message message olarak set et 
            ///Success = success; // 
        
        }   
        public Result(bool success)
        {
            Success = success;
        }

        public bool Success { get; } // getler readonly dir ve bunlar constructorda set edilebilirler

        public string Message { get; } // Buraya set koyabilirdik ama koymadık çünkü bu kodu kullanacak kişi başarılı dönüşlerini costructorla yapıcak kafasına göre bir şey yazmasın kodların okunabilirliği standart olsun 
    }
}
