using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    interface IElemento
    {
        bool IsEmpty { get; }
        bool HasNext { get; }
        int Size();
        
        IElemento Add(object item); // agregar un item
        object Top { get; } // retornar el primer item, lanzar exception si esta vacío.
        IElemento Remove(); // remover el primer item, lanzar exception si esta vacío.


    }
}
