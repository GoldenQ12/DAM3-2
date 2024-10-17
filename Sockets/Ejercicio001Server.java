import java.io.* ;
import java.net.* ;
class Servidor {
static final int PUERTO=5000;
public Servidor( ) {
try {


ServerSocket skServidor = new ServerSocket(PUERTO);


System.out.println("Escucho el puerto " + PUERTO );
for ( int numCli = 0; numCli < 6; numCli++ ) {
Socket skCliente = skServidor.accept(); // Crea objeto
System.out.println("Sirvo al cliente " + numCli);

//*******************ENVIAR MENSAJE******************
OutputStream aux = skCliente.getOutputStream();
DataOutputStream flujo= new DataOutputStream( aux );
flujo.writeUTF( "Hola cliente " + numCli );
//****************************************************


InputStream aux3 = skCliente.getInputStream();
DataInputStream flujo3 = new DataInputStream( aux3 );
System.out.println( flujo3.readUTF()+"Del cliente " + numCli);


/*InputStream aux4 = skCliente.getInputStream();
DataInputStream flujo4 = new DataInputStream( aux3 );
int res=0;
int suma=0;

suma=suma+flujo4;
res=suma/5;
System.out.println( res);*/


skCliente.close();
}
System.out.println("Demasiados clientes por hoy");
skServidor.close();
} catch( Exception e ) {
System.out.println( e.getMessage() );
}
}
public static void main( String[] arg ) {
new Servidor();
}
}