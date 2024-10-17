import java.util.Random;

public class Ejercicio012 extends Thread {
    private int nivel;
    
        public Ejercicio012(int nivel) {
            this.nivel = nivel;
        }
    
        @Override
        public void run() {
            System.out.println("Hilo " + nivel + " ha comenzado.");
    
            if (nivel < 5) { // Crea un hilo hijo solo si el nivel es menor a 5
            Ejercicio012 hiloHijo = new Ejercicio012(nivel + 1);
                hiloHijo.start();
    
                // Espera a que el hilo hijo termine
                try {
                    hiloHijo.join();
                } catch (InterruptedException e) { 
                    Thread.currentThread().interrupt();
                }
            }
            
            Random aleat = new Random();
    
            // Imprime el estado procesando 10 veces
            for (int i = 0; i < 10; i++) {
                System.out.println("Hilo " + nivel + " se estÃ¡ procesando.");
                try {
                    sleep(aleat.nextInt(500)+100); // Tiempo 2000 ms
                } catch (InterruptedException e) {
                    Thread.currentThread().interrupt();
                }
            }
            System.out.println("Hilo " + nivel + " ha terminado.");
        }
    
        public static void main(String[] args) {
        Ejercicio012 hiloPrincipal = new Ejercicio012(1);
            hiloPrincipal.start();
        }
    }