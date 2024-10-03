#Calcular la diferencia entre dos enteros positivos: Crearemos un algoritmo
#que reciba dos enteros positivos distintos y calcule la 
# diferencia entre el número
#mayor y el menor. Además, aseguraremos que el programa siempre muestre 6
#como resultado, independientemente del orden de entrada (por ejemplo, tanto
#para 9 y 15 como para 15 y 9).

print("")
try:
    n1=float(input("Ingrese el primer número."))
    n2=float(input("Ingrese el segundo número."))
except ValueError:
      print("ESCRIBIR SOLO NÚMEROS.")
      exit()
        
 

n3=n1-n2

if n3 <0 :
    print(f"La diferencia de los dos números es de {n3*-1}.")
else:
    print(f"La diferencia de los dos números es de {n3}.")