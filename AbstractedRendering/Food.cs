using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    public class Food : IGameObject
    {
        public int IsEaten { get; set; }

        public void Drow(IDrawer drawer)
        {
            drawer.WriteLine("Ne e vkusno");
        }
    }
}
