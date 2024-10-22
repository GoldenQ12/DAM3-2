import java.io.*;
import java.net.*;

public class ClienteEjercicio005 {
    public ClienteEjercicio005() {
        try {
            Socket socket = new Socket("localhost", 5000);
            int[] intArray = new int[20];

            OutputStream outputStream = socket.getOutputStream();
            ObjectOutputStream objectOutputStream = new ObjectOutputStream(outputStream);

            InputStream inputStream = socket.getInputStream();
            DataInputStream dataInputStream = new DataInputStream(inputStream);


            for (int i = 0; i < 20; i++) {
                intArray[i] = (int) (Math.random() * 100);
            }
            objectOutputStream.writeObject(intArray);

            double media = dataInputStream.readDouble();
            if (media != 0) System.out.println("La media recibida del servidor es: " + media);

            socket.close();
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        new ClienteEjercicio005();
    }
}
