using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;
using System.IO;

namespace AppKoralitos.Model.Clases
{
    class Factura
    {
        StringBuilder line = new StringBuilder();
        int max_art_char = 28;
        int max_char = 41;
        Orden order;

        public Factura(Orden order)
        {
            this.order = order;
        }

        private string character_line(char ch)
        {
            return line.AppendLine(new String(ch, max_char)).ToString();
        }

        private void sale_header()
        {
            //toString(#,#);
            line.AppendLine("ARTÍCULO                    |CANT| PRECIO");
        }

        private string text_left(string text)
        {
            return text.Length > max_char ? text.Substring(max_char - 1) : text;
        }

        private string text_rigth(string linea, string texto)
        {
            int espacio = max_char - linea.Length;
            if(texto.Length > espacio)
            {
                return texto.Substring(espacio - 1);
            }
            else
            {
                espacio -= texto.Length;
                return new string(' ', espacio) + texto; 
            }
        }

        private string center_text(string text)
        {
            int space = max_char - text.Length;
            if(space > 0)
            {
                string sides = new string(' ', space / 2);
                return sides + text + sides;
            }
            else
            {
                return text.Substring(max_char - 1);
            }
        }

        private string format_name(string text)
        {
            return text.Length > max_art_char ? text.Substring(max_art_char - 1) : text + new string(' ', max_art_char - text.Length);
        }

        private void add_articulos_factura()
        {
            foreach(var or in order.platillos)
            {
                var plate = Shared.get_instance().get_plate(or.Key);
                string art = format_name(plate.nombre);
                line.AppendLine(art + "    " + or.Value + " " + plate.precio.ToString("#,#"));
            }
        }

        private void add_articulos_pre_factura()
        {
            foreach (var or in order.platillos)
            {
                var plate = Shared.get_instance().get_plate(or.Key);
                line.AppendLine(" "+ or.Value +"  " + plate.nombre);
            }
        }

        private void cortar_ticket()
        {
            line.AppendLine("\x1B69");
        }

        private void preparar_factura(string client, string mesero, float subtotal, float descuento, float total)
        {
            line.AppendLine(center_text("Koraliitos"));
            line.AppendLine(center_text("Marisquería y más"));
            line.AppendLine(text_left("DIR: Guadalupe, San José"));
            line.AppendLine(text_left("TEL: 2222-2222"));
            line.AppendLine(text_left("CJ:") + Shared.get_instance().get_ced());
            line.AppendLine("");
            character_line('*');
            line.AppendLine("");
            line.AppendLine(text_left("Cliente: " + client));
            line.AppendLine(text_left("Atendió: " + mesero));
            line.AppendLine("");
            line.AppendLine(text_left("FECHA: " + DateTime.Now.ToString()));
            character_line('*');
            sale_header();
            character_line('*');
            add_articulos_factura();
            character_line('=');
            line.AppendLine(text_rigth("", "SUB TOTAL: " + subtotal.ToString("#,#")));
            line.AppendLine(text_rigth("", "DESCUENTO: " + descuento.ToString("#,#")));
            line.AppendLine(text_rigth("", "TOTAL: " + total.ToString("#,#")));
            character_line('_');
        }

        private void preparar_pre_factura()
        {
            line.AppendLine(center_text("Koraliitos"));
            line.AppendLine(center_text("Marisquería y más"));
            line.AppendLine("");
            character_line('*');
            line.AppendLine("");
            line.AppendLine(text_left("FECHA: " + DateTime.Now.ToString()));
            character_line('*');
            sale_header();
            character_line('*');
            add_articulos_pre_factura();
            character_line('=');
            line.AppendLine(" ");
            character_line('_');
        }

        public void factura(string client, string mesero, float subtotal, float descuento, float total)
        {
            preparar_factura(client, mesero, subtotal, descuento, total);
            cortar_ticket();
            RawPrinterHelper.SendStringToPrinter(Shared.get_instance().get_impresora(), this.line.ToString());
            line.Clear();
        }

        public void pre_factura()
        {
            preparar_pre_factura();
            cortar_ticket();
            RawPrinterHelper.SendStringToPrinter(Shared.get_instance().get_impresora(), this.line.ToString());
            line.Clear();
        }
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

            di.pDocName = "My C#.NET RAW Document";
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

        public static bool SendFileToPrinter(string szPrinterName, string szFileName)
        {
            // Open the file.
            FileStream fs = new FileStream(szFileName, FileMode.Open);
            // Create a BinaryReader on the file.
            BinaryReader br = new BinaryReader(fs);
            // Dim an array of bytes big enough to hold the file's contents.
            Byte[] bytes = new Byte[fs.Length];
            bool bSuccess = false;
            // Your unmanaged pointer.
            IntPtr pUnmanagedBytes = new IntPtr(0);
            int nLength;

            nLength = Convert.ToInt32(fs.Length);
            // Read the contents of the file into the array.
            bytes = br.ReadBytes(nLength);
            // Allocate some unmanaged memory for those bytes.
            pUnmanagedBytes = Marshal.AllocCoTaskMem(nLength);
            // Copy the managed byte array into the unmanaged array.
            Marshal.Copy(bytes, 0, pUnmanagedBytes, nLength);
            // Send the unmanaged bytes to the printer.
            bSuccess = SendBytesToPrinter(szPrinterName, pUnmanagedBytes, nLength);
            // Free the unmanaged memory that you allocated earlier.
            Marshal.FreeCoTaskMem(pUnmanagedBytes);
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
