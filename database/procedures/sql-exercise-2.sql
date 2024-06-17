DELIMITER $$

CREATE PROCEDURE Selecionar_Codigo(IN p_codigo INT)
BEGIN
    SELECT nome FROM clientes
    WHERE idCliente = p_codigo;
END $$

DELIMITER ;

CALL Selecionar_Codigo(1);

DROP PROCEDURE Selecionar_Codigo;
