using System;  

class Nodo  
{  
    public string nombres;  
    public Nodo izquierdo;  
    public Nodo derecho;  

    public Nodo(string nombre)  
    {  
        nombres = nombre;  
        izquierdo = null;  
        derecho = null;  
    }  
}  

public class ArbolbinarioBusqueda  
{  
    private Nodo raiz; // Root nivel 0  

    public void Insertar(string nombre)  
    {  
        raiz = InsertarRecursivo(raiz, nombre);  
    }  

    private Nodo InsertarRecursivo(Nodo nodo, string nombre)  
    {  
        if (nodo == null) return new Nodo(nombre);  

        int comparador = nombre.CompareTo(nodo.nombres);  
        if (comparador < 0)  
        {  
            nodo.izquierdo = InsertarRecursivo(nodo.izquierdo, nombre);  
        }  
        else if (comparador > 0)  
        {  
            nodo.derecho = InsertarRecursivo(nodo.derecho, nombre);  
        }  
        return nodo; // Nodo existente retornado sin cambios  
    }  

    public bool Buscar(string nombre)  
    {  
        return BuscarRecursivamente(raiz, nombre);  
    }  

    private bool BuscarRecursivamente(Nodo nodo, string valor)  
    {  
        if (nodo == null) return false;  

        int comparador = valor.CompareTo(nodo.nombres);  
        if (comparador == 0)  
        {  
            return true; // Encontrado  
        }  
        else if (comparador < 0)  
        {  
            return BuscarRecursivamente(nodo.izquierdo, valor);  
        }  
        else  
        {  
            return BuscarRecursivamente(nodo.derecho, valor);  
        }  
    }  
}  

class Program  
{  
    static void Main(string[] args)  
    {  
        ArbolbinarioBusqueda catalogoRevistas = new ArbolbinarioBusqueda();  

        // Agregar 10 títulos al catálogo  
        string[] titulos = {  
            "Revista de Ciencias",  
            "Revista de Tecnología",  
            "Revista de Historia",  
            "Revista de Arte",  
            "Revista de Medicina",  
            "Revista de Educación",  
            "Revista de Fútbol",  
            "Revista de Cocina",  
            "Revista de Viajes",  
            "Revista de Economía"  
        };  

        foreach (var titulo in titulos)  
        {  
            catalogoRevistas.Insertar(titulo);  
        }  

        // Menú de búsqueda  
        Console.WriteLine("Ingrese el título de la revista a buscar:");  
        string tituloABuscar = Console.ReadLine();  

        // Búsqueda de título  
        if (catalogoRevistas.Buscar(tituloABuscar))  
        {  
            Console.WriteLine("Encontrado");  
        }  
        else  
        {  
            Console.WriteLine("No encontrado");  
        }  
    }  
}  