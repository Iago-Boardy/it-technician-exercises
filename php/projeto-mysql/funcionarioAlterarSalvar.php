<?php
$idFuncionario = $_POST['idFuncionario'];
$nome = $_POST['nome'];
$idTrabalho = $_POST['trabalho'];

include_once 'connection.php';

$sql = "UPDATE funcionario 
        SET nome='$nome', idTrabalho='$idTrabalho'
        WHERE idFuncionario = '$idFuncionario'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao atualizar o funcionário: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
