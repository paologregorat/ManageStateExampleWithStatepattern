using ManageStateExampleWithStatepattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStateExampleWithStatepattern.Concrete
{
    public class ModificaOraState : ClockState
    {
        public ModificaOraState(Clock c) : base(c)
        {
            Console.WriteLine("Orologio in modialità modifica ore");
        }
        public override void Change()
        {
            _clock.Hours++;
            _clock.Hours = _clock.Hours % 24;
        }

        public override void Mode()
        {
            _clock.ChangeState(new ModificaMinuteState(_clock));
        }
    }
}
