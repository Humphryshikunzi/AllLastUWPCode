using System;

namespace MyApplicationofdelegatesandevents
{
    class InvigilatorInspect
    {   Students student = new Students();
        public   void InvigilatorInspecting(object source,EventArgs e)
        {
             Console.WriteLine(String.Format("We have been notified of an ongoing exam in room {0}"
                                             + " we are closely monitoring it.",
                  student.GetStuinfo()[0].Roomnumber));
        }
        public void Coping1(object source,EventArgs e)
        {
            var name1 = student.GetStuinfo()[0].Name;
            var name2 = student.GetStuinfo()[2].Name;
            var regno1 = student.GetStuinfo()[0].RegNumber;
            var regno2 = student.GetStuinfo()[2].RegNumber;
            var room = student.GetStuinfo()[0].Roomnumber;
            var Id1 = student.GetStuinfo()[0].NationalId;
            var Id2 = student.GetStuinfo()[2].NationalId;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine(string.Format("Alert noted , it has truly been confirmed that {0} in room {1} reg {2} and Id {3} is coping from {4}" +
                                            " reg num {5} and Id {6} ,action will be done upon completion of exam.", name1, room, regno1, Id1, name2, regno2, Id2));
           
        }
    }
}