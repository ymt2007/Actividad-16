using System;
using System.Collections.Generic;

Dictionary<string, Producto> productos = new Dictionary<string, Producto>();

int op;
do
{
    Console.WriteLine("1. Agregar producto");
    Console.WriteLine("2. Modificar producto");
    Console.WriteLine("3. Eliminar producto");
    Console.WriteLine("4. Buscar producto");
    Console.WriteLine("5. Mostrar todos");
    Console.WriteLine("6. Salir");

    op = int.Parse(Console.ReadLine());

    switch (op)
    {
        case 1:
            Console.WriteLine("Ingrese codigo:");
            string codigo = Console.ReadLine();

            if (productos.ContainsKey(codigo))
            {
                Console.WriteLine("El codigo ya existe");
            }
            else
            {
                Producto p = new Producto();

                Console.WriteLine("Ingrese nombre:");
                p.Nombre = Console.ReadLine();

                Console.WriteLine("Ingrese precio:");
                p.Precio = double.Parse(Console.ReadLine());

                p.Codigo = codigo;

                productos.Add(codigo, p);

                Console.WriteLine("Producto agregado");
            }
            break;

        case 2:
            Console.WriteLine("Ingrese codigo a modificar:");
            string codMod = Console.ReadLine();

            if (productos.ContainsKey(codMod))
            {
                Console.WriteLine("Nuevo nombre:");
                productos[codMod].Nombre = Console.ReadLine();

                Console.WriteLine("Nuevo precio:");
                productos[codMod].Precio = double.Parse(Console.ReadLine());

                Console.WriteLine("Producto modificado");
            }
            else
            {
                Console.WriteLine("No existe el producto");
            }
            break;

        case 3:
            Console.WriteLine("Ingrese codigo a eliminar:");
            string codEl = Console.ReadLine();

            if (productos.ContainsKey(codEl))
            {
                productos.Remove(codEl);
                Console.WriteLine("Producto eliminado");
            }
            else
            {
                Console.WriteLine("No existe el producto");
            }
            break;

        case 4:
            Console.WriteLine("Ingrese codigo a buscar:");
            string codBus = Console.ReadLine();

            if (productos.ContainsKey(codBus))
            {
                Producto p = productos[codBus];

                Console.WriteLine($"Codigo: {p.Codigo}");
                Console.WriteLine($"Nombre: {p.Nombre}");
                Console.WriteLine($"Precio: {p.Precio}");
            }
            else
            {
                Console.WriteLine("No existe el producto");
            }
            break;

        case 5:
            foreach (var p in productos)
            {
                p.Value.MostrarDatos();
            }
            break;

        case 6:
            Console.WriteLine("Saliendo...");
            break;

        default:
            Console.WriteLine("Opcion invalida");
            break;
    }

} while (op != 6);

class Producto
{
    public string Codigo;
    public string Nombre;
    public double Precio;
    public void MostrarDatos()
    {
        Console.WriteLine($"Codigo: {Codigo} Nombre: {Nombre} Precio: {Precio}");
    }
}