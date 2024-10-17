import random;

def generar_matriz(filas, columnas):
    return [[random.randint(1, 10) for _ in range(columnas)] for _ in range(filas)]

def sumar_matrices(A, B):
    return [[A[i][j] + B[i][j] for j in range(len(A[0]))] for i in range(len(A))]

def calcular_traza(matriz):
    return sum(matriz[i][i] for i in range(len(matriz)))

def encontrar_maximo(matriz):
    return max(max(fila) for fila in matriz)

def transponer_matriz(matriz):
    return [[matriz[j][i] for j in range(len(matriz))] for i in range(len(matriz[0]))]

def multiplicar_matrices(F, G):
    return [[sum(F[i][k] * G[k][j] for k in range(len(G))) for j in range(len(G[0]))] for i in range(len(F))]

def imprimir_matriz(matriz):
    for fila in matriz:
        print(fila)

def main():
    m, n = 3, 3
    A = generar_matriz(m, n)
    B = generar_matriz(m, n)
    print("Matriz A:")
    imprimir_matriz(A)
    print("Matriz B:")
    imprimir_matriz(B)

    C = sumar_matrices(A, B)
    print("Matriz C (A + B):")
    imprimir_matriz(C)

    p = 3
    D = generar_matriz(p, p)
    print("Matriz D:")
    imprimir_matriz(D)

    traza_D = calcular_traza(D)
    print(f"Traza de D: {traza_D}")

    maximo_D = encontrar_maximo(D)
    print(f"Valor máximo de D: {maximo_D}")

    E = transponer_matriz(D)
    print("Matriz E (traspuesta de D):")
    imprimir_matriz(E)

    m, n, p = 2, 3, 2  
    F = generar_matriz(m, n)
    G = generar_matriz(n, p)
    print("Matriz F:")
    imprimir_matriz(F)
    print("Matriz G:")
    imprimir_matriz(G)

    H = multiplicar_matrices(F, G)
    print("Matriz H (F * G):")
    imprimir_matriz(H)

if __name__ == "__main__":
    main()