using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.LSP.Compliant
{
    public abstract class Car
    {
        public abstract bool Stopped { get; set; }

        public abstract void Break();
    }
}
