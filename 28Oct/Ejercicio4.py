import math
#calcule el area de un circulo dado su radio
#area= pi*radio al cuadrado
def area_circulo(radio):
    return math.pi * radio **2
try:
    radio=float(input("Ingrese el radio de un círculo. Se calculará el área: "))
    if radio >=0:
        resultado = area_circulo(radio)
        print(f"El area de un círculo con radio {radio} es: {resultado:.2f}")
    else:  
        print("El número tiene que ser positivo.")
except ValueError:
    print("ERROR. REINICIE EL PROGRAMA.")