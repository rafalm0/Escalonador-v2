using System;
using System.Collections;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace Scheduller_v2
{
        static class Program
        {
            [STAThread]
            static void Main()
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                while (true)
                {
                    StarterForm Form1 = new StarterForm();
                    Application.Run(Form1);
                    SchedullerForm Form2 = new SchedullerForm(Form1.cpuN,Form1.memorysize,Form1.quantum,Form1.initProc,10);
                    Application.Run(Form2);
                }
            
            }
        }
    
}
