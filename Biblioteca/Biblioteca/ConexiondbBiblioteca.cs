using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace Biblioteca
{
    class ConexiondbBiblioteca
    {
        string cadena = "Data source=PC-PC\\TEW_SQLEXPRESS;Initial Catalog=documentos; Integrated Security= True";
        public SqlConnection conectarbd = new SqlConnection();
        
        public ConexiondbBiblioteca()
        {
            conectarbd.ConnectionString = cadena;
        }

        public void abrir()
        {
            try
            {
                conectarbd.Open();
                Console.WriteLine("Conexion abierta");
            }
            catch (Exception ex )
            {
                Console.WriteLine("Error al abrir la base de datos"+ex.Message);
            }
        }

        public void cerrar()
        {
            conectarbd.Close();
        }
    }

}
