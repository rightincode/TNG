using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Compliant
{
    public class MustangGT: Car
    {
        private bool _stopped;

        public override bool Stopped
        {
            get { return _stopped; }
            set { _stopped = value; }
        }

        public MustangGT()
        {
            _stopped = false;
        }

        public override void Break()
        {
            Stopped = true;
        }
    }
}
