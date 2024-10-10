# Factorial de un número: 
# Dado un número entero no negativo n, 
# calcula su factorial 
# (el producto de todos los enteros positivos desde 1 hasta n).
# Por ejemplo, el factorial de 5 es 5! = 5 × 4 × 3 × 2 × 1.
try:
    print(" ")
    print("Se dará a conocer el factorial de un número ingresado: ")
    n1=float(input(" Ingrese un número entero no negativo: "))
    n2=int(n1)
    fact=1
    if n1 <0 :
        n1= n1*-1
        n2=int(n1)
    print(f"El factorial de {n2} es: ")
    print(n2, "! = ",end=(""))
    for num in range((n2),0,-1):
        if num == 1:
            print( num, "=", fact)
            break
    
        fact= num * fact
        print( num, "x ",end=(""))
    
except ValueError:
    print ("E R R O R.")
