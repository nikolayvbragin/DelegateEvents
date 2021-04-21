using System;

namespace DelegateEvents
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Handler11 Handler1 = new Handler11();
            Handler22 Handler2 = new Handler22();
            ClassCounter.ReachedThreshold += Handler1.ShowMessage;
            ClassCounter.ReachedThreshold += Handler2.ShowMessage;
            Console.WriteLine("Запуск цикла");
            ClassCounter.Count();                
                
        }

       
    }
}
