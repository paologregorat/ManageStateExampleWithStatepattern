using ManageStateExampleWithStatepattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStateExampleWithStatepattern.Concrete
{
    public class Clock
    {
        private ClockState _currentState;
        public int Hours { get; set; }
        public int Minute { get; set; }
        public Clock()
        {
            ChangeState(new NormalState(this));
        }

        public ClockState GetCurrentState()
        {
            return _currentState;
        }

        public void ChangeState(ClockState cs)
        {
            _currentState = cs;
        }

        public void ModeButton()
        {
            _currentState.Mode();
        }

        public void ChangeButton()
        {
            _currentState.Change();
        }
    }
}
