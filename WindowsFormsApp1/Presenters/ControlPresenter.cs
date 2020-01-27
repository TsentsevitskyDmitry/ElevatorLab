using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Views;

namespace WindowsFormsApp1.Presenters
{
    class ControlPresenter : IControlPresenter, INotitifyAgent  // multiple inheritance of interfaces (спасибо, кэп)
    {
        IControlView _view;
        Services.FieldValidation _validator;
        Services.ElevatorService _elevator;
        
        public ControlPresenter(Form view) {
            _view = (IControlView)view;
            _validator = new Services.FieldValidation();
            _elevator = new Services.ElevatorService(this);
        }
        
        public void start(string floorsCount) {   // called from view
            if (!_validator.isPositiveInt(floorsCount))
            {
                _view.displayError("Wrong floors count!");
                return;
            }
            int floors = int.Parse(floorsCount);
            _validator.setMaxFloor(floors);
            _elevator.start(floors);
            _view.setStopState(true);
        }

        public void stop() {   // called from view
            _elevator.stop();
        }

        public void addPerson(string name, string weihgt, string initialFloor, string destinationFloor) {   // called from view
            if (   !_validator.isFloorValid(initialFloor) 
                || !_validator.isFloorValid(destinationFloor)
                || !_validator.isPositiveInt(weihgt) )
            {
                _view.displayError("Wrong User Data!");
                return;
            }
            Person person = new Person(name, Int32.Parse(weihgt), Int32.Parse(initialFloor), Int32.Parse(destinationFloor));
            _elevator.addPerson(person);
        }

        public void stateChanged() // callback from elevator service
        {
            List<string> data = _elevator.getPeopleData();
            _view.refreshInfoBox(data.ToArray());
            _view.displayOverweight(!_elevator.isWeightOk());

            if (data.Count == 0)
                _view.setStopState(true);
            else
                _view.setStopState(false);
        }
    }
}
