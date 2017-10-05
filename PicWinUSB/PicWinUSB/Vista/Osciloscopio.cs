using System;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

namespace PicWinUSB
{
    public partial class Osciloscopio : Form
    {
        private Thread graficador;
        Controlador.MasterControler master = new Controlador.MasterControler();
        IntPtr ihandle;
        //Inicializamos la clase Random
        Random r = new Random();
        public Osciloscopio(IntPtr iHandle)
        {
            InitializeComponent();
            ihandle = iHandle;
        }
        private void getPerformanceCounters()
        {
            
            while (true)
            {
                if (chart.IsHandleCreated)
                {
                    this.Invoke((MethodInvoker)delegate { UpdateCpuChart(); });
                   
                }
                else
                {
                    //......
                }
               // sucio();
                Thread.Sleep(10);
            }
        }

        private void UpdateCpuChart(){

            chart.Series["CH1"].Points.Clear();
            chart.Series["CH2"].Points.Clear();
            int i;
            byte[] ch1;
            byte[] ch2;
            double valor;
            double valor2;
            ch1 = ch1limpio();  //aqui copiar el arreglo ya ordenado
            ch2 = ch2limpio();
            for ( i = 0; i < ch1.Length- 1; ++i)
            {
                //Console.WriteLine(ch1.Length);
               valor =ch1[i];
                valor = (valor * 0.01960);
                chart.Series["CH1"].Points.AddY(valor);

                valor2 = ch2[i];
                valor2 = (valor2 * 0.01960);
                chart.Series["CH2"].Points.AddY(valor2);
                //Console.WriteLine(valor);
            }
            /*
            for (i = 0; i < ch2.Length - 1; ++i)
            {
                //Console.WriteLine(ch1.Length);
                valor2 = ch2[i];
                valor2 = (valor2 * 0.01960);
                chart.Series["CH2"].Points.AddY(valor2);
                //Console.WriteLine(valor2);
            }
            */
        }

        private byte[] ch1limpio() {
            int i;
            int n=0;
            int x=0;
            int y = 0;
            int inicio;
            int final;
            byte[] limpio = new byte[62];
            byte[] sucio = new byte[64];

            sucio = master.ch1(this.ihandle);
            inicio = sucio[62];
            final = sucio[63];
            x = (62-inicio);

            //Console.Write(inicio);   
            //Console.Write(final);
            for (i =inicio;i<limpio.Length;i++) {
                limpio[n]=sucio[i];
               // Console.WriteLine("arreglolimpio");
                //Console.Write(limpio[n]);
                //Console.WriteLine("---------------------");
                //Console.WriteLine("posicion de arreglo");
                //Console.WriteLine(n);
                n++;
            }
            for (y=final;y>=0;y--) {
               limpio[x] = sucio[y];
               // Console.WriteLine("arreglolimpio");
                //Console.Write(limpio[x]);
                //Console.WriteLine("---------------------");
                //Console.WriteLine("posicion de arreglo");
                //Console.WriteLine(x);
                x++;


            }
            /*
            for (i =0; i<limpio.Length;i++)
            {
                Console.WriteLine("arreglolimpio");
                Console.Write(limpio[i]);
                Console.WriteLine("---------------------");
            }
            */
            return limpio;
        }
        
        private byte[] ch2limpio()
        {
            int i;
            int n = 0;
            int x = 0;
            int y = 0;
            int inicio;
            int final;
            byte[] limpio = new byte[64];
            byte[] sucio = new byte[64];

            sucio = master.ch2(this.ihandle);
            inicio = sucio[62];
            final = sucio[63];
            x = (62 - inicio);

            //Console.Write(inicio);   
            //Console.Write(final);
            for (i = inicio; i < limpio.Length; i++)
            {
                limpio[n] = sucio[i];
                // Console.WriteLine("arreglolimpio");
                //Console.Write(limpio[n]);
                //Console.WriteLine("---------------------");
                //Console.WriteLine("posicion de arreglo");
                //Console.WriteLine(n);
                n++;
            }
            for (y = final; y >= 0; y--)
            {
                limpio[x] = sucio[y];
                // Console.WriteLine("arreglolimpio");
                //Console.Write(limpio[x]);
                //Console.WriteLine("---------------------");
                //Console.WriteLine("posicion de arreglo");
                //Console.WriteLine(x);
                x++;


            }
            /*
            for (i = 0; i < limpio.Length; i++)
            {
                Console.WriteLine("arreglolimpio");
                Console.Write(limpio[i]);
                Console.WriteLine("---------------------");
            }
            */

            return limpio;
        }
        

        private void metroButton1_Click(object sender, EventArgs e)
        {

            graficador = new Thread(new ThreadStart(this.getPerformanceCounters));
           // graficador.IsBackground = true;
            graficador.Start();


        }


        private void Osciloscopio_Load(object sender, EventArgs e)
        {


        }


    
        
    }
}
