-- ==========================================================
--  BASE DE DATOS DEL SISTEMA DE PRESTAMOS DEL PAÑOL ESCOLAR
--  Trabajo Integrador - Modelos y Sistemas - 7mo año
--  Ejecutar este script en SQL Server Management Studio (F5)
-- ==========================================================

USE master
GO

-- si la base ya existe la borro para crearla de nuevo
IF DB_ID('PanolEscolar') IS NOT NULL
BEGIN
    ALTER DATABASE PanolEscolar SET SINGLE_USER WITH ROLLBACK IMMEDIATE
    DROP DATABASE PanolEscolar
END
GO

CREATE DATABASE PanolEscolar
GO

USE PanolEscolar
GO

-- ---------------- TABLAS ----------------

-- alumnos que pueden pedir herramientas
CREATE TABLE Alumnos (
    IdAlumno INT IDENTITY(1,1) PRIMARY KEY,
    Dni VARCHAR(10) NOT NULL UNIQUE,
    Nombre VARCHAR(60) NOT NULL,
    Curso VARCHAR(20) NOT NULL,
    Sancionado BIT NOT NULL DEFAULT 0
)
GO

-- herramientas del pañol (el stock)
CREATE TABLE Herramientas (
    IdHerramienta INT IDENTITY(1,1) PRIMARY KEY,
    Nombre VARCHAR(60) NOT NULL,
    CantidadTotal INT NOT NULL,
    Disponibles INT NOT NULL,
    Danadas INT NOT NULL DEFAULT 0
)
GO

-- prestamos (entregas y devoluciones)
CREATE TABLE Prestamos (
    IdPrestamo INT IDENTITY(1,1) PRIMARY KEY,
    IdAlumno INT NOT NULL FOREIGN KEY REFERENCES Alumnos(IdAlumno),
    IdHerramienta INT NOT NULL FOREIGN KEY REFERENCES Herramientas(IdHerramienta),
    Cantidad INT NOT NULL,
    FechaPrestamo DATETIME NOT NULL DEFAULT GETDATE(),
    FechaDevolucion DATETIME NULL,
    Estado VARCHAR(20) NOT NULL   -- 'Prestado', 'Devuelto' o 'Devuelto dañado'
)
GO

-- historial de estado de cada herramienta
CREATE TABLE Historial (
    IdHistorial INT IDENTITY(1,1) PRIMARY KEY,
    IdHerramienta INT NOT NULL FOREIGN KEY REFERENCES Herramientas(IdHerramienta),
    Fecha DATETIME NOT NULL DEFAULT GETDATE(),
    Estado VARCHAR(20) NOT NULL,  -- 'Alta', 'Prestada', 'Devuelta' o 'Dañada'
    Detalle VARCHAR(200)
)
GO

-- ---------------- DATOS DE PRUEBA ----------------

INSERT INTO Alumnos (Dni, Nombre, Curso) VALUES ('45123456', 'Juan Perez', '7mo 1ra')
INSERT INTO Alumnos (Dni, Nombre, Curso) VALUES ('45987654', 'Maria Gomez', '7mo 1ra')
INSERT INTO Alumnos (Dni, Nombre, Curso) VALUES ('46111222', 'Lucas Fernandez', '6to 2da')

INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles) VALUES ('Martillo', 5, 5)
INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles) VALUES ('Destornillador plano', 10, 10)
INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles) VALUES ('Pinza universal', 6, 6)
INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles) VALUES ('Multimetro', 3, 3)
INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles) VALUES ('Soldador de estaño', 4, 4)
INSERT INTO Herramientas (Nombre, CantidadTotal, Disponibles) VALUES ('Llave francesa', 2, 2)

-- dejo registrado en el historial el alta de cada herramienta
INSERT INTO Historial (IdHerramienta, Estado, Detalle)
SELECT IdHerramienta, 'Alta', 'Se cargo al stock: ' + CAST(CantidadTotal AS VARCHAR) + ' unidades'
FROM Herramientas
GO

-- para comprobar
SELECT * FROM Alumnos
SELECT * FROM Herramientas
GO
