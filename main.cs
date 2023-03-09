using System;
using System.Globalization;

class Program{
	static void Main (string []args){

  Triangulo x, y;
  y = new Triangulo();
  x = new Triangulo();

  Console.WriteLine("Digite os três lados de um triângulo X:");

  x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  Console.WriteLine("Digite os três lados de um triângulo Y:");

  y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
  y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

  double areax = x.Area();
  double areay = y.Area();

  if(areax > areay){
    Console.WriteLine("Maior área: X");
  }else{
    Console.WriteLine("Maior área: Y");
  }
  
}}