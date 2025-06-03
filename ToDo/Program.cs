// See https://aka.ms/new-console-template for more information
using System.Collections.Generic;
Console.WriteLine("Hello, World!");

List <Tarea> pendiente = new List<Tarea>();
List<Tarea> realizada = new List<Tarea>();

Tarea uno = new Tarea();
uno.Descripcion = "lavar";
uno.Duracion = 5;
uno.TareaID = 1;

Tarea dos = new Tarea();
dos.Descripcion = "planchar";
dos.Duracion = 5;
dos.TareaID = 2;


pendiente.Add(uno);
pendiente.Add(dos);
foreach (Tarea a in pendiente)
{
    Console.WriteLine("tarea:" + a.Descripcion + " duracion:" + a.Duracion + "hs Id:" + a.TareaID);
}
mover(pendiente, realizada, 2);

foreach (Tarea a in pendiente)
{
    Console.WriteLine("tarea:" + a.Descripcion + " duracion:" + a.Duracion + "hs Id:" + a.TareaID);
}



static void mover(List<Tarea> pen, List<Tarea> reali, int id)
{

    Tarea tareaEncontrada = null;
    foreach (Tarea a in pen)
    {
        if (a.TareaID == id)
        {
            tareaEncontrada = a;
        }
    }
    if (tareaEncontrada != null)
    {
        pen.Remove(tareaEncontrada);
        reali.Add(tareaEncontrada);
    }
}

public class Tarea
{
    public int TareaID { get; set; }
    public string Descripcion { get; set; }
    public int Duracion { get; set; } // Validar que esté entre 10 y 100
                                      // Puedes añadir un constructor y métodos auxiliares si lo consideras necesario
}
