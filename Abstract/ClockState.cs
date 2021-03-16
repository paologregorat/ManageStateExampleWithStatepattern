using ManageStateExampleWithStatepattern.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStateExampleWithStatepattern.Abstract
{
    public abstract class ClockState
    {
        protected Clock _clock;
        public ClockState(Clock clock)
        {
            _clock = clock;
        }
        public abstract void Mode();
        public abstract void Change();
    }
}
