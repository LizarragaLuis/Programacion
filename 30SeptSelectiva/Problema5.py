#El juego de preguntas a las que se responde "Si o No" gana quien responda
#correctamente las tres preguntas. Si se responde mal a cualquiera de ellas
#ya no se pregunta la siguiente y termina el juego. Las preguntas son:
#1. Colón descubrió Ameérica?
#2. La independencia de México fue en el año 1810?
#3. The Doors fue un grupo de rock Americano?
si= 1
no= 2
try:
    print("Bienvenido a Juego de preguntas. Ganará un auto si responde las siguientes tres preguntas correctamente. ")
    R1= int(input("Colon descubrió América? 1 = Si, 2 = No."))
    if R1 ==si :
        print ("correcto!, avanzará a la segunda pregunta.")
        R2 = int (input("Segunda pregunta: La independencia de México fue en el año 1810? 1 = Sí, 2 = No."))
        if R2==no :
            print ("correcto!, avanzará a la última pregunta.")
            R3 = int (input ("Tercera pregunta: The Doors fue un grupo de rock Americano? 1 = Sí, 2 = No."))
            if R3 ==si :
                print("Correcto! a ganado el juego!!!")
            else: 
    
                print("Incorrecto, a perdido.")
        else:
            print("Incorrecto, a perdido.")
    else:
        print("Incorrecto, a perdido.")

except ValueError:
    print ("Incorrecto, a perdido el juego.")




#print("Bienvenido a Juego de preguntas. Ganará un auto si responde las siguientes tres preguntas correctamente. ")
#print("Primera pregunta.")
#R1= int (input("Colon descubrió América? 1 = Si, 2 = No."))
#if R1 == si :
#    print("Correcto")
#    
#else:
#    print("Incorrecto. Ah perdido")
#    exit()
#
#print("siguiente pregunta")