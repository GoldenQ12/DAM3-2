
class SimpleThread1 extends Thread { 
	public SimpleThread1 (String nombre){
		super (nombre);
		}
		 public void run()
		{
		for (int i =0;i<10; i++)
		{
		
		System.out.println(i + getName());
		} 
		System.out.println("Fin!" + getName());
		}
	}
public class Ejercicio02{
	public static void main (String[] args) 
	{
	SimpleThread1 hilo1 = new SimpleThread1 ("Hilo1"); 
	SimpleThread1 hilo2 = new SimpleThread1 ("Hilo2"); 
	hilo1.start(); // No run()
	hilo2.start(); // No run() 
	}
}