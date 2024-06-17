<?php
$nome = $_POST['nome'];
$logradouro = $_POST['logradouro'];
$complemento = $_POST['complemento'];
$bairro = $_POST['bairro'];
$cep = $_POST['cep'];
$cidade = $_POST['cidade'];
$uf = $_POST['uf'];
$email = $_POST['email'];
$idade = $_POST['idade'];

include_once "connection.php";

$sql = "INSERT INTO clientes (nome, logadouro, complemento, bairro, cep, cidade, uf, email, idade) 
        VALUES ('$nome', '$logradouro', '$complemento', '$bairro', '$cep', '$cidade', '$uf', '$email', $idade)";
$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Não conseguiu inserir";
} else {
    header("Location: menu.html");
}

mysqli_close($conn);
?>
