using AbstractedRendering.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractedRendering
{
    interface IGameObject
    {
        void Drow(IDrawer drawer);
    }
}
