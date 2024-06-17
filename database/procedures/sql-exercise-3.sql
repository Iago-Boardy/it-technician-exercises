DELIMITER $$

CREATE PROCEDURE Selecionar_Codigo(
    IN p_idCliente INT,
    OUT p_nome VARCHAR(255),
    OUT p_email VARCHAR(255)
)
BEGIN
    SELECT nome, email INTO p_nome, p_email
    FROM clientes
    WHERE idCliente = p_idCliente;
END $$

DELIMITER ;

CALL Selecionar_Codigo(1, @nome, @email);

SELECT @nome, @email;

