import java.io.*;
import java.net.*;

public class ServerEjercicio005 {
    public ServerEjercicio005() {
        try {
            int numero = 0;
            ServerSocket serverSocket = new ServerSocket(5000);
            System.out.println("Escuchando en el puerto 5000");

            for (int cliente = 0; cliente < 5; cliente++) {
                Socket socket = serverSocket.accept();

                OutputStream outputStream = socket.getOutputStream();
                DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

                InputStream inputStream = socket.getInputStream();
                ObjectInputStream objectInputStream = new ObjectInputStream(inputStream);

                int[] intArray = (int[]) objectInputStream.readObject();
                for (int i = 0; i < intArray.length; i++) {
                    numero += intArray[i];
                }
                double media = numero / intArray.length;
                dataOutputStream.writeDouble(media);
                serverSocket.close();
            }
            
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        new ServerEjercicio005();
    }
}
