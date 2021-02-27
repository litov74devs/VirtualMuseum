using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Virtual_Library
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoadingPage : ContentPage
    {
        private double realPriority; // your priority
        public double Priority
        {
            get
            {
                if (this.realPriority < -0.5) return 0;
                if (this.realPriority > 0.5) return 2;
                return 1;
            }
        }


        public LoadingPage()
        {
            InitializeComponent();



        }
    }
}