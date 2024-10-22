import java.io.*;
import java.net.*;

public class ServerEjercicio003 {

    public ServerEjercicio003() {
        try {
            ServerSocket serverSocket = new ServerSocket(5000);
            System.out.println("Escuchando en el puerto 5000");
            int numero = 0;

            for (int i = 0; i < 3; i++) {
                Socket socket = serverSocket.accept();

                InputStream inputStream = socket.getInputStream();
                DataInputStream dataInputStream = new DataInputStream(inputStream);

                
                OutputStream outputStream = socket.getOutputStream();
                DataOutputStream dataOutputStream = new DataOutputStream(outputStream);


                //* Logica de programa */
                for (int j = 0; j < 3; j++) {
                    numero += dataInputStream.readInt();
                }
                double media = numero / 3;

                dataOutputStream.writeDouble(media);

            }
            serverSocket.close();

        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        new ServerEjercicio003();
    }
}
