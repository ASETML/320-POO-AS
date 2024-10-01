using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    class Plane
    {
        // Display attributes
        // dimensions of the ASCII representation of the plane
        public const int WIDTH = 28;
        public const int HEIGHT = 6;

        private string[] view =
        {
            @" _                         ",
            @"| \                        ",
            @"|  \       ______          ",
            @"--- \_____/  |_|_\____  |  ",
            @"  \_______ --------- __>-} ",
            @"        \_____|_____/   |  "
        };

        // Model attributes
        private int _x;
        private int _altitude;
        public List<Para> parachutists;

        public int X { get => _x; set => _x = value; }
        public int Altitude { get => _altitude; set => _altitude = value; }

        /// <summary>
        /// Constructor
        /// </summary>
        public Plane()
        {
            _x = 0;
            _altitude = Config.SCREEN_HEIGHT;
            parachutists = new List<Para>();
        }

        /// <summary>
        /// Render
        /// </summary>
        public void draw()
        {
            for (int i = 0; i < view.Length; i++)
            {
                Console.SetCursorPosition(_x, i);
                Console.Write(view[i]);
            }
        }

        /// <summary>
        /// Move the plane
        /// </summary>
        public void update()
        {
            if (_x >= Config.SCREEN_WIDTH)
            {
                _x = 0;
            }
            else
            {
                _x++;
            }
        }

        /// <summary>
        /// Take a parachustist on board
        /// </summary>
        /// <param name="para"></param>
        public void board(Para para)
        {
            this.parachutists.Add(para);
        }

        internal Para dropParachutist()
        {
            Para parachutist = parachutists.First();
            parachutists.Remove(parachutist);
            parachutist.x = _x;
            parachutist.altitude = this._altitude;
            return parachutist;
        }
    }
}
