DELIMITER $$

CREATE PROCEDURE ValidarCliente(
    IN p_cli_idcliente INT,
    IN p_cli_nome VARCHAR(255)
)
BEGIN

    DECLARE id_exists INT;
    DECLARE name_exists INT;

    SELECT COUNT(*) INTO id_exists
    FROM clientes
    WHERE cli_idcliente = p_cli_idcliente;

    SELECT COUNT(*) INTO name_exists
    FROM clientes
    WHERE cli_nome = p_cli_nome;

    IF id_exists > 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'ID do cliente já existe';
    END IF;

    IF name_exists > 0 THEN
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Nome do cliente já existe';
    END IF;

END $$

DELIMITER ;

CALL ValidarCliente(1, 'Nome do Cliente');
