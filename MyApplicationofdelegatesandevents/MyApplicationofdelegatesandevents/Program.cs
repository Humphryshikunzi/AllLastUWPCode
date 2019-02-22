using System;
using System.Threading;

namespace MyApplicationofdelegatesandevents
{
    class Program
    {
        static void Main(string[] args)
        {
           var inspect=new Studentsinroom();
           var invigilatorinspect=new InvigilatorInspect();
           inspect.Examcompleted +=invigilatorinspect.InvigilatorInspecting;
           inspect.Examcompleted1 += invigilatorinspect.Coping1;
           inspect.Examongoing();
           Thread.Sleep(5000);
            inspect.Coping();
            Console.ReadKey();
        }

       
    }
    
}
