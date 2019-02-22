using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Getdatafromuserproj
{
   public  class GetAddeddata
    {
     public static   List<string> Firstnames=new List<string>();
     public static List<string> Secondnames = new List<string>();
     public static List<string> Passwords = new List<string>();
      
        public static  void Getdataadded(string firstname,
            string secondname, string password)
        {
            var details=new Details();
            Firstnames.Add(details.Firstname = firstname);
            Secondnames.Add(details.Secondname = secondname);
            Passwords.Add(details.Password = password);
            
        }
    }
}
