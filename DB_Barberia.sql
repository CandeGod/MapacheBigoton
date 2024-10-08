CREATE DATABASE DB_Barberias;
GO
USE DB_Barberias;
GO

-- Tabla de Sucursales
CREATE TABLE TBSucursal(
    IdSucursal INT NOT NULL IDENTITY,
    Ubicacion VARCHAR(100) NOT NULL,
    Direccion VARCHAR(120) NOT NULL,
    CONSTRAINT pkSucursal PRIMARY KEY (IdSucursal)
);

-- Tabla de Barberos
CREATE TABLE TBBarbero(
    IdBarbero INT NOT NULL IDENTITY,
    NombreBarbero VARCHAR(25) NOT NULL,
    IdSucursal INT NOT NULL,
    CONSTRAINT pkBarbero PRIMARY KEY (IdBarbero),
    CONSTRAINT fkSucursalBarbero FOREIGN KEY (IdSucursal) 
        REFERENCES TBSucursal(IdSucursal) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Tabla de Servicios
CREATE TABLE TBServicio(
    IdServicio INT NOT NULL IDENTITY,
    NombreServicio VARCHAR(40) NOT NULL,
    DescripcionServicio VARCHAR(250) NOT NULL,
    CostoServicio DECIMAL NOT NULL,
    IdSucursal INT NOT NULL,
    CONSTRAINT pkServicio PRIMARY KEY (IdServicio),
    CONSTRAINT fkSucursalServicio FOREIGN KEY (IdSucursal) 
        REFERENCES TBSucursal(IdSucursal) ON DELETE CASCADE ON UPDATE CASCADE
);

-- Tabla de Clientes
CREATE TABLE TBCliente(
    IdCliente INT NOT NULL IDENTITY,
    NombreCliente VARCHAR(35) NOT NULL,
    TelefonoCliente VARCHAR(10) NOT NULL,
    CONSTRAINT pkCliente PRIMARY KEY (IdCliente)
);

-- Tabla de Citas
-- Tabla de Citas
CREATE TABLE TBCita(
    IdCita INT NOT NULL IDENTITY,
    Fecha DATE NOT NULL,
    Hora TIME NOT NULL, -- Se agrega la columna Hora
    IdCliente INT NOT NULL,
    IdBarbero INT NOT NULL,
    IdServicio INT NOT NULL,
    IdSucursal INT NOT NULL,
    CONSTRAINT pkCita PRIMARY KEY (IdCita),
    CONSTRAINT fkCliente FOREIGN KEY (IdCliente) REFERENCES TBCliente(IdCliente),
    CONSTRAINT fkBarbero FOREIGN KEY (IdBarbero) REFERENCES TBBarbero(IdBarbero),
    CONSTRAINT fkServicio FOREIGN KEY (IdServicio) REFERENCES TBServicio(IdServicio),
    CONSTRAINT fkSucursalCita FOREIGN KEY (IdSucursal) 
        REFERENCES TBSucursal(IdSucursal) ON DELETE CASCADE ON UPDATE CASCADE
);




/*INSERT INTO TBSucursal (Ubicacion, Direccion) VALUES 
    ('Sucursal PARA ELMINAR', 'Calle Madero 123')*/
-- Insertar sucursales
INSERT INTO TBSucursal (Ubicacion, Direccion) VALUES 
    ('Sucursal Centro', 'Calle Madero 123'),
    ('Sucursal Norte', 'Av. Álvaro Obregón 456'),
    ('Sucursal Este', 'Av. Presidente Masaryk 789'),
    ('Sucursal Oeste', 'Calle Juarez 451');

-- Insertar barberos
INSERT INTO TBBarbero (NombreBarbero, IdSucursal) VALUES 
    ('Juan Pérez', 1),
    ('Carlos López', 1),
    ('Ana Torres', 2),
    ('Luis Fernández', 2),
    ('María Gómez', 3),
    ('Pedro Sánchez', 3),
    ('Laura Martínez', 4),
    ('José Ramírez', 4);

-- Insertar servicios
INSERT INTO TBServicio (NombreServicio, DescripcionServicio, CostoServicio, IdSucursal) VALUES 
    ('Corte de cabello', 'Un corte a la medida de tu estilo, realizado por profesionales que entienden las últimas tendencias y técnicas.', 15.00, 1),
    ('Arreglo de barba', 'Define y perfila tu barba con precisión para un look impecable, ya sea que prefieras un estilo clásico o moderno.', 12.00, 1),
    ('Tinte para barba', 'Dale un nuevo tono a tu barba, ya sea para cubrir las canas o para un cambio de estilo audaz.', 18.00, 2),
    ('Corte de puntas y peinado', 'Mantén tu cabello sano con un corte de puntas y termina con un peinado elegante para cualquier ocasión.', 22.00, 2),
    ('Afeitado clásico con navaja', 'Experiencia tradicional con navaja recta, acompañado de toallas calientes para un afeitado suave y cómodo.', 25.00, 3),
    ('Corte de cabello y barba', 'Un paquete completo para mantener tu cabello y barba en perfecto estado, todo en una sola visita.', 20.00, 3),
    ('Lavado y corte', 'Un tratamiento de lavado profesional seguido de un corte personalizado, asegurando frescura y estilo.', 10.00, 4),
    ('Tratamiento capilar hidratante', 'Repara y revitaliza tu cabello con un tratamiento profundo que le devolverá brillo, suavidad y salud.', 30.00, 4);

-- Insertar clientes
INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES 
    ('Pedro Martínez', '5551234567'),
    ('Luis García', '5557654321'),
    ('Ana López', '5552345678'),
    ('Carlos Sánchez', '5558765432'),
    ('María Fernández', '5553456789'),
    ('José Ramírez', '5559876543'),
    ('Laura Torres', '5554567890'),
    ('Juan Pérez', '5556789012'),
    ('Marta Gómez', '5557890123'),
    ('Ricardo Díaz', '5558901234'),
    ('Sofía Morales', '5559012345'),
    ('Miguel Herrera', '5550123456');

-- Insertar citas
INSERT INTO TBCita (Fecha, Hora, IdCliente, IdBarbero, IdServicio, IdSucursal) VALUES 
    ('2024-09-26', '10:00:00', 1, 1, 1, 1),
    ('2024-09-26', '11:00:00', 2, 2, 2, 1),
    ('2024-09-26', '12:00:00', 3, 3, 3, 2),
    ('2024-09-26', '13:00:00', 4, 4, 4, 2),
    ('2024-09-27', '14:00:00', 5, 5, 5, 3),
    ('2024-09-27', '15:00:00', 6, 6, 6, 3),
    ('2024-09-27', '16:00:00', 7, 7, 7, 4),
    ('2024-09-27', '17:00:00', 8, 8, 8, 4);


						 
select * from TBSucursal;
select * from TBBarbero;
select * from TBCliente;
select * from TBCita;
select * from TBServicio;

CREATE PROCEDURE InsertarCita
    @Fecha DATE,
    @Hora TIME,
    @IdCliente INT,
    @IdBarbero INT,
    @IdServicio INT,
    @IdSucursal INT
AS
BEGIN
    INSERT INTO TBCita (Fecha, Hora, IdCliente, IdBarbero, IdServicio, IdSucursal)
    VALUES (@Fecha, @Hora, @IdCliente, @IdBarbero, @IdServicio, @IdSucursal);
END
