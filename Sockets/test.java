import java.io.*;
import java.net.*;
class Cliente {
static final String HOST = "localhost";
static final int PUERTO=5000;
public Cliente( ) {
try{

Socket skCliente = new Socket( HOST , PUERTO );

//***********RECIBIR EL MENSAJE*********************
InputStream aux = skCliente.getInputStream();
DataInputStream flujo = new DataInputStream( aux );
System.out.println( flujo.readUTF());
//**************************************************


OutputStream aux2 = skCliente.getOutputStream();
DataOutputStream flujo2= new DataOutputStream( aux2 );
flujo2.writeUTF( "Hola servidor "  );

/*OutputStream aux3 = skCliente.getOutputStream();
DataOutputStream flujo3= new DataOutputStream( aux2 );
int numeroAleatorio = (int) (Math.random() * 100);

flujo3.writeInt( numeroAleatorio);*/


skCliente.close();
} catch( Exception e ) {
System.out.println( e.getMessage() );
}
}
public static void main( String[] arg ) {
new Cliente();
}
}