import java.io.*;
import java.net.*;  

public class ServerEjercicio002 {
    public ServerEjercicio002(){    
        try{
            ServerSocket serverSocket = new ServerSocket(5000);

            for (int i = 0; i < 5; i++) {
                Socket socket = serverSocket.accept();

                InputStream inputStream = socket.getInputStream();
                DataInputStream dataInputStream = new DataInputStream(inputStream);

                
                System.out.println("Hola cliente " + dataInputStream.readUTF());
            }
            serverSocket.close();

        }catch(IOException e){
            System.err.println("Error: " + e.getMessage());
        }
    }
    public static void main(String[] args) {
        new ServerEjercicio002();
    }
}
