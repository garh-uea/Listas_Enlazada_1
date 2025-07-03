public class Invertir
{
    public int Valor;
    public Invertir? Siguiente;

    public Invertir(int valor)
    {
        Valor = valor;
        Siguiente = null;
    }
}

public class ListaEnlazada
{
    private Invertir? cabeza;

    public ListaEnlazada()
    {
        cabeza = null;
    }

    // Agrega un valor  al final
    public void Agregar(int valor)
    {
        Invertir nuevo = new Invertir(valor);

        if (cabeza == null)
        {
            cabeza = nuevo;
        }
        else
        {
            Invertir actual = cabeza;
            while (actual.Siguiente != null)
            {
                actual = actual.Siguiente;
            }
            actual.Siguiente = nuevo;
        }
    }

    // Muestra todos los elementos de la lista
    public void Mostrar()
    {
        Invertir? actual = cabeza;

        Console.Write("Lista: ");
        while (actual != null)
        {
            Console.Write(actual.Valor + " ");
            actual = actual.Siguiente;
        }
        Console.WriteLine();
    }

    // Invierte la lista enlazada
    public void Invertir()
    {
        Invertir? anterior = null;
        Invertir? actual = cabeza;
        Invertir? siguiente;

        while (actual != null)
        {
            siguiente = actual.Siguiente;
            actual.Siguiente = anterior;
            anterior = actual;
            actual = siguiente;
        }

        cabeza = anterior;
    }
}

class ProgramaLista
{
    static void Main()
    {
        ListaEnlazada lista = new ListaEnlazada();

        lista.Agregar(4);
        lista.Agregar(7);
        lista.Agregar(12);
        lista.Agregar(17);
        lista.Agregar(21);
        lista.Agregar(25);

        Console.WriteLine("Antes de invertir el orden:");
        lista.Mostrar();

        lista.Invertir();

        Console.WriteLine("Después de invertir el orden:");
        lista.Mostrar();
    }
}