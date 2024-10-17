#Programa que realice las tablas de multiplicar del 1 al 3.

print("A continuación se imprimirá las talas de multiplicar del 1 al 3")
contador1=1
n1=1
while contador1 !=4:
    print("")
    print(f"Tabla de multiplicar del {contador1}: ")   
    print(" ") 
    for n1 in range(1,11,1):
        print(contador1, " x ",n1,"= ",(n1*contador1))
    print(" ")
    print("------------------------")
    contador1=contador1+1