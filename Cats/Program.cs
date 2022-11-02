// See https://aka.ms/new-console-template for more information
using Cats;

Cat[] cats = new Cat[3];
Cat barsik = new Cat();
barsik.Name = "Барсик";
barsik.Year = 2;
barsik.poroda = "Британец";
Cat belka = new Cat();
belka.Name = "Белка";
belka.Year = 3;
belka.poroda = "Бенгальская кошка";
Cat lupa = new Cat();
lupa.Name = "Лупа";
lupa.Year = 4;
lupa.poroda = "Сфинкс";

cats[0] = barsik;
cats[1] = belka;
cats[2] = lupa;

Controller controller = new Controller();
controller.Save(cats);
string path = "cats.json";
var t = controller.Load(path);
foreach (var item in t)
{
    Console.WriteLine(item.Name, item.Year, item.poroda);
}
