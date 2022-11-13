using MaterialSkin;
using System;
using System.Diagnostics;
using System.Linq;
using System.Windows.Forms;

namespace Test_Inteligencias_multiples
{
    public partial class Test : MaterialSkin.Controls.MaterialForm
    {
        //Varibale estatica para enviar entre formularios
        public static string Enviar_tipo { get; set; }

        int contadorP =0;
        readonly String[] Preguntas_text = {
        //Inteligencia verbal lingüística 
        "Los libros son muy importantes para mí.",
        "Oigo las palabras en mi mente antes de leer, hablar o escribirlas.",
        "Me aportan más la radio o unas cintas grabadas que la televisión\no las películas.",
        "Me gustan los juegos de palabras como el Scrabble, el Anagrams o\nel Password.",
        "Me gusta entretenerme o entretener a los demás con trabalenguas,\nrimas absurdas o juegos de palabras.",
        "En ocasiones, algunas personas me piden que les explique el significado\nde las palabras que utilizo (escritas u orales).",
        "En el cole asimilaba mejor la lengua y la literatura, las ciencias sociales y la historia que las mates y las ciencias naturales.",
        "Aprender a hablar o leer otra lengua (inglés, francés o alemán, por ejemplo) me resulta relativamente sencillo.",
        "Mi conversación incluye referencias frecuentes a datos que he leído o escuchado.",
        "Recientemente he escrito algo de lo que estoy especialmente.",
        //Inteligencia lógico-matemática
        "Soy capaz de calcular operaciones mentalmente sin esfuerzo.",
        "Las matemáticas y/o las ciencias figuraban entre mis asignaturas\nfavoritas en el colegio.",
        "Me gustan los juegos o los acertijos que requieren un pensamiento\nlógico.",
        "Me gusta realizar pequeños experimentos del tipo «¿Qué pasaría si...?».",
        "Mi mente busca patrones, regularidad o secuencias lógicas en las\ncosas.",
        "Me interesan los avances científicos.",
        "Creo que casi todo tiene una explicación racional.",
        "En ocasiones pienso en conceptos claros, abstractos, sin\npalabras ni imágenes.",
        "Me gusta detectar defectos lógicos en las cosas que la gente dice\ny hace en casa y en el trabajo",
        "Me siento más cómodo cuando las cosas están medidas, categorizarlas,\nanalizadas o cuantificadas de algún modo.",
        //Inteligencia viso-espacial
        "Cuando cierro los ojos percibo imágenes visuales claras.",
        "Soy sensible al color.",
        "Habitualmente utilizo una cámara de fotos o una videocámara\npara captar lo que veo ami alrededor.",
        "Me gustan los rompecabezas, los laberintos y demás juegos visuales.",
        "Por la noche tengo sueños muy intensos.",
        "En general, soy capaz de orientarme en un lugar desconocido.",
        "Me gusta dibujar o garabatear.",
        "En el colegio me costaba menos la geometría que el álgebra.",
        "Me puedo imaginar sin ningún esfuerzo el aspecto que tendría\nlas cosas vistas desde arriba.",
        "Prefiero el material de lectura con muchas ilustraciones.",
        //Inteligencia cinético-corporal,
        "Practico al menos un deporte o algún tipo de actividad\nfísica de forma regular.",
        "Me cuesta permanecer quieto durante mucho tiempo.",
        "Me gusta trabajar con las manos en actividades concretas como\ntejer, tallar, carpintería o construcción demaquetas.",
        "En general, las mejores ideas se me ocurren cuando estoy paseando,\ncorriendo o mientras realizo actividades físicas.",
        "Me gusta pasar mi tiempo de ocio al aire libre.",
        "Acostumbro a gesticular mucho o a utilizar otras formas de lenguaje\ncorporal cuando hablo con alguien.",
        "Necesito tocar las cosas para saber más sobre ellas.",
        "Me gustan las atracciones fuertes y las experiencias físicas emocionantes.",
        "Creo que soy una persona con una buena coordinación.",
        "No me basta con leer información o ver un vídeo sobre una nueva\nactividad: necesito practicarla.",
        //Inteligencia musical
        "Una voz agradable.",
        "Percibo cuando una nota musical está desafinada.",
        "Siempre estoy escuchando música.",
        "Tocó un instrumento musical.",
        "Sin la música,mi vida sería más triste.",
        "En ocasiones me sorprendo cantando mentalmente la música del\nanuncio de televisión o alguna otra melodía.",
        "Puedo seguir fácilmente el ritmo del tema musical con un\ninstrumento de percusión.",
        "Conozco las melodías de numerosas canciones.",
        "Con sólo escuchar una selección musical con uno o dos meses,\nya soy capaz de reproducirla con bastante acierto.",
        "Acostumbro a producir sonidos rítmicos con golpecitos o a cantar\nmelodías mientras estoy trabajando o estudiando.",
        //Inteligencia interpersonal,
        "Soy del tipo de personas a las que los demás piden opinión y\nconsejo en el trabajo o en el vecindario.",
        "Prefiero los deportes de equipo (fútbol o baloncesto) a los\ndeportes solitarios (natación o el jogging).",
        "Cuando tengo un problema, tiendo a buscar la ayuda de otra\npersona en lugar de intentar resolverlo por mí mismo.",
        "Tengo almenos tres amigos íntimos.",
        "Me gustan más los juegos sociales (como el Monopoly) que\nlos juegos en solitario (videojuegos).",
        "Disfruto con el reto que supone enseñar a otra persona, o\ngrupos de personas, lo que sé hacer.",
        "Me considero un líder (o los demás me dicen que lo soy).",
        "Me siento cómodo entre una multitud.",
        "Me gusta participar en actividades sociales relacionadas\ncon mi trabajo, con la parroquia o con la comunidad.",
        "Prefiero pasar una tarde en una fiesta animada que solo en casa.",
        //Inteligencia intrapersonal
        "Habitualmente dedico tiempo a meditar, reflexionar o pensar\nen cuestiones importantes de la vida.",
        "He asistido a sesiones de asesoramiento o a seminarios de\ncrecimiento personal para aprender a conocerme más.",
        "Soy capaz de afrontar los contratiempos con fuerza moral.",
        "Tengo una afición especial o una actividad que guardo para mí.",
        "Tengo algunos objetivos vitales importantes en los que pienso\nde forma habitual.",
        "Mantengo una visión realista de mis puntos fuertes y débiles\n(confirmados mediante feedback de otras fuentes).",
        "Preferiría pasar un fin de semana solo en una cabaña, en el\nbosque, que en un lugar turístico de lujo lleno de gente.",
        "Me considero una persona con mucha fuerza de voluntad o independiente.",
        "Escribo un diario personal en el que recojo los pensamientos\nrelacionados con mi vida interior.",
        "Soy trabajador autónomo o he pensado muy seriamente en la\nposibilidad de poner en marcha mi propio negocio.",
        //Inteligencia naturalista
        "Me gusta ir de excursión, el senderismo o simplemente pasear\nen plena naturaleza.",
        "Pertenezco a una asociación de voluntarios relacionada con\nla conservación del Medio ambiente.",
        "Me encanta tener animales en casa.",
        "Tengo una afición relacionada de algún modo con la naturaleza\n(por ejemplo, la observación de aves).",
        "He asistido a cursos relacionados con la naturaleza\n(por ejemplo, botánica o zoología).",
        "Se me da bien describir diferencias entre distintos tipos de\nárboles, perros, pájaros u otras especies de flora o fauna.",
        "Me gusta leer libros o revistas, o ver programas de televisión o\npelículas, en los que la naturaleza esté presente.",
        "Cuando tengo vacaciones, prefiero los entornos naturales (parques,\nsenderismo) a los hoteles y destinos urbanos.",
        "Me encanta visitar zoológicos, acuarios y demás lugares donde se\nestudia elmundo natural.",
        "Tengo un jardín y disfrutó cuidándolo."
        };
        //Valor para radio button
        int value = 0;
        //Contador para cada uno de los perfiles
        public static int contadorvl = 0 ;
        public static int contadorlm = 0;
        public static int contadorve = 0;
        public static int contadorcp = 0;
        public static int contadorm = 0;
        public static int contadorinter = 0;
        public static int contadorintra = 0;
        public static int contadorn = 0;
        //Contador para guardar en BD Respuestas
        string Respuestas_V_F = null;

        public Test()
        {
            InitializeComponent();
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            //Definimos nuevo esquema de colores
            SkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            SkinManager.ColorScheme = new ColorScheme(Primary.Blue500, Primary.Blue700, Primary.Blue700, Accent.Blue700, TextShade.WHITE);
            SkinManager.AddFormToManage(this);
            //Definimos texto inicial
            Preguntas.Text = Preguntas_text[0];
            //Cambiamos paginación
            Paginacion.Font.Size.Equals(8);
            Paginacion.Text = "Pregunta " + (contadorP + 1) + " de " + (Preguntas_text.Length);
        }

        private void materialRaisedButton1_Click(object sender, EventArgs e)
        {
            // Guarda valor de radiobuttons
            bool isV = Verdadero.Checked;
            //bool isF = Falso.Checked;

            //Validamos que se seleccionen ambos radio buttons
            /*if (isV  == false && isF==false)
            {
                MessageBox.Show("Debes elegir al menos una opción");
            }*/
            //else
            //{
                //Contador para ir iterando preguntas
                contadorP = contadorP + 1;
            //Cambiamos label de preguntas
            if (contadorP < Preguntas_text.Length)
            {
                Preguntas.Text = Preguntas_text[contadorP];
            }
                //Contamos puntos para cada tipo de perfil
                if (isV)
                {
                    value = 1;
                    //Dato para BD con todas las respuestas
                    Respuestas_V_F += "V";
                }
                else
                {
                    value = 0;
                    //Dato para BD con todas las respuestas
                    Respuestas_V_F += "F";
            }
                //Suma de inteligencia verbal lingüística
                if (contadorP>=1 && contadorP <= 10)
                {
                    contadorvl += value;
                }
                //Suma de inteligencia lógico-matemática
                if (contadorP >= 11 && contadorP <= 20)
                {
                        contadorlm += value;
                }
                //Suma de inteligencia viso-espacial
                if (contadorP >= 21 && contadorP <= 30)
                {
                    contadorve += value;
                }
                //Suma de inteligencia cinético-corporal
                if (contadorP >= 31 && contadorP <= 40)
                {
                    contadorcp += value;
                }
                //Suma de inteligencia musical
                if (contadorP >= 41 && contadorP <= 50)
                {
                    contadorm += value;
                }
                //Suma de inteligencia interpersonal
                if (contadorP >= 51 && contadorP <= 60)
                {
                    contadorinter += value;
                }
                //Suma de inteligencia intrapersonal
                if (contadorP >= 61 && contadorP <= 70)
                {
                    contadorintra += value;
                }
                //Suma de inteligencia naturalista
                if (contadorP >= 71 && contadorP <= 80)
                {
                    contadorn += value;
                }
                


            //Reseteamos radio buttons
            Verdadero.Checked = false;
                Falso.Checked = false;

                //Cambiamos paginación
                Paginacion.Text = "Pregunta "+(contadorP+1)+" de "+ (Preguntas_text.Length);
            //Cambiamos de forma cuando el resultado este listo
            //Debug.WriteLine(contadorP);
            if (contadorP == (Preguntas_text.Length))
                {
                /*Debug.WriteLine(contadorvl);
                Debug.WriteLine(contadorlm);
                Debug.WriteLine(contadorve);
                Debug.WriteLine(contadorcp);
                Debug.WriteLine(contadorm);
                Debug.WriteLine(contadorinter);
                Debug.WriteLine(contadorintra);
                Debug.WriteLine(contadorn);*/

                //Generamos vector con todos los resultados
                var arr = new int[] {contadorvl,
                contadorlm,contadorve,contadorcp,contadorm,
                contadorinter,contadorintra,contadorn};

                //Obtenemos el valor máximo
                var max = arr.Max();

                //Generamos variable para determinar el tipo intelgiencia del usuario

                string tipo_de_inteligencia = null;
                if (max == contadorvl)
                {
                    tipo_de_inteligencia = "Verbal lingüística";
                }
                if (max == contadorlm)
                {
                    tipo_de_inteligencia = "Lógico matemática";
                }
                if (max == contadorve)
                {
                    tipo_de_inteligencia = "Viso espacial";
                }
                if (max == contadorcp)
                {
                    tipo_de_inteligencia = "Cinético corporal";
                }
                if (max == contadorm)
                {
                    tipo_de_inteligencia = "Musical";
                }
                if (max == contadorinter)
                {
                    tipo_de_inteligencia = "Interpersonal";
                }
                if (max == contadorintra)
                {
                    tipo_de_inteligencia = "Intrapersonal";
                }
                if (max == contadorn)
                {
                    tipo_de_inteligencia = "naturalista";
                }

                //Enviamos información al otro formulario
                Enviar_tipo = tipo_de_inteligencia;
                //MessageBox.Show("Tu tipo de inteligencia es : " + tipo_de_inteligencia);

                //Generamos dato aletorio para ID de respuestas
                var chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
                var stringChars = new char[5];
                var random = new Random();

                for (int i = 0; i < stringChars.Length; i++)
                {
                    stringChars[i] = chars[random.Next(chars.Length)];
                }

                var finalString = new String(stringChars);

                //Guardamos respuestas en BD
                Respuestas Respuestas = new Respuestas
                {
                    Respuestas_ID = finalString,
                    Respuestas_V_F = Respuestas_V_F,
                    Vl = contadorvl,
                    Lm = contadorlm,
                    Ve = contadorve,
                    Cp = contadorcp,
                    M = contadorm,
                    Inter = contadorinter,
                    Intra = contadorintra,
                    N = contadorn,
                    Respuestas_R = tipo_de_inteligencia
                };

                int resultado = Respuestas_Dao.Insertar_Respuestas(Respuestas);
                if (resultado > 0)
                {
                    MessageBox.Show("Respuestas Guardadadas Con Exito!!", "Respuestas Guardadadas", MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("No se pudo guardar las respuestas", "Fallo al guardar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);
                }

                //Guardamos usuario en db

                Usuario Usuario = new Usuario();
                Usuario.Nombre = Registro.Nombre;
                Usuario.FechaN = Registro.Fn;
                Usuario.Correo = Registro.Correo;
                Usuario.Celular = Registro.celular;
                Usuario.FechaA = Registro.Fa;
                Usuario.HoraA = Registro.Ha;
                Usuario.Respuestas_ID = finalString;

                int resultado_2 = UsuarioDao.Insertar_Usuario(Usuario);
                if (resultado_2 < 0)
                {
                    MessageBox.Show("No se pudo guardar la información del usuario", "Fallo al guardar!!", MessageBoxButtons.OK,
                    MessageBoxIcon.Exclamation);

                }
                


                Resultado resultado_frm = new Resultado();
                resultado_frm.Show();
                this.Hide();
                }

            //}


           


          


        }

        private void Formulario_FormClosed(object sender, System.Windows.Forms.FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
