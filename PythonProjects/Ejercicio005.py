import random

def main():
    n = pedirCantidad()
    aNombres = generarNombres(n)
    print(aNombres)
    aLongitudes = devolverLongitudes(aNombres, n)
    print(aLongitudes)
    aDni = generarDNI(n)
    print(aDni)
    dict_personas = diccionario_personas(aNombres, aDni)
    print(dict_personas)
    dni_a_buscar = input("Introduce el dni a buscar: ")
    buscar_nombre_por_dni(dict_personas, dni_a_buscar)
    media = calcularMedia(devolverLongitudes(aNombres, n))
    varianza = calcularVarianza(devolverLongitudes(aNombres, n))
    print(f"La media es : {media} ")
    print(f"La varianza es : {varianza} ")
    guardar_datos(aNombres, aDni, aLongitudes, "datos.txt")

def pedirCantidad():
    n = int(input("Escribe la cantidad de elementos del array: "))
    return n

def generarNombres(n):
    arrayNombres = ["Juan", "Jose", "Luis", "Angel", "Angel", "Ander", "Varela", "Samu", "Lazaro", "Mikel"]
    dev = []
    for i in range(n):
        aleatorio = random.randint(0, 9)
        dev.append(arrayNombres[aleatorio])
    return dev

def devolverLongitudes(aNombres, n):
    aDev = []
    for i in range(n):
        aDev.append(len(aNombres[i]))
    return aDev

def generarDNI(n):
    aDev = []
    for i in range(n):
        posiblesCaracteres = "QWERTYUIOPASDFGHJKLÑZXCVBNM"
        letra = posiblesCaracteres[random.randint(1,26)]
        numeros = random.randint(100000000,99999999)
        dni = f"{numeros}{letra}"
        aDev.append(dni)
    return aDev

def buscarElemento(aBuscar, elemento, n):
    TheGrefg = 0
    for i in range(n):
        if aBuscar[i] == elemento:
            TheGrefg += 1
            if TheGrefg == 2:
                return i
    return -1

def buscarDNI(aBuscar, elemento, n):
    for i in range(n):
        if i < len(aBuscar) and aBuscar[i] == elemento:
            return True
    return

def diccionario_personas(aDnis, aNombres):
    diccionario = dict(zip(aNombres, aDnis))
    return diccionario

def buscar_nombre_por_dni(diccionario, dni):
    if dni in diccionario:
        print("El nombre correspondiente en el diccionario a el dni " + dni + " es " + diccionario[dni])
    else:
        print(f"El DNI {dni} no se encuentra en el diccionario.")

def calcularMedia(lista):
    suma = sum(lista)
    media = suma / len(lista)
    return media


def calcularVarianza(lista):
    media = calcularMedia(lista)
    varianza = sum((x - media) ** 2 for x in lista) / len(lista)
    return varianza

def guardar_datos(nombres, dnis, longitudes, nombre_fichero):
    with open(nombre_fichero, 'w') as fichero:
        for nombre, dni, longitud in zip(nombres,dnis,longitudes):
            fichero.write(f"{nombre} - {dni}  -  {longitud}\n")

main()