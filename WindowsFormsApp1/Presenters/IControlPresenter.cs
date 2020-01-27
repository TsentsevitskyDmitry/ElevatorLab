using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Presenters
{
    interface IControlPresenter // interface from View to Presenter
    {
        void start(string floorsCount);
        void stop();
        void addPerson(string nameField, string weighField, string initialFloorField, string destinationFloorField);
        void stateChanged();
    }
}
