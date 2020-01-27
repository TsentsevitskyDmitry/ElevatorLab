using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using WindowsFormsApp1.Models;
using WindowsFormsApp1.Presenters;

namespace WindowsFormsApp1.Services
{
    class ElevatorService   // main elevator processor, other classes are auxiliary 
    {
        private int _floors;
        private List<Person> _people;
        INotitifyAgent _notifyAgent;

        Thread myThread;
        private bool _running = false;
        int currentWeight = 0;

        public ElevatorService(INotitifyAgent notifyAgent)
        {
            _people = new List<Person>();
            _notifyAgent = notifyAgent;
        }

        public void start(int floors)
        {
            _floors = floors;

            myThread = new Thread(elevatorThread);
            _running = true;
            myThread.Start();
        }

        public void stop()
        {
            if (myThread == null) return;
            _running = false;
            myThread.Join();
            _notifyAgent.stateChanged();
        }

        public void addPerson(Person person)    // called from Presenter
        {
            _people.Add(person);
            _notifyAgent.stateChanged();
        }

        public List<string> getPeopleData()    // called from Presenter
        {
            List<string> result = new List<string>();
            foreach (Person p in _people)
            {
                result.Add("Челик " + p.Name + " сейчас " + p.getStateString() + " на этаже " + p.CurrentFloor);
            }
            return result;
        }

        public bool isWeightOk() {    // called from Presenter
            return currentWeight <= Settings.GeneralSettings.MAX_WEIGHT;
        }

        private void elevatorThread()   // thread func
        {
            int f = 1;
            while (_running) {
                Console.Out.WriteLine("тыц " + f); // just to know where elevator is

                for (int i = 0; i < _people.Count; ++i) {
                    _people[i].elevatorAtFloorSlot(f); // notify all persons
                    currentWeight = 0;

                    if (_people[i].getState() == PersonStates.carriedToDestFloor)
                        currentWeight += _people[i].Weight;  // calculate current weight

                    if (_people[i].getState() == PersonStates.removed)
                        _people.Remove(_people[i--]);  // roll back pointer cos we delete current item
                }

                _notifyAgent.stateChanged();    // notify Presenter that peole and elevator states are changed and He need to update information on the View

                ++f;
                if (f > _floors) f = 1; // simple counter
                Thread.Sleep(Settings.GeneralSettings.FLOOR_SPEED);     // move from one floor to another
            }
        }

    }
}
