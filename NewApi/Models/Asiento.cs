namespace Models;

public class Asiento{

public int Fila{get; set;}

public int Columna{get; set;}

public int Id {get;  set;}

public bool Ocupado { get; set;}



Asiento (int fila, int columna, int Id, bool ocupado){

    Fila = fila;
    Columna = columna;
    Id = Id
    Ocupado = ocupado;

}

    public bool EstaOcupado()
    {
        return Ocupado;
    }


    public void OcuparAsiento()
    {
        Ocupado = true;
    }


    public void DesocuparAsiento()
    {
        Ocupado = false;
    }

}




