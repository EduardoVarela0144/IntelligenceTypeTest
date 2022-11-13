using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Inteligencias_multiples
{
    public class UsuarioDao
    {
       public static int Insertar_Usuario(Usuario Usuario)
        {
            int retorno = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("Insert into usuario (nombre,fecha_n,correo,celular,fecha_a,hora_a,respuestas_id) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}')",
            Usuario.Nombre,Usuario.FechaN,Usuario.Correo,Usuario.Celular,Usuario.FechaA,Usuario.HoraA,Usuario.Respuestas_ID), BDcon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            BDcon.CerrarConexion();
            return retorno;
        }
    }
}
