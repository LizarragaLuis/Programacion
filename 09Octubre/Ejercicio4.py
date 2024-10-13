#Tenemos la pantalla del celular bloqueada. Partiendo de un PIN_SECRETO,
#intentaremos desbloquear la pantalla. Tenemos hasta 3 intentos. Simula el
#proceso con Python. En caso de acceder, lanza al usuario &#39;login correcto&#39;.
#Sino, &#39;llamando al policía&#39;.
PIN= 369
n1= 1
lol=0
while True:
    print("")
    print("Celular bloqueado. Ingrese su NIP.")
    try:
        lol=int(input(""))
    except ValueError:
        n1=n1+1
    if lol == PIN:
            print("Bienvenido de nuevo.")
            exit()
    else:
        if n1 == 3:  
            print("Ha realizado el número de intentos máximo, se llamará a la policía.")
            print(" ")
            break
        else:   
            n1=n1+1
            print(" ")
            print("Vuelvalo a intentar.")        

