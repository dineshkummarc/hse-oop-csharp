﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace StarSystem
{
    class Planet : CelestialBody
    {
        private float radius = 10;

        private PlanetSystem planetSystem;

        public override CelestialSystem Parent
        {
            get { return planetSystem; }
        }

        public Planet(PlanetSystem planetSystem)
        {
            this.planetSystem = planetSystem;
        }

        public override PointF Position
        {
            get { return planetSystem.Position; }
        }

        public override void Draw(System.Drawing.Graphics gr)
        {
            Brush brush = new SolidBrush(Color.Blue);
            PointF pos = Position;

            gr.FillEllipse(brush, pos.X -radius, pos.Y - radius, 2*radius, 2*radius);
        }
    }
}
