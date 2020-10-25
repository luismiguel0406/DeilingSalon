﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using Capa_Gestion_de_seguridad;
using System.IO;


namespace Sistema_de__inventarioGP2
{
   public class Creador_de_factura
    {
        

        public class clsFuncion
        {
            
            public class CreaTicket
            {
                
                public static StringBuilder line = new StringBuilder();
                string ticket = "";
                string parte1, parte2;

                public static int max = 32;//DE 40 A  32 LO
                int cort;
                public static string LineasGuion()
                {
                    string LineaGuion = "--------------------------------";   // agrega lineas separadoras -

                    return line.AppendLine(LineaGuion).ToString();
                }


                public static void EncabezadoVenta()
                {
                    string LineEncabesado = "Articulo      Can    Unit  Valor";   // agrega lineas de  encabezados
                    line.AppendLine(LineEncabesado);
                }
                public void TextoIzquierda(string par1)                          // agrega texto a la izquierda
                {
                    max = par1.Length;
                    if (max > 32)                                 // **********
                    {
                        cort = max - 32;
                        parte1 = par1.Remove(32, cort);        // si es mayor que 40 caracteres, lo corta
                    }
                    else { parte1 = par1; }                      // **********
                    line.AppendLine(ticket = parte1);

                }
                public void TextoDerecha(string par1)
                {
                    ticket = "";
                    max = par1.Length;
                    if (max > 32)                                 // **********
                    {
                        cort = max - 32;
                        parte1 = par1.Remove(32, cort);           // si es mayor que 40 caracteres, lo corta
                    }
                    else { parte1 = par1; }                      // **********
                    max = 32 - par1.Length;                     // obtiene la cantidad de espacios para llegar a 40
                    for (int i = 0; i < max; i++)
                    {
                        ticket += " ";                          // agrega espacios para alinear a la derecha
                    }
                    line.AppendLine(ticket += parte1 + "\n");                //Agrega el texto

                }
                public void TextoCentro(string par1)
                {
                    ticket = "";
                    max = par1.Length;
                    if (max > 32)                                 // **********
                    {
                        cort = max - 32;
                        parte1 = par1.Remove(32, cort);          // si es mayor que 40 caracteres, lo corta
                    }
                    else { parte1 = par1; }                      // **********
                    max = (int)(32 - parte1.Length) / 2;         // saca la cantidad de espacios libres y divide entre dos
                    for (int i = 0; i < max; i++)                // **********
                    {
                        ticket += " ";                           // Agrega espacios antes del texto a centrar
                    }                                            // **********
                    line.AppendLine(ticket += parte1 + "\n");

                }
                public void TextoExtremos(string par1, string par2)
                {
                    max = par1.Length;
                    if (max > 14)                                 // **********
                    {
                        cort = max - 14;
                        parte1 = par1.Remove(14, cort);          // si par1 es mayor que 18 lo corta
                    }
                    else { parte1 = par1; }                      // **********
                    ticket = parte1;                             // agrega el primer parametro
                    max = par2.Length;
                    if (max > 14)                                 // **********
                    {
                        cort = max - 14;
                        parte2 = par2.Remove(14, cort);          // si par2 es mayor que 18 lo corta
                    }
                    else { parte2 = par2; }
                    max = 32 - (parte1.Length + parte2.Length);
                    for (int i = 0; i < max; i++)                 // **********
                    {
                        ticket += " ";                            // Agrega espacios para poner par2 al final
                    }                                             // **********
                    line.AppendLine(ticket += parte2 + "\n");                   // agrega el segundo parametro al final

                }
                public void AgregaTotales(string par1, float total)
                {
                    max = par1.Length;
                    if (max > 20)                                 // **********
                    {//se cambio de 25 a 20 y el mas de 40 a  36
                        cort = max - 20;
                        parte1 = par1.Remove(20, cort);          // si es mayor que 25 lo corta
                    }
                    else { parte1 = par1; }                      // **********
                    ticket = parte1;
                    parte2 = total.ToString() + "$";
                    max = 32 - (parte1.Length + parte2.Length);
                    for (int i = 0; i < max; i++)                // **********
                    {
                        ticket += " ";                           // Agrega espacios para poner el valor de moneda al final
                    }                                            // **********
                    line.AppendLine(ticket += parte2 + "\n");

                }

                // se le pasan los Medicamentos con sus detalles
                public void AgregaArticulo(string Articul, double preci, int can, double subtota)
                {
                    string Articulo = Articul;
                    double precio = preci;
                    int cant = can;
                    double subtotal = subtota;

                    if (cant.ToString().Length <= 1 && precio.ToString("c").Length <= 9 && subtotal.ToString("c").Length <= 9) // valida que cant precio y total esten dentro de rango
                    {

                        string elementos = "", espacios = "";
                        bool bandera = false;
                        int nroEspacios = 0;

                        if (Articulo.Length > 14)                                 // **********
                        {   // habilite estas dos lineas
                          //  cort = max - 16;
                            parte1 = Articulo.Remove(14);          // corta a 16 la descripcion del articulo
                            nroEspacios = (2 - cant.ToString().Length);
                            espacios = "";
                            for (int i = 0; i < nroEspacios; i++)
                            {
                                espacios += " ";
                            }
                            elementos += espacios + cant.ToString();

                            // colocamos el precio a la derecha
                            nroEspacios = (8 - precio.ToString().Length);
                            espacios = "";

                            for (int i = 0; i < nroEspacios; i++)
                            {
                                espacios += " ";
                            }
                            elementos += espacios + precio.ToString();

                            //colocar el subtotal a la dercha
                            nroEspacios = (8 - subtotal.ToString().Length);
                            espacios = "";

                            for (int i = 0; i < nroEspacios; i++)
                            {
                                espacios += " ";
                            }
                            elementos += espacios + subtotal.ToString();

                            int CaracterActual = 0;// indica en que caracter se quedo
                            for (int Longtext = Articulo.Length; Longtext > 14; Longtext-=14)
                            {
                                if (bandera == false)
                                {
                                    line.AppendLine(Articulo.Substring(CaracterActual, 14) + elementos);
                                    bandera = true;

                                }
                                else
                                {
                                    line.AppendLine(Articulo.Substring(CaracterActual, 14));

                                }
                                CaracterActual += 14;
                            }
                            line.AppendLine(Articulo.Substring(CaracterActual, Articulo.Length - CaracterActual));


                        }
                        else
                        {

                            for (int i = 0; i < (14 - Articulo.Length); i++)
                            {
                                espacios += " ";

                            }
                            elementos = Articulo + espacios;
                            nroEspacios = (2 - cant.ToString().Length);
                            espacios = " ";
                            for (int i = 0; i < nroEspacios; i++)
                            {
                                espacios += " ";
                            }
                            elementos += espacios + cant.ToString();

                            // colocamos el precio a la derecha
                            nroEspacios = (8 - precio.ToString().Length);
                            espacios = " ";

                            for (int i = 0; i < nroEspacios; i++)
                            {
                                espacios += " ";
                            }
                            elementos += espacios + precio.ToString();

                            //colocar el subtotal a la dercha
                            nroEspacios = (8 - subtotal.ToString().Length);
                            espacios = " ";

                            for (int i = 0; i < nroEspacios; i++)
                            {
                                espacios += "";
                            }
                            elementos += espacios + subtotal.ToString();
                            line.AppendLine(elementos);

                        }
                    }
                    else
                    {
                        //  MessageBox.Show("Valores fuera de rango");

                    }
                }
                public void ImprimirTiket(string stringimpresora)
                {
                    RawPrinterHelper.SendStringToPrinter(stringimpresora, line.ToString());



                    MessageBox.Show(line.ToString());///Muestra la factura que se ha generado

                    line = new StringBuilder();
                    
                }
                public class RawPrinterHelper
                {
                    // Structure and API declarions:
                    [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
                    public class DOCINFOA
                    {
                        [MarshalAs(UnmanagedType.LPStr)]
                        public string pDocName;
                        [MarshalAs(UnmanagedType.LPStr)]
                        public string pOutputFile;
                        [MarshalAs(UnmanagedType.LPStr)]
                        public string pDataType;
                    }
                    [DllImport("winspool.Drv", EntryPoint = "OpenPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool OpenPrinter([MarshalAs(UnmanagedType.LPStr)] string szPrinter, out IntPtr hPrinter, IntPtr pd);

                    [DllImport("winspool.Drv", EntryPoint = "ClosePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool ClosePrinter(IntPtr hPrinter);

                    [DllImport("winspool.Drv", EntryPoint = "StartDocPrinterA", SetLastError = true, CharSet = CharSet.Ansi, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool StartDocPrinter(IntPtr hPrinter, Int32 level, [In, MarshalAs(UnmanagedType.LPStruct)] DOCINFOA di);

                    [DllImport("winspool.Drv", EntryPoint = "EndDocPrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool EndDocPrinter(IntPtr hPrinter);

                    [DllImport("winspool.Drv", EntryPoint = "StartPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool StartPagePrinter(IntPtr hPrinter);

                    [DllImport("winspool.Drv", EntryPoint = "EndPagePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool EndPagePrinter(IntPtr hPrinter);

                    [DllImport("winspool.Drv", EntryPoint = "WritePrinter", SetLastError = true, ExactSpelling = true, CallingConvention = CallingConvention.StdCall)]
                    public static extern bool WritePrinter(IntPtr hPrinter, IntPtr pBytes, Int32 dwCount, out Int32 dwWritten);

                    // SendBytesToPrinter()
                    // When the function is given a printer name and an unmanaged array
                    // of bytes, the function sends those bytes to the print queue.
                    // Returns true on success, false on failure.
                    public static bool SendBytesToPrinter(string szPrinterName, IntPtr pBytes, Int32 dwCount)
                    {
                        Int32 dwError = 0, dwWritten = 0;
                        IntPtr hPrinter = new IntPtr(0);
                        DOCINFOA di = new DOCINFOA();
                        bool bSuccess = false; // Assume failure unless you specifically succeed.

                        //se agrega esto verificanco si es factura o cotizacion
                      // CreaTicket creador = new CreaTicket();
                       
                        di.pDocName = "Facturado por: "+ cachelogin.nombre.ToString() +" "+DateTime.Now.ToShortDateString()+" - "+DateTime.Now.ToShortTimeString();
                        di.pDataType = "RAW";
                        
                        

                        // Open the printer.
                        if (OpenPrinter(szPrinterName.Normalize(), out hPrinter, IntPtr.Zero))
                        {
                            // Start a document.
                            if (StartDocPrinter(hPrinter, 1, di))
                            {
                                // Start a page.
                                if (StartPagePrinter(hPrinter))
                                {
                                    // Write your bytes.
                                    bSuccess = WritePrinter(hPrinter, pBytes, dwCount, out dwWritten);
                                    EndPagePrinter(hPrinter);
                                }
                                EndDocPrinter(hPrinter);
                            }
                            ClosePrinter(hPrinter);
                        }
                        // If you did not succeed, GetLastError may give more information
                        // about why not.
                        if (bSuccess == false)
                        {
                            dwError = Marshal.GetLastWin32Error();
                        }
                        return bSuccess;
                    }

                    public static bool SendStringToPrinter(string szPrinterName, string szString)
                    {
                        IntPtr pBytes;
                        Int32 dwCount;
                        // How many characters are in the string?
                        dwCount = szString.Length;
                        // Assume that the printer is expecting ANSI text, and then convert
                        // the string to ANSI text.
                        pBytes = Marshal.StringToCoTaskMemAnsi(szString);
                        // Send the converted ANSI string to the printer.
                        SendBytesToPrinter(szPrinterName, pBytes, dwCount);
                        Marshal.FreeCoTaskMem(pBytes);
                        return true;
                    }
                }
            }
        }
}
}