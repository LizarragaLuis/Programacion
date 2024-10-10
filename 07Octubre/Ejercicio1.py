#Suma de los primeros N números naturales:
# Dado un número entero positivo N,
# encuentra la suma de los primeros N números naturales. 
# Por ejemplo, si N es 5, la suma sería 1 + 2 + 3 + 4 + 5.
try:
    print(" ")
    suma=0
    n1=int(input("Ingrese un número entero positivo."))
    num=1
    for num in range(1, (n1+1),1):
        if num == (n1):
            suma=num+suma
            print(num, f"= {suma}")
            break
        print(num," + ", end=" ")
        suma=num+suma
except ValueError:
    print("E R R O R")
    exit()
