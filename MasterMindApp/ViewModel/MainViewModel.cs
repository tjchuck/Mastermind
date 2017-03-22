using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using System.Windows.Media;
using System;
using System.Collections.Generic;

namespace MasterMindApp.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        public ICommand SlotClickCommand { get; set; }
        public ICommand PrzyciskClickCommand { get; set; }
        public Slot[] Slots { get; set; }
        public string PrzyciskText { get; set; }
        public SolidColorBrush PrzyciskColor { get; set; } 

        public MainViewModel()
        {
            SlotClickCommand = new RelayCommand(SlotClick);
            PrzyciskClickCommand = new RelayCommand(PrzyciskClick);
            PrzyciskText = "Start";
            PrzyciskColor = Brushes.Green;
            Slots = new Slot[TILESCOUNT];
            for(int i = 0; i < TILESCOUNT; i++)
            {
                Slots[i] = new Slot();
            }
        }

        private readonly int TILESCOUNT = 32;

        private void SlotClick()
        {
            MessageBox.Show("clicked");
        }

        private void PrzyciskClick()
        {
            MessageBox.Show("Przycisk clicked.");
        }
    }

    public class Slot
    {
        public ICommand SlotClickCommand { get; set; }

        public Slot()
        {
            SlotClickCommand = new RelayCommand(SlotClick);
            State = SlotState.Empty;
            ColorText = "Pusty";
        }

        private void SlotClick()
        {
            MessageBox.Show("Tile clicked.");
        }

        public SlotState State
        {
            get { return state; }
            set
            {
                state = value;
            }
        }
        public SolidColorBrush Brush { get; set; }
        public string ColorText { get; set; }

        private SlotState state;
    }


    public enum SlotState
    {
        Empty,
        White,
        Blue,
        Green,
        Red,
        Yellow
    }
}