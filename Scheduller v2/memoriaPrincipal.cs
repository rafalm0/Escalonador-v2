using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduller_v2
{
    public class memoriaPrincipal
    {
        public memoriaSecundaria hd;
        public Scheduller escalonador;
        public int tamanho_total;
        public int tamanho_ocupado;
        public int pagesize;
        public LinkedList<pagina> paginas;


        public memoriaPrincipal(int tamanho,int pagesize, Scheduller escalonador)
        {
            tamanho_total = tamanho;
            paginas = new LinkedList<pagina>();
            tamanho_ocupado = 0;
            this.pagesize = pagesize;
            this.escalonador = escalonador;
            int quantPag = tamanho / pagesize;
            while(quantPag -- > 0)
            {
                pagina nova = new pagina(Convert.ToString(++escalonador.identificadorProxPagina), this, hd, escalonador, pagesize);
                nova.activate();
                paginas.AddLast(nova);
            }
        }

        

        public pagina storeAndGetNew(pagina swapped)
        {
            pagina nova = hd.storeAndGetNew(swapped);
            nova.activate();
            paginas.AddLast(nova);
            return nova;
        }

        public void swapPage(pagina swapped,pagina needed)
        {
            paginas.AddAfter(paginas.Find(swapped), needed);
            paginas.Remove(swapped);
            hd.swapPage(swapped, needed);
        }

        public bool checarBlocos(Processo a)
        {
            foreach(particao part in a.blocos_de_memoria)
            {
                if (!part.ativa)
                {
                    return false;
                }
            }
            return true;
        }

        public void recalculate_usage()
        {
            int usage = 0;
            foreach(pagina page in paginas)
            {
                foreach(particao part in page.particoes)
                {
                    usage += part.memoria_usada;
                }
            }
            tamanho_ocupado = usage;
            //return usage;
        }

        /*public bool fitIn(LinkedList<pagina> importantes,pagina inserting)
        {
            LinkedList<pagina> naoNecessarias = new LinkedList<pagina>();
            foreach(pagina page in paginas)
            {
                if (!importantes.Contains(page))
                {
                    naoNecessarias.AddLast(page);
                }
            }
            if(naoNecessarias.Count )
        }*/


        public particao searchSmaller(int tamanho)
        {
            particao smaller = null;
            foreach(pagina page in paginas)
            {
                particao a = page.searchSmaller(tamanho);
                if (a == null)
                {
                    continue;
                }
                else if(a.tamanho == tamanho)
                {
                    return a;
                }
                else 
                {
                    if( smaller == null)
                    {
                        smaller = a;
                    }
                    else if (smaller.tamanho > a.tamanho && a.tamanho > tamanho )
                    {
                        smaller = a;
                    }
                }
            }
            return smaller;
        }

        public bool allocateMemory(Processo a,int tamanho)
        {
            particao found = searchSmaller(tamanho);
            if (found != null)
            {
                found.usando = a;
                a.blocos_de_memoria.AddLast(found);
                found.memoria_usada = tamanho;
                return true;
            }
            else
            {
                //deAllocateMemory(a);
                a.status = 2;
                return false;
            }
        }

        public void deAllocateMemory(Processo a)
        {
            foreach(particao part in a.blocos_de_memoria)
            {
                part.usando = null;
                part.memoria_usada = 0;
            }
            a.blocos_de_memoria.Clear();
        }
    }
}
