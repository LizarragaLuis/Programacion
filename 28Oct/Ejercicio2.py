n=int(0)
def factorial(n):
    if n < 0:
        return "El factorial no está definido para números negativos."
    else:
        if n == 0 or n == 1:
            return 1
        else:
            resultado = 1
            n=int(n+1) #Esto era el problema profe, necesitaba decirle antes del for que si no es int se convierta a int para 
            #que el for funcione.
        for i in range(2,n):
            resultado *= i
        return resultado
numero = float(input("Ingrese un número. Se le regresará su factorial (no negativos): "))
print(f"El factorial de {numero} es: {factorial(numero)}")

