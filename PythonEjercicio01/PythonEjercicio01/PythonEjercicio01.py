
import os
from re import match
from tokenize import Number


def getListaElementos(): 
    for x in listaElementos:
        print(x)


def getElementByLinearSearch(element : str):
    for x in range(len(listaElementos)):
        print(listaElementos[x])
        if(listaElementos[x] == element):
            return listaElementos.index(listaElementos[x])
        
def getElementByBinarySearch(array, min, max, element):
    mid = (max + min) / 2
    
    while min <= max:
        middle = (min + max) / 2
        mid = array[middle]
        if (mid > element):
            max = mid - 1
        elif mid < element:
            max = mid + 1
        else:
            return mid
    return -1

def Sort(array):
    for i in range(0, len(array)):
        for j in range(i+1, len(array)):
            if array[i] >= array[j]:
                array[i], array[j] = array[j],array[i]
    

def isSorted(list):
    previous_number = 0
    for i in list:
        value = list[i]
        if value - previous_number >= 0:
            previous_number = list[i]
            return True
        else:
            return False
        
    

listaElementos = []
opc = 5 

print("Introduce la cantidad de elementos") 
cantidadElementos = int(input()) 


for x in range(cantidadElementos):
    print("Introduce un elemento ( string ): ") 
    elementToInsert = input() 
    listaElementos.append(elementToInsert) 
    elementToInsert = "" 

while True:

    if opc == 0:
        break
    getListaElementos()
    print("Introduce una opcion: ") 

    print("1.- Buscar un elemento por busqueda lineal") 
    print("2.- Ordenar lista de elementos") 
    print("3.- Buscar un elemento con busqueda lineal con lista de elementos ya ordenado") 
    print("4.- Buscar un elemento con busqueda binaria con lista de elementos ya ordenado") 
    print("0.- Salir") 
    try:
        opc = int(input())
    except:
        print("Introduce una opcion valida")

    
    match opc:
        case 1:
            elemento = input("Introduce un elemento a buscar: ")
            print("El elemento se encuentra en la posicion " + str(getElementByLinearSearch(elemento)))
        case 2:
            try:
                Sort(listaElementos)
                print("Ordenado correctamente")
            except: 
                print("Error al ordenar")
                
        case 3:
            elemento = input("Introduce un elemento a buscar: ")
            if isSorted(getListaElementos):
                print("El elemento se encuentra en la posicion " + getElementByLinearSearch(elemento))
            else:
                print("La lista de elementos no esta ordenada")
        case 4:
            elemento = input("Introduce un elemento a buscar: ")
            if isSorted(getListaElementos):
                print("El elemento se encuentra en la posicion " + getElementByBinarySearch(listaElementos, 0, listaElementos - 1, elemento))
            else:
                print("La lista de elementos no esta ordenada")
            



