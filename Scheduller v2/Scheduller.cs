using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduller_v2
{
    public class Scheduller
    {
        public int identificadorProxProcesso;
        public int identificadorProxProcessador;
        public int identificadorProxPagina;
        public int quantum;
        public memoriaPrincipal ram;
        public memoriaSecundaria hd;
        public LinkedList<Processador> processadores;
        public LinkedList<Processo> filaEspera;
        public LinkedList<Processo> filaAbortados;
        public Random randomizer;

        public Scheduller(int memoria,int processoN,int processadorN,int quantum,int pagesize)
        {
            processadores = new LinkedList<Processador>();
            filaEspera = new LinkedList<Processo>();
            filaAbortados = new LinkedList<Processo>();
            this.quantum = quantum;
            randomizer = new Random();
            ram = new memoriaPrincipal(memoria, pagesize, this);
            hd = new memoriaSecundaria(pagesize, ram, this);
            ram.hd = hd;
            while (processadorN-- > 0)
            {
                processadores.AddLast(new Processador(Convert.ToString(++identificadorProxProcessador), ram, hd, this));
            }
            while (processoN -- > 0)
            {
                addProcesso();
            }

        }

        public void work()
        {
            runLFU();
            foreach(Processador c in processadores)
            {
                if (c.rodando == null)
                {
                    if(filaEspera.Count > 0)
                    {
                        Processo novo = filaEspera.First();
                        filaEspera.RemoveFirst();
                        if (novo.blocos_de_memoria.Count == 0)
                        {
                            if (!ram.allocateMemory(novo, 10))
                            //if (!ram.allocateMemory(novo, randomizer.Next(1, 11)))// alocacao inicial
                            {
                                abortProcess(novo); // se chegou aqui deu ruim e nao tinha memoria
                            }
                        }
                        if (ram.checarBlocos(novo))
                        {
                            c.rodando = novo;
                            
                        }
                        
                    }
                }
                else
                {
                    if (randomizer.Next(1, 11) == 1)
                    {
                        if (!ram.allocateMemory(c.rodando, 10))
                        //if (!ram.allocateMemory(c.rodando, randomizer.Next(1, 11))) // alocacao dinamica 
                        {
                            abortProcess(c.rodando); // se chegou aqui deu ruim e nao tinha memoria
                        }
                    }
                    c.work();
                }
            }
        }

        public void abortProcess(Processo a)
        {
            foreach(Processador c in processadores)
            {
                if (c.rodando == a)
                {
                    c.rodando = null;

                }
            }
            if (filaEspera.Contains(a))
            {
                filaEspera.Remove(a);
            }
            ram.deAllocateMemory(a);
            filaAbortados.AddLast(a);
        }


        public void sendToQueue(Processo a)
        {
            filaEspera.AddLast(a);
        }

        public LinkedList<pagina> getPaginasImportantes() //retorna as paginas que precisam estar na memoria e as que irao precisar dos dois proximos processos
        {
            LinkedList<pagina> importantes = new LinkedList<pagina>();
            foreach (Processador P in processadores)
            {
                if (P.rodando != null)
                {
                    foreach(particao part in P.rodando.blocos_de_memoria)
                    {
                        if (!importantes.Contains(part.paginaPai))
                        {
                            importantes.AddLast(part.paginaPai);
                        }
                    }
                }
            }
            if (filaEspera.Count != 0)
            {
                foreach (particao part in filaEspera.First.Value.blocos_de_memoria)
                {
                    if (!importantes.Contains(part.paginaPai))
                    {
                        importantes.AddLast(part.paginaPai);
                    }
                }
                if (filaEspera.First.Next != null)
                {
                    foreach (particao part in filaEspera.First.Next.Value.blocos_de_memoria)
                    {
                        if (!importantes.Contains(part.paginaPai))
                        {
                            importantes.AddLast(part.paginaPai);
                        }
                    }
                }
            }
            return importantes;

        }

        public LinkedList<pagina> getPaginasNaoNecessarias(LinkedList<pagina> importantes)
        {
            LinkedList<pagina> naoNecessarias = new LinkedList<pagina>();
            foreach(pagina page in ram.paginas)
            {
                if (!importantes.Contains(page)){
                    naoNecessarias.AddLast(page);
                }
            }
            naoNecessarias.OrderBy<pagina, int>(pagina => pagina.acessos);
            return naoNecessarias;
        }

        public LinkedList<Processo> getProcessoImportantes() // retorna os processos rodando e os dois primeiros na fila de espera
        {
            LinkedList<Processo> importantes = new LinkedList<Processo>();
            foreach(Processador P in processadores)
            {
                if (P.rodando != null)
                {
                    importantes.AddLast(P.rodando);
                }
            }
            if(filaEspera.First() != null)
            {
                importantes.AddLast(filaEspera.First());
                if(filaEspera.First.Next != null)
                {
                    importantes.AddLast(filaEspera.First.Next);
                }
            }
            return importantes;

        }
        
        public void runLFU()
        {
            ram.recalculate_usage();
            if (ram.tamanho_ocupado != 0)
            {
                if (ram.tamanho_ocupado / ram.tamanho_total > 0.8)
                {
                    LinkedList<pagina> importantes = getPaginasImportantes();
                    if (importantes.Count == 0)
                    {
                        return;
                    }
                    LinkedList<pagina> Naoimportantes = getPaginasNaoNecessarias(importantes);
                    if (Naoimportantes.Count == 0)
                    {
                        return;
                    }
                    foreach (pagina page in importantes)
                    {
                        if (!page.ativa)
                        {
                            if (Naoimportantes.Count == 0)
                            {
                                return;
                            }
                            ram.swapPage(Naoimportantes.First.Value, page);
                            Naoimportantes.RemoveFirst();
                        }
                    }
                }
            }
        }

        public void addProcesso()
        {
            filaEspera.AddLast(new Processo(randomizer.Next(4, 21), quantum, Convert.ToString(++identificadorProxProcesso), ram, hd, this));
        }

    }
}
