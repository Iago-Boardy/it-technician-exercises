<?php
include_once "connection.php";

$nome = $_POST['nome'];

$sql = "INSERT INTO projeto (nomeProjeto) VALUES ('$nome')";
$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Não conseguiu inserir";
} else {
    header("Location: menu.html");
}

mysqli_close($conn);
?>
