#Escribe un programa que pida al usuario ingresar 5 palabras y las almacene en
#un arreglo. Luego, ordena el arreglo alfabéticamente y muestra el resultado.
#Puedes utilizar sort().

palabras = []


def es_palabra(entrada):
    return entrada.isalpha()

for i in range(5):
    while True:
        palabra = input(f"Ingrese la palabra {i+1}: ")
        if es_palabra(palabra):
            palabras.append(palabra)
            break
        else:
            print("Error: Debe ingresar solo palabras (letras). Intente nuevamente.")


palabras.sort()
print("Las palabras ordenadas alfabéticamente son:")
for palabra in palabras:
    print(palabra)

#.isalpha es un comando que revisa si una cadena de texto contiene solo letras.