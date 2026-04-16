CREATE DATABASE jackers;
USE jackers;
CREATE TABLE tbl_programa1 (
    id INT AUTO_INCREMENT PRIMARY KEY,
    producto VARCHAR(100) NOT NULL,
    cantidad INT NOT NULL,
    precio DECIMAL(10,2) NOT NULL,
    subtotal DECIMAL(10,2) NOT NULL,
    descuento DECIMAL(10,2) NOT NULL,
    neto DECIMAL(10,2) NOT NULL
);
SELECT * FROM tbl_programa1;