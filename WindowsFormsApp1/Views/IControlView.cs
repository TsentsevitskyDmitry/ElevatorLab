using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Views
{
    interface IControlView  // interface from Presenter to View
    {
        void refreshInfoBox(string[] lines);
        void displayError(string msg);
        void setStopState(bool state);
        void displayOverweight(bool state);
    }
}