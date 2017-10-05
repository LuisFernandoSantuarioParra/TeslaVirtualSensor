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
using System.Diagnostics;




namespace PicWinUSB
{
    public partial class Giroscopio : Form
    {
        Controlador.MasterControler master = new Controlador.MasterControler();
        IntPtr ihandle;
        public Giroscopio(IntPtr iHandle)
        {
            InitializeComponent();
            ihandle = iHandle;
        }

    }
}
