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
            BindingContext = new MyViewModel1();
        }


        /* Windows의 ComboBox의 대응하는 View는 Picker. 특이사항으로 Item은 Binding 불가. */
        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            var vm = BindingContext as MyViewModel1;
            if (vm != null)
            {
                myPicker.Items.Clear();
                foreach (var item in vm.Operations)
                {
                    myPicker.Items.Add(item);
                }

                myPicker.SelectedIndex = 0;
            }
        }
    }
}
