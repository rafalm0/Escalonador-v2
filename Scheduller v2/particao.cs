using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduller_v2
{
    public class particao
    {
        public String identificador;
        public int tamanho;
        public int memoria_usada;
        public memoriaPrincipal ram;
        public memoriaSecundaria hd;
        public Scheduller escalonador;
        public Processo usando;
        public pagina paginaPai;
        public bool molded;
        public bool ativa; // TRUE == ram // FALSE == hd

        public particao(memoriaPrincipal ram, memoriaSecundaria hd, Scheduller escalonador,int tamanho,string id,pagina pai)
        {
            paginaPai = pai;
            identificador = id;
            this.tamanho = tamanho;
            molded = false;
            memoria_usada = 0;
            usando = null;
            this.ram = ram;
            this.hd = hd;
            this.escalonador = escalonador;
        }

        public void deactivate()
        {
            ativa = false;
        }

        public void activate()
        {
            ativa = true;
        }

    }
}
