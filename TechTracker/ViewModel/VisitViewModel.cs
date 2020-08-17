using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using TechTracker.View;
using Xamarin.Forms;

namespace TechTracker.ViewModel
{
    public class VisitViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;


        public VisitViewModel()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {

        }

        private bool _TurnFlashOn;
        public bool TurnLightOn
        {
            get { return _TurnFlashOn; }
            set
            {
                _TurnFlashOn = value;
                PropertyChanged(this, new PropertyChangedEventArgs("TurnLightOn"));
                
            }
        }


    }
}