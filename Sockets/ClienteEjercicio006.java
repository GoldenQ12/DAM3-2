import java.net.*;
import java.io.*;

public class ClienteEjercicio006 {


    public ClienteEjercicio006() {
        try {
            Socket socket = new Socket("localhost", 5000);

            Persona p1 = new Persona("Juan", 20);

            OutputStream outputStream = socket.getOutputStream();
            ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);

            objectOutputStream.writeObject(p1);

            socket.close();
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
    public static void main(String[] args) {
        new ClienteEjercicio006();
    }
}

