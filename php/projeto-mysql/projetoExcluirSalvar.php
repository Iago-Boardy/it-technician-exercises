<?php
$idProjeto = $_POST['idProjeto'];

include_once "connection.php";

$sql = "DELETE FROM projeto WHERE idProjeto = '$idProjeto'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao excluir o projeto: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
