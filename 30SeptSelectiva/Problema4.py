#Invertir un número de tres dígitos: Elaboraremos un algoritmo para invertir un
#número almacenado en una variable A. Por ejemplo, si ingresamos 834, el
#programa debe dar como salida 438. El dato ingresado debe estar en un rango
#de 1 a 999.

print("")
try:
    n1=float(input("Ingrese un número desde 1 hasta 999:"))
except ValueError: 
    print("No a ingresado un número. Cerrando Aplicación.")
    exit()
if n1 >0 and n1 <10:
    print(f"El número invertido es {n1}.")
else:
    if n1 >= 10 and n1 < 100:
        unidad =n1 //10
        decena =n1 %10
        invert=(decena*10)+unidad
        print(f"El número invertido es {invert}.")
    else:
        if n1 >= 100 and n1 <999:
            centena = n1 // 100
            decena1 = n1 // 10
            decena2 = decena1 % 10
            unidad = n1 % 10
            invert = (unidad*100)+(decena2*10)+centena
            print(f"El número invertido es {invert}.")
        else:
            print("No a ingresado un número dentro del límite.")