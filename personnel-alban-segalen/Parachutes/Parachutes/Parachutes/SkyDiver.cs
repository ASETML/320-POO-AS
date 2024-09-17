using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parachutes
{
    /// <summary>
    /// SkyDiver class
    /// </summary>
    class Skydiver
    {
        //Pos X
        public int _x { get; set; }
        //Pos Y
        public int _y { get; set; }
        //Speed
        private int _speed = 1;
        
        public SKYDIVERSTATE _state { get; set; } = SKYDIVERSTATE.inPlane;

        //Appearance without parachute
        private string[] _withoutParachute =
        {
                @"     ",
                @"     ",
                @"     ",
                @"  o  ",
                @" /░\ ",
                @" / \ ",
            };
        //Appearance with parachute
        private string[] _withParachute =
        {
                @" ___ ",
                @"/|||\",
                @"\   /",
                @" \o/ ",
                @"  ░  ",
                @" / \ ",
            };

        //Constructor
        public Skydiver() {}

        /// <summary>
        /// Move the skyDiver
        /// </summary>
        public void Move()
        {
            if (_state != SKYDIVERSTATE.onGround)
            {
                _y += _speed;
                this.DeployParachute();
                this.CheckGround();
            }
            this.Show();
        }

        /// <summary>
        /// Show the skyDiver
        /// </summary>
        public void Show()
        {
            string[] parachutes;
            int i = 0;
            //Change appearance if the parachute is deployed

            switch (_state)
            {
                case SKYDIVERSTATE.inAirWithParachute:
                    parachutes = _withParachute;
                    break;
                default:
                    parachutes = _withoutParachute;
                    break;
            }
            //Loop through the string array, one line at a time
            foreach (var parachute in parachutes)
            {
                if (_y + 1 < Config.SCREEN_HEIGHT)
                {
                    Console.SetCursorPosition(_x, _y + i);
                    i++;
                    Console.WriteLine(parachute);
                }
            }
        }

        /// <summary>
        /// Deploy the parachute
        /// </summary>
        public void DeployParachute()
        {
            if (_y > (Config.SCREEN_HEIGHT / 2))
            {
                _state = SKYDIVERSTATE.inAirWithParachute;
                _speed = 1;
            }
        }

        //Check if the skyDiver reached the ground
        public void CheckGround()
        {
            if (_y == Config.SCREEN_HEIGHT)
            {
                _speed = 0;
                _state = SKYDIVERSTATE.onGround;
            }
        }
    }
}
