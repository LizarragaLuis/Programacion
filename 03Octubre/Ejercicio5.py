#Problema 5: En la Ponduka State University, los veteranos sólo pagan $30 (dólares)
#por asignatura mientras que los demás (regulares) pagan $50 por asignatura. Escriba
#un algoritmo en el que el usuario introduce los datos del estudiante (Vet o Reg) y el
#número de asignaturas. La salida debe indicar si el estudiante es de la categoría
#veterano o regular e indicar el número de materias y los costos de la colegiatura.
try:
    print("")
    print("Bienvenido a Ponduka State University, ingrese su categoría: ")
    mem=str(input("Si eres veterano ingresa vet. Si no, ingresa reg."))
    print(" ")
    if mem != "vet" and mem != "reg":
     print("E R R O R")
     print(" ")
     exit()
    n1= int(input("En cuantas asignaturas te inscribiste?"))
    if mem =="vet" :
      costo= n1*30

      print("Estado: Veterano.")
    else:
          costo= n1*50
          print("Estado: Regular.")
    
    print(f"Asignaturas inscritas: {n1:.0f}")
    print(f"Costo de la colegiatura: {costo:.0f} dólares.")
    print("")   
except ValueError:
    print("")
    print("Se produjo un error, intentelo de nuevo.")
    print(" ")
    exit()