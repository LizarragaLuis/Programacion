# Realiza un programa que pida números mientras no se ingrese uno
# negativo. Al final, se debe mostrar la suma
#  de los números ingresados.
try:
    print("El programa seguirá corriendo hasta que ingrese un número negativo")
    n1= 0
    acumulador =0
    bandera= True
    while bandera:
        if n1 <0:
            bandera = False 
        else:
            acumulador = n1 + acumulador
            n1=float(input("Ingrese un número positivo o negativo:"))
        
    print(f"Se ingresó un número negativo, terminando la operación.")
    print(f"La suma total de los números positivos ingresados es de {acumulador}.")
    print("La suma es de ", acumulador)

    exit()
except ValueError :
    print ("error")
    exit()