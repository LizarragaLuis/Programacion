#Programa que realice las tablas de multiplicar del 1 al 3, 
#pero que unicamense imprima los resultados pares.

print("A continuación se imprimirá las talas de multiplicar del 1 al 3")
contador1=1
n1=1
n2=0
while contador1 !=4:
    print("")
    print(f"Tabla de multiplicar del {contador1}: ")   
    print(" ") 
    for n1 in range(1,11,1):
        n2=(contador1*n1)%2
        if n2==0:
         print(contador1, " x ",n1,"= ",(n1*contador1))   
    print(" ")
    print("------------------------")
    contador1=contador1+1