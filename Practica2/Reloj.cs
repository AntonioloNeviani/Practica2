/*Practica 2, Programacion 3, Alumno: Jorge Antonio*/
using System;

namespace Practica2{
	
	public class Reloj{
		
		public Reloj (){	
		}
		public void iniciar(){
			
			while(true){
				Console.Clear();
				Console.WriteLine (DateTime.Now.ToLongTimeString() );
				System.Threading.Thread.Sleep(1000);
           	}
		}
	}
}

