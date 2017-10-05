////////////////////////////////////////////////////////////////////////////
////                                                                    ////
////    This aplication shows how to use Microsoft WinUSB driver with   ////
////    a PIC 18F2550. Information has been extracted from MSDN:        ////
////                                                                    ////
////    - How to Use WinUSB to Communicate with a USB Device:           ////
////    http://www.microsoft.com/whdc/device/connect/WinUsb_HowTo.mspx  ////
////    - WinUSB:                                                       ////
////    http://msdn2.microsoft.com/en-us/library/aa476426.aspx          ////
////    - WinUSB User-Mode Client Support Routines:                     ////
////    http://msdn2.microsoft.com/en-us/library/aa476437.aspx          ////
////                                                                    ////
////    PicWinUSB is offered AS-IS and without warranty of any kind.    ////
////    You cannot copy, distribute or sell this code.                  ////
////                                                                    ////
////////////////////////////////////////////////////////////////////////////
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;

namespace PicWinUSB.Controlador
{
    public class MasterControler
    {
        PicWinUSBAPI picwinusbapi = new PicWinUSBAPI();

        public bool ledVerde(IntPtr iHandle)
        {

            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X01;                                     //Led ROJO OFF Led Verde ON
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
            return bres;
        }
        public bool ledRojo(IntPtr iHandle) {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X02;                                     //Led ROJO ON Led Verde OFF
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
            return bres;
        }

        public bool ledOn(IntPtr iHandle){
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X03;                                     //Leds ON
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
            return bres;
        }

        public bool ledOff(IntPtr iHandle) {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X00;                                     //Leds OFF
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
            return bres;
        }

        public bool toggle(IntPtr iHandle) {
            bool bres;
            byte[] sdBuffer = new byte[3];                          // Definer el tamaño del buffer
            sdBuffer[0] = 0X09;                                     //Modo Led
            sdBuffer[1] = 0X04;                                     //Led Toggle
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer); //Enviar
            return bres;
        }

        public byte[] ch1(IntPtr iHandle)
        {
            int ch1 = 0;
            int i = 0;
            bool bres;
            byte[] sdBuffer = new byte[1];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[64];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x0a;    //Modo SUMA
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);

            /*
            if (bres == false) {
                Console.Write("no se recibio nada");
            } else {
                Console.Write("se recibio el dato: ");
            }
            */

            for (i = 0; i < rdBuffer.Length; i++)
            {
                ch1 = rdBuffer[i];
               // Console.Write("valor for: ");
             //   Console.WriteLine(ch1);
            }
            return rdBuffer;
        }

        public byte[] ch2(IntPtr iHandle)
        {
            int ch2 = 0;
            int i = 0;
            bool bres;
            byte[] sdBuffer = new byte[1];           // Define send DataBuffer size
            byte[] rdBuffer = new byte[64];           // Define recieve DataBuffer size

            sdBuffer[0] = 0x0b;    //Modo SUMA
            bres = picwinusbapi.Write_PicWinUSB(iHandle, sdBuffer);
            bres = picwinusbapi.Read_PicWinUSB(iHandle, rdBuffer);

            /*
            if (bres == false)
            {
                Console.Write("no se recibio nada");
            }
            else
            {
                Console.Write("se recibio el dato: ");
            }
            */
            for (i = 0; i < rdBuffer.Length; i++)
            {
                ch2 = rdBuffer[i];
                // Console.Write("valor for: ");
            //    Console.WriteLine(ch2);
            }
            return rdBuffer;
        }


    }
}
