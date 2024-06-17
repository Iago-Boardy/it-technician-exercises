<?php
$idCidade = $_POST['idCidade'];

include_once "connection.php";

$sql = "DELETE FROM municipios WHERE idCidade = '$idCidade'";
$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao excluir o município: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
