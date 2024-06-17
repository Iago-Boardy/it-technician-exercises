<?php
$idCidade = $_POST['idCidade'];
$cidade = $_POST['cidade'];
$uf = $_POST['uf'];

include_once "connection.php";

$sql = "UPDATE municipios 
        SET cidade='$cidade', uf='$uf'
        WHERE idCidade = '$idCidade'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao atualizar o município: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
