#Crear un programa que permita al usuario ingresar los montos de las
#compras de un cliente (se desconoce la cantidad de datos que cargará, la
#cual puede cambiar en cada ejecución), cortando el ingreso de datos
#cuando el usuario ingrese el monto 0. Si ingresa un monto negativo, no se
#debe procesar y se debe pedir que ingrese un nuevo monto. Al finalizar,
#informar el total a pagar teniendo que cuenta que, si las ventas superan el
#total de $1000, se le debe aplicar un 10% de descuento.
total= 0
print("")
print("Bienvenido a Abarrotes Pepino®, por favor ingrese el costo del artículo a ingresar.")
acumulado=int(input(" "))
#print("ERROR, HABLE CON UN ENCARGADO PARA DESBLOQUEAR EL SISTEMA

while True:
       if acumulado ==0:
           break
       else:
        total= (acumulado + total)
        print("Ingrese el precio del siguiente artículo. Si desea ver su total ingrese 0.")
       try:
        acumulado= int(input(""))
          
       except ValueError:
        print("Se produjo un error, vuelva a intentarlo.") 
        print(" ")

if total >= 1000:
    descuento= total *.90
    print(f"Su total es de {descuento} pesos, con un descuento especial en la compra mayor a 1000 pesos.")
else:
    print(f"Su total es {total} pesos. ")