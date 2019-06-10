using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduller_v2
{
    public class pagina
    {
        public String identificador;
        public int identificadorProxParticao;
        public memoriaPrincipal ram;
        public memoriaSecundaria hd;
        public int tamanho;
        public bool ativa; // TRUE == ram // FALSE == hd
        public int acessos;
        public LinkedList<particao> particoes;
        public Scheduller escalonador;

        public pagina(String id,memoriaPrincipal ram, memoriaSecundaria hd, Scheduller escalonador,int tamanho)
        {
            acessos = 0;
            identificadorProxParticao = 0;
            particoes = new LinkedList<particao>();
            particoes.AddLast(new particao(ram, hd, escalonador, tamanho,Convert.ToString(++identificadorProxParticao),this));
            identificador = id;
            this.tamanho = tamanho;
            this.ram = ram;
            this.hd = hd;
            this.escalonador = escalonador;
        }
        

        public particao searchSmaller(int tamanho)
        {
            particao smaller = null;
            foreach(particao part in particoes)
            {
                if (part.usando == null)
                {
                    if (part.tamanho == tamanho)
                    {
                        return part;
                    }
                    else if (smaller == null && part.tamanho > tamanho)
                    {
                        if (!part.molded)
                        {
                            return mold(part, tamanho);
                        }
                        else
                        {
                            smaller = part;
                            
                        }
                    }
                    else if ((part.tamanho > tamanho) && (part.tamanho < smaller.tamanho))
                    {
                        if (part.molded)
                        {
                            smaller = part;
                        }
                        else
                        {
                            return mold(part, tamanho);
                        }
                    }
                }
                
            }
            return smaller;
        }

          
        public particao mold(particao W, int tamanhoDesejado)
        {
            particao moldada = new particao(ram, hd, escalonador,W.tamanho - tamanhoDesejado, Convert.ToString(++identificadorProxParticao),this);
            W.paginaPai.particoes.AddAfter(W.paginaPai.particoes.Find(W),moldada);
            W.tamanho = tamanhoDesejado;
            W.molded = true;
            return W;
        }

        public void deactivate()
        {
            ativa = false;
            foreach(particao p in particoes)
            {
                p.deactivate();
            }
        }

        public void activate()
        {
            ativa = true;
            foreach (particao p in particoes)
            {
                p.activate();
            }
        }
    }
}
