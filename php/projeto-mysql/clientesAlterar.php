<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Alterar Clientes</title>
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
            justify-content: center;
            align-items: center; 
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
        <h1>Alterar Clientes</h1>
        <?php
        include_once "connection.php";
        ?>

        <form action="clientesAlterarSalvar.php" method="post" autocomplete="off">
            <label for="idCliente">Nome do Cliente</label>
            <select name="idCliente" id="idCliente">
                <option value="" selected>Selecione...</option>
                <?php 
                // conexão
                $sql1 = "SELECT idCliente, nome FROM clientes ORDER BY nome";
                $resultado1 = mysqli_query($conn, $sql1);
                while ($linha1 = mysqli_fetch_array($resultado1, MYSQLI_NUM)) {
                    echo "<option value='{$linha1[0]}'>{$linha1[1]}</option>";
                }
                ?>
            </select>

            <label for="nome">Nome</label>
            <input type="text" name="nome" id="nome" value="" placeholder="Informe o nome" required>

            <label for="logradouro">Logradouro</label>
            <input type="text" name="logradouro" id="logradouro" placeholder="Qual o logradouro" required>

            <label for="complemento">Complemento</label>
            <input type="text" name="complemento" id="complemento" placeholder="Qual o complemento">

            <label for="bairro">Bairro</label>
            <input type="text" name="bairro" id="bairro" placeholder="Qual o bairro" required>

            <label for="cep">CEP</label>
            <input type="text" name="cep" id="cep" placeholder="Qual o cep" required>

            <label for="cidade">Cidade</label>
            <input type="text" name="cidade" id="cidade" placeholder="Qual a cidade" required>

            <label for="uf">UF</label>
            <input type="text" name="uf" id="uf" placeholder="Qual a uf" required>

            <label for="email">Email</label>
            <input type="text" name="email" id="email" placeholder="Qual o email" required>

            <label for="idade">Idade</label>
            <input type="text" name="idade" id="idade" placeholder="Qual a idade" required>

            <input type="submit" value="Salvar">
        </form>

        <div class="buttons">
            <a href="javascript:window.history.back();">Voltar</a>
        </div>
    </div>
</body>
</html>
