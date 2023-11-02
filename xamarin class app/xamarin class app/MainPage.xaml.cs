using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace xamarin_class_app
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        int count = 0;

        void Button_Clicked(object sender, EventArgs e)
        {
            double weightInLbs = Convert.ToDouble(In_Weight.Text);
            double heightInInches = Convert.ToDouble(In_Height.Text);

            
            double bmi = ((weightInLbs / (heightInInches * heightInInches)) * 703);
            Out_Text.Text = bmi.ToString();
        }



    }
}
