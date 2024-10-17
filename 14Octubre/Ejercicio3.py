#Programa que solicite 10 números al usuario,
#este debe imprimir como resultado
#cuantos de los números que ingresó el
#usuario fueron pares, impares y ceros.

n1=1
imp=0
par=0
cero=0
num=0
print("Por favor ingrese 10 números.")
while True:
    try:
        num=float(input(f"Ingrese el número {n1}: "))
        
        n1=n1+1
        if num == 0:
            cero= cero + 1
        else:
            if (num%2)==0:
                par=par+1
            else:
                imp=imp+1
        if n1==11:
            break
    except ValueError:
        print("Error, intentelo de nuevo.")

print(" ")
print("De los números ingresados se encuentran: ")
print(" ")
print(f"La cantidad de números que son cero: {cero}.")
print(" ")
print(f"La cantidad de números que son pares: {par}.")                        
print(" ")
print(f"La cantidad de números que son impares: {imp}.")
exit()