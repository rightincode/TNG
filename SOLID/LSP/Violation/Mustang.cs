using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Violation
{
    public class Mustang
    {
        public Engine engine = new Engine();

        private bool _stopped;

        public bool Stopped
        {
            get { return _stopped; }
            set { _stopped = value; }
        }
        
        public Mustang() {
            _stopped = false;
        }
        public virtual void Break()
        {
            _stopped = true;
        }
    }
}
