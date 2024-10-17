# ? 1- Permita introducir al usuario el número de elementos del array
# ? 2- Permita introducir al usuario los elementos del array
# ? 3- Busque un elemento (que introduce el usuario) con búsqueda lineal
# ? 4- Ordene el array. Se pueden implementar varios métodos
# ? 5- Busque un elemento (que introduce el usuario) con búsqueda lineal sabiendo que está ordenado
# ? 6- Busque un elemento (que introduce el usuario) con búsqueda binaria sabiendo que está ordenado

# * Punto 1
num_elementos = int(input("Introduce el número de elementos del array: "))
array = []
# * Punto 2
for i in range(num_elementos):
    elemento = input(f"Introduce el elemento {i+1}: ")
    array.append(elemento)
print("El array resultante es:", array)

# * Punto 3
element_a_buscar = input("Introduce el elemento a buscar: ")
for i in range(len(array)):
    if array[i] == element_a_buscar:
        print(f"El elemento '{element_a_buscar}' se encuentra en la posición {i}.")
        break
else:
    print(f"El elemento '{element_a_buscar}' no se encuentra en el array.")

# * Punto 4

n = len(array)
for i in range(n):
    for j in range(0, n - i - 1):
        if array[j] > array[j + 1]:
            array[j], array[j + 1] = array[j + 1], array[j]

print("El array ordenado es:", array)

# * Punto 5

elemento_buscar = input("Introduce el elemento a buscar en el array ordenado: ")
encontrado = False
for i in range(len(array)):
    if array[i] == elemento_buscar:
        print(f"El elemento '{elemento_buscar}' se encuentra en la posición {i}.")
        encontrado = True
        break
    elif array[i] > elemento_buscar:
        break

if not encontrado:
    print(f"El elemento '{elemento_buscar}' no se encuentra en el array.")

# * Punto 6

elemento_buscar = input("Introduce el elemento a buscar con búsqueda binaria: ")
izquierda, derecha = 0, len(array) - 1
encontrado = False

while izquierda <= derecha:
    medio = (izquierda + derecha) // 2
    if array[medio] == elemento_buscar:
        print(f"El elemento '{elemento_buscar}' se encuentra en la posición {medio}.")
        encontrado = True
        break
    elif array[medio] < elemento_buscar:
        izquierda = medio + 1
    else:
        derecha = medio - 1

if not encontrado:
    print(f"El elemento '{elemento_buscar}' no se encuentra en el array.")






