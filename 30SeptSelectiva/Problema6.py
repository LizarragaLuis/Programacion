#Una frutería ofrece las manzanas con descuento según la siguiente tabla:
#NUM DE KILOS COMPRADOS             %DESCUENTO
# 0     -       2                       0%
#   2.01    -   5                       10%
#5.01 - 10                              15%
#10.01 en adelante                      20%
#Determinar cuanto pagará una persona que compre manzanas en esa frutería.
manzanaprecio=float(46.90)
try:
    KC=float(input(f"Cuantos kilos de manzana compraste? "))
    if KC >=0 and KC <=2:
        print(f"El costo sería de:{(manzanaprecio*KC):.2f}$")

    else:
        if KC >2 and KC <=5:
            print(f"El costo sería de:{(manzanaprecio*KC)*.90:.2f}$")
        else:
            if KC >5 and KC <=10:
                print(f"El costo sería de:{(manzanaprecio*KC)*.85:.2f}$")
            else:
                print(f"El costo sería de:{(manzanaprecio*KC)*.80:.2f}$")
except ValueError:
    print("E R R O R")


