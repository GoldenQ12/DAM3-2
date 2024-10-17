# ? 1- Permita introducir al usuario el número de elementos del array
# ? 2- Permita introducir al usuario los elementos del array
# ? 3- Busque un elemento (que introduce el usuario) con búsqueda lineal
# ? 4- Ordene el array. Se pueden implementar varios métodos
# ? 5- Busque un elemento (que introduce el usuario) con búsqueda lineal sabiendo que está ordenado
# ? 6- Busque un elemento (que introduce el usuario) con búsqueda binaria sabiendo que está ordenado

# ! ADDITIONS
# * - 7 - Cambiar la introducción de datos a la generación aleatoria
# * - 8 - Cambiar la estructura del programa a métodos
# * - 9 - Poner el método de búsqueda binaria en forma recursiva



import random;


def main():
    num_elementos = GenerarNumeroDeElementosArray()
    print(f"Número de elementos generados: {num_elementos}")

    array = []
    GenererarElementoArray(array)
    print("Array generado:", array)

    encontrado = BuscarElementoArray(array)
    print("Elemento encontrado en array desordenado:", encontrado)

    array_ordenado = OrdenarArray(array.copy())
    print("Array ordenado:", array_ordenado)

    encontrado_ordenado = BuscarElementoArrayOrdenado(array_ordenado)
    print("Elemento encontrado en array ordenado (búsqueda lineal):", encontrado_ordenado)

    encontrado_binario = BuscarElementoArrayBinario(array_ordenado)
    print("Elemento encontrado en array ordenado (búsqueda binaria):", encontrado_binario)

# * Punto 1
def GenerarNumeroDeElementosArray():
    num_elementos = GenerarNumeroAleatorio(0,100)
    return num_elementos

# * Punto 2
def GenererarElementoArray(array):
    for i in range(len(array)):
        elemento = GenerarNumeroAleatorio(i, len(array))
        array.append(elemento)

# * Punto 3
def BuscarElementoArray(array):
    element_a_buscar = input("Introduce el elemento a buscar: ")
    for i in range(len(array)):
        if array[i] == element_a_buscar:
            return True
    return False

# * Punto 4
def OrdenarArray(array): 
    n = len(array)
    for i in range(n):
        for j in range(0, n - i - 1):
            if array[j] > array[j + 1]:
                array[j], array[j + 1] = array[j + 1], array[j]
    return array


# * Punto 5

def BuscarElementoArrayOrdenado(array): 
    elemento_buscar = input("Introduce el elemento a buscar en el array ordenado: ")
    encontrado = False
    for i in range(len(array)):
        if array[i] == elemento_buscar:
            encontrado = True
        elif array[i] > elemento_buscar:
            return False
    return encontrado

# * Punto 6

def BuscarElementoArrayBinario(array):
    elemento_buscar = input("Introduce el elemento a buscar con búsqueda binaria: ")
    izquierda, derecha = 0, len(array) - 1
    encontrado = False
    while izquierda <= derecha:
        medio = (izquierda + derecha) // 2
        if array[medio] == elemento_buscar:
            encontrado = True
            return encontrado
        elif array[medio] < elemento_buscar:
            izquierda = medio + 1
        else:
            derecha = medio - 1
    return encontrado




def GenerarNumeroAleatorio(min, max):
    return random.randint(min, max)


