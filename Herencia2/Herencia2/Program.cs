using Herencia2.Models;

List<FiguraGeometrica> listaFG = new List<FiguraGeometrica>();

Circulo c1 = new Circulo(20);
ClaseCuadrado cua1 = new ClaseCuadrado(15, 20);


listaFG.Add(c1);
listaFG.Add(cua1);

foreach (FiguraGeometrica tmp in listaFG) {

    Console.WriteLine(tmp.ToString());

}