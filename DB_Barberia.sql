CREATE DATABASE DB_Barberias;
USE DB_Barberias;



CREATE TABLE TBBarbero(
    IdBarbero INT NOT NULL IDENTITY,
    NombreBarbero VARCHAR(25) NOT NULL,
    CONSTRAINT pkBarbero PRIMARY KEY (IdBarbero)
);


CREATE TABLE TBServicio(
    IdServicio INT NOT NULL IDENTITY,
	NombreServicio VARCHAR(40) NOT NULL,
    DescripcionServicio VARCHAR(250) NOT NULL,
    CostoServicio DECIMAL NOT NULL,
    CONSTRAINT pkServicio PRIMARY KEY (IdServicio)
);

CREATE TABLE TBCliente(
    IdCliente INT NOT NULL IDENTITY,
    NombreCliente VARCHAR(35) NOT NULL,
    TelefonoCliente VARCHAR(10) NOT NULL,
    CONSTRAINT pkCliente PRIMARY KEY (IdCliente)
);

CREATE TABLE TBCita(
    IdCita INT NOT NULL IDENTITY,
    Fecha DATE NOT NULL,
    IdCliente INT NOT NULL,
    IdBarbero INT NOT NULL,
    IdServicio INT NOT NULL,
    CONSTRAINT pkCita PRIMARY KEY (IdCita),
    CONSTRAINT fkCliente FOREIGN KEY (IdCliente) REFERENCES TBCliente(IdCliente),
    CONSTRAINT fkBarbero FOREIGN KEY (IdBarbero) REFERENCES TBBarbero(IdBarbero),
    CONSTRAINT fkServicio FOREIGN KEY (IdServicio) REFERENCES TBServicio(IdServicio)
);





INSERT INTO TBBarbero (NombreBarbero) VALUES ('Juan Pérez');
INSERT INTO TBBarbero (NombreBarbero) VALUES ('Carlos López');


INSERT INTO TBServicio (NombreServicio, DescripcionServicio, CostoServicio) VALUES ('Corte de Cabello', 'Corte de cabello estándar', 150.00);
INSERT INTO TBServicio (NombreServicio, DescripcionServicio, CostoServicio) VALUES ('Afeitado', 'Afeitado con navaja', 100.00);



INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Pedro Martínez', '5551234567');
INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Luis García', '5557654321');


INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-15', 1, 1, 1);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-16', 2, 2, 2);


INSERT INTO TBBarbero (NombreBarbero) VALUES ('Juan Pérez');
INSERT INTO TBBarbero (NombreBarbero) VALUES ('Carlos López');
INSERT INTO TBBarbero (NombreBarbero) VALUES ('Ana Torres');
INSERT INTO TBBarbero (NombreBarbero) VALUES ('Luis Fernández');
INSERT INTO TBBarbero (NombreBarbero) VALUES ('María Gómez');



INSERT INTO TBServicio (NombreServicio, DescripcionServicio, CostoServicio) VALUES
('Corte de cabello', 'Un corte a la medida de tu estilo, realizado por profesionales que entienden las últimas tendencias y técnicas.', 15.00),
('Arreglo de barba', 'Define y perfila tu barba con precisión para un look impecable, ya sea que prefieras un estilo clásico o moderno.', 12.00),
('Tinte para barba', 'Dale un nuevo tono a tu barba, ya sea para cubrir las canas o para un cambio de estilo audaz.', 18.00),
('Corte de puntas y peinado', 'Mantén tu cabello sano con un corte de puntas y termina con un peinado elegante para cualquier ocasión.', 22.00),
('Afeitado clásico con navaja', 'Experiencia tradicional con navaja recta, acompañado de toallas calientes para un afeitado suave y cómodo.', 25.00),
('Corte de cabello y barba', 'Un paquete completo para mantener tu cabello y barba en perfecto estado, todo en una sola visita.', 20.00),
('Lavado y corte', 'Un tratamiento de lavado profesional seguido de un corte personalizado, asegurando frescura y estilo.', 10.00),
('Tratamiento capilar hidratante', 'Repara y revitaliza tu cabello con un tratamiento profundo que le devolverá brillo, suavidad y salud.', 30.00);




INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Pedro Martínez', '5551234567');
INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Luis García', '5557654321');
INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Sofía Hernández', '5559876543');
INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Miguel Ángel', '5556543210');
INSERT INTO TBCliente (NombreCliente, TelefonoCliente) VALUES ('Laura Sánchez', '5554321098');



INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-15', 1, 1, 1);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-16', 2, 2, 2);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-17', 3, 3, 3);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-18', 4, 4, 4);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-19', 5, 5, 5);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-20', 1, 2, 1);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-21', 2, 3, 2);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-22', 3, 4, 3);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-23', 4, 5, 4);
INSERT INTO TBCita (Fecha, IdCliente, IdBarbero, IdServicio) VALUES ('2024-09-24', 5, 1, 5);


select * from TBCita