#Contar dígitos en un número: 
#Dado un número entero positivo, cuenta cuántos dígitos tiene.
#Por ejemplo, si el número es 12345, la respuesta sería 5.

n1=int(input("Ingresa un número entre 10 al 9999:" ))

n1str= str(n1)
digitos = len(n1str)

print(f"El número {n1} cuenta con {digitos} dígitos. ")