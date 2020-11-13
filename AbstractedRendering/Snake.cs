using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    class Snake : IGameObject
    {
        public void Drow(IDrawer drawer)
        {
            drawer.WriteLine("Az sym zmiata");
        }
    }
}
