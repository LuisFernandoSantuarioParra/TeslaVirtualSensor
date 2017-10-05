using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace PicWinUSB
{
    public partial class Termometro : Form
    {
        private Thread graficador2;
        Controlador.MasterControler master = new Controlador.MasterControler();
        IntPtr ihandle;
        public Termometro(IntPtr iHandle)
        {
            InitializeComponent();
            ihandle = iHandle;
        }
        private byte[] ch1limpio()
        {
            int i;
            int n = 0;
            int x = 0;
            int y = 0;
            int inicio;
            int final;
            byte[] limpio = new byte[62];
            byte[] sucio = new byte[64];

            sucio = master.ch1(this.ihandle);
            inicio = sucio[62];
            final = sucio[63];
            x = (62 - inicio);
            for (i = inicio; i < limpio.Length; i++)
            {
                limpio[n] = sucio[i];
                n++;
            }
            for (y = final; y >= 0; y--)
            {
                limpio[x] = sucio[y];
                x++;
            }
            return limpio;
        }

        public int suma()
        {//aqui cambiar la funcion por la conversion a luxes
            int i = 0;
            int suma = 0;
            byte[] ch1;
            ch1 = ch1limpio();
            for (i = 0; i < ch1.Length - 1; i++)
            {
                suma = suma + ch1[i];
            }
            return suma;
        }

        private void UpdateCpuChart()
        {
            bunifuProgressBar1.Refresh();
            bunifuProgressBar1.MaximumValue= 1000;

            int y = 0;
            for (y = 0; y < ch1limpio().Length; y++)
            {
                int i = 0;
                i = suma();
                bunifuProgressBar1.Value = i;
            }
        }

        private void getPerformanceCounters()
        {



            while (true)
            {
                if (bunifuProgressBar1.IsHandleCreated)
                {

                    this.Invoke((MethodInvoker)delegate
                    {
                        UpdateCpuChart();
                    });

                }
                else
                {
                    //......

                }
                Thread.Sleep(10);

            }
        }



        

        private void bunifuiOSSwitch1_OnValueChange_1(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Enabled == true)
            {
                graficador2 = new Thread(new ThreadStart(this.getPerformanceCounters));
                // graficador.IsBackground = true;
                graficador2.Start();
            }
            else
            {
                graficador2.Abort();

            }
        }
    }
}
