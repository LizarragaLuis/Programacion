#Secuencia de Fibonacci: 
# Genera los primeros N términos de la secuencia de Fibonacci.
#  La secuencia comienza con 0 y 1,
#  y cada término posterior es la suma de los dos términos anteriores. 
# Por ejemplo, si N es 8, la secuencia sería: 0, 1, 1, 2, 3, 5, 8, 13.
try:
    n1=float(input("Se va realizar la secuencia de Fibonacci, ingrese cuántas veces quiere que pase la secuencia: "))
    futuro = 0
    presente= 1
    pasado = 0
    n2= int(n1)
    print("")
    for num in range(0, n2, 1):
        print(pasado, end=" ")
        futuro = presente + pasado
        pasado = presente
        presente = futuro
        
    print(" ")
except ValueError:
    print("E R R O R.")