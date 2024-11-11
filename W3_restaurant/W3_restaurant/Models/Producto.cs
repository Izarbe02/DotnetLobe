namespace Models;

public abstract class Producto {
    public string Nombre {get;set;}
    public double Precio {get;set;}

    public Producto(string nombre, double precio) {
        Nombre = nombre;
        Precio = precio;

        if (precio < 0) {
            throw new ArgumentException("El precio no puede ser negativo");
        }
    }

    public abstract void MostrarDetalles();

   // public abstract string MostrarDetallesGuardado();

}
