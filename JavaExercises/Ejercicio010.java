package packageJavaPSP;

class Animal extends Thread {
	String nombre;
	
	public Animal(int prio, String nombre) {
		this.nombre = nombre;
		setPriority(prio);
	}
	
	public void run () {
		for ( int i= 0; i < 30; i++) {
			System.out.print( nombre );
			yield();
		}
		System.out.println("\n Llega" + nombre + "\n");
	}
}
public class Ejercicio010 {
	
	static Animal tortuga;
	static Animal liebre;
	static Animal guepardo;
	
	public static void main (String[] args) {
		tortuga = new Animal(1, "T");
		liebre = new Animal(10, "L");
		guepardo = new Animal (7, "G");
		
		tortuga.start();
		liebre.start();
		guepardo.start();
	}
}
