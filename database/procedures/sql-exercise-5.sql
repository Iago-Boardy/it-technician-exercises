DELIMITER $$

CREATE PROCEDURE Selecionar_Codigo(
    IN p_idAlunos INT,
    OUT p_nome VARCHAR(255),
    OUT p_peso FLOAT,
    OUT p_altura FLOAT,
    OUT p_imc FLOAT
)
BEGIN
    DECLARE v_altura FLOAT;

    SELECT nome, peso INTO p_nome, p_peso
    FROM alunos
    WHERE idAlunos = p_idAlunos;

    SELECT altura INTO v_altura
    FROM alunos
    WHERE idAlunos = p_idAlunos;

    SET p_altura = v_altura;

    IF v_altura > 0 THEN
        SET p_imc = p_peso / (v_altura * v_altura);
    ELSE
        SET p_imc = 0;
    END IF;
END $$

DELIMITER ;

SET @Nome = '';
SET @Peso = 0.0;
SET @Altura = 0.0;
SET @IMC = 0.0;

CALL Selecionar_Codigo(1, @Nome, @Peso, @Altura, @IMC);

SELECT @Nome AS Nome, @Peso AS Peso, @Altura AS Altura, @IMC AS IMC;



DROP PROCEDURE Selecionar_Codigo;
