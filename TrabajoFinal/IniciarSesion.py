import tkinter as tk
from tkinter import ttk

#VENTANA PRINCIPIAL
ventana = tk.Tk()
ventana.title("HardTable 1.0 - Iniciar Sesión")
ventana.geometry("480x350")
ventana.resizable(False, False)
ventana.configure(bg="#F5F5F5")

ventana.update_idletasks()
ancho = ventana.winfo_width()
alto = ventana.winfo_height()
x = (ventana.winfo_screenwidth() // 2) - (ancho // 2)
y = (ventana.winfo_screenheight() // 2) - (alto // 2)
ventana.geometry(f"+{x}+{y}")
icono = tk.PhotoImage(file="trabajo final/recursos/icono.png")

ventana.iconphoto(False, icono)
#ICONO DE LA VENTANA


#MARCO PRINCIPAL INICIO SESION
frame = tk.Frame(ventana, bg="white", bd=2, relief="flat")
frame.place(relx=0.5, rely=0.5, anchor="center", width=380, height=280)


titulo = tk.Label(frame, text="Hard Table", font=("Segoe UI", 18, "bold"), bg="white", fg="#333")
titulo.pack(pady=(20, 10))

# #ETIQUETAS
usuario_label = tk.Label(frame, text="Usuario", font=("Segoe UI", 12), bg="white", fg="#555")
usuario_label.pack(anchor="w", padx=40, pady=(10, 0))
usuario_entry = ttk.Entry(frame, font=("Segoe UI", 12))
usuario_entry.pack(padx=40, fill="x", pady=5)

contrasena_label = tk.Label(frame, text="Contraseña", font=("Segoe UI", 12), bg="white", fg="#555")
contrasena_label.pack(anchor="w", padx=40, pady=(10, 0))
contrasena_entry = ttk.Entry(frame, font=("Segoe UI", 12), show="*")
contrasena_entry.pack(padx=40, fill="x", pady=5)

# BOTON PA ENTRAR
def iniciar_sesion():
    usuario = usuario_entry.get()
    contrasena = contrasena_entry.get()
    print(f"Usuario: {usuario}, Contraseña: {contrasena}")

boton = tk.Button(
    frame,
    text="Entrar",
    font=("Segoe UI", 12, "bold"),
    bg="#6A1B9A",         
    fg="white",         
    activebackground="#8E24AA",
    activeforeground="white",
    relief="solid",        
    bd=2,                  
    highlightbackground="#333333", 
    highlightcolor="#333333",     
    cursor="hand2",
    command=iniciar_sesion
)
boton.pack(pady=(20, 5), ipadx=80, ipady=5)

# Texto de ayuda
olvide = tk.Label(frame, text="¿Olvidaste tu contraseña?", font=("Segoe UI", 10), bg="white", fg="#777", cursor="hand2")
olvide.pack(pady=(5, 0))

ventana.mainloop()

