-- Define um novo delimitador
DELIMITER $$

-- Cria a procedure chamada Ajustar_Preco
CREATE PROCEDURE Ajustar_Preco()
BEGIN
    DECLARE max_preco FLOAT;

    -- Obtém o maior valor unitário do produto
    SELECT MAX(PrecoUnitario) INTO max_preco FROM Produtos;

    -- Verifica se o maior valor unitário é maior ou igual a 1200
    IF max_preco >= 1200 THEN
        -- Aplica uma redução de 9,07%
        UPDATE Produtos
        SET PrecoUnitario = PrecoUnitario * (1 - 0.0907);
    ELSE
        -- Aplica uma redução de 4,02%
        UPDATE Produtos
        SET PrecoUnitario = PrecoUnitario * (1 - 0.0402);
    END IF;
END $$

-- Redefine o delimitador para o padrão
DELIMITER ;

-- Chama a procedure Ajustar_Preco para aplicar a redução
CALL Ajustar_Preco();

-- (Opcional) Exibe os preços atualizados dos produtos para verificação
SELECT * FROM Produtos;

-- (Opcional) Exclui a procedure Ajustar_Preco, se necessário
-- DROP PROCEDURE Ajustar_Preco;
