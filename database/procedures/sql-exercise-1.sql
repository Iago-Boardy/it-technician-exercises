DELIMITER $$
CREATE PROCEDURE Selecionar_Clientes(IN quantidade INT)
BEGIN

SELECT * FROM clientes
LIMIT quantidade;

wadeqeEND $$
DELIMITER ;

CALL Selecionar_Clientes(2); 

