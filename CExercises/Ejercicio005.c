#include <stdio.h>
#include <unistd.h>
#include <stdlib.h>


void main(){
    pid_t pid;
    int num = 6;
    pid = fork();

    if(pid == -1){
        printf("Error al crear proceso");
        exit(-1);
    } 
    else{
        if(pid == 0){
        num -= 5;
        printf("Variable en Proceso Hijo: %d", num);
        } else{
            num += 5;
            printf("Variable en Proceso Padre: %d", num);
        }
    }
}
