
def kilo_mil(n1):
    con1=n1*.62137119
    return con1
def mil_kilo(n1):
    con2=n1*1.609
    return con2
try:
    convertir=float(input("Ingresará kilómetros(Presione 1) o millas(Presione 2)? "))
    n1=float(input("Ingrese el valor que desee convertir: "))
    if convertir == 1:
        res1=kilo_mil(n1)
        print(f"Son {res1:.2f} millas.")
    elif convertir == 2:
     res1=mil_kilo(n1)
     print(f"Son {res1:.2f} kilometros.")
    else:
        print("E R R O R")
except ValueError:
    print("E R R O R. Reinicie el programa.")