using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Cola : IQueue
    {
        private IElemento tope;
        public Cola() { this.tope = new ElementoVacio(); }
        public bool IsEmpty { get { return this.tope.IsEmpty; } }
        public int Size{get{return this.tope.Size();}}
        public void Add(object item){this.tope = this.tope.Add(item);}
        public object Top { get { return this.tope.Top; } } // retornar el primer item, lanzar exception si esta vacío.
        public void Remove(){this.tope = this.tope.Remove();}// remover el primer item, lanzar exception si esta vacío.*/
    }
}
