using AbstractedRendering.Contracts;
using AbstractedRendering.Drawers;
using System;
using System.Net.Http.Headers;

namespace AbstractedRendering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Drawer drawer = new ConsoleDrawer();
            IDrawer drawer = new HtmlDrawer("../../../game");
            //IDrawer drawer = new FileDrawer("../../../game.txt"); //и след като имаме класа FileDrawer с тази елементарна промяна сменяме начина на писане от конзолен на txt!!!
            //Това е мощтта, красотата на абстракцията (вместо да сменяме във всеки клас, (класовете може да са хиляди) с подходяща абстракция го правим от едно място)!!!
            //Това което направихме се нарича Dependence Inversion и е основен принцип на Solid!
            Game game = new Game(drawer);
            game.Start();//И от тук на сетне играта (game) подава конзолния дроуер наляво надясно, който пък ще извика конзолата да печата! 
        }
    }
}
