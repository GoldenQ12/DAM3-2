import java.io.*;
import java.net.*;

public class ServerEjercicio001 {

    public ServerEjercicio001(){
        try{
            ServerSocket serverSocket = new ServerSocket(5000);
            System.out.println("Servidor iniciado en el puerto 5000");
            for (int i = 0; i < 5; i++) {
                Socket socket = serverSocket.accept();

                // for reading
                InputStream inputStream = socket.getInputStream();
                DataInputStream dataInputStream = new DataInputStream(inputStream);
                
                System.out.println("El numero recibido por el cliente es: " + dataInputStream.readInt());
                socket.close();
            }
            serverSocket.close();
            
        }catch(IOException e){
            System.err.println("Error: " + e.getMessage());
        }
    }

    public static void main(String[] args) {
        new ServerEjercicio001();
    }
}
