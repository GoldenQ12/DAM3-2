import java.net.*;
import java.io.*;

public class ClienteEjercicio001 {
    public ClienteEjercicio001() {
        try {
            Socket socket = new Socket("localhost", 5000);

            // for writting
            OutputStream outputStream = socket.getOutputStream();
            DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

            int numeroAleatorio = (int) (Math.random() * 100);
            dataOutputStream.writeInt(numeroAleatorio);
            System.out.println("Número enviado al servidor: " + numeroAleatorio);

            socket.close();
        } catch (IOException e) {
            System.err.println("Error connecting to server: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        new ClienteEjercicio001();
    }
}
