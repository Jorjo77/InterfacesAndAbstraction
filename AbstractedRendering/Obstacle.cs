using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    public class Obstacle : IGameObject
    {

        public void Drow(IDrawer drawer)
        {
            drawer.WriteLine("Obstacle na pytq");
        }
    }
}
