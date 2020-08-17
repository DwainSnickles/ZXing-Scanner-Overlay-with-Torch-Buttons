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
    public partial class ScannerView : ContentPage
    {
        //Add Reference for binding
        VisitViewModel visitViewModel;

        public ScannerView()
        {
            InitializeComponent();
            //Bind To S 
            visitViewModel = new VisitViewModel();
            BindingContext = visitViewModel;
        }

        private void scanView_OnScanResult(ZXing.Result result)
        {

        }

        private async void btnCancel_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
            //await Navigation.PushModalAsync(new NavigationPage(new VisitPageMain()));
        }

        private void btnTorchOn_Clicked(object sender, EventArgs e)
        {
            if (visitViewModel.TurnLightOn == false){visitViewModel.TurnLightOn = true; }
        }

        private void btnTorchOFF_Clicked(object sender, EventArgs e)
        {
            if (visitViewModel.TurnLightOn == true) { visitViewModel.TurnLightOn = false; }
        }
    }
}