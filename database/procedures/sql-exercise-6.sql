DELIMITER $$

CREATE PROCEDURE Somar_Numeros(
    IN n1 INT,
    IN n2 INT,
    OUT total INT
)
BEGIN
    SET total = n1 + n2;
END $$

DELIMITER ;

SET @total = 0;

CALL Somar_Numeros(5, 3, @total);

SELECT @total AS total;

DROP PROCEDURE Somar_Numeros;
