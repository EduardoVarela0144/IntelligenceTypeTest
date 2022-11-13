using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Inteligencias_multiples
{
    public class Usuario
    {
        
        public string Nombre { get; set; }
        public string FechaN { get; set; }
        public string Correo { get; set; }
        public Int64 Celular { get; set; }
        public string FechaA { get; set; }
        public string HoraA { get; set; }
        public string Respuestas_ID { get; set; }
        


        public Usuario() { }

        public Usuario(string Nombre,string FechaN,string Correo,Int64 Celular,string FechaA,string HoraA,string Respuestas_ID)
        {
            this.Nombre = Nombre;
            this.FechaN = FechaN;
            this.Correo = Correo;
            this.Celular = Celular;
            this.FechaA = FechaA;
            this.HoraA = HoraA;
            this.Respuestas_ID = Respuestas_ID;
        }
    }
}
