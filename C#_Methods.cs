/*Metodos*/
//Los metodos son bloques de codigo que nosotros creamos en nuestro programa
//Para correr estas lineas de codigo, debemos llamar el metodo en nuestro metodo Main()
//Asignar distintos nombres a cada metodo que creemos nos ayudara a mantener un codigo ordenado
//Podemos especificar un cierto tipo de dato a usar dentro de nuesto metodo(method function) definiendo sus parametros
//Los parametros pueden usarse en nuestra funcion como una manera de tomar cierto tipo de dato y usarlo dentro del metodo

class OurProgram{
    private static void Main(){
        //Calculate(); asi llamamos un metodo (ahora son funciones)
        //CalcUserInput(); los () se llaman parametros, datos con los que cuenta un metodo, tambien se llaman argumentos
        
        //System.Console.Write("Porfavor ingresa un numero para realizar la suma ");
        //string userInput = System.Console.ReadLine();
        //CalcUserInputParams(userInput);
    }
    
    //private static void Calculate(){
        //int valorUno = 2;
        //int valorDos = 3;
        //int result;

        //result = valorUno + valorDos;
        //System.Console.Write(result);
    //}

    //private static void CalcUserInput(){
      //  System.Console.Write("Please enter a number to be added");
      //  int valueFive = 5; //le asiganmos un valor a una variable
      //  int userInput = System.Convert.ToInt32(System.Console.ReadLine()); //el usuario determina el valor del numero 2 ingresandolo mediante el teclado

      //  int result = valueFive + userInput; //definimos nuestro resultado
      
      //  System.Console.Write("That number plus 5 is " + result); //mostramos el resultado
    //}
    private static void CalcUserInputParams(string userParams){
        int valueFive = 5;
        int userInput = System.Console.ToInt32(System.Console.ReadLine(userParams));//usamos nuestros parametros para transformar el dato que el usuario ingrese a un tipo String
        int resultado = valueFive + userInput;
        System.Console.Write("Ese numero más 5 es "+ resultado);
    }
}