#include <stdio.h>  
#include <stdlib.h>  

// Definición de un nodo del árbol binario  
struct Nodo {  
    int dato;  // Almacena un valor entero  
    struct Nodo* izquierda;  // Puntero al hijo izquierdo  
    struct Nodo* derecha;    // Puntero al hijo derecho  
};  

// Función para crear un nuevo nodo  
struct Nodo* crearNodo(int valor) {  
    struct Nodo* nuevoNodo = (struct Nodo*)malloc(sizeof(struct Nodo)); // Asignar memoria para un nuevo nodo  
    nuevoNodo->dato = valor;         // Asignar el valor al nodo  
    nuevoNodo->izquierda = NULL;     // Inicializar el hijo izquierdo como NULL  
    nuevoNodo->derecha = NULL;       // Inicializar el hijo derecho como NULL  
    return nuevoNodo;                // Retornar el nuevo nodo creado  
}  

// Función para insertar un nuevo nodo en el árbol binario  
struct Nodo* insertar(struct Nodo* nodo, int valor) {  
    // Si el árbol está vacío, se crea y retorna un nuevo nodo  
    if (nodo == NULL) {  
        return crearNodo(valor);  
    }  

    // Si el valor a insertar es menor que el dato del nodo actual,  
    // se inserta en el subárbol izquierdo  
    if (valor < nodo->dato) {  
        nodo->izquierda = insertar(nodo->izquierda, valor);  
    }   
    // Si el valor a insertar es mayor que el dato del nodo actual,  
    // se inserta en el subárbol derecho  
    else if (valor > nodo->dato) {  
        nodo->derecha = insertar(nodo->derecha, valor);  
    }  

    // Retornar el nodo sin cambios  
    return nodo;  
}  

// Función para realizar un recorrido in-order (ordenado)  
void recorridoInOrden(struct Nodo* nodo) {  
    if (nodo != NULL) { // Verificar si el nodo no es NULL  
        recorridoInOrden(nodo->izquierda); // Recorrer el subárbol izquierdo  
        printf("%d ", nodo->dato);         // Imprimir el dato del nodo actual  
        recorridoInOrden(nodo->derecha);   // Recorrer el subárbol derecho  
    }  
}  

// Programa principal  
int main() {  
    struct Nodo* raiz = NULL; // Inicializar la raíz del árbol como NULL  

    // Insertar elementos en el árbol  
    raiz = insertar(raiz, 5);  
    insertar(raiz, 3);  
    insertar(raiz, 7);  
    insertar(raiz, 1);  
    insertar(raiz, 4);  

    printf("Recorrido in-order del árbol binario (enteros):\n");  
    recorridoInOrden(raiz); // Salida: 1 3 4 5 7  
    printf("\n");  

    return 0; // Fin del programa  
}  