<?php 
    $localhost = "192.168.20.3";
    $user = "root";
    $password = "12345";
    $banco = "2024_iago_fistdb";
    $conn = mysqli_connect($localhost, $user, $password, $banco);

    if (! $conn) {
        header("Location: index.html");
    }

    ?>