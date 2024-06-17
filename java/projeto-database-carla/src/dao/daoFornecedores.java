package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import model.Fornecedores;

public class daoFornecedores {
    
    // variavel de datasource para a conexão
    private DataSource dataSource;
    
    // método construtor para passar o dataSource
    public daoFornecedores(DataSource dataSource){
        this.dataSource = dataSource;
    }

    // para popular os dados no arraylist de acordo com a quantidade de 
    // registros na tabela de fornecedores

    public ArrayList<Fornecedores> consultar(){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT * "
                    + "     FROM fornecedores";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);

            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Fornecedores> lista = new ArrayList<Fornecedores>();
            
            // enquanto tiverem registros no ResultSet (rs), 
            // vai adicionando na lista
            while(rs.next()){
                // cria objeto de municipio
                // cada cidade é um objeto
                Fornecedores user = new Fornecedores();

                user.setIdFornecedor(rs.getInt("IdFornecedor"));
                user.setFor_nome(rs.getString("for_nome"));
                user.setFor_cidade(rs.getString("for_cidade"));
                user.setFor_uf(rs.getString("for_uf"));
                user.setFor_telefone(rs.getString("for_telefone"));
                user.setFor_cnpj(rs.getString("for_cnpj"));
                user.setFor_email(rs.getString("for_email"));
                user.setFor_representante(rs.getString("for_representante"));
                user.setFor_fone_representante(rs.getString("for_fone_representante"));
                
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

    public void createNS(Fornecedores usu) {
        throw new UnsupportedOperationException("Ainda não suportado."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }
    
    // insere dados
    public void inserir(Fornecedores usu){
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "INSERT INTO Fornecedores "
                    + "              (for_nome, "
                    + "               for_cidade, "
                    + "               for_uf, "
                    + "               for_telefone, "
                    + "               for_cnpj, "
                    + "               for_email, "
                    + "               for_representante, "
                    + "               for_fone_representante) "
                    + "       VALUES (?, ?, ?, ?, ?, ?, ?, ?)";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setString(1,usu.getFor_nome());
            ps.setString(2,usu.getFor_cidade());
            ps.setString(3,usu.getFor_uf());
            ps.setString(4,usu.getFor_telefone());
            ps.setString(5,usu.getFor_cnpj());
            ps.setString(6,usu.getFor_email());
            ps.setString(7,usu.getFor_representante());
            ps.setString(8,usu.getFor_fone_representante());
            
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
    public ArrayList<Fornecedores> readOne(String descricao){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT * "
                    + "     FROM fornecedores "
                    + "    WHERE (for_nome LIKE ?)";

            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);
            ps.setString(1,"%"+descricao+"%");
            
            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Fornecedores> lista = new ArrayList<Fornecedores>();
            
            while(rs.next()){
                // instancia um objeto
                Fornecedores usu = new Fornecedores();
                
                // joga dados da lista para o objeto
                usu.setIdFornecedor(rs.getInt("IdFornecedor"));
                usu.setFor_nome(rs.getString("for_nome"));
                usu.setFor_cidade(rs.getString("for_cidade"));
                usu.setFor_uf(rs.getString("for_uf"));
                usu.setFor_telefone(rs.getString("for_telefone"));
                usu.setFor_cnpj(rs.getString("for_cnpj"));
                usu.setFor_email(rs.getString("for_email"));
                usu.setFor_representante(rs.getString("for_representante"));
                usu.setFor_fone_representante(rs.getString("for_fone_representante"));
                
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
                    + "     FROM fornecedores "
                    + "    WHERE (idFornecedor = ?)";
            
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
    public void alterar(Fornecedores usu){
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            // monta SQL
            String SQL = "UPDATE fornecedores "
                    + "      SET for_nome = ?,"
                    + "          for_cidade = ?,"
                    + "          for_uf = ?,"
                    + "          for_telefone = ?,"
                    + "          for_cnpj = ?,"
                    + "          for_email = ?,"
                    + "          for_representante = ?,"
                    + "          for_fone_representante = ?"
                    + "    WHERE idFornecedor=?";

            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setString(1,usu.getFor_nome());
            ps.setString(2,usu.getFor_cidade());
            ps.setString(3,usu.getFor_uf());
            ps.setString(4,usu.getFor_telefone());
            ps.setString(5,usu.getFor_cnpj());
            ps.setString(6,usu.getFor_email());
            ps.setString(7,usu.getFor_representante());
            ps.setString(8,usu.getFor_fone_representante());
            ps.setInt(9,usu.getIdFornecedor());
            
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

    public ArrayList<Fornecedores> montaCombo(){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT idForneedor, for_nome FROM fornecedores";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);

            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Fornecedores> lista = new ArrayList<Fornecedores>();
            
            // enquanto tiverem registros no ResultSet (rs), 
            // vai adicionando na lista
            while(rs.next()){
                // cria objeto de municipio
                // cada cidade é um objeto
                Fornecedores user = new Fornecedores();

                user.setIdFornecedor(rs.getInt("IdFornecedor"));
                user.setFor_nome(rs.getString("for_nome"));
                
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
            JOptionPane.showMessageDialog(null, "Erro ao recuperar dados "+ex.getMessage());
        }
        catch (Exception ex){
            JOptionPane.showMessageDialog(null,"Erro geral "+ex.getMessage());
        }
        
        // fecha o statement e o datasource
        dataSource.closeDataSource();
            
        // caso aconteça alguma coisa
        return null;
    }

}