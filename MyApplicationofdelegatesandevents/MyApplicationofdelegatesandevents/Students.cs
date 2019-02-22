using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace MyApplicationofdelegatesandevents
{
    class Students
    {
        public List<Studentinfo> GetStuinfo()
        {
            var stude=new List<Studentinfo>();
            {
                stude.Add(new Studentinfo(){Name = "Humphry",RegNumber = "E021-01-0686/2017",NationalId = 36058390,Roomnumber ="45"});
                stude.Add(new Studentinfo() { Name = "Cleophas", RegNumber = "E021-01-0696/2017", NationalId = 36058391,Roomnumber = "30"});
                stude.Add(new Studentinfo() { Name = "Frankline",RegNumber = "E021-01-0386/2017", NationalId = 36058380,Roomnumber = "11"});
                stude.Add(new Studentinfo() { Name = "Carson", RegNumber = "E021-01-0486/2017", NationalId = 36056390,Roomnumber = "56"});
                stude.Add(new Studentinfo() { Name = "Randy", RegNumber = "E021-01-0681/2017", NationalId = 36051390,Roomnumber = ""});
            }
           return stude;
        }
    }
}