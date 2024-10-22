import java.net.*;
import java.io.*;

public class ServerEjercicio006 {
    

    public ServerEjercicio006() {
        try {
            ServerSocket serverSocket = new ServerSocket(5000);
            System.out.println("Escuchando en el puerto 5000");

            for (int cliente = 0; cliente < 5; cliente++) {
                Socket socket = serverSocket.accept();

                InputStream inputStream = socket.getInputStream();
                ObjectInputStream objectInputStream = new ObjectInputStream(inputStream);

                Persona p1 = (Persona) objectInputStream.readObject();
                System.out.println("Persona recibida del cliente " + (cliente + 1) + ": " + 
                "\nNombre: " + p1.getNombre() + 
                "\nEdad: " + p1.getEdad());
            }
            serverSocket.close();
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
    public static void main(String[] args) {
        new ServerEjercicio006();
    }
}
