using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Inteligencias_multiples
{
    public class BDcon
    {
        public static NpgsqlConnection ObtenerConexion()
        {
            NpgsqlConnection conectar = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = administrador; Password = administrador; Database = Res");
            conectar.Open();
            return conectar;
        }
        public static NpgsqlConnection CerrarConexion()
        {
            NpgsqlConnection desconectar = new NpgsqlConnection("Server = localhost; Port = 5432; User Id = administrador; Password = administrador; Database = Res");
            desconectar.Close();
            return desconectar;
        }
    }
}
