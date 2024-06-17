-- Define um novo delimitador
DELIMITER $$

-- Cria a procedure chamada Aplicar_Aumento
CREATE PROCEDURE Aplicar_Aumento()
BEGIN
    -- Atualiza o salário de todos os funcionários aplicando um aumento de 5,14%
    UPDATE Funcionarios
    SET Salario = Salario * 1.0514;
END $$

-- Redefine o delimitador para o padrão
DELIMITER ;

-- Chama a procedure Aplicar_Aumento para aplicar o aumento
CALL Aplicar_Aumento();

-- (Opcional) Exibe os salários atualizados dos funcionários para verificação
SELECT * FROM Funcionarios;

-- (Opcional) Exclui a procedure Aplicar_Aumento, se necessário
-- DROP PROCEDURE Aplicar_Aumento;
