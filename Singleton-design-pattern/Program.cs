using System;
using System.Threading.Tasks;


namespace SingletonDesignPpattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Parallel.Invoke(
                ()=>PrintEmployeeDetails(),
                ()=>PrintStudentDetails()
                );
            //PrintEmployeeDetails();

            //PrintStudentDetails();

            /*   without sealed class, nested classes can be created and with an inheritance that leads to violation of the singleton*/
            //Singleton.DerivedSingleton obj =new Singleton.DerivedSingleton();
            //obj.PrintDetails("From Derived");

            Console.ReadLine();
        }

        private static void PrintEmployeeDetails()
        {
            Singleton fromEmployee = Singleton.Getinstance;
            fromEmployee.PrintDetails("fromEmployee");
        }

        private static void PrintStudentDetails()
        {
            Singleton fromStudent = Singleton.Getinstance;
            fromStudent.PrintDetails("fromStudent");
            Console.WriteLine("++++++++++++++++++++++++++++++++");
        }
    }
}
