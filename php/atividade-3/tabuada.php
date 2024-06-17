<?php 
$number1 = $_POST['number1'];
$number2 = $_POST['number2'];
$number3 = $_POST['number3'];
?>


<!DOCTYPE html>
<html lang="pt-br">
<head>
    <link rel="preconnect" href="https://fonts.googleapis.com">
    <link rel="preconnect" href="https://fonts.gstatic.com" crossorigin>
    <link href="https://fonts.googleapis.com/css2?family=Mulish:ital,wght@0,200..1000;1,200..1000&display=swap" rel="stylesheet">
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tabuada</title>
    <link rel="stylesheet" href="style.css">
</head>

<body>
    <section>
    <h1>Atividade 3</h1>

        <?php 
        if ($number1 > $number2 && $number1 > $number3) {
            echo "O " .$number1. " é o maior";
        } else if ($number1 === $number2 && $number1 === $number3) {
            echo "Os números são iguais";
        } else if($number2 > $number1 && $number2 > $number3){
            echo "O " .$number2. " é maior";
        } else {
            echo "O " .$number3. " é maior";
        }
        ?>

        
        </section>    
</body>
</html>