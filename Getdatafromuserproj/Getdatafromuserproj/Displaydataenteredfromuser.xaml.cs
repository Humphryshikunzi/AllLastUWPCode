using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Getdatafromuserproj
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Displaydataenteredfromuser : Page
    {
        public Displaydataenteredfromuser()
        {
            this.InitializeComponent();
        }

        private void Displaydataenteredfromuser_OnLoaded(object sender, RoutedEventArgs e)
        {
          
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(EnterDatafromuserproject));
        }

        private void ButtonBase_OnClick1(object sender, RoutedEventArgs e)
        {

            StringBuilder strin=new StringBuilder();
            for (int i = 0; i < GetAddeddata.Firstnames.Count; i++)
            {
                strin.Append(GetAddeddata.Firstnames[i] + "  ");
            }

            strin.ToString();
            StringBuilder sec=new StringBuilder();
            for (int i = 0; i < GetAddeddata.Secondnames.Count; i++)
            {
                sec.Append(GetAddeddata.Secondnames[i] + " ");
            }

            sec.ToString();
            StringBuilder pass = new StringBuilder();
            for (int i = 0; i < GetAddeddata.Passwords.Count; i++)
            {
                pass.Append(GetAddeddata.Passwords[i] + " ");
            }

            pass.ToString();

               ShowFistnames.Text = strin.ToString();
               ShowSecondnames.Text = sec.ToString();
               ShowPasswords.Text = pass.ToString();

        }
    }
}
