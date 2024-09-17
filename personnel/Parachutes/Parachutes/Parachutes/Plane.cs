using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    /// <summary>
    /// Plane Object
    /// </summary>
    class Plane
    {
        //Pos x
        private int _x = 1;
        //Pos y
        private int _y = 3;
        //Speed
        private int _speed = 2;
        //Crew
        private List<Skydiver> _crew;
        //Appearance
        private string[] _view =
        {
                @" _                         ",
                @"| \                        ",
                @"|  \       ______          ",
                @"--- \_____/  |_|_\____  |  ",
                @"  \_______ --------- __>-} ",
                @"        \_____|_____/   |  "
            };

        //Constructeur
        public Plane(int x, int speed, List<Skydiver> crew)
        {
            _x = x;
            _speed = speed;
            _crew = crew;
        }

        /// <summary>
        /// Move the Plane
        /// </summary>
        public void Move()
        {
            _x += _speed;
            this.Show();
        }

        /// <summary>
        /// Show the plane
        /// </summary>
        public void Show()
        {
            int i = 0;
            //Loop through the string array, one line at a time
            foreach (var view in _view)
            {
                if (_x < Config.SCREEN_WIDTH)
                {
                    Console.SetCursorPosition(_x, i);
                    i++;
                    Console.WriteLine(view);
                }
            }
        }

        public void Drop()
        {
            int i = 0;
            foreach (Skydiver skydiver in _crew)
            {
                
                if (skydiver._state == SKYDIVERSTATE.inPlane)
                {
                    while (i < 1)
                    {
                        skydiver._y = this._y;
                        skydiver._x = this._x;
                        skydiver._state = SKYDIVERSTATE.inAirWithoutParachute;
                        i++;
                    }
                    
                }
                else if (skydiver._state != SKYDIVERSTATE.onGround)
                {
                    ShowParas();
                }
            }
        }

        public void ShowParas()
        {
            foreach (Skydiver skydiver in _crew)
            {
                skydiver.Move();
            }
        }
    }
}
