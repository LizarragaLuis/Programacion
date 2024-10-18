#Luis Fernando Lizarraga Trujillo matricula 240085
# Realice un programa que resuelva lo siguiente:
#En un grupo de 15 alumnos de la UPBc, se busca nombrar
#a un jefe de grupo mediante el voto de cada uno de ellos.
#Todo esto en presencia de su maestro asesor. Se decidió una votación.
#Los tres cantidados son: 1.HUGO, 2.PACO y 3.LUIS.
#El maestro asesor les solicitó que el primero lugar sea el jefe de grupo
#y el segundo lugar será el tesorero.
#a) QUEREMOS SABER QUIEN SERA EL JEFE DE GRUPO, CON CUANTOS VOTOS Y PORCENTAJE
#b)QUEREMOS SABER QUIEN SERA EL TESORERO, CON CUANTOS VOTOS Y PORCENTAJE
#c) AL TERCER LUGAR LE DAREMOS LAS GRACIAS POR PARTICIPAR.
print("")
prim=0
seg=0
ter=0
luis=0
emp1=0
emp2=0
hugo=0
paco=0
cont=1
por1=0
por2=0
por3=0
while True:
    print(" ")
    print(" ")
    print(" ")
    print(" Bienvenido al programa de selección de jefe de grupo del salón 3AV.")
    print("Los candidatos elegidos para votación son:")
    print("     Luis(1)       Paco(2)      Hugo(3)")
    print(f"Eres el estudiante número {cont} en votar.")
    try:
     
     a=int(input("Ingrese el número asignado al estudiante por el que deseé votar: "))
     
     if a==1:
       luis=luis+1
       cont=cont+1
     else:
       if a==2:
         paco=paco+1
         cont=cont+1
       else:
         if a==3:
           hugo=hugo+1
           cont=cont+1
         else:
           print("Intente nuevamente")
    except (ValueError):
      print(" ")
      print(' ')
      print(' ')
      print("Vuelvalo a intentar")
    if cont ==16:
     break
if hugo==luis and luis== paco:
  print(" ")
  print(" ")
  print(" ")
  print(" ")
  print(" ")
  print(" ")
  print("Hubo un triple empate, se le solicita al profesor que ingrese su voto para desempatar.")
  while True:
   try:
    print("     Luis(1)       Paco(2)      Hugo(3)")
    a=int(input("Ingrese el número asignado al estudiante por el que deseé votar: "))
    
    if a==1:
        luis=luis+1
        break
    else:
       if a==2:
          paco=paco+1
          break
       else:
          if a==3:
             hugo=hugo+1
             break
          else:
             print('Vuelvalo a intentar.')
       
   except ValueError:
     print("Vuelva a intentar.")
     print(" ")
     print(" ")
     print(" ")
     print(" ")
  
else:
    
    if (hugo==luis or hugo == paco or paco==luis):
        print("Se tuvo un empate entre dos candidatos, se realizará ahora una nueva votación para ellos dos.")
        cont=1

        if hugo==luis:
            while True:
                print(" ")
                print(" ")
                print(" ")
                print("Bienvenido al desempate de selección de jefe de grupo del salón 3AV.")
                print("Los candidatos elegidos para votación son:")
                print("      Luis(1)       Hugo(2)")
                luis=0
                hugo=0
                paco=0   
                try:
                    print(f"Eres el estudiante número {cont} en votar.")
                    a=int(input("Ingrese el número asignado al estudiante por el que deseé votar: "))
                    if a==1:
                        luis=luis+1
                        cont=cont+1
                    else:
                        if a==2:
                            hugo=hugo+1
                            cont=cont+1
                        else:
                            print("Vuelvalo a introducir.")
                    if cont ==16:
                        break
                except ValueError:
                    print("Intente de nuevo.")
        else:
            if luis==paco:
                while True:
                    print(" ")
                    print(" ")
                    print(" ")
                    print("Bienvenido al desempate de selección de jefe de grupo del salón 3AV.")
                    print("Los candidatos elegidos para votación son:")
                    print("      Luis(1)     Paco(2)")
                    luis=0
                    hugo=0
                    paco=0   
                    try:
                        print(f"Eres el estudiante número {cont} en votar.")
                        a=int(input("Ingrese el número asignado al estudiante por el que deseé votar: "))
                        if a==1:
                            luis=luis+1
                            cont=cont+1
                        else:
                            if a==2:
                                paco=paco+1
                                cont=cont+1
                            else:
                                print("Vuelvalo a introducir.")
                        if cont ==16:
                            break
                    except ValueError:
                        print("Intente de nuevo.")
            else:
                if paco==hugo:
                    while True:
                        print(" ")
                        print(" ")
                        print(" ")
                        print("Bienvenido al desempate de selección de jefe de grupo del salón 3AV.")
                        print("Los candidatos elegidos para votación son:")
                        print("    Paco(1)     Hugo(2)")
                        luis=0
                        hugo=0
                        paco=0   
                        try:
                            print(f"Eres el estudiante número {cont} en votar.")
                            a=int(input("Ingrese el número asignado al estudiante por el que deseé votar: "))
                            if a==1:
                                paco=paco+1
                                cont=cont+1
                            else:
                                if a==2:
                                    hugo=hugo+1
                                    cont=cont+1
                                else:
                                    print("Vuelvalo a introducir.")
                            if cont ==16:
                                break
                        except ValueError:
                            print("Intente de nuevo.")
        

  
por1=luis*100/15
por2=paco*100/15
por3=hugo*100/15
print(luis)
print(paco)
print(hugo)
print(f"{por1:.2f}%")
print(f"{por2:.2f}%")
print(f"{por3:.2f}%")


