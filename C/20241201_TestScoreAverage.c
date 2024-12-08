/*Purpose of the program is to calculate the score avg of 3 test scores, and show the user if has passed or failed a class,
or if he must take a "remedial test" to increase score*/
//Inclusion of Libraries
#include <stdlib.h>
#include <stdio.h>

//Criation of the function that will calculate the grades average
int calcularMedia (int a, int b, int c){
    float media;
    media = (a +  b + c) / 3;
    return media;
}

int main() {
   
   int nota1,nota2,nota3;
   float media;
   //Declaring the three grade variables and the average
   printf("Type your first test score:\n");
   scanf("%d",&nota1);
   //Prompting the user for the first grade
   printf("Type your second test score:\n");
   scanf("%d",&nota2);
   //Prompting the user for the second grade
   printf("Type your third test score:\n");
   scanf("%d",&nota3);
   //Prompting the user for the third grade
   media = calcularMedia(nota1,nota2,nota3);
   //Indicating to the program that the media float variable is equal to the calcularMedia function of the variables nota1, nota2, e nota3
   printf("Score average: %.2f\n",media);
   //Showing the user the average of his grades
   if (media >= 7){
    printf("Approved");
   }
   if (media >= 5 && media < 7){
    printf("Remedial test");
   }
   if (media < 5){
    printf("Failed");
   }
   //Showing the user his situation depending on his average score
   
    return 0;
}
