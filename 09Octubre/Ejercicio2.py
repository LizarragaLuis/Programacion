#Escribe un programa que inicie mostrando en pantalla la letra de “Un
#elefante se columpiaba” iniciando con el número 1, después pregunta al
#usuario cuantos elefantes más se columpiarán y debe responder un
#número más al mostrado. 
# En caso de ingresar un número diferente, pedirle
#que intente de nuevo y repetir el ciclo hasta tener 10 elefantes.

n1=(0)
n2=(1)
n3=(1)
n4=(2)

while n3!=10 :
        print(" ")
        print(f"{n2} elefante se columpiaba sobre la tela de  una araña,")
        if n3 == 1:
            
            print("como veía que resistía, fue a llamar a otro elefante.")
            print(" ")
        else:
            print("como veían que resistía, fueron a llamar a otro elefante.")
            print(" ")
        try:
            n1=int(input("Cuantos elefantes se columpiarán? "))
            if n1 == n4:
                n3=n3+1
                n4=n4+1
                n2=n2+1
            else:
                print(" ")
                print("Intenta de nuevo.")
                print(" ")
        except ValueError:
             print(" ")
             print ("Solamente números enteros, intente de nuevo.")
             print(" ")
print("Se acabó.")