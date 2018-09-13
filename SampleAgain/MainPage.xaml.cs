using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace SampleAgain
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            var sampleInterface = DependencyService.Get<ISample>();
            SampleLabel.Text = sampleInterface?.doProjectStuff();
        }
    }
}
