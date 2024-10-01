using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    class Dispatch : IDispatchable
    {
        List<Box> boxes;

        public Dispatch()
        {

        }

        public void ItemToBox(Box box)
        {
            boxes.Add(box);
        }

        public Box RetireFromBox(int index)
        {
            if (index < boxes.Count)
            {
                return boxes[index];
            }
            else
            {
                throw new ArgumentOutOfRangeException("index");
            }
        }
    }
}
