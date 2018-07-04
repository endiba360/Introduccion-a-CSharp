/*Condicionales*/
//Cuando creamos un programa que contiene un poco mas de logica, probablemente desearemos que nuestro codigo corra dependiendo de ciertas cosas que sucedan dentro de el
//En este caso necesitaremos usar Condicionales para dirigir nuestro programa hacia donde debe ir, o que es lo que debe hacer si sucede algo en especifico
//Por ejemplo, si queremos cambial un valor Boolean de true a false, podemos hacerlo dependiendo de cierto input del usuario
//Condicionales basicos son if/else if/else if/else 

using System;
class OurProgram{
    static void Main(){
        CalcUserInput();
    }
    static void CalcUserInput(){
        Console.Write("Please enter a number between 1 and 10");
        int userInput = Convert.ToInt32(Console.ReadLine());
        //If/else conditional
        //Si el numero que ingrese el usuario es mayor o igual a 1 Y menor o igual a 5
        /*if(userInput >= 1 && userInput <= 5){
            //Entonces se escribe en la pantalla el mensaje correspondiente
            Console.Write("That number is between 1 and 5");
        }else{
            //Si la condicion no se cumple, entonces entramos al else, donde debemos escribir que sucede si no se cumple la condicion
            //en este caso se muestra otro mensaje en la pantalla
            Console.Write("That number is greater than 5");
        }*/
        
        //if/else else if
        /*if(userInput > 1 && userInput < 5){
            Console.Write("That number is between 1 and 5");
        }else if(userInput > 5 && userInput < 10){
            Console.Write("That number is between 5 and 10");
        }else{
            Console.Write("That number is not within our range");
        }*/

        //A su vez podemos agregar booleans para disparar diferentes resultados usando condicionales
        bool outOfRange = false; //se utiliza un solo signo = para usar el "igualque"
        if(userInput > 1 && userInput < 5){
            Console.Write("That number is between 1 and 5");
        }else if(userInput > 5 && userInput < 10){ //si el numero que ingrese el usuario es mayor a 1 Y el numero que ingrese el usuario es menor a 10
            Console.Write("That number is between 5 and 10");
        }else if(userInput < 1 || userInput > 10){ //si el numero que ingrese el usuario es menor a 1 O el numero que ingrese el usuario es mayor a 10
            outOfRange = true;
            if(outOfRange == true){ //se utilizan dos signos de = para comparar un valor con otro
                Console.Write("that number is out of range");
            }
        }else{
            Console.Write("That number is 1, 5 or 10");
        }
    }
}