using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using SQLite;

namespace DataAccess
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    ["Recipees"]
    public class Recipe
    {
        [Primary,AutoIncrement]
        public int Id { get; set; }
        []
        public string Name { get; set; }

    }
	public partial class Sqlite : ContentPage
	{
        
		public Sqlite ()
		{
			InitializeComponent ();
		}
	}
}