using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Media;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MasterMindApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand ButtonClickCommand { get; set; }
        //public SlotViewModel[] Slots { get; set; }
        public ObservableCollection<SlotViewModel> Slots { get; set; }
        public string ButtonText { get; set; }
        public SolidColorBrush ButtonColor { get; set; } 

        public MainViewModel()
        {
            ButtonClickCommand = new RelayCommand(ButtonClick);
            ButtonText = "Start";
            ButtonColor = Brushes.Green;

            Slots = new ObservableCollection<SlotViewModel>();
            for (int i = 0; i < TILESCOUNT; i++)
            {
                Slots.Add(new SlotViewModel());
            }
        }

        private readonly int TILESCOUNT = 32;

        private void ButtonClick()
        {
            MessageBox.Show("Button clicked.");
        }
    }
}