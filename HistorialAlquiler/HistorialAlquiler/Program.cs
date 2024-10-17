using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Design;
using System.Data;
using Microsoft.Data.SqlClient;

using Conexion;
using System.Runtime.CompilerServices;

// Variables locales
string cadenaConex = @"Server=192.168.184.172,1433;Database=Pruebas;Uid=pruebas;Pwd=pruebas;TrustServerCertificate=tTrue";
//se utiliza using para asgurarnos de la destruccion de los objetos y liberar recursos
using (SqlConnection con = new SqlConnection(cadenaConex))
{         
    List<historialAlquiler> lisHistorico = new List<historialAlquiler>();
    using (SqlCommand com = new SqlCommand())
    {
        try {
            com.Connection = con ;
            com.CommandType = CommandType.StoredProcedure;
            com.CommandText = "dbo.historialAlquileres";

            //parametros de entrada
            com.Parameters.AddWithValue("@nombre", "Anton");
            con.Open();

            if (con.State == ConnectionState.Open){
                            SqlDataReader lector = com.ExecuteReader();
                            while  (lector.Read())
                            {
                                if (lector != null){
                                    historialAlquiler item = new historialAlquiler();
                                    item.Titulo = lector ["Titulo"] != DBNull.Value? lector ["TITULO"].ToString() : string.Empty;
                                    item.Socio = lector ["Socio"] !=  DBNull.Value? lector  ["Socio"].ToString() : string.Empty;
                                    item.idEjemplar = lector ["idEjemplar"] != DBNull.Value? lector ["idEjemplar"].ToString() :  string.Empty;
                                    item.nombreActor = lector ["nombreActor"] != DBNull.Value? lector ["nombreActor"].ToString() : string.Empty;
                                    item.nombreDirector = lector ["nombreDirector"] != DBNull.Value? lector ["nombreDirector"].ToString() : string.Empty;
                                    item.fechaPrestamo = lector ["fechaPrestamo"] != DBNull.Value? lector ["fechaPrestamo"].ToString() : string.Empty;
                                    item.fechaDevolucion = lector ["fechaDevolucion"] != DBNull.Value? lector ["fechaDevolucion"].ToString() : string.Empty;
                                    lisHistorico.Add(item);

                    }
                }
                lector.Close();
            }
        }
        catch(Exception e){
           Console.WriteLine("ERROR :  " + e.Message);
        }
        finally{
            con.Close();
            Console.WriteLine("Conexión con base de datos cerrada.");
        }
        foreach ( historialAlquiler item  in  lisHistorico){
            Console.WriteLine($"{item.Titulo};{item.Socio};{item.idEjemplar};{item.nombreActor};{item.nombreDirector};{item.fechaPrestamo};{item.fechaDevolucion};");
        }

    }
}




