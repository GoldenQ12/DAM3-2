#include <stdio.h>
#include <stdlib.h>
#include <string.h>
#include <unistd.h>
#include <sys/wait.h>

int main(void) {
    int fd[2];
    pid_t pid;
    char saludoHijo[] = "Hola padre.\0";
    char buffer[80];

    pipe(fd);
    pid = fork();

    switch (pid) {
        case -1:
            printf("NO SE HA PODIDO CREAR HIJO.\n");
            exit(-1);

        case 0:
            close(fd[0]);
            write(fd[1], saludoHijo, strlen(saludoHijo));
            printf("El HIJO ENVIA MENSAJE AL PADRE...\n");
            close(fd[1]);
            break;

        default:
            close(fd[1]);
            read(fd[0], buffer, sizeof(buffer));
            printf("El PADRE recibe algo del pipe: %s\n", buffer);
            close(fd[0]);
            wait(NULL);
            break;
    }

    return 0;
}
