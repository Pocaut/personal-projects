#include <stdlib.h>
#include <stdio.h>
//Inclusion of Libraries

int contarPares (int numeros[20]){
    int pares=0,i;
    //Initializing the variable pares and declaring viariable i
    for(i=0;i<20;i++){
    if (numeros[i]%2==0){
        pares++;
    }
    //Loop to check the division remainder of the array number, counting the even numbers
    }
    return pares;
}
//Creating a function to count Even Numbers within an array
int main() {
    
    int numeros[20], i, pares;
    //Declaring the array numeros, variables i and pares;
    
    for (i=0;i<20;i++){
        printf ("Digite o numero da posição [%d] do vetor\n",i);
        scanf ("%d",&numeros[i]);
    }
    //Loop to prompt the user to fill in the array
  
  printf ("O numero de pares é %d\n",pares = contarPares(numeros));
  //Show the amount of even numbers by declaring that the variable pares is equla to the function contarPares in relation to the array

    return 0;
}
