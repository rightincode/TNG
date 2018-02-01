using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Violation
{
    public class MustangGT: Mustang
    {
        public MustangGT()
        {
        }

        public override void Break()
        {
            base.Stopped = false;
        }
    }
}
