using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTracker.ViewModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TechTracker.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class VisitPageMain : ContentPage
    {


        public VisitPageMain()
        {
           
            InitializeComponent();


        }

        private void btnOverRideQR_Clicked(object sender, EventArgs e)
        {

        }

        private void btnScanQR_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new ScannerView());
        }

        private void OverRide_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {

        }

        private void btnPunchIn_Clicked(object sender, EventArgs e)
        {

        }

        private void btnPunchOut_Clicked(object sender, EventArgs e)
        {

        }

        private void btnDatabaseCheck_Click(object sender, EventArgs e)
        {

        }





    }
}