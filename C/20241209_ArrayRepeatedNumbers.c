/*Purpose of the program is to allow the user to
set the size of an array, fill the array, and count repeated numbers.
Code written in portuguese, originally written for
a uni project*/

#include <stdio.h>

int main() {
    int tamanhoi, tamanhoj, i, j, k, l, igual = 0;

    printf("Defina o tamanho do vetor no eixo i ---->\n");
    scanf("%d", &tamanhoi);
    printf("Defina o tamanho do vetor no eixo j ---->\n");
    scanf("%d", &tamanhoj);

    
    int vetor[tamanhoi][tamanhoj];
    int verificado[tamanhoi][tamanhoj]; 

    
    for (i = 0; i < tamanhoi; i++) {
        for (j = 0; j < tamanhoj; j++) {
            verificado[i][j] = 0;
        }
    }

    
    for (i = 0; i < tamanhoi; i++) {
        for (j = 0; j < tamanhoj; j++) {
            printf("Insira o numero [%d][%d] do vetor: ", i, j);
            scanf("%d", &vetor[i][j]);
        }
    }

    
    for (i = 0; i < tamanhoi; i++) {
        for (j = 0; j < tamanhoj; j++) {
            
            if (verificado[i][j]) {
                continue;
            }
            for (k = 0; k < tamanhoi; k++) {
                for (l = 0; l < tamanhoj; l++) {
                    
                    if ((i != k || j != l) && vetor[i][j] == vetor[k][l] && !verificado[k][l]) {
                        igual++;
                        verificado[k][l] = 1;
                    }
                }
            }
            verificado[i][j] = 1; 
        }
    }

    printf("O numero de valores repetidos é: %d\n", igual);

    return 0;
}
