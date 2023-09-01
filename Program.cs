//Ingresar por pantalla 2 números y calcular las 4 operaciones aritméticas con 
//dichos números. Imprimir en pantalla el resultado de cada operación.
//Realizar un algoritmo que me pida 3 números por pantalla, con el primer número
//hallar el cuadrado, con el segundo número hallar la raíz cuadrada y 
//con el tercer número hallar la raíz cúbica. Mostrar en pantalla los 3 resultados aritméticos.

//1 se define la clase del programa con su respectivo metodo main

public class MiPrimerPrograma //Pascal case
{
    
    static void Main(string[] arg)
    {
        //2 declaracion de variables
        int num1, num2, suma, resta, multi, divi;
       

        //3 pedir los valores por pantalla

        Console.Write("Escriba el primer numero: ");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.Write("Escriba el segundo numero: ");
        num2 = Convert.ToInt32(Console.ReadLine());

        //4 realizar los calculos

        suma = num1 + num2;
        resta = num1 - num2;
        multi = num1 * num2;
        divi = num1 / num2;

        //5 mostrar resultados
        Console.Write("la suma es: "+ suma);
        Console.Write("\n");
        Console.Write("la resta es: "+ resta);
        Console.Write("\n");
        Console.Write("la multiplicacion es: "+ multi);
        Console.Write("\n");
        Console.Write("la divicion es: "+ divi);


    }



}
