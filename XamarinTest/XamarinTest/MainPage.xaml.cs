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

            label_test.TextColor = Color.Red;
            btn_test.Clicked += Btn_test_Clicked;
        }

        private void Btn_test_Clicked(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            DisplayAlert("Title", "Message", "확인", "취소");
        }
    }
}
