using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    interface IDispatchable
    {
        void ItemToBox(Box box);
        Box RetireFromBox(int index);
    }
}
