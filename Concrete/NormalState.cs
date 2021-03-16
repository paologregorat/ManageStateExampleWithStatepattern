using ManageStateExampleWithStatepattern.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ManageStateExampleWithStatepattern.Concrete
{
    public class NormalState : ClockState
    {
        public NormalState(Clock c) : base(c)
        {
            Console.WriteLine("Orologio in modalità normale");
        }
        public override void Change()
        {
            Console.WriteLine("Orologio in modalità normale, change non ha effetto");
        }

        public override void Mode()
        {
            _clock.ChangeState(new ModificaOraState(_clock));
        }
    }
}
