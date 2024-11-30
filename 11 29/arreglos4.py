#Escribe un programa que pida al usuario ingresar 5 letras y las almacene en un
#arreglo. Luego, pide al usuario que ingrese una letra a buscar y cuenta cuántas
#veces aparece esta letra en el arreglo.

letras = []

for i in range(5):
    letra = input(f"Ingrese la letra {i + 1}: ")
    while len(letra) != 1 or not letra.isalpha():
        letra = input(f"Ingrese solo una letra válida para la letra {i + 1}: ")
    letras.append(letra.lower()) 

buscar = input("Ingrese la letra que desea buscar: ").lower()

contador = letras.count(buscar)


if contador > 0:
    print(f"La letra '{buscar}' aparece {contador} vez/veces en el arreglo.")
else:
    print(f"La letra '{buscar}' no aparece en el arreglo.")
