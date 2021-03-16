using ManageStateExampleWithStatepattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStateExampleWithStatepattern.Concrete
{
    public class ModificaMinuteState : ClockState
    {
        public ModificaMinuteState(Clock c) : base(c)
        {
            Console.WriteLine("Orologio in modialità modifica minuti");
        }
        public override void Change()
        {
            _clock.Hours++;
            _clock.Hours = _clock.Hours % 60;
        }

        public override void Mode()
        {
            _clock.ChangeState(new NormalState(_clock));
        }
    }
}
