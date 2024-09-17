using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones.Model
{
    class Building
    {
        public int coordX { get; set; }
        public int coordY { get; set; }

        public int widthX { get; set; }
        public int widthY { get; set; }

        public Color color { get; set; }

        private Pen buildingBrush = new Pen(new SolidBrush(this.color), 3);

        public Building(int coordX, int coordY, int widthX, int widthY, Color color)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.widthX = widthX;
            this.widthY = widthY;
            this.color = color;
        }

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle();
            drawingSpace.Graphics.DrawString($"{this}", TextHelpers.drawFont, TextHelpers.writingBrush, _x + 5, _y - 5);
        }
    }
}
