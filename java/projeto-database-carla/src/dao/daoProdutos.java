package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import model.Produtos;

public class daoProdutos {
    
    // variavel de datasource para a conexão
    private DataSource dataSource;
    
    // método construtor para passar o dataSource
    public daoProdutos(DataSource dataSource){
        this.dataSource = dataSource;
    }

    // para popular os dados no arraylist de acordo com a quantidade de 
    // registros na tabela de fornecedores

    public ArrayList<Produtos> consultar(){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT p.*, f.for_nome as fornecedor, c.cat_descricao as categoria FROM produtos p, fornecedores f, categorias c WHERE (p.idFornecedor=f.idFornecedor) AND (p.prod_categoria = c.idCategoria)";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);

            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Produtos> lista = new ArrayList<Produtos>();
            
            // enquanto tiverem registros no ResultSet (rs), 
            // vai adicionando na lista
            while(rs.next()){
                // cria objeto de municipio
                // cada cidade é um objeto
                Produtos user = new Produtos();

                user.setIdProduto(rs.getInt("IdProduto"));
                user.setProd_descricao(rs.getString("prod_descricao"));
                user.setIdFornecedor(rs.getInt("idFornecedor"));
                user.setProd_categoria(rs.getInt("prod_categoria"));
                user.setProd_validade(rs.getString("prod_validade"));
                user.setProd_preco_custo(rs.getDouble("prod_preco_custo"));
                user.setProd_preco_venda(rs.getDouble("prod_preco_venda"));
                user.setProd_quantidade(rs.getInt("prod_quantidade"));
                user.setProd_minimo(rs.getInt("prod_minimo"));
                user.setFornecedor(rs.getString("fornecedor"));
                user.setCategoria(rs.getString("categoria"));
                
                // adiciona o objeto (registro) na lista (arraylist)
                lista.add(user);
            }
            
            // fecha o statement e o datasource
            ps.close();
            dataSource.closeDataSource();
            
            // retorna os dados consultados
            return lista;
        }
        catch (SQLException ex){
            System.err.println("Erro ao recuperar dados "+ex.getMessage());
        }
        catch (Exception ex){
            System.err.println("Erro geral "+ex.getMessage());
        }
        
        // fecha o statement e o datasource
        dataSource.closeDataSource();
            
        // caso aconteça alguma coisa
        return null;
    }

    public void createNS(Produtos usu) {
        throw new UnsupportedOperationException("Ainda não suportado."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    // insere dados
    public void inserir(Produtos usu){
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "INSERT INTO produtos "
                    + "              (prod_descricao, "
                    + "               fornecedor, "
                    + "               prod_validade, "
                    + "               prod_preco_custo, "
                    + "               prod_preco_venda, "
                    + "               categoria, "
                    + "               prod_quantidade, "
                    + "               prod_minimo) "
                    + "       VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setString(1,usu.getProd_descricao());
            ps.setString(2,usu.getFornecedor());
            ps.setString(3,usu.getProd_validade());
            ps.setDouble(4,usu.getProd_preco_custo());
            ps.setDouble(5,usu.getProd_preco_venda());
            ps.setString(6,usu.getCategoria());
            ps.setInt(7,usu.getProd_quantidade());
            ps.setInt(8,usu.getProd_minimo());
            
            // executa a inserção no banco
            ps.executeUpdate();
            ps.close();
            
            JOptionPane.showMessageDialog(null,"Salvo com sucesso!");
        }
        catch (SQLException ex){
            //System.err.println("Erro ao salvar os dados "+ex.getMessage());
            JOptionPane.showMessageDialog(null,"Erro ao salvar!\n"+ex);
        }
        finally{
            // fecha o statement e o datasource
            //ps.close();
            dataSource.closeDataSource();
        }
    }

    // para consultar um registros na tabela de municipios
    public ArrayList<Produtos> readOne(String descricao){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT * "
                    + "     FROM produtos "
                    + "    WHERE (for_nome LIKE ?)";

            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);
            ps.setString(1,"%"+descricao+"%");
            
            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Produtos> lista = new ArrayList<Produtos>();
            
            while(rs.next()){
                // instancia um objeto
                Produtos usu = new Produtos();
                
                // joga dados da lista para o objeto
                usu.setIdProduto(rs.getInt("IdProduto"));
                usu.setProd_descricao(rs.getString("prod_descricao"));
                usu.setFornecedor(rs.getString("fornecedor"));
                usu.setProd_validade(rs.getString("prod_validade"));
                usu.setProd_preco_custo(Double.parseDouble("prod_preco_custo"));
                usu.setProd_preco_venda(Double.parseDouble("prod_preco_custo"));
                usu.setCategoria(rs.getString("categoria"));
                usu.setProd_quantidade(Integer.parseInt("prod_quantidade"));
                usu.setProd_minimo(Integer.parseInt("prod_minimo"));
                
                // adiciona o objeto (registro) na lista (arraylist)
                lista.add(usu);
            }
            
            // fecha o statement e o datasource
            ps.close();
            dataSource.closeDataSource();
            
            // retorna os dados consultados
            return lista;
        }
        catch (SQLException ex){
            System.err.println("Erro ao recuperar dados "+ex.getMessage());
        }
        catch (Exception ex){
            System.err.println("Erro geral "+ex.getMessage());
        }
        
        // fecha o statement e o datasource
        dataSource.closeDataSource();
            
        // caso aconteça alguma coisa
        return null;
    }

// excluir registro
    public void excluir(int codigo){
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "DELETE "
                    + "     FROM produtos "
                    + "    WHERE (idProduto = ?)";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setInt(1,codigo);

            // executa a inserção no banco
            ps.executeUpdate();
            ps.close();
            
            JOptionPane.showMessageDialog(null,"Excluído com sucesso!");
        }
        catch (SQLException ex){
            //System.err.println("Erro ao salvar os dados "+ex.getMessage());
            JOptionPane.showMessageDialog(null,"Erro ao excluir!\n"+ex);
        }
        finally{
            // fecha o statement e o datasource
            dataSource.closeDataSource();
        }
    }
    
    // alterar dados
    public void alterar(Produtos usu){
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            // monta SQL
            String SQL = "UPDATE produtos "
                    + "      SET prod_descricao = ?,"
                    + "          fornecedor = ?,"
                    + "          prod_validade = ?,"
                    + "          prod_preco_custo = ?,"
                    + "          prod_preco_venda = ?,"
                    + "          categoria = ?,"
                    + "          prod_quantidade = ?,"
                    + "          prod_minimo = ?"
                    + "    WHERE idProduto = ?";

            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setString(1,usu.getProd_descricao());
            ps.setString(2,usu.getFornecedor());
            ps.setString(3,usu.getProd_validade());
            ps.setDouble(4,usu.getProd_preco_custo());
            ps.setDouble(5,usu.getProd_preco_venda());
            ps.setString(6,usu.getCategoria());
            ps.setInt(7,usu.getProd_quantidade());
            ps.setInt(8,usu.getProd_minimo());
            ps.setInt(9,usu.getIdProduto());
            
            // executa a inserção no banco
            ps.executeUpdate();
            ps.close();
            
            JOptionPane.showMessageDialog(null,"Alterado com sucesso!");
        }
        catch (SQLException ex){
            //System.err.println("Erro ao salvar os dados "+ex.getMessage());
            JOptionPane.showMessageDialog(null,"Erro ao alterar!\n"+ex);
        }
        finally{
            // fecha o statement e o datasource
            dataSource.closeDataSource();
        }
    }
}