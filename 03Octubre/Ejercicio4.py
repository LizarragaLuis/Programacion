#Problema 4: Suponiendo que se ingresa una vocal por teclado, 
#realice un algoritmo
#para determinar si es abierta o cerrada.
#i y u cerradas
print(" ")
try:
    Vok=str(input("Ingrese una vocal por favor (utilize caracteres en minúscula): "))

    if Vok== "a" or Vok == "e" or Vok== "o":
        print("La vocal que escribió es considerada una vocal abierta.")
    else:
        if Vok=="i" or Vok == "u":
            print("La vocal que ingresó es considerada una vocal cerrada.")
        else:
            print('E R R O R')
except ValueError:
    print("Se produjo un error, intentelo de nuevo mas tarde.")