using System;

namespace Calculadora
{
	class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Sobrecarga de operadores");
			
//			Calculadora c = new Calculadora(5);
//			
//			int d = -c;
//			Console.WriteLine("El nuevo numero es: "+d);
			
			
			Circulo a = new Circulo(2);
			Circulo b = new Circulo(3);
			Circulo c = a+b;
			Console.WriteLine("El radio de c es: "+c.Radio);
			
			Console.WriteLine("El area de c es: "+c.Area());
			
			Console.ReadKey(true);
		}
	}
	
	//Sobrecarga de operadores unarios

	class Calculadora
	{
		public int Numero{get; set;}
		
		public Calculadora(int numero){
			Numero = numero;
		}
		
		public static int operator - (Calculadora c){
			
			c.Numero = -c.Numero;
			return c.Numero;
		}
	}
	class Circulo
	{
		public double Radio{get; set;}
			
			public Circulo(double radio){
			Radio = radio;
		}
		
		public static Circulo operator + (Circulo a, Circulo b){
			Circulo c = new Circulo(0);
			c.Radio = a.Radio + b.Radio;
			return c;
		}
		
		public static Circulo operator - (Circulo a, Circulo b){
			Circulo c = new Circulo(0);
			c.Radio = a.Radio - b.Radio;
			return c;
		}
		
		public static Circulo operator * (Circulo a, Circulo b){
			Circulo c = new Circulo(0);
			c.Radio = a.Radio * b.Radio;
			return c;
		}
		
		public double Area()
		{
			return Math.PI * Math.Pow(Radio, 2);
		}
	}
}