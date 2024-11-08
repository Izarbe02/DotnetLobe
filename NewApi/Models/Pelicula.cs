namespace Models;


public class Pelicula
{
    public int Id { get; set; }
    public string Nombre { get; set; }
    public string Director { get; set; }
    public string Sinopsis { get; set; }
    public decimal Precio { get; set; }
}
    public Pelicula(string nombre, int id, string director,  string sinopsis,int precio) {
        Nombre = nombre;
        Id = id;
        Director = director;
        Sinopsis = sinopsis;
        Precio = precio;

    }
    



/*public void MostrarPedido() {
    Console.WriteLine("\n-------Pedido------");
    foreach (var producto in productos) {
        producto.Item1.MostrarDetalles();
        Console.WriteLine($"Cantidad: {producto.Item2}");
    }

    var dateFormatterstring = "dd/MM/yy HH:mm";
    Console.WriteLine($"Fecha pedido: {FechaPedido.ToString(dateFormatterstring)}");
    var fechaEntrega = FechaPedido.AddMinutes(30);
    var dateFormatterstringEntrega = "dd/MM/yyyy HH:mm:ss";
    Console.WriteLine($"Tu pedido se entregará a las : {fechaEntrega.ToString(dateFormatterstringEntrega)}");
}*/

    public void pelicula.MostrarDetalles();


