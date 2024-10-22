import java.io.*;
import java.net.*;


public class ClienteEjercicio004 {
    public ClienteEjercicio004() {
        try {
            Socket socket = new Socket("localhost", 5000);

            OutputStream outputStream = socket.getOutputStream();
            DataOutputStream dataOutputStream = new DataOutputStream(outputStream);

            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

                System.out.println("Introduce un numero: ");
                String mensaje = bufferedReader.readLine();
                int numero = Integer.parseInt(mensaje);
                dataOutputStream.writeInt(numero);

            socket.close();
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
    public static void main(String[] args) {
        new ClienteEjercicio004();
    }
}
