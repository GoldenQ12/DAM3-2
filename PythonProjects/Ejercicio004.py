import functools

numeros = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10]
es_par = lambda x: x % 2 == 0
pares = list(filter(es_par, numeros))
cuadrado = lambda x: x ** 2
cuadrados_pares = list(map(cuadrado, pares))
suma = lambda x, y: x + y
suma_total = functools.reduce(suma, cuadrados_pares)

# Imprimir resultados
print("Números originales:", numeros)
print("Números pares:", pares)
print("Cuadrados de números pares:", cuadrados_pares)
print("Suma total de cuadrados pares:", suma_total)
