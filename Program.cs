using System;
					
public class Program
{
	public static void Main ()
	{ int Operacion;
		double N1, N2;
		
		Console.WriteLine("----------CALCULADORA SOFKA----------");

		Console.WriteLine("Ingrese el Primer numero:  ");
		N1= Convert.ToDouble(Console.ReadLine( ));
	 
		Console.WriteLine("Ingrese el Segundo numero:  ");
		N2= Convert.ToDouble(Console.ReadLine(  ));

		Console.WriteLine("Ingrese la operacion a efectuar:");
		
	 	Console.Write ("1. Suma:, 2. Resta:, 3. Multiplicacion:, 4. Division: ");
		Operacion= Convert.ToInt32(Console.ReadLine(  ));
		
		
	  if (Operacion == 1)
	  {
		 Console.WriteLine ("El resultado de la Suma es: ");
	 	 Console.WriteLine (N1+N2); 
	  }
			 	 
	  if (Operacion == 2)
	  {
	 	 Console.WriteLine ("El resultado de la Resta es: ");
	 	 Console.WriteLine (N1-N2);
	  }
	  if (Operacion == 3)
	  {
	 	 Console.WriteLine ("El resultado de la Multiplicacion es: ");
	 	 Console.WriteLine (N1*N2);
	  }
	  if (Operacion == 4)
	  {
	 	 Console.WriteLine ("El resultado de la Division es: ");
	 	 Console.WriteLine (N1/N2);
	  }
	}
}
