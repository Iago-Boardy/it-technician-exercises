<?php
$idTrabalho = $_POST['idTrabalho'];
$nomeTrabalho = $_POST['nomeTrabalho'];

include_once "connection.php";

$sql = "UPDATE trabalho 
        SET nomeTrabalho='$nomeTrabalho'
        WHERE idTrabalho = '$idTrabalho'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao atualizar o trabalho: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
