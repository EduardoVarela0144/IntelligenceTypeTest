using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_Inteligencias_multiples
{
    public class Respuestas
    {
        public string Respuestas_ID { get; set; }
       
        public string Respuestas_V_F { get; set; }
        public int Vl { get; set; }
        public int Lm { get; set; }
        public int Ve { get; set; }
        public int Cp { get; set; }
        public int M { get; set; }
        public int Inter { get; set; }
        public int Intra { get; set; }
        public int N { get; set; }
        public string Respuestas_R { get; set; }


        public Respuestas() { }

        public Respuestas(string Respuestas_ID, string Respuestas_R,string Respuestas_V_F,int vl,int lm,int ve,int cp,int m,int inter,int intra,int n)
        {
            this.Respuestas_ID = Respuestas_ID;
            this.Respuestas_V_F = Respuestas_V_F;
            this.Vl = vl;
            this.Lm = lm;
            this.Ve = ve;
            this.Cp = cp;
            this.M = m;
            this.Inter = inter;
            this.Intra = intra;
            this.N = n;
            this.Respuestas_R = Respuestas_R;
        }
    }
}
