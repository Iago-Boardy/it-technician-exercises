<?php
$idCliente = $_POST['idCliente'];
$nome = $_POST['nome'];
$logradouro = $_POST['logradouro'];
$complemento = $_POST['complemento'];
$bairro = $_POST['bairro'];
$cep = $_POST['cep'];
$cidade = $_POST['cidade'];
$uf = $_POST['uf'];
$email = $_POST['email'];
$idade = $_POST['idade'];

include_once 'connection.php';

$sql = "UPDATE clientes 
        SET nome='$nome', logadouro='$logradouro', complemento='$complemento', bairro='$bairro', cep='$cep', cidade='$cidade', uf='$uf', email='$email', idade='$idade'
        WHERE idCliente = '$idCliente'";

$result = mysqli_query($conn, $sql);

if (!$result) {
    echo "Erro ao atualizar o cliente: " . mysqli_error($conn);
} else {
    header("Location: menu.html");
    exit();
}

mysqli_close($conn);
?>
