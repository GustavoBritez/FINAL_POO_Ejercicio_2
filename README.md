# 🚜 Ejercicio 3: Granja de Animales 🐮🐔🐴

Este proyecto implementa un sistema básico de gestión para una granja, utilizando los principios de **Herencia**, **Clases Abstractas** y **Eventos** en C#. El objetivo es simular el comportamiento de diferentes tipos de animales cuando son alimentados.

## ✨ Requisitos Funcionales del Sistema

---

### 1. 🧬 Clase Base Abstracta (`Animales`)

Se define una clase base abstracta para establecer la estructura de todos los animales de la granja:


* **Método Clave:** La clase `Animales` debe incluir el método abstracto `public abstract void Comer(object sender , EventArgs e );`, que definirá el comportamiento específico de alimentación.

---

### 2. 🦄 Clases Derivadas (Comportamientos Específicos)

Se crean al menos tres clases que heredan de `Animales`, cada una con una lógica de alimentación distinta (implementando el método `Comer`):

* **🐮 Vaca:** Al ser alimentada, **incrementa su peso en 10 kg**.
* **🐔 Gallina:** Al ser alimentada, **produce un huevo adicional**.
* **🐴 Caballo:** Al ser alimentado, **incrementa su energía en un 20%**.

---

### 3. 📢 Gestión Centralizada de Eventos (`Granja`)

La clase `Gestionar_Granja` (o `Granja`) es el controlador central:

* **Evento:** Debe incluir un evento `public event EventHandler AlimentarHandler;` que dispara la acción de comer.
* **Suscripción:** Cada animal, al ser agregado, debe **suscribirse** al evento a través de la clase `Granja`.
* **Métodos Clave:**
    * `void AgregarAnimal(Animales animal)`: Agrega un animal a la lista. Debe validar que **no existan duplicados** (basados en el `Id`).
    * `void AlimentarTodos()`: Invoca el evento `AlimentarHandler` para alimentar a todos los animales suscritos.

---

## 💻 Interfaz de Usuario (Windows Forms)

Se implementa una aplicación de escritorio para interactuar con el sistema:

* **Controles de Entrada:**
    * `TextBox`: Ingreso de **Nombre**.
    * `ComboBox`: Selección de **Especie** (Vaca, Gallina, Caballo).
* **Acciones:**
    * `Button`: **Agregar** (crea e inscribe un nuevo animal).
    * `Button`: **Alimentar** (dispara el evento global).
* **Visualización:**
    * `DataGridView`: Muestra dinámicamente la lista de animales con: `Nombre`, `Especie`, `Id` y una columna personalizada llamada **Atributo** (que muestra la cualidad específica de cada herencia, como el Peso, Huevos o Energía).

---

## 📝 Condiciones de Implementación

1.  La clase `Granja` gestiona toda la **suscripción y ejecución** del evento.
2.  El método `Comer` en cada clase derivada debe ser implementado de forma **personalizada**.
3.  El sistema debe utilizar el `Nombre` para garantizar que no haya **duplicados**.
