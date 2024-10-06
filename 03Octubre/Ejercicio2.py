#Problema 2: Crear un programa que pida al usuario los tres lados de un triángulo y
#determine si es equilátero, isósceles o escaleno.
# Triángulo equilátero
#Todos sus lados son iguales. Es un polígono regular, ya que sus tres ángulos internos
#on idénticos y miden 60º cada uno.
# Triángulo isósceles
#Tiene dos lados iguales y uno diferente. Los dos ángulos del triángulo isósceles que
#están frente a los lados iguales también tienen la misma medida.
# Triángulo escaleno
#Todos sus lados y ángulos son desiguales. Es la forma más general de un triángulo. 
#Los triángulos también se pueden clasificar según sus ángulos, en triángulos
#acutángulos, rectángulos u obtusángulos.
try:
    dosouno = str(input("Ingresarás lados o ángulos? "))
    if dosouno == "ángulos" or dosouno == "angulos":
        n1=float(input("Ingrese el primer ángulo: "))
        n2=float(input("Ingrese el segundo ángulo: "))
        n3=float(input("Ingrese el tercer ángulo: "))
        if (n1 <90 and n2<90 and n3 <90)and n1+n2+n3==180:
            print("El triángulo se clasifica como Acutángulo.")
        else:
           
                if (n1 == 90 and n3<90 and n2<90) or (n2 <90 and n3 ==90 and n1 <90) or (n2==90 and n1<90 and n3 <90) and n1+n2+n3==180:
                    print("El triángulo se clasifica como Rectángulo.")
                else:
                    if (n1 >90 and n2 <90 and n3 <90) or (n1<90 and n2>90 and n3<90) or (n1<90 and n2<90 and n3>90) and (n1+n2+n3==180):
                        print("El triángulo se clasifica como Obtusángulo.")
                    else:
                        print("La suma de los ángulos ingresados no da 180 grados, por lo que no puede ser un triángulo.")
                    exit()           

    else:
        if dosouno =="lados":
            n1=float(input("Ingrese la medida del primer lado: "))
            n2=float(input("Ingrese la medida del segundo lado: "))
            n3=float(input("Ingrese la medida del tercer lado: "))
            if n1 == n2 and n2 == n3 :
                print("El triángulo se clasifica como un triángulo equilátero.")  
            else:
                if (n1== n2 and n1 !=n3) or (n2==n3 and n2 != n1) or (n1==n3 and n3 !=n2):
                    print("El triángulo se clasifica como un triángulo equilátero.") 
                else:
                    #if (n1 != n2 and n1 != n3 and n2 != n3):
                        print("El triángulo se clasifica como un triángulo escaleno.") 
        else:
             print("Intentelo de nuevo mas tarde.")
             exit()
except ValueError:
    print("E R R O R. Intentelo nuevamente.")