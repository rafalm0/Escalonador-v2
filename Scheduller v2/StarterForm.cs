using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduller_v2
{
    public partial class StarterForm : Form
    {
        public int cpuN;
        public int memorysize;
        public int initProc;
        public int quantum;
        private bool close;

        public StarterForm()
        {
            InitializeComponent();
            close = true;
        }
        

        private void Startbutton_Click(object sender, EventArgs e)
        {
            
            cpuN = (int)cpunumeric.Value;
            if(cpuN == 0)
            {
                return;
            }
            memorysize = (int)memorynumeric.Value;
            if(memorysize == 0)
            {
                return;
            }
            quantum = (int)quantumnumeric.Value;
            if(quantum == 0)
            {
                return;
            }
            initProc = (int)processonumeric.Value;
            close = false;
            Close();
        }

        private void StarterForm_FormClosing_1(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                Environment.Exit(0);
            }
        }
    }
}
