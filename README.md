# Sistema de Gestión de Préstamos del Pañol Escolar

Sistema de escritorio para controlar los préstamos de herramientas del pañol de la escuela: stock, entregas y devoluciones, historial de cada herramienta y reporte de insumos dañados.

Trabajo Integrador Individual de **Modelos y Sistemas — 7mo Año** (Escuela Técnica), Opción A.

## Funcionalidades

- Registrar préstamos y devoluciones (en buen estado o dañadas).
- Alta de alumnos y manejo de sanciones.
- Control de stock: total, disponibles, prestadas y dañadas.
- Reporte de insumos dañados e historial de estado por herramienta.
- Un alumno sancionado no puede pedir herramientas, y no se puede prestar más de lo disponible.

## Tecnologías

- C# con Windows Forms (.NET 10)
- SQL Server Express
- Microsoft.Data.SqlClient
- Programación orientada a objetos, arquitectura en 3 capas

## Requisitos

- Visual Studio 2026 (o 2022 con .NET 10) con el módulo de desarrollo de escritorio .NET
- SQL Server Express y SQL Server Management Studio

## Instalación y ejecución

1. Abrir SQL Server Management Studio, conectarse a `.\SQLEXPRESS` y ejecutar `BaseDeDatos/PanolEscolar.sql`. Crea la base `PanolEscolar` con datos de prueba.
2. Abrir `PanolEscolar.sln` en Visual Studio.
3. Si el servidor SQL tiene otro nombre, cambiar la cadena de conexión en `CapaDatos/Conexion.cs`.
4. Establecer `CapaPresentacion` como proyecto de inicio y ejecutar con F5.

## Estructura del proyecto

```
├── PanolEscolar.sln
├── CapaPresentacion/      Formulario (interfaz de usuario)
├── CapaNegocio/           Reglas y validaciones
├── CapaDatos/             Acceso a SQL Server
│   └── Entidades/         Alumno, Herramienta, Prestamo, Historial
├── BaseDeDatos/           Script de creación de la base
├── Capturas/              Capturas de pantalla y diagramas
└── Documentacion_TP_Panol_Escolar.pdf
```

## Documentación

La documentación completa (marco conceptual, paso a paso, diagrama de flujo, caso de uso y captura anotada) está en [Documentacion_TP_Panol_Escolar.pdf](Documentacion_TP_Panol_Escolar.pdf).

## Autor

Ignacio Rivarola Centurion
