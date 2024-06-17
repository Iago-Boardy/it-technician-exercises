<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Consulta de Trabalhos</title>
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            margin: 0;
            padding: 0;
        }

        .container {
            min-width: 800px;
            margin: 50px auto;
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

        table {
            width: 100%;
            border-collapse: collapse;
        }

        th, td {
            padding: 10px;
            border-bottom: 1px solid #ddd;
            text-align: left;
        }

        th {
            background-color: #f2f2f2;
            font-weight: bold;
        }

        td {
            background-color: #fff;
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

        .buttons {
            text-align: center;
            margin-top: 20px;
        }

        .btn {
            display: inline-block;
            padding: 10px 20px;
            margin: 0 10px;
            border: none;
            border-radius: 4px;
            background-color: #4CAF50;
            color: white;
            cursor: pointer;
        }

        .btn:hover {
            background-color: #45a049;
        }
    </style>
</head>
<body>
    <div class="container">
        <h1>Consulta de Trabalhos</h1>
        <table>
            <thead>
                <tr>
                    <th>Código</th>
                    <th>Nome Trabalho</th>
                </tr>
            </thead>
            <tbody>
                <?php
                include_once "connection.php";

                $sql = "SELECT * FROM trabalho";
                $result = mysqli_query($conn, $sql);

                while ($row = mysqli_fetch_array($result, MYSQLI_NUM)) {
                    echo "<tr>";
                    for ($i = 0; $i < count($row); $i++) {
                        echo "<td>" . $row[$i] . "</td>";
                    }
                    echo "</tr>";
                }
                mysqli_close($conn);
                ?>
            </tbody>
        </table>

        <div class="buttons">
            <button onclick="window.history.back();" class="btn">Voltar</button>
            <a href="trabalhoAlterar.php" class="btn">Alterar</a>
            <a href="trabalhoExcluir.php" class="btn">Deletar</a>
        </div>
    </div>
</body>
</html>
