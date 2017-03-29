using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterMindApp.Model
{
    public class Slot
    {
        public SlotState State { get; set; }

        public Slot()
        {
            State = SlotState.Empty;
        }


        private SlotState state;

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
}
