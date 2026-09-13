# Charla 1 - Manejo de Excepciones en C#

Repositorio correspondiente a la **Charla / Investigación N.º 1** del curso **Herramientas de Programación Aplicada III**, enfocado en el manejo de excepciones y la depuración de errores en C#.

## 📌 Tema

**Clases en C#: Manejo de Excepciones (`try-catch-finally`)**

El objetivo de este trabajo es estudiar el manejo de excepciones en C# y demostrar, mediante diferentes escenarios prácticos, cómo controlar errores durante la ejecución de una aplicación y mejorar su estabilidad, robustez y facilidad de mantenimiento.

## 📚 Contenido

La investigación aborda los siguientes conceptos:

- Excepciones en C#
- Errores en tiempo de ejecución
- Bloque `try`
- Bloque `catch`
- Bloque `finally`
- Instrucción `throw`
- Excepciones personalizadas
- Estabilidad y robustez del software
- Confiabilidad
- Mantenibilidad
- Usabilidad

## 💻 Escenarios prácticos

El repositorio contiene tres escenarios desarrollados en C# para demostrar distintas formas de aplicar el manejo de excepciones.

### Escenario 1 - Estructura y datos

Aplicación sencilla para ingresar y mostrar una edad.

Se utiliza el manejo de excepciones para controlar errores producidos al convertir los datos ingresados por el usuario.

Excepciones utilizadas:

- `FormatException`
- `OverflowException`

Esto permite controlar situaciones como:

- Ingreso de letras en lugar de números.
- Ingreso de valores numéricos demasiado grandes.

**Resultado Escenario 1**

<img width="711" height="463" alt="image" src="https://github.com/user-attachments/assets/012eb43d-e6fd-49e2-b121-8877b17dca72" />



### Escenario 2 - Validación y robustez

Aplicación para registrar los datos y la calificación de un estudiante.

Incluye:

- Validación de campos vacíos.
- Uso de `ErrorProvider`.
- Restricción de caracteres mediante `KeyPress`.
- Validación de calificaciones entre **0 y 100**.
- Creación de una excepción personalizada.
- Manejo de errores mediante `try-catch-finally`.

La excepción personalizada permite impedir el registro de calificaciones fuera del rango establecido.

**Resultado Escenario 2**

<img width="542" height="287" alt="image" src="https://github.com/user-attachments/assets/dc118f44-bb0e-4bd1-bbf3-ab737156dbc6" />


### Escenario 3 - Calidad, seguridad y mantenimiento

Aplicación para registrar información de una persona, incluyendo:

- Nombre
- Cédula
- Teléfono

Las validaciones se encuentran organizadas en una clase estática llamada `Verificaciones`.

Se utiliza la instrucción `throw` para generar excepciones cuando los datos no cumplen con las condiciones establecidas, por ejemplo:

- Campos vacíos.
- Nombre con caracteres no permitidos.
- Cédula con formato incorrecto.
- Teléfono con formato incorrecto.

Este enfoque permite separar las validaciones del resto de la aplicación y facilita el mantenimiento del código.

**Resultado Escenario 3**

<img width="468" height="453" alt="image" src="https://github.com/user-attachments/assets/f47ea14e-8a4c-4107-9282-745fe2eb2ea6" />


## 🛠️ Tecnologías utilizadas

- C#
- .NET
- Windows Forms

## 🎯 Importancia del manejo de excepciones

El uso adecuado de excepciones ayuda a desarrollar aplicaciones más estables y permite controlar situaciones inesperadas sin que el programa termine abruptamente.

Además, contribuye principalmente a tres características de calidad del software:

- **Confiabilidad:** permite responder de manera controlada ante fallos.
- **Mantenibilidad:** facilita la identificación y corrección de errores.
- **Usabilidad:** permite mostrar al usuario mensajes claros cuando ocurre un problema.

## 👥 Integrantes

- **Ellis Anria**
- **Aimee Matias**
- **Emanuel Vargas**

## 🎓 Información académica

**Universidad Tecnológica de Panamá**  
**Facultad de Ingeniería de Sistemas Computacionales**  
**Licenciatura en Ingeniería de Sistemas y Computación**
**Curso:** Herramientas de Programación Aplicada III
**Grupo:** 1IL133
**Docente:** Irina Fong
**Semestre:** II Semestre 2026

## 📖 Referencias

Para el desarrollo de la investigación se consultó principalmente:

- Microsoft Learn - Excepciones y control de excepciones en C#
- Microsoft Learn - Buenas prácticas para excepciones
- ISO/IEC 25010 - Modelo de calidad del software

---

**Universidad Tecnológica de Panamá - 2026**
