#include <stdio.h>
#include <stdlib.h>
#include <string.h>

void main(void)
{
	char saludo[] = "Un saludo!!!!\n";
	char archivo[] = "texto.txt";
	char buffer[10];
	int fd, bytesleidos;


	fd = open(archivo, 1);
	
	if( fd == -1 )
 	{
		printf("ERROR AL CREAR EL FICHER...\n");
		exit(-1);
	}
	

	printf("Escribe el saludo...\n");
	write(fd, saludo, strlen(saludo));
	close(fd);

	fd = open(archivo,0);
	printf("Contenido del fichero: \n");

	bytesleidos = read(fd, buffer, 1);
	while (bytesleidos != 0){
		printf("%s", buffer);
		bytesleidos = read(fd, buffer, 1);
	}
	close(fd);
}
