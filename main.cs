using System;
using System.Globalization;

class Program{
	static void Main (string []args){

  Triangulo x, y;
  y = new Triangulo();
  x = new Triangulo();

  double areax, px;
  double areay, py;

  Console.WriteLine("Digite os três lados de um triângulo:");

  x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  Console.WriteLine("Digite os três lados de um triângulo:");

  y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  px = (x.A + x.B + x.C) / 2;
  areax = Math.Sqrt( px * (px - x.A) * (px - x.B) * (px - x.C));

  py = (y.A + y.B + y.C) / 2;
  areay = Math.Sqrt( py * (py - y.A) * (py - y.B) * (py - y.C));

  if(areax > areay){
    Console.WriteLine("Maior área: X");
  }else{
    Console.WriteLine("Maior área: Y");
  }
  
}
}