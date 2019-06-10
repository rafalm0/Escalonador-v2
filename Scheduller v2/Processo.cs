using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Scheduller_v2
{
    public class Processo
    {
        public String identificador;

        public memoriaPrincipal ram;
        public memoriaSecundaria hd;
        public Scheduller escalonador;

        public int tempo_faltando;
        public int tempo_total;
        public int quantum_total;
        public int quantum_sobrando;

        public int status; // 0 = fila de espera // 1 = rodando // 2 == esperando ser abortado // 3 == esperando ser finalizado
        public LinkedList<particao> blocos_de_memoria;

        public Processo(int tempo,int quantum,String identificador,memoriaPrincipal ram,memoriaSecundaria hd, Scheduller escalonador)
        {
            blocos_de_memoria = new LinkedList<particao>();
            status = 0;
            tempo_faltando = tempo;
            tempo_total = tempo;
            quantum_total = quantum;
            quantum_sobrando = quantum_total;
            this.identificador = identificador;
            this.ram = ram;
            this.hd = hd;
            this.escalonador = escalonador;
        }


        public LinkedList<pagina> procurarPagInativas()
        {
            LinkedList<pagina> necessarias = new LinkedList<pagina>();
            foreach (particao part in blocos_de_memoria)
            {
                if (!part.paginaPai.ativa && !necessarias.Contains(part.paginaPai))
                {
                    necessarias.AddLast(part.paginaPai);
                }
            }
            return necessarias;
        }

    }
}
