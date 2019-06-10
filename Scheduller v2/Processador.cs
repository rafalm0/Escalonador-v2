using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduller_v2
{
    public class Processador
    {
        public String identificador;

        public memoriaPrincipal ram;
        public memoriaSecundaria hd;
        public Scheduller escalonador;
        public Processo rodando;


        public Processador(String id, memoriaPrincipal ram, memoriaSecundaria hd, Scheduller escalonador)
        {
            identificador = id;
            this.ram = ram;
            this.hd = hd;
            this.escalonador = escalonador;
            rodando = null;
        }

        public void work()
        {
            if(rodando != null)
            {
                if (escalonador.randomizer.Next(1, 6) == 1)
                {
                    if(rodando.blocos_de_memoria.Count > 0)
                        rodando.blocos_de_memoria.ElementAt(escalonador.randomizer.Next(0, rodando.blocos_de_memoria.Count - 1)).paginaPai.acessos++;
                }
                if (rodando.tempo_faltando -- <= 0)
                {
                    ram.deAllocateMemory(rodando);
                    rodando.status = 3;
                    escalonador.abortProcess(rodando);
                    rodando = null;
                    return;
                }
                if (rodando.quantum_sobrando -- <= 0)
                {
                    rodando.status = 0;
                    rodando.quantum_sobrando = rodando.quantum_total;
                    escalonador.sendToQueue(rodando);
                    rodando = null;
                }
                
            }
            

        }
    }
}
