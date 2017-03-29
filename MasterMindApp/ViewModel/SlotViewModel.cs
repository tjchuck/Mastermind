using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using System.Windows.Media;
using MasterMindApp.Model;
using GalaSoft.MvvmLight;

namespace MasterMindApp.ViewModel
{
    public class SlotViewModel : ViewModelBase
    {
        public ICommand SlotClickCommand { get; set; }

        public Brush SlotBrush
        {
            get { return slotBrush; }
            //set { Set(() => slotBrush, ref slotBrush, value); }
            set { slotBrush = value; RaisePropertyChanged(); }
        }

        public string ColorText
        {
            get { return colorText; }
            set { Set(() => ColorText, ref colorText, value); }
        }

        public SlotViewModel()
        {
            SlotClickCommand = new RelayCommand(SlotClick);            
            //ColorText = "Pusty";
            SlotBrush = Brushes.Blue;
        }

        private void SlotClick()
        {
            //ColorText = "aaa";
            SlotBrush = Brushes.Brown;
        }


        private string colorText;
        private Brush slotBrush;
    }
}
