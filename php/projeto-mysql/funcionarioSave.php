<?php
include_once "connection.php";

$nome = $_POST['nome'];
$trabalho = $_POST['trabalho'];

$sql = "INSERT INTO funcionario (nome,idTrabalho) VALUES ('$nome', $trabalho)";
$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Não conseguiu inserir";
} else {
    header("Location: menu.html");
}

mysqli_close($conn);
?>
