using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    class PersonState // just to simplify Person class
    {
        private PersonStates _state = PersonStates.waitsForElevator;

        public void setState(PersonStates state) {
            _state = state;
        }

        public PersonStates getState() {
            return _state;
        }

        public string getStateString() {
            switch (_state) {
                case PersonStates.waitsForElevator:
                    return "ждет лифтик";   // all text constants must be in separate file (for ex: Settings/Strings.cs) 

                case PersonStates.carriedToDestFloor:
                    return "едет себе";

                case PersonStates.gaveUp:
                    return "вышел и переводит дух";

                case PersonStates.removed:
                    return "why do u see this??";
            }
            return "*Что-то пошло не так!*";
        }
    }
}
