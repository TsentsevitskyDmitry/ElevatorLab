using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class Person
    {
        public string Name { set; get; }
        public int InitFloor { set; get; }
        public int DestFloor { set; get; }
        public int Weight { set; get; }
        public int CurrentFloor { set; get; }

        private PersonState _state;
        private int untilRemoveNotify = Settings.GeneralSettings.GAVEUP_DELAY / Settings.GeneralSettings.FLOOR_SPEED;

        public Person(string name, int weihgt, int initFloor, int destFloor) {
            Name = name;                // Can we use C-like fields initialization with C# Fields?
            InitFloor = initFloor;
            DestFloor = destFloor;
            CurrentFloor = initFloor;
            Weight = weihgt;
            _state = new PersonState();
        }

        public PersonStates getState()
        {
            return _state.getState();
        }
        public string getStateString()
        {
            return _state.getStateString();
        }

        public void elevatorAtFloorSlot(int floor) {
            if(_state.getState() == PersonStates.carriedToDestFloor)
                CurrentFloor = floor;
            changeState(floor);
        }

        private void changeState(int floor) {
            if (_state.getState() == PersonStates.waitsForElevator && floor == InitFloor)
                _state.setState(PersonStates.carriedToDestFloor);
            
            if (_state.getState() == PersonStates.carriedToDestFloor && floor == DestFloor)
                _state.setState(PersonStates.gaveUp);

            if (_state.getState() == PersonStates.gaveUp && untilRemoveNotify != 0)
                --untilRemoveNotify;

            if (untilRemoveNotify == 0)
                _state.setState(PersonStates.removed);
        }
    }
}
