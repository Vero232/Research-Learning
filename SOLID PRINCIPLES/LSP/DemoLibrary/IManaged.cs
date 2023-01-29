using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    internal interface IManaged 
    {
        IEmployee Manager { get; set; }

        void AssignManager(IEmployee manager);
    }
}
