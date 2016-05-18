using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinTest
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            grid1.BindingContext = new MyViewModel1();

            /* Windows의 ComboBox의 대응하는 View는 Picker. 특이사항으로 Item은 Binding 불가. */
            foreach (var item in (grid1.BindingContext as MyViewModel1).Operations)
            {
                myPicker.Items.Add(item);
            }
            myPicker.SelectedIndex = 0;


            grid2.BindingContext = new MyViewModel2();
        }
    }
}
