using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Services
{
    class FieldValidation   // validate user input 
                            // I have no idea how to do it right
                            // and английский я тоже донт ноу
    {
        private int _maxFloor = 0;

        public bool isPositiveInt(string value) {
            int result;
            bool valid = Int32.TryParse(value, out result);

            return valid && result > 0;
        }

        public void setMaxFloor(int floor) {
            _maxFloor = floor;
        }

        public bool isFloorValid(string floor)
        {
            int result;
            bool valid = Int32.TryParse(floor, out result);

            return valid && result <= _maxFloor && result > 0;
        }
        
    }
}
