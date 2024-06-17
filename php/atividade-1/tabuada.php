<?php 
$number = $_POST['number'];
$i = 0;

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
        <h1>Tabuada do número <?php echo $number; ?></h1>

        <div class="tabuada">
            <?php 
            for ($i = 1; $i <= 10; $i++) { ?>
                <tr>
                    <td><?php echo $number. "x" .$i." = ".$number*$i."<br>";?></td>
                </tr>
            <?php
            } ?>
        </div>
        </section>    
</body>
</html>