import java.io.*;
import java.net.*;

public class ServerEjercicio004 {

    public ServerEjercicio004() {
        try {
            ServerSocket serverSocket = new ServerSocket(5000);
            System.out.println("Escuchando en el puerto 5000");
            int numero = 0;
            int contClientes = 0;
            double media = 0;

            for (int i = 0; i < 5; i++) {
                Socket socket = serverSocket.accept();

                InputStream inputStream = socket.getInputStream();
                DataInputStream dataInputStream = new DataInputStream(inputStream);

                
                OutputStream outputStream = socket.getOutputStream();
                DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

                numero += dataInputStream.readInt();
                contClientes++;

                if (contClientes == 5){
                    media = numero / 5;
                    dataOutputStream.writeDouble(media);
                    System.out.println("La media de los 5 numeros introducidos es: " + media);
                }


            }
            serverSocket.close();

        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        new ServerEjercicio004();
    }
}
