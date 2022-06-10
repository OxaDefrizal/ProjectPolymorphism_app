using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectPolymorphism_app
{
    
    public class PrinterWindows
    {
        
        public virtual void Show()
        {
            
            Console.WriteLine("\nPrinter display dimesion : ");
        }
        public virtual void Print()
        {
            Console.WriteLine("Printer printer printing : ");
        }
    }
}
