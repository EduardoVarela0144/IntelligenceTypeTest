using MaterialSkin;
using System;
using System.Windows.Forms;

namespace Test_Inteligencias_multiples
{
    public partial class Registro : MaterialSkin.Controls.MaterialForm
    {

        public static string Nombre;
        public static string Fn;
        public static string Correo;
        public static Int64 celular;
        public static string Fa;
        public static string Ha;
        public Registro()
        {
            InitializeComponent();
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            //Definimos nuevo esquema de colores
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
            SkinManager.AddFormToManage(this);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            var dt = DateTime.Now;
            Nombre = TextNombre.Text;
            Fn = fn.Value.ToString("yyyy-MM-dd");
            Correo = TextCorreo.Text;
            celular = Int64.Parse(TextCelular.Text);
            Fa = dt.ToString("yyyy-MM-dd");
            Ha =  dt.ToString("hh:mm:ss");

            Test formulario = new Test();
            formulario.Show();
            this.Hide();

        }

        private void Registro_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
