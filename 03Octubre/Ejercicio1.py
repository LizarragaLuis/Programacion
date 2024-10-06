#Problema 1: Crear un programa que pida al usuario su edad y le indique a qué grupo
# pertenece. Puedes definir tus propios rangos de edad.
# Infancia (0 a 6 años)
# Niñez (6 a 12 años)
# Adolescencia (12 a 20 años)
# Juventud (20 a 25 años)
# Adultez (25 a 60 años)
# Ancianidad (60 años en adelante)

print(" ")
try:
    edad=int(input("Cuantos años tienes? "))

    if edad >0 and edad <=6:
        print("Perteneces a la etapa de la Infancia.")
    else:
    
        if edad >6 and edad <= 12:
            print("Perteneces a la etapa de la Niñez.")
        else:
            if edad >12 and edad <=20:
                print("Perteneces a la etapa de la Juventud.")
            else:
                if edad >20 and edad <=25 :
                    print("Perteneces a la etapa de la Adultez.")  
                else:
                    if edad>25 and edad <60:
                        print("Perteneces a la etapa de la Adultez.")
                    else:
                        print("Perteneces a la etapa de la Ancianidad.")
except ValueError:
    print("E R R O R.")
    exit()