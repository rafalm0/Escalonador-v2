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
    public partial class SchedullerForm : Form
    {
        public bool close;
        public bool timer_status;
        public Scheduller escalonador; 

        public SchedullerForm(int cpuN, int memoryN, int quantum, int initProc,int pagesize)
        {
            InitializeComponent();
            close = true;
            timer_status = true;
            escalonador = new Scheduller(memoryN, initProc, cpuN, quantum, pagesize);
            aTimer.Start();
        }

        public void update_windows()
        {
            proclist.Items.Clear();
            foreach(Processo a in escalonador.filaEspera)
            {
                proclist.Items.Add(new ListViewItem(new String[] {a.identificador,Convert.ToString(a.tempo_total), Convert.ToString(a.tempo_faltando) }));
            }
            cpulist.Items.Clear();
            foreach(Processador c in escalonador.processadores)
            {
                if(c.rodando == null)
                    cpulist.Items.Add(new ListViewItem(new String[] {c.identificador,"","","","" }));
                else
                    cpulist.Items.Add(new ListViewItem(new String[] { c.identificador,c.rodando.identificador, Convert.ToString(c.rodando.quantum_sobrando), Convert.ToString(c.rodando.tempo_faltando), Convert.ToString(c.rodando.tempo_total) }));
            }
            ramlist.Items.Clear();
            foreach(pagina page in escalonador.ram.paginas)
            {
                foreach(particao part in page.particoes)
                {
                    if (part.usando != null)
                        ramlist.Items.Add(new ListViewItem(new String[] {page.identificador,part.identificador, part.usando.identificador,Convert.ToString(part.memoria_usada) , Convert.ToString(part.tamanho) }));
                    else
                        ramlist.Items.Add(new ListViewItem(new String[] { page.identificador, part.identificador,"","", Convert.ToString(part.tamanho) }));
                }
            }
            hdlist.Items.Clear();
            foreach (pagina page in escalonador.hd.paginas)
            {
                foreach (particao part in page.particoes)
                {
                    if (part.usando != null)
                        ramlist.Items.Add(new ListViewItem(new String[] { page.identificador, part.identificador, part.usando.identificador, Convert.ToString(part.memoria_usada), Convert.ToString(part.tamanho) }));
                    else
                        ramlist.Items.Add(new ListViewItem(new String[] { page.identificador, part.identificador, "", "", Convert.ToString(part.tamanho) }));
                }
            }
            finalList.Items.Clear();
            foreach(Processo a in escalonador.filaAbortados)
            {
                if (a.status == 3)
                    finalList.Items.Add(new ListViewItem(new String[] {a.identificador, "finalizado" }));
                else
                    finalList.Items.Add(new ListViewItem(new String[] {a.identificador, "abortado" }));
            }
        }

        private void SchedullerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (close)
            {
                Environment.Exit(0);
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            close = false;
            Close();
        }

        private void pauseButton_Click(object sender, EventArgs e)
        {
            if (timer_status)
            {
                aTimer.Stop();
                timer_status = false;
            }
            else
            {
                aTimer.Start();
                timer_status = true;
            }
        }

        private void processoButton_Click(object sender, EventArgs e)
        {
            escalonador.addProcesso();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
        }

        private void aTimer_Tick(object sender, EventArgs e)
        {
            escalonador.work();
            update_windows();
        }
        
    }
}
