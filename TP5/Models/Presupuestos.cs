using System;

namespace TP5.Models;
/*
● Presupuestos
    ○ int IdPresupuesto
    ○ string nombreDestinatario
    ○ List<PresupuestoDetalle> detalle
    ○ Metodos
        ■ MontoPresupuesto ()
        ■ MontoPresupuestoConIva()
        ■ CantidadProductos ()
*/
public class Presupuestos
{
    public Presupuestos(int idPresupuesto, string nombreDestinatario, List<PresupuestosDetalle> vdetalle)
    {
        IdPresupuesto = idPresupuesto;
        this.nombreDestinatario = nombreDestinatario;
        this.vdetalle = vdetalle;
    }

    public int IdPresupuesto{get;private set;}
    public string nombreDestinatario{get;private set;}
    public List <PresupuestosDetalle>vdetalle {get;private set;}

}