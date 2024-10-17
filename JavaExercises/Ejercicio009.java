class Contador {
    protected int cont = 0;
    
    public int getContador() { return this.cont;}
    public void setContador (int cont ) {this.cont = cont;}


    public synchronized int incContador(int val)
    {
        this.cont+=val;
        try{
            Thread.sleep((long) (Math.random() * 100 ));
        } catch (Exception ex) {
            System.out.println(ex.getMessage() + "");
        }
        return this.cont;
    }
}

class ContadorHilo extends Thread {
    Contador cont;
    ContadorHilo (String nombre, Contador cont){
        super(nombre);
        this.cont = cont;
    }

    public void run(){
        for ( int i= 0; i < 3; i++){
            try{
                synchronized(cont){
                    int a = cont.getContador();
                    sleep((long) (Math.random() * 10));
                    cont.setContador(a+1);
                    System.out.println(getName() + " - contador " + cont.getContador());

                    sleep((long) (Math.random() * 10));
                }
            } catch (Exception ex){
                System.out.println(ex.getMessage());
            }
        }
        System.out.println("Fin " + getName());
    }
}

public class Ejercicio09{
    public static void main(String[] args) {
        Contador cont = new Contador();
        ContadorHilo hilo1 = new ContadorHilo("Hilo1", cont);
        ContadorHilo hilo2 = new ContadorHilo("Hilo2", cont);
        ContadorHilo hilo3 = new ContadorHilo("Hilo3", cont);
        ContadorHilo hilo4 = new ContadorHilo("Hilo4", cont);

        hilo1.start();
        hilo2.start();
        hilo3.start();
        hilo4.start();
        try {
            hilo1.join();
            hilo2.join();
            hilo3.join();
            hilo4.join();
        } catch (Exception e) {
            System.out.println(e.getMessage());
        }
    }
}
