package dao;

import java.sql.Connection;
import java.sql.PreparedStatement;
import java.sql.ResultSet;
import java.sql.SQLException;
import java.util.ArrayList;
import javax.swing.JOptionPane;
import model.Usuário;

public class daoUsuarios {
    private DataSource dataSource;

    public daoUsuarios(DataSource datasource){
        this.dataSource = datasource;
    }
 // para popular os dados no arraylist de acordo com a quantidade de 
    // registros na tabela de usuarios
    public ArrayList<Usuário> readAll(){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT * "
                    + "     FROM USUARIOS";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);

            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Usuário> lista = new ArrayList<Usuário>();
            
            // enquanto tiverem registros no ResultSet (rs), 
            // vai adicionando na lista
            while(rs.next()){
                // cria objeto de municipio
                // cada cidade é um objeto
                Usuário user = new Usuário();

                user.setIdUsuario(rs.getInt("idUsuario"));
                user.setNome(rs.getString("Nome"));
                user.setEmail(rs.getString("Email"));
                user.setSenha(rs.getString("Senha"));
               
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
     // insere dados
    public void create(Usuário usu){
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "INSERT INTO usuarios (Nome, Email, Senha) VALUES (?, ?, ?)";
            
            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setString(1,usu.getNome());
            ps.setString(2,usu.getEmail());
            ps.setString(3,usu.getSenha());

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
    public ArrayList<Usuário> readOne(String descricao){

        //Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try{
            String SQL = "SELECT * FROM usuarios WHERE (Nome LIKE ?)";

            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = dataSource.getConnection().prepareStatement(SQL);
            ps.setString(1,"%"+descricao+"%");
            
            // executa a consulta no banco
            ResultSet rs = ps.executeQuery();
            
            // cria a lista de resultados trazidos da tabela
            ArrayList<Usuário> lista = new ArrayList<Usuário>();
            
            while(rs.next()){
                // instancia um objeto
                Usuário usu = new Usuário();
                
                // joga dados da lista para o objeto
                usu.setIdUsuario(rs.getInt("idUsuario"));
                usu.setNome(rs.getString("Nome"));
                usu.setEmail(rs.getString("Email"));
                usu.setSenha(rs.getString("Senha"));
                
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

    public void excluir(int codigo) {
        Connection con = dataSource.getConnection();
        PreparedStatement ps = null;

        try {
            String SQL = "DELETE FROM usuarios WHERE (idUsuario = ?)";

            // para mandar como uma instrução, precisa usar o PreparedStatement
            // traduz o comando SQL para execução
            ps = con.prepareStatement(SQL);
            ps.setInt(1, codigo);

            // executa a inserção no banco
            ps.executeUpdate();
            ps.close();

            JOptionPane.showMessageDialog(null, "Excluído com sucesso!");
        } catch (SQLException ex) {
            //System.err.println("Erro ao salvar os dados "+ex.getMessage());
            JOptionPane.showMessageDialog(null, "Erro ao excluir!\n" + ex);
        } finally {
            // fecha o statement e o datasource
            dataSource.closeDataSource();
        }
    }

    public void alterar(Usuário usu) {
        throw new UnsupportedOperationException("Not supported yet."); // Generated from nbfs://nbhost/SystemFileSystem/Templates/Classes/Code/GeneratedMethodBody
    }

}
