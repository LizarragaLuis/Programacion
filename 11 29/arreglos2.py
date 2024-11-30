#Escribe un programa que solicite al usuario ingresar 5 números y los almacene
#en un arreglo. Luego, encuentra y muestra el valor máximo y mínimo del arreglo.
#Puedes usar min(), max().
num_lista=[]
orden=["primer","segundo","tercer","cuarto","quinto"]
def es_numero(alo):
    return alo.isdigit()
n=0
for n in range(5):
    while True:
        num = input(f"Ingrese el {orden[n]} número: ")
        if es_numero(num):
            num_lista.append(num)
            break
        else:
            print("Error, ingrese solamente números.")

print("El número más grande dentro de la lista es: ", min(num_lista))
print("El número más pequeño dentro de la lista es: ", max(num_lista))