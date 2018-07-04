//Las clases contienen metodos, pero las clases se encuentran dentro de Namespaces
//Nuestro programa puede saber que metodo llamar al hacer uso de un namespace
//Podemos eliminar el tener que escribir System al añadir en namespace system al principio del programa
using System; //para definir que namespace estamos utilizando, basta con utilizar la palabra using seguida del nombre del namespace que vamos a utilizar
class OurProgram{
    static void Main(){
        CalcUserInput();
    }

    static void CalcUserInput(){
        //Ahora podemos retirar la palabra System del resto de nuestro codigo para mantener un codigo mas limpio y ordenado, debemos evitar repetir el namespace
        Console.Write("Please enter a number to be added ");
        int valueFive = 5;
        int userInput = Console.ToInt32(Console.ReadLine());
        int result = valueFive + userInput;
        Console.Write("That number plus 5 is "+ result);
    }
}