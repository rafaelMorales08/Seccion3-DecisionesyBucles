
using System.Windows.Markup;

var cantidad1 = 5;
var canitdad2 = 5;

var cantidadIgualAcantidad2 = cantidad1 == canitdad2;

var cantidad1EsDiferemteCantidad2 = cantidad1 != canitdad2;

Console.WriteLine($"son {cantidad1} y {canitdad2} iguales? {cantidadIgualAcantidad2}");
Console.WriteLine($"son {cantidad1} y {canitdad2} diferentes? {cantidad1EsDiferemteCantidad2}");

var esCantidad1Menorque10 = cantidad1 < 10;
var esCantidad1Mayorque10 = cantidad1 > 10;

var nombre1 = "rafa";
var nombre2 = "claudia";

var sonIgualLosNombre = nombre1 == nombre2;

//tienen que ser true ambas si una es false ya todo es falso
var cantidad = 6;
var estaEntre5y10 = cantidad > 5 && cantidad < 10;
Console.WriteLine($"esta el {cantidad} entre 5 y 10 {estaEntre5y10}");

//verdadero si se cumple las condiciones
//falso si no se cimple la condicion
var cantidadEs5o6 = cantidad == 5 || cantidad == 6;
Console.WriteLine("|| " + cantidadEs5o6);

//EVITAR UN ERRO DE REFERENCIA NULA

string? apellido = "MORALES";

var ElApellidoEstaEnMayuscula = apellido is not null && apellido == apellido.ToUpper();
Console.WriteLine(ElApellidoEstaEnMayuscula);


var numero = 4;

if (numero > 2)
{
    Console.WriteLine("es mayor..");

}
else
{
    Console.WriteLine("es menor..");

}

bool usuarioLogeado = false;

string mensajeBienvenido = usuarioLogeado ? "true" : "false";
Console.WriteLine(mensajeBienvenido);


//ejemplo de or

var hoy = DateTime.Today;

var estacion = hoy.Month switch
{

    3 or 4 or 5 => "primavera",
    6 or 7 or 8 => "verano",
    9 or 10 or 11 => "otoño",
    12 or 1 or 2 => "invierno",
    _ => throw new ApplicationException("mes incorrecto")
};

Console.WriteLine(estacion);



int contador = 1;

while (contador <= 10) {

    Console.WriteLine(contador);
    contador++;
}