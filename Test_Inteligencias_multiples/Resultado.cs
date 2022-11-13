using MaterialSkin;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Test_Inteligencias_multiples
{
    public partial class Resultado : MaterialSkin.Controls.MaterialForm
    {
        public Resultado()
        {
            InitializeComponent();
        }

        private void Resultado_Load(object sender, EventArgs e)
        {
            //Definimos nuevo esquema de colores
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
            SkinManager.AddFormToManage(this);
            //Mostramos resultados
            Tipo.ForeColor = Color.LimeGreen;
            Tipo.Text = Test.Enviar_tipo;
            //Agregamos información a la gráfica
            double[] data = new double[] {
                Test.contadorvl,
                Test.contadorlm, 
                Test.contadorve, 
                Test.contadorcp,
                Test.contadorm,
                Test.contadorinter,
                Test.contadorintra,
                Test.contadorn
                 };
            string[] inteligencias = new string[] {
                "Verbal lingüística",
                "Lógica matemática",
                "Viso espacial", 
                "Cinético corporal",
                "Musical",
                "Interpersonal",
                "Intrapersonal",
                "Naturalista"
            };
            chart1.Series["Series1"].Points.DataBindXY(inteligencias, data);
        }

        private void Resultado_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
