using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    class Factory : Building
    {
        private float _powerComsumption;
        private int _id;

        public Factory(float powerComsumption, int id, int coordX, int coordY, int widthX, int widthY, Color color) : base(coordX, coordY, widthX, widthY, color)
        {
            _powerComsumption = powerComsumption;
            _id = id;
        }

    }
}
