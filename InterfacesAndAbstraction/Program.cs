﻿using InterfacesAndAbstraction.Contracts;
using System;

namespace InterfacesAndAbstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            //Абстракция - да използваме само информацията която ни интересува в даден контекст и забравяме маловажната за дадения контекст; Обратното на абстракция е конкретика. В програмирането винаги търсим абстракцията, как можем да погледнем нещата от птичи поглед и това да ни опрости кода и работата. Абсатракцията ни е най-големия приятел, когато се борим със сложни проекти (проблеми). Важна задача на ООП е да направи кода по-четим, по разбираем. Абстракцията е много важна за да може един код да е разбираем. Без абстракция, трудно се разбира кода. 
            //Абстракцията ни помага да разберем какво прави един обект, а не как го прави!!!
            //Двата основни начина да постигнем абстракция са с интерфейси и с абстрактни класове. Много често вместо интерфейс можем да срещнем contract или договор, тъй като Абстракцията казва какво точно ще прави един клас, какво е важното (като договор си е). 
            //Енкапсулацията е на ниво клас, ниво обект, докато Абстракцията е на по - високо ниво, тя е на ниво много обекти, много класове, на ниво йерархия, на ниво архитектура (как комуникират различните класове, как се подават данни, как знаят едни други за себе си).
            //Енкапсулацията се постига с access modifiers, а Абстракцията  с интерфейси и с абстрактни класове. Различни са, но се допълват много добре. Абстракцията помага да не повтаряме код.
            //Абстракцията маха конкретните наща и оставя общите между различни обекти. Общите неща пишем на интерфейси. По този начин лесно ще можем да решим от едно място да изберем и променим ако желаем конкретната имплементация. Така става лесно променянето на кода и преизползването. Можем да гледаме на абстракцията като преобразуване на нашия обект към нещо по общо, което ще ни свърши работа, нещо по-общо специално за случая който ни трябва.
            //Абстракцията показва само нещата които ще са нужни за дадена операция, нищо повече!
            //Интерфейса съдържа само сигнатурата на методи 90%  и  пропъртита 10% (приблизително).
            //Интерфейсите могат да се наследяват едни други, както се наследяват класовете.
            //Ако имаме наследяване след двете точки първо се записва класа, а след него със запетайка интерфейса/интерфейсите(ако са повече) и имплементираме.
            //Интерфейсите могат да се наследяват едни други, но се случва рядко!!!
            //Виктор не ни препоръчва да наследяваме интерфейси! Едно от основните правила във солид принципите е да имаме малки Интерфейси
            //Интерфейсите се използват много по често от абстрактния клас, затова ще работим повече с тях!
            //Ако клас наследява клас с интерфейс, то той наследява всичко и интерфейса!
            //is убива абстракцията и полиморфизма.
            //Един клас може да наследява много интерфейси

            //Абстрактните класове не могат да се инстанцират и могат да имат абстрактни методи и пропъртита! Ако наследяват интерфейси, трвбва да си имплементират вдичко което се изисква от интерфейсите които наследяват!(да си спазят договора ;-)). Всеки един абстракт метод е виртуал метод!
            //Разликата между абстрактния клас и интерфейса е една - че абстрактния клас може да има имплементация вътре за разлика от интерфейса (много обичат да го питат по интервюта!!!). Той може да служи като интерфейс, да казва какво трябва да има един клас който го наследява, но може да има и дефолтна имплементация!!!
            //слагайки абстракт на метод (в Абстрактен клас), казваме че този метод трябва да се имплементира от класовете които наследяват абстракт класа, но тук не казваме каква е имплементацията! Имплементацията да си я правят децата както си искат!
            //Когато нашия клас наследява абстрактен клас, не е като при интерфейсите просто да имплементираме методите от абстрактния клас, а трябва да ги оверрайднем.
            //Абстрактен клас използваме когато искаме освен да зададем някакви методи за имплементиране на децата и дефолтни такива (по-рядко се използва от интерфейсите). 
            //Когато нямаме да задаваме дефолтни методи използваме интерфейс.
            //Абстрактния клас е като шаблон!

            //Можем да мап -ваме интерфейса към абстрактен клас: Примера е в AbstractClass в Worker!

            //Aбстрактния метод е задължително virtual метод, т.е. той може да се оверрайдва.
            //Aбстрактен метод можем да имаме само в абстрактни класове.
            //Aбстрактния метод не дава имплементация

            //Един клас може да наследява множество интерфейси, т.е. интерфейса е по гъвкав от Абстрактния клас защото един клас може да наследява само един абстрактен клас; 
            //Абстрактния клас може да даде дефолтна имплементация (полета, пропъртита, методи) на всички които го наследяват, докато при интерфейсите това го няма, те казват само какво да има без да дават имплементация (въпреки че в новата версия на С# можело, но въпроса бил какъв е смисъла!?).
            //При интерфейса ако добавим един метод, трябва да го имплементираме във всички наследници, докато при Абстрактния клас автоматично отива (се имплементира).
            //Разликата между abstract и virtual метод/пропирти е че abstract се имплементира задължително, а virtual се override -ва и има default стойност!!!
            //static class е клас който има само статични мембъри и не може да се инстанцира.

            //Една голяма игра 5000 класа е нищо - Виктор го каза!???

            //За колко време се учат фреймуърци като Angular, React, ASP.NET? - относително е, на какво ниво, но сравнително бързо за няколко дни колкото да си свършиш нещо работа, не е като програмирането!!!

            //при добре усвоен материал след ООП е възможно да си намерим работа, НО след WEB - a със сигурност!!! 

            //WPF не ни го препоръчва засега, WEB - a е много по важен, декстопа позамира и има по-малко работа! Силата в момента е в WEB и мобайл!

            //В AbstractedRendering това което направихме се нарича Dependence Inversion и е основен принцип на Solid, отлична илюстрация за мощтта на абстракцията!

            //Интерфейса ВИНАГИ е публичен, както и всички мембъри в класа който имплементира Интерфейса трябва да са публични!!!

            //Интерфейсите не могат да имат конструктор, защото не могат да се инстанцират!ISomething = new ISomething - такова нещо няма!
            //ISomething = new Person - тук Person - а е клас, имплементирал този интерфейс. Тук отдясно можем да сложим всеки клас който е имплементирал интерфейса!

            //Интерфейса не може да наследява клас.

            //Ако направим лист от интерфейс, в него ще мога да добавям всички обекти от класове имплементирали интерфейса!

            //List<object> objects = new List<object>(); в това можеш да пълниш всичко, но няма смисъл, ще имаш проблем с разпечатването! 

            //Когато искаме отвън класа (от мейна например) да променяме някое пропърти, например .Name ни трябва сетер, ако няма да променяме, а само ще печатаме тогава сетер не ми трябва (гетъра е достатъчен)! При прайвет сет вътре в класа можем да променяме стойността на пропъртито, но ако нямаме сетър и вътре в класа не можем!  

            //Debug => Windows => Call Stack  удобно е да си наблюдаваме стека при дебъгване - показва ни пътя, от къде минаваме, да пробвам! 

            //Когато си направим някаква йерархия от интерфейси и класове можем да я онагледим с add Class Diagram (даваме име на диаграмата), Class View, маркираме интерфейсите и класовете и ги слагаме в прозореца пред нас (с влачене става).

            Store store = new Store();
            User user = new User();
            user.Money = 500;
            var nikeShoe = (new Shoe() { Price = 55 });
            store.BuyProduct(nikeShoe, user);
            store.BuyProduct(new Microphone() { Price = 333 }, user);
            store.BuyProduct(new Toothbrush() { Price = 22 }, user);
        }
    }
}
