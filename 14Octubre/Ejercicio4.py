#programa que te pida temperaturas en los 7 dias de la semana y que nos diga
#la temperatura mas alta, mas baja y el promedio
n=int(0)
semana=['Lunes', 'Martes','Miércoles', 'Jueves','Viernes', 'Sábado','Domingo']
registro=0
cal=0
prom=0
fr=100000000000000000000000000000000000000000000000000000000000000000000000000
for n in semana:
     registro=float(input(f"Ingrese la temperatura registrada el día {n}: "))
     if registro >cal:
      cal=registro
     if registro< fr:
      fr = registro
     prom=registro+prom
print("La temperatura más alta registrada fue de: ", cal, " grados Celsius.")
print("La temperatura más baja registrada fue de: ", fr , " grados Celsius.")
print("El promedio de temperatura fue de ",(prom/7),".")