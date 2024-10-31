def cel_far(n1):
    con2=(n1*1.8)+32 #Formula para sacar Fahrenheit
    return con2

def far_cel(n1):
    con1=(n1-32)/1.8 #Formula para sacar Celsius
    return con1
try:
    convertir=float(input("Escribirá grados Celsius(Presione 1) o Grados Fahrenheit(Presione 2)? "))
    n1=float(input("Ingrese el valor que desee convertir: "))
    if convertir == 1:
        res1=cel_far(n1)
        print(f"Son {res1:.2f} grados fahrenheit.")
    elif convertir == 2:
     res1=far_cel(n1)
     print(f"Son {res1:.2f} grados Celsius.")
    else:
        print("E R R O R")
except ValueError:
    print("E R R O R. Reinicie el programa.")