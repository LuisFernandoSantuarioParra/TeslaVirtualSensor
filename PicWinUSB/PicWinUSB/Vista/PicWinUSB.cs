using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace PicWinUSB
{
    public partial class PicWinUSB : Form
    {
        IntPtr iHandle;     // global device handle definition
        PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();

        //Importando dll para mover ventana sin borde
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //fin de importacion


        public PicWinUSB()
        {
            Guid InterfaceGuid = new Guid("31415926-5358-9793-2384-626433832795"); // .Inf defined Guid
            InitializeComponent();
            iHandle = picwinusbapi.Init_PicWinUSB(InterfaceGuid);

        }

        //Controlador mover ventana
        private void BarraSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Fin de controlador mover ventana

        //controlador de panel de contenidos
        private void AddFormInPanel(object formHijo)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.FormBorderStyle = FormBorderStyle.None;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        //fin controlador de panel de contenidos

        //Inicio de llamado de hijos
        private void teslabutton_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new TeslaWindow(this.iHandle));
            bunifuImageButton1.Hide();

        }
        
        private void bunifuImageButton1_Click(object sender, EventArgs e)
        {
            AddFormInPanel(new Miselaneo(this.iHandle));
            bunifuImageButton1.Hide();
           
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);

            this.bunifuImageButton1.Show();

        }

        //Final de llamado de hijos
    }
}
