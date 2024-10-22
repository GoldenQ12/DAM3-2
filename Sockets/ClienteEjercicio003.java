import java.io.*;
import java.net.*;


public class ClienteEjercicio003 {
    public ClienteEjercicio003() {
        try {
            Socket socket = new Socket("localhost", 5000);

            InputStream inputStream = socket.getInputStream();
            DataInputStream dataInputStream = new DataInputStream(inputStream);

            OutputStream outputStream = socket.getOutputStream();
            DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

            for (int i = 0; i < 3; i++) {
                System.out.println("Introduce un numero: ");
                String mensaje = bufferedReader.readLine();
                int numero = Integer.parseInt(mensaje);
                dataOutputStream.writeInt(numero);
            }
            System.out.println("El servidor dice que la media de los 3 numeros introducidos es: " + dataInputStream.readDouble());
            socket.close();
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
    public static void main(String[] args) {
        new ClienteEjercicio003();
    }
}
