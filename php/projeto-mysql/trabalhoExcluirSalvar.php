<?php
$idTrabalho = $_POST['idTrabalho'];

include_once "connection.php";

$sql = "DELETE FROM trabalho WHERE idTrabalho = '$idTrabalho'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao excluir o trabalho: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
