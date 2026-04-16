CREATE DATABASE empresa;

USE empresa;

CREATE TABLE pagos (
    id INT AUTO_INCREMENT PRIMARY KEY,
    empleado VARCHAR(100),
    horas INT,
    tarifa DOUBLE,
    basico DOUBLE,
    bonificacion DOUBLE,
    neto DOUBLE
);