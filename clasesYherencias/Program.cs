// See https://aka.ms/new-console-template for more information

var rect = new Rectangulo();

rect.Base=20;

rect.Altura= 55;

Console.WriteLine($"El area es : {rect.Area()} ");

Console.WriteLine($"La Altura es : {rect.Perimetro()} "); 

class Rectangulo {
   public double Base { get; set; }
   public double Altura { get; set; }

public double Area() => Base * Altura;

public double Perimetro() =>  2 * Base + 2 * Altura;
}