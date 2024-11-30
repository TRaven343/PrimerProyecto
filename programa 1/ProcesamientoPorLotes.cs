using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;
using System.Runtime.InteropServices;
using System.Collections.Specialized;
using System.Drawing.Text;
using System.IO;
using System.Runtime.CompilerServices;

namespace programa_1
{
    public partial class ProcesamientoPorLotes : Form
    {
        //Se crea el reloj global
        Stopwatch oSW = new Stopwatch();
        
        //Arreglo con diferentes nombres
        string[] listNombres =
{
             "Jorge", "Ivan", "Edwin","Paco","Hector",
             "Hugo","Eduardo","Luis","Pedro","Maria","Mariana","Patricia","Liz",
             "Fernanda","Alondra","Angela"
            };

        //Arreglo con diferentes operadores
        char[] listOperadores =
        {
                '+', '-', '*', '/'
            };

        //Generacion de los elementos aleatorios
        Random aleatorio = new Random();

        public ProcesamientoPorLotes()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        //Funcion creada por alguien en stackoverflow, 
        //Otorga la posibilidad de pausar el prorgrama por unos segundos
        //Con ponel wait(x) en donde se necesite
        public void wait(int milliseconds)
        {
            var timer1 = new System.Windows.Forms.Timer();
            if (milliseconds == 0 || milliseconds < 0) return;
            timer1.Interval = milliseconds;
            timer1.Enabled = true;
            timer1.Start();

            timer1.Tick += (s, e) =>
            {
                timer1.Enabled = false;
                timer1.Stop();
                
            };

            while (timer1.Enabled)
            {
                Application.DoEvents();
            }
        }
        //Esta funcion sirve para la ejecucion y segundos en tiempo real
        public int EjecutarYTemporizador(TextBox textbox, Programador programador)
        {
         
            int x = programador.tiempo / 1000;
            do
            {
                textbox.Text += programador.id + ". ";
                textbox.Text += programador.nombre + "\r\n";
                textbox.Text += programador.num1 + " ";
                textbox.Text += programador.simbolo + " ";
                textbox.Text += programador.num2 + " " + "\r\nTME: ";
                textbox.Text += x + "\r\n";
                wait(1000);
                x--;
                textbox.Text = "";
            } while (x != 0);
            
            return x;
        }

        //Se capturan los datos entrantes con dos formas para ser expresada
        public void Printprogramertotextbox(TextBox textbox, Programador programador, int moredetails)
        {


            if (moredetails == 1)
            {
                textbox.Text += programador.id + ". ";
                textbox.Text += programador.nombre + "\r\n";
                textbox.Text += programador.num1 + " ";
                textbox.Text += programador.simbolo + " ";
                textbox.Text += programador.num2 + " " + "\r\nTME: ";
                textbox.Text += programador.tiempo / 1000 + "\r\n";
            }
            else if (moredetails == 2)
            {
                textbox.Text += programador.id + ". ";
                textbox.Text += programador.nombre + "\r\n";
                textbox.Text += programador.num1 + " ";
                textbox.Text += programador.simbolo + " ";
                textbox.Text += programador.num2 + " " + " = ";
                textbox.Text += programador.res + "\r\n" + "\r\n";
            }

        }
        //Metodo para identificar la operacion y resolverla
        public float RealizarOperacion(char operacion, int num1, int num2)
        {
            float res = 0;

            if (operacion == '+')
            {
                res = num1 + num2;
            }
            else if (operacion == '*')
            {
                res = num1 * num2;
            }
            else if (operacion == '-')
            {
                res = num1 - num2;
            }
            else if (operacion == '/')
            {
                res = num1 / num2;
            }
            return res;
        }

        //clase programador donde se guardaran los datos en variables
        public class Programador
        {
            public int id;
            public string nombre;
            public int num1, num2, tiempo;
            public char simbolo;
            public float res;

            public Programador(int nid, int nnum1, int nnum2,int ntiempo, char nsimbolo, string nnombre, float nres)
            {
                id = nid;
                nombre = nnombre;
                num1 = nnum1;
                num2 = nnum2;
                tiempo = ntiempo;
                simbolo = nsimbolo;
                res = nres;


            }
        }

        //Las funciones que comienzan con el boton de "Generar"
        private async void ButtonGen_Click(object sender, EventArgs e) 
        {
            oSW.Start(); //Con este comando comienza el temporizador
            timer1.Enabled = true; //Con este otro activamos la herramienta Timer
            //Con esto agregamos el numero de programadores que se crearan
            int elementos = Convert.ToInt32(NumProc.Text);
            
            //variables para el ciclo y un auxiliar para los lotes
            int a;
            int numlot1 = elementos / 5; //Se capturan el numero de lotes que habra
            int auxesp = 0; //Contador auxiliar de los elementos
            int auxres = 0; //Auxiliar para el decremento del numero de lotes



            //lista donde se agregaran los datos de los programadores
            List<Programador> datos = new List<Programador>();

            //Se limpia la pantalla en caso de volver a tener el programa con datos
            EnEspera.Text = "";
            Terminados.Text = "";
            //Se crea un archivo de texto nuevo en caso de tener uno ya existente
            //para que cada que se generen nuevos datos los viejos desaparezcan.
            Ghost.Text = "";// Limpiamos ghost para que no se acumulen los datos
            //Se crea un nuevo archivo limpio de Datos.txt
            using (FileStream fs = new FileStream("Datos.txt", FileMode.Create))
            {
                using (StreamWriter data = new StreamWriter(fs))
                {
                    await data.WriteAsync(Ghost.Text);
                }
            }

            //Comienzan los cliclos
            //El primero es para agregar los datos a los programadores
            for (a = 1; a <= elementos; a++)
            {
                int id = a;
                string nombre = listNombres[aleatorio.Next(listNombres.Length)];
                int num1 = aleatorio.Next(50, 101);
                int num2 = aleatorio.Next(50);
                char simbol = listOperadores[aleatorio.Next(listOperadores.Length)];
                int tiempo = aleatorio.Next(5000, 13000);
                float res;

                //Aqui se agregan los datos recibidos para el metodo realizarOperacion
                res = RealizarOperacion(simbol, num1, num2);
                //Aqui se guardan los datos que se capturaron en las variables 
                Programador nprogramador = new Programador(id, num1, num2, tiempo, simbol, nombre, res);
                datos.Add(nprogramador);// Se guarda en la lista datos
                auxesp++;//El contador auxiliar incrementa hasta llegar al maximo de elemntos agregados
                auxres = numlot1; //se le da el valor de numero de lotes existentes a auxres
            }
            int tm = numlot1 == 0 ? elementos : 5; //Con esta variable podemos agarrar 5 elementos 
            int Nloot = 0; //Nloot sera el contador de lotes que incrementaran cada 5 elementos o los ultimos elementos
            for (int i = 1; i <= datos.Count(); i++) 
            {

                bool imprimirlote = false; //Iniciamos una variable en falso
                if (i != datos.Count())
                {
                    Printprogramertotextbox(EnEspera, datos[i], 1);
                    if (i % 5 == 0 && i != 0)
                    {
                        imprimirlote = true; //Si la condicional funciona, el bool se vuelve true
                        tm = 5; //El contador de numero de procesos se vuelve en 5 
                        Nloot++; //Se incrementa la cantidad de lootes en 1
                        auxres--; //Se decrementa el numero maximo de lootes para la textbox que muestra el numero restante de lotes
                        if (Nloot == numlot1)
                        {
                            tm = elementos % 5; //Cuando Nloot alcanza al numero maximo de lotes, se sacan los ultimos elementos 
                        }

                    }
                    textBox2.Text = ""; //Se limpia la textbox del maximo de lootes para el auxiliar del decremento
                    textBox2.Text += auxres; //Se ingresa el nuevo valor 
                    EnEspera.Text += "\r\n" + "\r\n" + "Procesos en espera = " + (tm - 1); //Se imprime el numero de procesos pendientes por lote
                    tm--; //Esto decrementa el numero de procesos cuando pasa a ejecucion
                }

                //Agrega la informacion al segundo textbox "Ejecucion"
                
                EjecutarYTemporizador(Ejecutar, datos[i - 1]); //Se ingresan datos en una posicion diferente para simular que se mueven los datos
                if (imprimirlote || i == 1) //Si se cumple la condicional, se imprimira un numero de lote donde corresponde
                {
                    Ghost.Text += "Lote: " + (Nloot + 1) + "\r\n"; //Se estampa el numero de lote para Ghost
                }
                Printprogramertotextbox(Ghost, datos[i - 1], 1); //Se agregan datos en una textbox fantasta para acomodar Datos.txt
                
              
    
                if (imprimirlote || i == 1) //Si se cumple la condicional, se imprimira un numero de lote donde corresponde
                {
                    Terminados.Text += "Lote: " + (Nloot + 1) + "\r\n";//Se estampa el numero de lote para terminados
                }
                Printprogramertotextbox(Terminados, datos[i - 1], 2);//Se agregan datos para la textbox terminados
                EnEspera.Text = ""; //Se limpiaran los datos anteriores que estaban en la textbox EnEspera

                //Los datos que han agregado en Ghost comienzan a ser agregados al .txt
                using (FileStream fs = new FileStream("Datos.txt", FileMode.Create))
                {
                    using (StreamWriter data = new StreamWriter(fs))
                    {
                        await data.WriteAsync(Ghost.Text); //Toma los datos que estan en la textbox y los pone en el .txt
                    }
                }
            }
        }
 
        private void NumProc_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Con estos comandos configuramos el Timer para que funcione con minutos, segundos y milisegundos
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int)oSW.ElapsedMilliseconds);
            Seg.Text = ts.Seconds.ToString(); //Asignamos el textbox para el contador de segundos
        }

        private void Ejecutar_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                //Cuando se presione el boton resultado, se generara un documento .txt llamado resultados
                //En ese documento se guardaran los programadores junto con sus operaciones resueltas
                using (FileStream fs = new FileStream("Resultados.txt", FileMode.Create))
                {
                    using (StreamWriter data = new StreamWriter(fs))
                    {
                        data.WriteAsync(Terminados.Text);
                    }
                }           
        }
    }
}
