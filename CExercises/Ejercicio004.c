#include <stdlib.h>
#include <unistd.h>
#include <stdio.h>
#include <sys/wait.h>  // For wait() system call

// ABUELO-HIJO-NIETO
int main() {
    pid_t pid, Hijo_pid, pid2, Hijo2_pid;

    pid = fork();  // Soy el Abuelo, creo al Hijo

    if (pid == -1) { // Ha ocurrido un error
        printf("No se ha podido crear el proceso hijo...\n");
        exit(-1);
    }

    if (pid == 0) { // Nos encontramos en Proceso Hijo
        pid2 = fork();  // Soy el Hijo, creo al Nieto

        switch (pid2) {
            case -1:  // Error
                printf("No se ha podido crear el proceso hijo en el HIJO...\n");
                exit(-1);
                break;

            case 0:  // Proceso Nieto
                printf("\t\tSoy el proceso NIETO %d; Mi padre es = %d\n", getpid(), getppid());
                break;

            default:  // Proceso Hijo (padre del Nieto)
                Hijo2_pid = wait(NULL);  // Espera la terminación del Nieto
                printf("\tSoy el proceso HIJO %d, Mi padre es: %d.\n", getpid(), getppid());
                printf("\tMi hijo: %d terminó.\n", Hijo2_pid);
                break;
        }
    } else {  // Nos encontramos en Proceso Abuelo
        Hijo_pid = wait(NULL);  // Espera la finalización del proceso Hijo
        printf("Soy el proceso ABUELO: %d, Mi HIJO: %d terminó.\n", getpid(), pid);
    }

    exit(0);
}
