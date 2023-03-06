using System;

class Program{

static void Main(){

  int nota;
	string resultado="Reprovado";

	Console.WriteLine("Digite sua nota");
	nota = int.Parse(Console.ReadLine());

	if(nota >= 6){
	resultado = "Aprovado";
		}

	Console.WriteLine("Resultado: {0}", resultado);
  }
  }