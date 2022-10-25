using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System.Diagnostics;
using System.Reflection.Metadata.Ecma335;

class Program
{
    static void Main(string[] args)
    {
        //NewMethod();
        CustomerTest();
    }

    private static void CustomerTest()
    {
        MotorcyleManager motorcycleManager = new MotorcyleManager(new EfMotorcyleDal());
        foreach (var motorcyle in motorcycleManager.GetMotorcyleDetails()) 
        {
            Console.WriteLine(motorcyle.MotorcyleName+"/"+motorcyle.BrandId);

        }
    }

    private static void NewMethod()
    {
        MotorcyleManager motorcyleManager = new MotorcyleManager(new InMemoryMotorcyleDal());

        foreach (var motorcyle in motorcyleManager.GetAll())
        {
            Console.WriteLine(motorcyle.MotorcyleName);

        }
    }

}