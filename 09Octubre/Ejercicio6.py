#Realice un programa que calcule todas las ordenadas pares de la función
#Y=f(x)= x *x*x+1, debe imprimir la abscisa y la ordenada para los valores
#comprendidos entre 0 y 30.
x=0
y=0
while True:
   
    y=x*x*x+1
    print(f"({x},{y})")
    x=x+1
    
    if x == 31:
        break

