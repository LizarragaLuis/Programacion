#Problema 3: Crear una calculadora simple que realice operaciones básicas 
#(suma, resta, multiplicación y división) de acuerdo con la elección del usuario. Después le
#solicitará al usuario 2 números para realizar la operación seleccionada.
try:
    print(" ")
    print("Bienvenido a calcucrack.com, la página en donde puede realizar operaciones utilizando dos dígitos. Qué operación va a realizar hoy? ")
    print(" ")
    print ("1. Suma    2.Resta     3.Multiplicación    4.División")
    print(" ")
    ope=int(input(" "))
    if ope >4:
        print("Esa función todavía no se encuentra disponible. Espere a futuras actualizaciones!")
        exit()
    n1= float (input("Ingrese el primer dígito: "))
    n2= float (input("Ingrese el segundo dígito: "))
    

    if ope == 1:
        n3=n1+n2
        print (f"El resultado de la suma es de {n3:.2f}.")
    else:
        if ope == 2:
            n3=n1-n2
            print(f"El resultado de la resta es de {n3:.2f}.")
        else:
            if ope ==3:
              n3=n1*n2
              print(f"El resultado de la multiplicación es de {n3:.2f}.")
            else:
                if ope == 4:
                  n3= n1/n2
                  print(f"El resultado de la división es de {n3:.2f}.")
                
                  
except ValueError:
    print("E R R O R.")