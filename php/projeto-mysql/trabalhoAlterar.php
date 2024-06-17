<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Alterar Trabalho</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .container {
            min-width: 800px;
            margin: 0 auto;
            background-color: #fff;
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
            padding: 20px;
        }

        h1 {
            text-align: center;
            color: #333;
            margin-bottom: 20px;
        }

        form {
            max-width: 600px;
            margin: 0 auto;
        }

        label {
            display: block;
            margin: 10px 0 5px;
            font-weight: bold;
        }

        select, input[type="text"], input[type="submit"] {
            width: 100%;
            padding: 10px;
            margin-bottom: 10px;
            border-radius: 4px;
            border: 1px solid #ccc;
        }

        input[type="submit"] {
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
        }

        input[type="submit"]:hover {
            background-color: #45a049;
        }

        .buttons {
            text-align: center;
            margin-top: 20px;
        }

        a {
            display: inline-block;
            padding: 10px 20px;
            margin: 0 10px;
            border-radius: 4px;
            background-color: #4CAF50;
            color: white;
            text-decoration: none;
            text-align: center;
        }

        a:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Alterar Trabalho</h1>
        <?php
        include_once "connection.php";
        ?>

        <form action="trabalhoAlterarSalvar.php" method="post" autocomplete="off">
            <label for="idTrabalho">Nome do Trabalho</label>
            <select name="idTrabalho" id="idTrabalho">
                <option value="" selected>Selecione...</option>
                <?php 
                $sql1 = "SELECT idTrabalho, nomeTrabalho FROM trabalho ORDER BY nomeTrabalho";
                $resultado1 = mysqli_query($conn, $sql1);
                while ($linha1 = mysqli_fetch_array($resultado1, MYSQLI_NUM)) {
                    echo "<option value='{$linha1[0]}'>{$linha1[1]}</option>";
                }
                ?>
            </select>

            <label for="nomeTrabalho">Nome do Trabalho</label>
            <input type="text" name="nomeTrabalho" id="nomeTrabalho" value="" placeholder="Informe o nome do trabalho" required>

            <input type="submit" value="Salvar">
        </form>

        <div class="buttons">
            <a href="javascript:window.history.back();">Voltar</a>
        </div>
    </div>
</body>
</html>
