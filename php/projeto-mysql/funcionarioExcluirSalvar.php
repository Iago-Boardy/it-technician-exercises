<?php
$idFuncionario = $_POST['idFuncionario'];

include_once 'connection.php';

$sql = "DELETE FROM funcionario WHERE idFuncionario = '$idFuncionario'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao excluir o funcionário: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
