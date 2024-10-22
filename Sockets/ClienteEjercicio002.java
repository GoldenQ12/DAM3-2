import java.io.*;
import java.net.*;

public class ClienteEjercicio002 {

    public ClienteEjercicio002() {
        try {
            Socket socket = new Socket("localhost", 5000);

            OutputStream outputStream = socket.getOutputStream();
            DataOutputStream dataOutputStream = new DataOutputStream(outputStream);
            BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in));

            System.out.println("Introduce tu nombre: ");
            String mensaje = bufferedReader.readLine();
            dataOutputStream.writeUTF(mensaje);


            socket.close();
        } catch (Exception e) {
            System.err.println("Error: " + e.getMessage());
        }
    }
    public static void main(String[] args) {
        new ClienteEjercicio002();
    }
}
