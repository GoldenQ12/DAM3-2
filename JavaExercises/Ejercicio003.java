
public class Ejercicio03 {
	public static void main (String[] args) {
		System.out.println("*********" + Thread.activeCount());
		
		Hilos hilo1 = new Hilos("Hilo1"); 
		System.out.println("<<<<<<<<<" + Thread.activeCount());
		Hilos hilo2 = new Hilos("Hilo2"); 
		hilo1.start(); // No run()
		hilo2.start(); // No run()
		System.out.println("++++++" + Thread.activeCount());
		for(int i=0 ;i<10;i++){
			System.out.println(i + " - Hilo principal");
		}
		System.out.println("--------" + Thread.activeCount());
	}
}

class Hilos extends Thread{
	public Hilos(String nombre) {
		super (nombre);
	}
	public void run(){
		for (int i =0;i<10; i++){
			System.out.println(i + " - " + getName());
		}
		System.out.println("Fin del " + getName());
	}
}