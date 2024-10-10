#Tabla de multiplicar: Dado un número entero x,
#  imprime la tabla de multiplicar para ese número 
# hasta un cierto límite
# (por ejemplo, las primeras 10 multiplicaciones).
#  Por ejemplo, si x es 7, mostraría:
#7 × 1 = 7
#7 × 2 = 14
#…
#7 × 10 = 70
print(" ")
n1=int(input("Ingrese un número y se le daráa una tabla de multiplicar: "))
n2= n1+1
for num in range(1,13,1):
    n3= num * n1
    
    print(n1, " x ",num, " = ", n3)