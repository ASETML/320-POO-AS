using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Drones
{
    class Building
    {
        public int coordX { get; set; }
        public int coordY { get; set; }

        public int widthX { get; set; }
        public int widthY { get; set; }

        public Color buildingColor { get; set; } = new Color();

        private Pen buildingBrush;

        public Building(int coordX, int coordY, int widthX, int widthY, Color color)
        {
            this.coordX = coordX;
            this.coordY = coordY;
            this.widthX = widthX;
            this.widthY = widthY;
            this.buildingColor = color;
            buildingBrush = new Pen(new SolidBrush(buildingColor), 3);
    }

        public void Render(BufferedGraphics drawingSpace)
        {
            drawingSpace.Graphics.DrawRectangle(buildingBrush, new Rectangle(coordX, coordY, widthX, widthY));
        }
    }
}
