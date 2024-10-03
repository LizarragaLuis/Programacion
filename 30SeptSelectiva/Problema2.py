#Determinar si dos números tienen signos opuestos: Escribiremos un
#algoritmo que lea dos números enteros como entrada y muestre el mensaje
#“Signos Opuestos” solo si uno de los números es positivo y el otro es negativo.

try:
    num1=float(input("Por favor ingresa un número: "))
    num2=float(input("Por favor ingresa otro número: "))
except ValueError:
    print("ESCRIBIR SOLO NÚMEROS.")
    exit()

if (num1 > 0 and num2 > 0) or (num1 < 0 and num2 <0):
    print("Los números tienen signoss iguales.")
else:
    print("Los números tienen signos opuestos.")