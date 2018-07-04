/*Introduccion a C#*/
//Estructura de un archivo .cs
//Cuando definimos una clase, es lo primero que creamos cuando construimos un nuevo archivo C#
//Una clase funciona como la Casa para nuestro codigo, pues todo lo que estaremos programando se encontrara dentro de la clase
//Nuestro primer metodo tendra siempre el nombre Main() el cual sera siempre el primer metodo a ser llamado entre cualquier clase
//Cualquier metodo que creemos despues podra tener cualquier nombre, sin embargo, nuestro primer metodo siempre debe ser llamado Main()

class OurProgram{
    //Todos los metodos llevaran las palabras static void y en seguida el nombre del metodo
    //void significa que el metodo regresa un tipo de dato vacio = void
    //static significa que todos en la clase comparten este metodo
    static void Main(){
	System.Console.Write("Hola mundo!");
    //dentro de nuestra clase escribimos la primera instruccion que realizara nuestro programa
    //System.Console.Write son las palabras para indicarle a la computadora que queremos escribir algo en pantalla
    //Write("Hola mundo!"); dentro de los () va nuestro mensaje acompañado de "" que indican que estamos escribiendo texto
    //al final de cada instruccion debemos escribir ; para indicar el fin
    }
}