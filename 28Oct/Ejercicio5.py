#crea funcion que convierta minutos a horas y viceversa.
def min_hor(n1):
    con2=n1/60
    return con2

def hor_min(n1):
    con1=n1*60
    return con1
try:
    convertir=float(input("Convertira minutos a horas? (Ingrese 1) o Horas a minutos? (Ingrese 2): "))
    n1=float(input("Ingrese el valor que desee convertir: "))
    if convertir == 1:
        res1=min_hor(n1)
        print(f"Es una cantidad de  {res1:.2f} Horas.")
    elif convertir == 2:
     res1=hor_min(n1)
     print(f"Es una cantidad de  {res1:.2f} Minutos.")
    else:
        print("E R R O R")
except ValueError:
    print("E R R O R. Reinicie el programa.")
