#Leer 10 números e imprimir cuantos son positivos,
#cuantos negativos y
#cuantos cero.
n1=1
neg=0
pos=0
cero=0
num=0
print("Por favor ingrese 10 números.")
while True:
    try:
        num=float(input(f"Ingrese el número {n1}: "))
        
        n1=n1+1
        
        if num >0:
            pos=pos+1
        else:
            if num == 0:
                cero= cero + 1
            else:
                neg=neg+1
        if n1==11:
            break
    except ValueError:
        print("Error, intentelo de nuevo.")

print(" ")
print("De los números ingresados se encuentran: ")
print(" ")
print(f"La cantidad de números que son cero es de: {cero}.")
print(" ")
print(f"La cantidad de números mayores a cero son de: {pos}.")                        
print(" ")
print(f"La cantidad de números menores a cero son de: {neg}.")
exit()