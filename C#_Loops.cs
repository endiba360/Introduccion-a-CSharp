/*Loops*/
//Crear mas funcionalidad para nuestras aplicaciones escribiendo condicionales puede convertirce en algo repetitivo y tomar mucho codigo que implementar
//Una manera mas rapida y efectiva de hacer que nuestro programa realice las mismas tareas que realizabamos con todas esas condicionaes es utilizando Loops
//Existen diferentes tipos de Loops que pueden ser usados, usados para que nuestro codigo realice una tarea dependiendo en una condicion
//En este ejemplo analizaremos las herramientas for y while (los loops o bucles escenciales)

using System;
class OurProgram{
    static void Main(){

        CalcUserInput();
    
    }
    static void CalcUserInput(){
        Console.Write("Please enter a number between 1 and 10");
        int userInput = Convert.ToInt32(Console.ReadLine());

        //WHILE Loop
        /*while(userInput < 10){ //mientras el input del usuario sea menor a 10
            userInput += 1; //se le sumara un 1
            Console.Write(userInput + "\n");// "\n" significa que se dara un salto de linea en la pantalla
            if(userInput > 18 || userInput < 1){
                //si el input llega a ser mayor a 18 o es menor a 1
                break;
                //el programa finaliza
            }
        }
        Console.Write("Process Done");*/// y se visualiza el mensaje final
        //FOR Loop
        int i;//Para hacer uso del FOR loop debemos utilizar una variable de tipo int que se llamara i, la cual tendra el valor de nuestro userInput solo para realizar el proceso
        for(i = userInput; i <= 10; i++){ //Se asigna el valor de userInput a i, se escrbibe la comparativa o la condicion, y se incrementa el valor de i (los signos ++ significan un incremento)
            Console.Write(i + "\n");
            if(userInput >10 || userInput < 1){
                break;
            }
        }Console.Write("Process Done!");
    }
}