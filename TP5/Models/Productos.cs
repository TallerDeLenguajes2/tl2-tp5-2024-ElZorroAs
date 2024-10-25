using System;

namespace TP5.Models;
/*
● Productos
    ○ int idProducto
    ○ string descripcion
    ○ int precio
*/
public class Productos
{
    public Productos(int idProducto, string descripcion, int precio)
    {
        this.idProducto = idProducto;
        this.descripcion = descripcion;
        this.precio = precio;
    }

    public int idProducto{get;private set;}
    public string descripcion{get;private set;}
    public int precio{get;private set;}
}
