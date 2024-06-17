<?php
if ($_SERVER['REQUEST_METHOD'] === 'POST') {
    $idCliente = $_POST['idCliente'];

    if (!empty($idCliente)) {
        include_once 'connection.php';

        $sql = "DELETE FROM clientes WHERE idCliente = ?";
        $stmt = mysqli_prepare($conn, $sql);
        mysqli_stmt_bind_param($stmt, 'i', $idCliente);
        $result = mysqli_stmt_execute($stmt);

        if ($result) {
            header("Location: menu.html");
        } else {
            echo "Erro ao excluir o cliente.";
        }

        mysqli_stmt_close($stmt);
        mysqli_close($conn);
    } else {
        echo "Nenhum cliente selecionado.";
    }
} else {
    header("Location: menu.html");
}
?>
