<?php
$idProjeto = $_POST['idProjeto'];
$nomeProjeto = $_POST['nomeProjeto'];

include_once "connection.php";

$sql = "UPDATE projeto 
        SET nomeProjeto='$nomeProjeto'
        WHERE idProjeto = '$idProjeto'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao atualizar o projeto: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
