<?php
$cidade = $_POST['cidade'];
$uf = $_POST['uf'];

include_once "connection.php";

$sql = "INSERT INTO municipios (cidade, uf) VALUES ('$cidade', '$uf')";
$result = mysqli_query($conn, $sql);

if (! $result) {
    echo "Não consegiu inserir";
} else {
    header("Location: menu.html");
}

mysqli_close($conn);
?>