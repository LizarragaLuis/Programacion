#Escribe un programa que pida al usuario ingresar 6 números y los almacene en
#un arreglo. Luego, comprueba si el arreglo está ordenado de menor a mayor y
#muestra el resultado.

def es_numero(alo):
    return alo.isdigit()

num_lista = []
orden = ["primer", "segundo", "tercer", "cuarto", "quinto", "sexto"]


for n in range(6):
    while True:
        num = input(f"Ingrese el {orden[n]} número: ")
        if es_numero(num):
            num_lista.append(int(num))  #aqui me marcaba error asi que investigando lo solucioné volviendolo entero.
            break
        else:
            print("Error, ingrese solamente números.")

num_og = num_lista.copy()

num_sort = num_lista.copy()
num_sort.sort()

print("\nLista ingresada:", num_lista)
print("Lista ordenada:", num_sort)


if num_lista == num_sort:
    print("\nLa lista se encuentra de menor a mayor.")
else:
    print("\nLa lista no se encuentra de menor a mayor.")
