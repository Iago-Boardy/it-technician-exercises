-- Define um novo delimitador
DELIMITER $$

-- Cria a procedure chamada Calcular_Media
CREATE PROCEDURE Calcular_Media(
    IN v1 FLOAT,    -- Primeiro valor de entrada
    IN v2 FLOAT,    -- Segundo valor de entrada
    IN v3 FLOAT,    -- Terceiro valor de entrada
    IN v4 FLOAT,    -- Quarto valor de entrada
    OUT media FLOAT -- Valor de saída onde será armazenada a média
)
BEGIN
    -- Calcula a média dos quatro valores de entrada e armazena no parâmetro de saída
    SET media = (v1 + v2 + v3 + v4) / 4;
END $$

-- Redefine o delimitador para o padrão
DELIMITER ;

-- Define a variável de saída @media
SET @media = 0.0;

-- Chama a procedure Calcular_Media com os valores de exemplo e armazena o resultado em @media
CALL Calcular_Media(3.5, 4.5, 5.0, 6.0, @media);

-- Seleciona e exibe o valor da média calculada
SELECT @media AS Media;

-- Exclui a procedure Calcular_Media
DROP PROCEDURE Calcular_Media;
