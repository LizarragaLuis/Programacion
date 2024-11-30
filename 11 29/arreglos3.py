#Escribe un programa que pida al usuario ingresar 5 números
#y los almacene en un arreglo. Luego, invierte el orden de 
#los elementos en el arreglo y muestra el resultado.

num_lista = []
invertido = [1, 2, 3, 4, 5] 
orden = ["primer", "segundo", "tercer", "cuarto", "quinto"]

def es_numero(alo):
    return alo.isdigit()


for n in range(5):
    while True:
        num = input(f"Ingrese el {orden[n]} número: ")
        if es_numero(num):
            num_lista.append(num) 
            break
        else:
            print("Error, ingrese solamente números.")

for i in range(5):
    invertido[4-i] = num_lista[i]

print("Lista invertida:", invertido)
