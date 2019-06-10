using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduller_v2
{
    public class memoriaSecundaria
    {
        public memoriaPrincipal ram;
        public Scheduller escalonador;
        public int pagesize;
        public LinkedList<pagina> paginas;

        public memoriaSecundaria(int pagesize, memoriaPrincipal ram,  Scheduller escalonador)
        {
            this.pagesize = pagesize;
            this.ram = ram;
            this.escalonador = escalonador;
            paginas = new LinkedList<pagina>();
        }

        public pagina storeAndGetNew(pagina swapped)
        {
            swapped.deactivate();
            paginas.AddLast(swapped);
            return new pagina(Convert.ToString(++escalonador.identificadorProxPagina), ram, this, escalonador, pagesize);
        }

        public void swapPage(pagina swapped,pagina needed)
        {
            swapped.deactivate();
            needed.activate();
            paginas.AddAfter(paginas.Find(needed), swapped);
            paginas.Remove(needed);
        }
        
    }
}
