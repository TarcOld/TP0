using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ElementoVacio : IElemento
    {
        private IElemento siguiente;

        public ElementoVacio()
        {
            this.siguiente = null;
        }

        public bool IsEmpty { get { return true; } }
        public bool HasNext { get { return false; }}
        public int Size() { return 0; }

        public IElemento Add(object item){return (new ElementoLleno(item));}


        public object Top { get { throw new Exception(); } }
        public IElemento Remove() { throw new Exception();}

    }


}
