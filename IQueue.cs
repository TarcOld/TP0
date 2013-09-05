
public interface IQueue
{
    bool IsEmpty { get; }
    int Size { get; }
    void Add(object item); // agregar un item
    object Top { get; } // retornar el primer item, lanzar exception si esta vacío.
    void Remove(); // remover el primer item, lanzar exception si esta vacío.
}