#include <stdlib.h>
#include <stdio.h>
//Inclusion of libraries.
int main() {
    //The program's purpose is to inform the user if his expenses are exceeding his monthly salary.
    
    int gastos, salario;
    //Declaration of expense and salary variables.
    
    printf ("Type your monthly salary:\n");
    scanf ("%d",&salario);
    //Prompting the user to enter their salary
    printf ("Enter your spending this month:\n");
    scanf ("%d",&gastos);
    //Asking the user to enter their expenses.
    
    if (gastos > salario){
        
        printf ("Too much. You've exceeded your salary.");
        return 0;
    }
    //If expenses are greater than salary, inform that the user has exceeded his/her salary and terminate the program.
    
    if (gastos < salario){
        printf ("You've used less than half of your salary,\n");
        
    }
    //If expenses are less than salary, inform that the user has not yet exceeded his/her salary and continue the program.
    if (gastos < (salario/2)){
        printf("but its ok, you can use more.");
    }
    //If expenses are less than half of the salary, inform that the user can still spend more.
    if (gastos >= (salario/2)){
        
        printf("but hold back a bit, you've used more than half.");
    }
    //If expenses are greater than half of the salary, inform the user to be careful with further expenses.
    
    
    return 0;
}
