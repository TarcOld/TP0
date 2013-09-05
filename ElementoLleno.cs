using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class ElementoLleno : IElemento
    {
        private IElemento siguiente;
        private object objeto;

        public ElementoLleno(object item)
        {
            this.siguiente = new ElementoVacio();
            this.objeto = item;
        }

        public bool IsEmpty {get{ return false;} }
        public bool HasNext {get{ return true;} }
        public int Size() { return (1 + this.siguiente.Size());}        


        public IElemento Add(object item)
        {
/*            if (this.siguiente.HasNext) this.siguiente.Add(item);
            else this.siguiente = this.siguiente.Add(item);
            return (this);*/
            this.siguiente = this.siguiente.Add(item);
            return this;
        }


        public object Top { get{return this.objeto;} }
        public IElemento Remove() {return this.siguiente; }

    }


}
