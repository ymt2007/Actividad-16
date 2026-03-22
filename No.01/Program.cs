using System;
using System.Collections.Generic;

Dictionary<string, Producto> productos = new Dictionary<string, Producto>();
int op;
do
{
    Console.WriteLine("Bienvenido al menu, eliga la opcion que necesite");
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Modificar producto");
    Console.WriteLine("3. Eliminar producto");
    Console.WriteLine("4. Buscar producto");
    Console.WriteLine("5. Mostrar todos los productos");
    Console.WriteLine("6. salir");
     op=int.Parse(Console.ReadLine());
} while (op!=6);

class Producto
{
    public string Codigo;
    public string Nombre;
    public double Precio;
}