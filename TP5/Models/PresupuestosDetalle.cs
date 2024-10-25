using System;

namespace TP5.Models;
/*
● PresupuestosDetalle
    ○ Productos producto
    ○ int cantidad
*/
public class PresupuestosDetalle
{
    public PresupuestosDetalle(Productos producto, int cantidad)
    {
        this.producto = producto;
        this.cantidad = cantidad;
    }

    public Productos producto{get;private set;}
    public int cantidad{get;private set;}
    
}