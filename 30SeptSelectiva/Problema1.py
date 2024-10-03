# Encontrar el mayor entre tres números: Dadas tres variables enteras num1,
# num2 y num3, debemos encontrar el número más grande entre ellos y
# almacenarlo en una variable entera llamada max.

print(" ")
num1=float(input("Ingrese el primer valor: "))
num2=float(input("Ingrese el segundo valor: "))
num3=float(input("Ingrese el tercer valor: "))

if num1 > num2 and num1 > num3 :
    max=num1    
else:
    if num2>num1 and num2>num3 :
     max=num2
    else:
     max=num3

print(f"El número mas grande es {max}.")