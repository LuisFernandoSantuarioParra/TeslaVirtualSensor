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

namespace PicWinUSB
{
    public partial class TeslaWindow : Form
    {
        Controlador.MasterControler master = new Controlador.MasterControler();
        IntPtr ihandle;

        public TeslaWindow(IntPtr iHandle)
        {
            InitializeComponent();
            ihandle = iHandle;
        }

        private void ButtonOnOff_OnValueChange(object sender, EventArgs e)
        {
            if (ButtonOnOff.Value==true) {
                master.ledOn(this.ihandle);
            } else {
                master.ledOff(this.ihandle);
            }
        }

        private void ButtonToggle_OnValueChange(object sender, EventArgs e)
        {

            if (ButtonToggle.Value == true)
            {
                master.toggle(this.ihandle);
            }
            else
            {
                master.toggle(this.ihandle);
            }
        }

        private void Buttongreenred_OnValueChange(object sender, EventArgs e)
        {
            if (Buttongreenred.Value == true)
            {
                master.ledVerde(this.ihandle);
            }
            else
            {
                master.ledRojo(this.ihandle);
            }
        }

        private void metroLabelHeader6_Click(object sender, EventArgs e)
        {

        }
    }
}
