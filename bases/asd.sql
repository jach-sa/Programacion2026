UCREATE TABLE pago (
 ID INT AUTO_INCREMENT,
 Empleado VARCHAR(35),
 Horas INT,
 Basico FLOAT(10,2),
 Tarifa FLOAT(10,2),
 Bonificacion FLOAT(10,2),
 netoempleado FLOAT(10,2),
 CONSTRAINT id PRIMARY KEY (ID)
);