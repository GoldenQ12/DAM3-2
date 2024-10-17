#include <stdlib.h>
#include <unistd.h>
#include <stdio.h>
#include <sys/wait.h>

void main(void)
{
    pid_t pa1, pa2, pa11, pa12, pa121;

    pa1 = fork();  // Crea el primer proceso hijo

    if (pa1 == -1) { // error al crear el proceso hijo
        printf("No se ha podido crear el proceso hijo pa1...\n");
        exit(-1);
    }

    if (pa1 == 0) { // Estamos en el primer hijo (pa1)
        pa11 = fork();  // Crea un hijo (pa11) dentro de pa1
        if (pa11 == 0) {
            // Este es el proceso pa11
            printf("\tSoy el proceso pa11 %d; Mi padre es: %d\n", getpid(), getppid());
        } else {
            wait(NULL);  // Espera a pa11
            pa12 = fork();  // Crea otro hijo (pa12) dentro de pa1

            if (pa12 == -1) {
                printf("No se ha podido crear el proceso hijo pa12 en el HIJO\n");
                exit(-1);
            }

            if (pa12 == 0) { // Estamos en el proceso pa12
                pa121 = fork();  // Crea un hijo (pa121) dentro de pa12
                if (pa121 == 0) {
                    printf("\t\tSoy el proceso pa121 %d; Mi padre es: %d\n", getpid(), getppid());
                } else {
                    wait(NULL);  // Espera a pa121
                    printf("\t\tSoy el proceso pa12 %d; Mi padre es: %d\n", getpid(), getppid());
                }
            } else {
                wait(NULL);  // Espera a pa12
                printf("\tSoy el proceso pa1 %d; Mi padre es: %d\n", getpid(), getppid());
            }
        }
    } else {  // Estamos en el proceso padre
        wait(NULL);  // Esperamos finalización del proceso hijo pa1
        pa2 = fork();  // Crea el segundo proceso hijo pa2

        if (pa2 == -1) { // error al crear el proceso hijo pa2
            printf("No se ha podido crear el proceso hijo pa2...\n");
            exit(-1);
        }

        if (pa2 == 0) { // Estamos en el segundo hijo pa2
            printf("Soy el proceso pa2 %d; Mi padre es: %d\n", getpid(), getppid());
        } else {  // Proceso padre
            wait(NULL);  // Esperamos finalización del proceso hijo pa2
            printf("Soy el proceso padre: %d, Mis HIJOS: %d y %d terminaron \n", getpid(), pa1, pa2);
        }
    }

    exit(0);
}