using System;
using System.Threading;

namespace MyApplicationofdelegatesandevents
{
  class  Studentsinroom
    {
        Students student=new Students();
        public event EventHandler Examcompleted;

        protected virtual void OnExamcompleted()    
        {
            if (Examcompleted!=null)
            {
                Examcompleted(this, EventArgs.Empty);
            }
        }

        public  void Examongoing()
        {
           
             Console.WriteLine(String.Format("The exam has just started in room {0} ,",student.GetStuinfo()[0].Roomnumber+
                 " we will notify you when it ends"));
              Thread.Sleep(5000);
         
        }




        public event EventHandler Examcompleted1;

        protected virtual void OnExamcompleted1()
        {
            if (Examcompleted1 != null)
            {
                Examcompleted1(this, EventArgs.Empty);
            }
        }
     
        public void Coping()
        {
            var name1 = student.GetStuinfo()[0].Name;
            var name2 = student.GetStuinfo()[2].Name;
            var regno1 = student.GetStuinfo()[0].RegNumber;
            var regno2 = student.GetStuinfo()[2].RegNumber;
            var room = student.GetStuinfo()[0].Roomnumber;
            var Id1 = student.GetStuinfo()[0].NationalId;
            var Id2 = student.GetStuinfo()[2].NationalId;
            Console.WriteLine(string.Format("Alert {0} in room {1} reg {2} and Id {3} is coping from {4}" +
                                            " reg num {5} and Id {6}.",name1,room,regno1,Id1,name2,regno2,Id2));
            OnExamcompleted1();
        }
     
    }
}