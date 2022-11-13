using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Inteligencias_multiples
{
    public class Respuestas_Dao
    {
        public static int Insertar_Respuestas(Respuestas Respuestas)
        {
            int retorno = 0;
            NpgsqlCommand comando = new NpgsqlCommand(string.Format("Insert into respuestas (respuestas_id,respuestas_v_f,vl,lm,ve,cp,m,inter,intra,n,respuestas_r) values ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}')",
            Respuestas.Respuestas_ID,Respuestas.Respuestas_V_F,Respuestas.Vl,Respuestas.Lm,Respuestas.Ve,Respuestas.Cp,Respuestas.M,Respuestas.Inter,Respuestas.Intra,Respuestas.N, Respuestas.Respuestas_R), BDcon.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();
            BDcon.CerrarConexion();
            return retorno;
        }
        
    }
}
