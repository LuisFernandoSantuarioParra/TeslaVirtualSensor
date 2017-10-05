using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace PicWinUSB
{
    public partial class Miselaneo : Form
    {
        // area de inicializacion
        Controlador.MasterControler master = new Controlador.MasterControler();
        IntPtr ihandle;
        public Miselaneo(IntPtr iHandle)
        {
            InitializeComponent();
            ihandle = iHandle;
        }

        //limpiador y ordenador de arreglos para sensores
        private byte[] ch1limpio(byte[] arreglo)
        {
            int i;
            int n = 0;
            int x = 0;
            int y = 0;
            int inicio;
            int final;
            byte[] limpio = new byte[62];
            byte[] sucio = new byte[64];

            sucio = arreglo;
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

        //area para las operaciones y conversiones
        public int suma()
        {//aqui cambiar la funcion por la conversion a luxes
            int i = 0;
            int suma = 0;
            byte[] ch1;
            ch1 = ch1limpio(master.ch1(this.ihandle));
            for (i = 0; i < ch1.Length - 1; i++)
            {
                suma = suma + ch1[i];
            }
            return suma;
        }

        //humedad
        public double promedio() {
            double promedio=0;
            foreach (byte c in ch1limpio(master.ch1(this.ihandle))) {
                promedio += (c * 0.01960);
               // Console.WriteLine("-----------------");
              //  Console.WriteLine(c * 0.01960);
                //Console.WriteLine("-----------------");
            }
            

            return (promedio/ ch1limpio(master.ch1(this.ihandle)).Length);
        }
        public double promedio2()
        {
            double promedio = 0;
            foreach (byte c in ch1limpio(master.ch2(this.ihandle)))
            {
                promedio += (c * 0.01960);
                // Console.WriteLine("-----------------");
                //  Console.WriteLine(c * 0.01960);
                //Console.WriteLine("-----------------");
            }


            return (promedio / ch1limpio(master.ch2(this.ihandle)).Length);
        }

        //-----------------------------------
        //UPDATE DE GRAFICAS

        //LUXOMETRO
        private void UpdateLuxChart()
        {
            var ccd = new GChartLib.GCircleChartData();
            gCircleChart1.Maximum = 5000;
            gCircleChart1.Refresh();
            gCircleChart1.Data.Clear();
            ccd.Value = 0;
            ccd.FillColor= Color.FromArgb(197, 149, 56);
            int y = 0;
            for (y = 0; y < ch1limpio(master.ch1(this.ihandle)).Length; y++)
            {
                int i = 0;
                i =Convert.ToInt32(promedio());
                //i =Convert.ToInt32 ( (((2500)/ promedio())-500) / 3.3);

                ccd.Value = i;
                ccd.Name = i.ToString();
            }
            gCircleChart1.Data.Add(ccd);
        }
        //------------------------------------------------------------

        //HUMEDAD
        private void UpdateHumedadChart()
        {
            bunifuCircleProgressbar1.Refresh();
            bunifuCircleProgressbar1.MaxValue = 1000;

            int y = 0;
            for (y = 0; y < ch1limpio(master.ch1(this.ihandle)).Length; y++)
            {
                int i = 0;
                i = Convert.ToInt32(promedio()) ;
                i = ((i * -1) + 5)*200;
                bunifuCircleProgressbar1.Value = i;

                // Console.WriteLine(promedio());
                 Console.WriteLine(i);
            }
        }

        //------------------------------------------------------------

        //TERMOMETRO
        private void UpdateTermoChart()
        {

           
            progressBar1.Maximum = 500;

            int y = 0;
            for (y = 0; y < ch1limpio(master.ch1(this.ihandle)).Length; y++)
            {
                int i = 0;
                i = (Convert.ToInt32(promedio())*1000)/10;
                
                progressBar1.Value = i;
                Console.WriteLine(i);
            }
        }
        //------------------------------------------------------------

        //OSCILOSCPIO
        private void UpdateCh1Chart()
        {
            chart.Series["CH1"].Points.Clear();
            int i;
            byte[] ch1;
            double valor;
            ch1 = ch1limpio(master.ch1(this.ihandle));  //aqui copiar el arreglo ya ordenado
            for (i = 0; i < ch1.Length - 1; ++i)
            {
                //Console.WriteLine(ch1.Length);
                valor = ch1[i];
                valor = (valor * 0.01960);
                chart.Series["CH1"].Points.AddY(valor);
            }
          
        }
        private void UpdateCh2Chart()
        {
            chart.Series["CH2"].Points.Clear();
            int i;
            byte[] ch2;
            double valor2;
            ch2 = ch1limpio(master.ch2(this.ihandle));
            for (i = 0; i < ch2.Length - 1; ++i)
            {
                valor2 = ch2[i];
                valor2 = (valor2 * 0.01960);
                chart.Series["CH2"].Points.AddY(valor2);
            }

        }
        //------------------------------------------------------------

        //Giroscopio
        private void UpdateGiroscopioChart()
        {
            
            int i;
            int y;
           
            i = Convert.ToInt32(promedio());
            y = Convert.ToInt32(promedio2());

            Console.WriteLine("canal1");
            Console.WriteLine(i);
            Console.WriteLine("canal2");
            Console.WriteLine(y);

            if (i==0 && y==0 || i>=1 && y>=1 ) {
                if (i == 0 && y == 0) {
                    if (nucleo.Top - nucleo.Height <= -115) {
                        nucleo.Top += 0;
                       
                    } else {
                        
                        nucleo.Top += -5;
                        //Console.WriteLine(nucleo.Top * 1);
                        //Console.WriteLine(nucleo.Top-nucleo.Height);

                    }
                } else if (i >= 1 && y >= 1) {
                    if (nucleo.Top + nucleo.Height > contenedorGiro.Height)
                    {
                        nucleo.Top += 0;

                    }
                    else
                    {
                        nucleo.Top += 5;
                        //Console.WriteLine(nucleo.Top * 1);
                        //Console.WriteLine(nucleo.Top-nucleo.Height);

                    }
                }
            }else if(i >= 1 && y == 0 || i == 0 && y >= 1){
                Console.WriteLine(contenedorGiro.Width);
                if (i >= 1 && y == 0) {
                    if (nucleo.Left- nucleo.Width <=-110)
                    {
                        nucleo.Left += 0;

                    }
                    else
                    {

                        nucleo.Left += -5;
                        //Console.WriteLine(nucleo.Top * 1);
                        //Console.WriteLine(nucleo.Left-nucleo.Width);

                    }


                } else if (i == 0 && y >= 1) {

                    if (nucleo.Left - nucleo.Width >= 190)
                    {
                        nucleo.Left += 0;

                    }
                    else
                    {

                        nucleo.Left += 5;
                        //Console.WriteLine(nucleo.Top * 1);
                        //Console.WriteLine(nucleo.Left - nucleo.Width);

                    }

                }

            }

        }
        //------------------------------------


        // area de timers
        private void Luxometro_Tick(object sender, EventArgs e)
        {
            UpdateLuxChart();
        }

        private void Humedad_Tick(object sender, EventArgs e)
        {
            UpdateHumedadChart();
        }

        private void Termometro_Tick(object sender, EventArgs e)
        {
            UpdateTermoChart();
        }

        private void Giroscopio_Tick(object sender, EventArgs e)
        {
            UpdateGiroscopioChart();
        }

        private void Osciloscpio_Tick(object sender, EventArgs e)
        {
            UpdateCh1Chart();
            UpdateCh2Chart();
        }

        // area de botones
        private void bunifuiOSSwitch1_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch1.Value==true) {
                Luxometro.Start();
            }
            else {
                Luxometro.Stop();
            }
        }

        private void bunifuiOSSwitch2_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch2.Value == true)
            {
                Humedad.Start();
            }
            else
            {
                Humedad.Stop();
            }
        }

        private void bunifuiOSSwitch3_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch3.Value == true)
            {
                Termometro.Start();
            }
            else
            {
                Termometro.Stop();
            }
        }

        private void bunifuiOSSwitch4_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch4.Value == true)
            {
                Giroscopio.Start();
            }
            else
            {
                Giroscopio.Stop();
            }
        }

        private void bunifuiOSSwitch5_OnValueChange(object sender, EventArgs e)
        {
            if (bunifuiOSSwitch5.Value == true)
            {
                Osciloscpio.Start();
            }
            else
            {
                Osciloscpio.Stop();
            }
        }
    }
}
