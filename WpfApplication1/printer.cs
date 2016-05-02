using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApplication1
{
    class Printer
    {
        String[] printers = new String[2];
        
        public Printer()
        {
            printers[0] = "pos1";
            printers[1] = "pos2";
        }

        public String getPrinterName()
        {
            return "pos58";
        }

        public String [] getList()
        {
            return printers;
        }
    }
}
